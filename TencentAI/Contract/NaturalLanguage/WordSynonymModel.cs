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
    public class WordSynonymModel
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Datas data { get; set; }
    }

    public class Datas
    {
        public string text { get; set; }
        public List<SynTokens> syn_tokens { get; set; }
    }

    public class SynTokens
    {
        public OriWord ori_word { get; set; }
        public List<SynWords> syn_words { get; set; }
    }

    public class OriWord
    {
        public string word { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }

    public class SynWords
    {
        public string word { get; set; }
        public double weight { get; set; }
    }
}
