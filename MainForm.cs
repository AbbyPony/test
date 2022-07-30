using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01PLC通讯模拟
{
    public partial class MainForm : Form
    {

        private delegate void ShowTxt(string txt, string Name);
        List<Control> List_Control = new List<Control>();
        public enum SoftElemType
        {
            //AM600
            ELEM_QX = 0,     //QX元件
            ELEM_MW = 1,     //MW元件
            ELEM_X = 2,      //X元件(对应QX200~QX300)
            ELEM_Y = 3,      //Y元件(对应QX300~QX400)

            //H3U
            REGI_H3U_Y = 0x20,       //Y元件的定义	
            REGI_H3U_X = 0x21,      //X元件的定义							
            REGI_H3U_S = 0x22,      //S元件的定义				
            REGI_H3U_M = 0x23,      //M元件的定义							
            REGI_H3U_TB = 0x24,     //T位元件的定义				
            REGI_H3U_TW = 0x25,     //T字元件的定义				
            REGI_H3U_CB = 0x26,     //C位元件的定义				
            REGI_H3U_CW = 0x27,     //C字元件的定义				
            REGI_H3U_DW = 0x28,     //D字元件的定义				
            REGI_H3U_CW2 = 0x29,    //C双字元件的定义
            REGI_H3U_SM = 0x2a,     //SM
            REGI_H3U_SD = 0x2b,     //
            REGI_H3U_R = 0x2c       //

        }
        #region //汇川PLC标准库
        [DllImport("StandardModbusApi.dll", EntryPoint = "Init_ETH_String", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Init_ETH_String(string sIpAddr, int nNetId = 0, int IpPort = 502);

        [DllImport("StandardModbusApi.dll", EntryPoint = "Exit_ETH", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Exit_ETH(int nNetId = 0);

        [DllImport("StandardModbusApi.dll", EntryPoint = "H3u_Write_Soft_Elem", CallingConvention = CallingConvention.Cdecl)]
        public static extern int H3u_Write_Soft_Elem(SoftElemType eType, int nStartAddr, int nCount, byte[] pValue, int nNetId = 0);

        [DllImport("StandardModbusApi.dll", EntryPoint = "H3u_Read_Soft_Elem", CallingConvention = CallingConvention.Cdecl)]
        public static extern int H3u_Read_Soft_Elem(SoftElemType eType, int nStartAddr, int nCount, byte[] pValue, int nNetId = 0);

        [DllImport("StandardModbusApi.dll", EntryPoint = "H3u_Read_Soft_Elem_Float", CallingConvention = CallingConvention.Cdecl)]
        public static extern int H3u_Read_Soft_Elem_Float(SoftElemType eType, int nStartAddr, int nCount, float[] pValue, int nNetId = 0);



        /******************************************************************************
         1.功能描述 : 写Am600软元件
         2.返 回 值 :1 成功  0 失败
         3.参    数 : nNetId:网络链接编号
			          eType：软元件类型    ELEM_QX = 0//QX元件  ELEM_MW = 1 //MW元件
			          nStartAddr:软元件起始地址（QX元件由于带小数点，地址需要乘以10去掉小数点，如QX10.1，请输入101，MW元件直接就是它的元件地址不用处理）
			          nCount：软元件个数
			          pValue：数据缓存区
        4.注意事项 :  1.x和y元件地址需为8进制; 
			          2. 当元件位C元件双字寄存器时，每个寄存器需占4个字节的数据
			          3.如果是写位元件，每个位元件的值存储在一个字节中
        ******************************************************************************/
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Write_Soft_Elem", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Write_Soft_Elem(SoftElemType eType, int nStartAddr, int nCount, byte[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Write_Soft_Elem_Int16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Write_Soft_Elem_Int16(SoftElemType eType, int nStartAddr, int nCount, short[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Write_Soft_Elem_Int32", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Write_Soft_Elem_Int32(SoftElemType eType, int nStartAddr, int nCount, int[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Write_Soft_Elem_UInt16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Write_Soft_Elem_UInt16(SoftElemType eType, int nStartAddr, int nCount, ushort[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Write_Soft_Elem_UInt32", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Write_Soft_Elem_UInt32(SoftElemType eType, int nStartAddr, int nCount, uint[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Write_Soft_Elem_Float", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Write_Soft_Elem_Float(SoftElemType eType, int nStartAddr, int nCount, float[] pValue, int nNetId = 0);



        /******************************************************************************
         1.功能描述 : 读Am600软元件
         2.返 回 值 :1 成功  0 失败
         3.参    数 : nNetId:网络链接编号
			          eType：软元件类型   ELEM_QX = 0//QX元件  ELEM_MW = 1 //MW元件
			          nStartAddr:软元件起始地址（QX元件由于带小数点，地址需要乘以10去掉小数点，如QX10.1，请输入101，其它元件不用处理）
			          nCount：软元件个数
			          pValue：返回数据缓存区
         4.注意事项 : 如果是读位元件，每个位元件的值存储在一个字节中，pValue数据缓存区字节数必须是8的整数倍
        ******************************************************************************/
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Read_Soft_Elem", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Read_Soft_Elem(SoftElemType eType, int nStartAddr, int nCount, byte[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Read_Soft_Elem_Int16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Read_Soft_Elem_Int16(SoftElemType eType, int nStartAddr, int nCount, short[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Read_Soft_Elem_Int32", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Read_Soft_Elem_Int32(SoftElemType eType, int nStartAddr, int nCount, int[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Read_Soft_Elem_UInt16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Read_Soft_Elem_UInt16(SoftElemType eType, int nStartAddr, int nCount, ushort[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Read_Soft_Elem_UInt32", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Read_Soft_Elem_UInt32(SoftElemType eType, int nStartAddr, int nCount, uint[] pValue, int nNetId = 0);
        [DllImport("StandardModbusApi.dll", EntryPoint = "Am600_Read_Soft_Elem_Float", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Am600_Read_Soft_Elem_Float(SoftElemType eType, int nStartAddr, int nCount, float[] pValue, int nNetId = 0);
        #endregion


        private static object Lock1 = new object();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Write_Click(object sender, EventArgs e)
        {
            Am600_Write_Soft_Elem_Int16(SoftElemType.ELEM_MW, int.Parse(txt_PLCAddress.Text.Trim()), 1, new short[] { short.Parse(Txt_Write.Text.Trim()) }, 0);


        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            short[] Trg_GetSN = new short[11];
            Am600_Read_Soft_Elem_Int16(SoftElemType.ELEM_MW, int.Parse(Txt_PLCReadAdd.Text.Trim()), 11, Trg_GetSN, 0);
            Txt_Read.Text = ToASCII(Trg_GetSN).Trim();
            //Txt_Read.Text = ToASCII(new short[] { 33, 34, 35, 36, 37 });
        }

        public string ToASCII(short[] PLCData)//十进制转化为ASCII码
        {
            lock (Lock1)
            {
                //int[] zx = new int[] { 68, 76, 72, 72 };
                string data = string.Empty;
                for (int j = 0; j < PLCData.Length; j++)
                {
                    int lpshDeviceValue = PLCData[j];
                    if (lpshDeviceValue != 0)
                    {
                        string DisplayData = lpshDeviceValue.ToString("X"); //十进制转换成十六进制
                        byte[] array = new byte[(DisplayData.Length + 1) / 2];
                        int index = ((DisplayData.Length + 1) / 2) - 1;   //PLC中输入与显示的顺序相反，所以这块index从最后一位开始
                        for (int i = 0; i < DisplayData.Length; i += 2)
                        {
                            array[index] = Convert.ToByte(DisplayData.Substring(i, 2), 16);
                            index--;
                        }
                        DisplayData = Encoding.Default.GetString(array);
                        data += DisplayData;
                    }
                }
                return data;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            JsonSerializerSettings jsetting = new JsonSerializerSettings();
            jsetting.NullValueHandling = NullValueHandling.Ignore;//Json不输出空值
            SNCheckRec snCheck = new SNCheckRec();
            snCheck.code = "200";
            snCheck.data = new Data_Receive[1];
            snCheck.data[0] = new Data_Receive();
            //snCheck.data[0] = new Data_Receive[0];
            snCheck.data[0].params1 = new Params();
            //snCheck.data.params1.ToString();
            snCheck.data[0].result = true;
            //snCheck.data.message = "成功";
            snCheck.data[0].resultCode = "200";
            snCheck.data[0].item = "C70700131-01";
            snCheck.data[0].itemRevision = "0001";
            string SendData = JsonConvert.SerializeObject(snCheck, Formatting.None, jsetting);
            SendData = SendData.Replace("params1", "params");
            List_Control = GetAllControls(this);//列表中添加所有窗体控件




            JObject recobj = JsonConvert.DeserializeObject<JObject>(SendData);

            txt_JsonCode.Text = recobj["code"].ToString();

            //JArray _jobject = new JArray();
            txt_DataResult.Text = Convert.ToBoolean(recobj["data"][0]["result"]).ToString();
            txt_DataResultCode.Text = recobj["data"][0]["resultCode"].ToString();
            txt_DataItem.Text = recobj["data"][0]["item"].ToString();
            txt_DataItemRe.Text = recobj["data"][0]["itemRevision"].ToString();
            txt_DataParams.Text = recobj["data"][0]["params"].ToString();

            BG_History bg = new BG_History();
            bg.history = new History[1];
            bg.history[0] = new History();
            bg.history[0].data = new Data9();
            bg.history[0].data.insight = new Insight9();
            bg.history[0].data.insight.uut_attributes = new Uut_attributes9();
            bg.history[0].data.insight.uut_attributes.rcam_hole_bin_best_fit = "123";
            string SendData1 = JsonConvert.SerializeObject(bg, Formatting.None, jsetting);
            JObject recobj1 = JsonConvert.DeserializeObject<JObject>(SendData1);
            Txt_Read.Text = recobj1["history"][0]["data"]["insight"]["uut_attributes"]["rcam_hole_bin_best_fit"].ToString();


            txt_PLCAddress.Text = DateTime.Now.AddSeconds(-60).ToString("yyyy-MM-dd HH:mm:ss");
            Txt_Write.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


            TraceData tdata = new TraceData();
            tdata.serials = new Serials1();
            tdata.data = new Data1();
            tdata.data.insight = new Insight1();
            tdata.data.insight.test_attributes = new Test_Attributes();
            tdata.data.insight.test_station_attributes = new Test_Station_Attributes();
            tdata.data.insight.uut_attributes = new Uut_Attributes();

            tdata.serials.fg = "111";

            tdata.data.insight.test_attributes.test_result = "pass";
            tdata.data.insight.test_attributes.unit_serial_number = "111";
            tdata.data.insight.test_attributes.uut_start = DateTime.Now.AddSeconds(-24).ToString("yyyy-MM-dd HH:mm:ss");
            tdata.data.insight.test_attributes.uut_stop = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            tdata.data.insight.test_station_attributes.fixture_id = "H-76HO-SMA40-2200-A-00003";
            tdata.data.insight.test_station_attributes.head_id = "1";
            tdata.data.insight.test_station_attributes.line_id = "IPGL_C09-3FA";
            tdata.data.insight.test_station_attributes.software_name = "DEVELOPMENT1";
            tdata.data.insight.test_station_attributes.software_version = "V1.111";
            tdata.data.insight.test_station_attributes.station_id = "Site_LineID_MachineID_StationName";

            tdata.data.insight.uut_attributes.STATION_STRING = "Free-from-string";
            tdata.data.insight.uut_attributes.box_id = "111";
            tdata.data.insight.uut_attributes.fg_sn = "111";

            tdata.event1 = "pack";
            string SendTrace = JsonConvert.SerializeObject(tdata, Formatting.None, jsetting);
            SendTrace = SendTrace.Replace("event1", "event");

        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                int nNetId = 0;
                int nIpPort = 502;
                bool result = Init_ETH_String("192.168.0.1", nNetId, nIpPort);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        public void UiText(string str1, string Name)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ShowTxt(UiText), new object[] { str1, Name });
                return;
            }
            foreach (Control ctrl in List_Control)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    if (ctrl.Name == Name)
                    {
                        ctrl.Text = str1;
                    }
                }
            }
        }

        public List<Control> GetAllControls(Control control)
        {
            var list = new List<Control>();
            foreach (Control con in control.Controls)
            {
                list.Add(con);
                if (con.Controls.Count > 0)
                {
                    list.AddRange(GetAllControls(con));
                }
            }
            return list;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
            //Application.Exit();
        }
    }
}
