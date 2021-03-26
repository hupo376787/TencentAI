///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentAI
{
    public class Constants
    {
        //Get key at https://ai.qq.com/console/home
        public const string AppID = "your app id";
        public const string AppKey = "your app key";
    }

    public class ApiAddress
    {
        public const string vision_imgidentify = "https://api.ai.qq.com/fcgi-bin/vision/vision_imgidentify";

        public const string naturallanguage_ailab = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_texttrans";
        public const string naturallanguage_translateman = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_texttranslate";

        public const string naturallanguage_wordseg = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_wordseg";
        public const string naturallanguage_wordpos = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_wordpos";
        public const string naturallanguage_wordner = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_wordner";
        public const string naturallanguage_wordsyn = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_wordsyn";

        public const string naturallanguage_wordcom = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_wordcom";
        public const string naturallanguage_textpolar = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_textpolar";

        public const string naturallanguage_imagetranslate = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_imagetranslate";


        public const string face_detectface = "https://api.ai.qq.com/fcgi-bin/face/face_detectface";

        public const string ocr_idcardocr = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_idcardocr";
        public const string ocr_bcocr = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_bcocr";
        public const string ocr_driverlicenseocr = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_driverlicenseocr";
        public const string ocr_bizlicenseocr = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_bizlicenseocr";
        public const string ocr_creditcardocr = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_creditcardocr";
        public const string ocr_platenumberocr = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_plateocr";
        public const string ocr_handwritingocr = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_handwritingocr";
        public const string ocr_generalocr = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_generalocr";
    }
}
