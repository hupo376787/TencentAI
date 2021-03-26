///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentAI.Contract.Vision.OCR
{
    public class IDCard
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string name { get; set; }
        public string sex { get; set; }
        public string nation { get; set; }
        public string birth { get; set; }
        public string address { get; set; }
        public string id { get; set; }
        public string frontimage { get; set; }
        public string authority { get; set; }
        public string valid_date { get; set; }
        public string backimage { get; set; }
    }
}
