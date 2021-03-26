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
    public class WordSegModel
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string text { get; set; }
        public List<BaseTokens> base_tokens { get; set; }
        public List<MixTokens> mix_tokens { get; set; }
    }

    public class MixTokens
    {
        public string word { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }

    public class BaseTokens
    {
        public string word { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }
}
