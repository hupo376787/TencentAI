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
    public class WordEmotionPolarModel
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Datae data { get; set; }
    }

    public class Datae
    {
        public string text { get; set; }
        public int polar { get; set; }
        public double confd { get; set; }
    }
}
