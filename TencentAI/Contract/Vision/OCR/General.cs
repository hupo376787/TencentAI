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
    public class General
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Datag data { get; set; }
    }

    public class Datag
    {
        public List<Item_listg> item_list { get; set; }
    }

    public class Item_listg
    {
        public string item { get; set; }
        public string itemstring { get; set; }
        public List<Itemcoordg> itemcoord { get; set; }
        public List<Wordsg> words { get; set; }
    }

    public class Itemcoordg
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Wordsg
    {
        public string character { get; set; }
        public double confidence { get; set; }
    }
}
