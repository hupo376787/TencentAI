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
    public class BizLicense
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Dataz data { get; set; }
    }

    public class Dataz
    {
        public List<Item_listz> item_list { get; set; }
    }

    public class Item_listz
    {
        public string item { get; set; }
        public string itemstring { get; set; }
        public List<Itemcoordz> itemcoord { get; set; }
        public double itemconf { get; set; }
    }

    public class Itemcoordz
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
