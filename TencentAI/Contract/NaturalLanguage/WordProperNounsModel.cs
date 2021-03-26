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
    public class WordProperNounsModel
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Datan data { get; set; }
    }

    public class Datan
    {
        public string text { get; set; }
        public List<NerTokens> ner_tokens { get; set; }
    }

    public class NerTokens
    {
        public string word { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
        public List<int> types { get; set; }
        public List<int> weights { get; set; }
    }
}
