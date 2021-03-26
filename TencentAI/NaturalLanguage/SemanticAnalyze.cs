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
    public class SemanticAnalyze
    {
        public static async Task<Contract.NaturalLanguage.WordComponentModel> IntentionComponentIdentification(string originalText)
        {
            Contract.NaturalLanguage.WordComponentModel res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                originalText = originalText.Replace(" ", "").Replace(Environment.NewLine, "").Replace("\r", "");
                if (originalText.Length >= 50)
                    originalText = originalText.Substring(0, 50);
                string strUtf8Text = StringHelper.GetUtf8String(originalText);
                param.Add("text", strUtf8Text);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param, true);
                string json = await HttpHelper.SendPostAsync(ApiAddress.naturallanguage_wordcom, data);
                res = JsonConvert.DeserializeObject<Contract.NaturalLanguage.WordComponentModel>(json);
                return res;
            }
            catch { }

            return null;
        }
    }
}
