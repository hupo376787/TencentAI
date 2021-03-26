using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentAI.Helpers;

namespace TencentAI.NaturalLanguage
{
    public class EmotionAnalyze
    {
        public static async Task<Contract.NaturalLanguage.WordEmotionPolarModel> EmotionPolarAnalyze(string originalText)
        {
            Contract.NaturalLanguage.WordEmotionPolarModel res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                originalText = originalText.Replace(" ", "").Replace(Environment.NewLine, "").Replace("\r", "");
                if (originalText.Length >= 60)
                    originalText = originalText.Substring(0, 60);
                string strUtf8Text = StringHelper.GetUtf8String(originalText);
                param.Add("text", strUtf8Text);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!


                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param, true);
                string json = await HttpHelper.SendPostAsync(ApiAddress.naturallanguage_textpolar, data);
                res = JsonConvert.DeserializeObject<Contract.NaturalLanguage.WordEmotionPolarModel>(json);
                return res;
            }
            catch { }

            return null;
        }
    }
}
