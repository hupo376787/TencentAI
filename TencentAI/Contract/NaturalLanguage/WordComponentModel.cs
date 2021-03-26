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
    public class WordComponentModel
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public Datac data { get; set; }
    }

    public class Datac
    {
        public string text { get; set; }
        public int intent { get; set; }
        public List<ComTokens> com_tokens { get; set; }
    }

    public class ComTokens
    {
        public int com_type { get; set; }
        public string com_word { get; set; }
    }
}
