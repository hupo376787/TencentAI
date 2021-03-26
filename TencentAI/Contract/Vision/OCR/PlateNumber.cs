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
    public class PlateNumber
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Datap data { get; set; }
    }

    public class Datap
    {
        public List<Item_listp> item_list { get; set; }
    }

    public class Item_listp
    {
        public string item { get; set; }
        public string itemstring { get; set; }
        public List<Itemcoord> itemcoord { get; set; }
        public double itemconf { get; set; }
    }
}
