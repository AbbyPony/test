using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PLC通讯模拟
{
    public class BG_History
    {
        public double age { get; set; }
        public string project { get; set; }
        public string component { get; set; }
        public string created { get; set; }
        public History[] history { get; set; }
        public Serials serials { get; set; }
    }

    public class History
    {
        public string id { get; set; }
        public Data9 data { get; set; }
        //public string event { get; set; }
    }

    public class Data9
    {
        public Insight9 insight { get; set; }
    }

    public class Insight9
    {
        public Test_attributes9 test_attributes { get; set; }
        public Uut_attributes9 uut_attributes { get; set; }

    }
    public class Test_attributes9
    {
        public string uut_stop { get; set; }
        public string uut_start { get; set; }
        public string test_result { get; set; }
        public string unit_serial_number { get; set; }
    }

    public class Uut_attributes9
    {
        public string box_id { get; set; }
        public string pack_time { get; set; }
        public string STATION_STRING { get; set; }
        public string rcam_hole_bin_best_fit { get; set; }
        public string rcam_hole_bin_diagonal { get; set; }
        public string rcam_hole_bin_max_inscribed { get; set; }


    }

    public class Serials
    {
        public string band { get; set; }
        public string sp { get; set; }
    }
}
