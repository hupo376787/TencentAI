///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentAI.Contract.NaturalLanguage
{
    public class TextTransAILabModel
    {
        public TextTransAILabModel()
        {

        }

        public int ret { get; set; }
        public string msg { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public int type { get; set; }
            public string org_text { get; set; }
            public string trans_text { get; set; }
        }
    }
}
