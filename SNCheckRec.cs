using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PLC通讯模拟
{
    public class SNCheckRec
    {
        public string code { get; set; }
        public Data_Receive[] data { get; set; }
    }
    public class Data_Receive
    {
        public Params params1 { get; set; }
        public bool result { get; set; }
        public string resultCode { get; set; }
        public string item { get; set; }
        public string itemRevision { get; set; }
    }
    public class Params
    {

    }
}
