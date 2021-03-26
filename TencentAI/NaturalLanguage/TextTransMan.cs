///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentAI.Helpers;

namespace TencentAI.NaturalLanguage
{
    public class TextTransMan
    {
        //doc ---- http://ai.qq.com/doc/nlptrans.shtml
        public static async Task<Contract.NaturalLanguage.TextTransManModel> TextTranslate(string originalText, string sourceLang, string targetLang)
        {
            Contract.NaturalLanguage.TextTransManModel res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                string strUTF8Text = StringHelper.GetUtf8String(originalText);
                param.Add("text", originalText);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));
                param.Add("source", sourceLang);
                param.Add("target", targetLang);

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.naturallanguage_translateman, data);
                res = JsonConvert.DeserializeObject<Contract.NaturalLanguage.TextTransManModel>(json);
                return res;
            }
            catch { }

            return null;
        }
    }
}
