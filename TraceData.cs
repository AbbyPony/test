using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PLC通讯模拟
{
    public class TraceData
    {
        public Serials1 serials { get; set; }
        public Data1 data { get; set; }
        public string event1 { get; set; }

    }

    public class Serials1
    {
        public string fg { get; set; }
    }
    public class Data1
    {
        public Insight1 insight { get; set; }

    }
    public class Insight1
    {
        public Test_Attributes test_attributes { get; set; }
        public Test_Station_Attributes test_station_attributes { get; set; }
        public Uut_Attributes uut_attributes { get; set; }
    }



    public class Test_Attributes
    {
        public string test_result { get; set; }
        public string unit_serial_number { get; set; }
        public string uut_start { get; set; }
        public string uut_stop { get; set; }
    }
    public class Test_Station_Attributes
    {
        public string fixture_id { get; set; }
        public string head_id { get; set; }
        public string line_id { get; set; }
        public string software_name { get; set; }
        public string software_version { get; set; }
        public string station_id { get; set; }
    }
    public class Uut_Attributes
    {
        public string STATION_STRING { get; set; }
        public string box_id { get; set; }
        public string fg_sn { get; set; }
    }
}
