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
    public class WordPositionTaggingModel
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Datap data { get; set; }
    }

    public class Datap
    {
        public string text { get; set; }
        public List<BaseTokensp> base_tokens { get; set; }
        public List<MixTokensp> mix_tokens { get; set; }
    }

    public class MixTokensp
    {
        public string word { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
        public int pos_code { get; set; }
    }

    public class BaseTokensp
    {
        public string word { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
        public int pos_code { get; set; }
    }
}
