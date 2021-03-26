///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System.Collections.Generic;

namespace TencentAI.Contract.NaturalLanguage
{
    public class ImageTransModel
    {
        public ImageTransModel()
        {

        }

        public int ret { get; set; }
        public string msg { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public string session_id { get; set; }
            public List<ImageRecords> image_records { get; set; }
        }

        public class ImageRecords
        {
            public string source_text { get; set; }
            public string target_text { get; set; }
            public int x { get; set; }
            public int y { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }
    }
}
