///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentAI.Contract.Vision.ImageIdentify
{
    public class ImageIdentifyResult
    {
        public ImageIdentifyResult()
        {

        }

        public int ret { get; set; }
        public string msg { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public TagList[] tag_list { get; set; }
        }

        public class TagList
        {
            public int label_id { get; set; }
            public string label_name { get; set; }
            public float label_confd { get; set; }
        }
    }

}
