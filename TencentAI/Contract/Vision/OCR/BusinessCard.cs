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
    public class BusinessCard
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Datab data { get; set; }
    }

    public class Datab
    {
        public string angle { get; set; }
        public List<Item_list> item_list { get; set; }
    }

    public class Item_list
    {
        public string item { get; set; }
        public string itemstring { get; set; }
        public List<Itemcoord> itemcoord { get; set; }
        public List<Words> words { get; set; }
    }

    public class Itemcoord
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Words
    {
        public string character { get; set; }
        public double confidence { get; set; }
    }
}
