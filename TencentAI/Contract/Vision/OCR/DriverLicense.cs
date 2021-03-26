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
    public class DriverLicense
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Datad data { get; set; }
    }

    public class Datad
    {
        public List<Item_listd> item_list { get; set; }
    }

    public class Item_listd
    {
        public string item { get; set; }
        public string itemstring { get; set; }
        public List<Itemcoordd> itemcoord { get; set; }
        public double itemconf { get; set; }
    }

    public class Itemcoordd
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
