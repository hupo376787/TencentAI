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
    public class BaseTextAnalyze
    {
        public static async Task<Contract.NaturalLanguage.WordSegModel> WordSeg(string originalText)
        {
            Contract.NaturalLanguage.WordSegModel res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                originalText = originalText.Replace(" ", "").Replace(Environment.NewLine, "").Replace("\r", "");
                if (originalText.Length >= 512)
                    originalText = originalText.Substring(0, 512);
                string strGBKText = StringHelper.GetGBKString(originalText);
                param.Add("text", strGBKText);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding encodingGBK = Encoding.GetEncoding("GBK");

                //获取签名
                string signStr = Tools.MakeSign(param, encodingGBK);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param, true, encodingGBK);
                string json = await HttpHelper.SendPostAsync(ApiAddress.naturallanguage_wordseg, data, encodingGBK);
                res = JsonConvert.DeserializeObject<Contract.NaturalLanguage.WordSegModel>(json);
                return res;
            }
            catch { }

            return null;
        }

        public static async Task<Contract.NaturalLanguage.WordPositionTaggingModel> WordPositionTagging(string originalText)
        {
            Contract.NaturalLanguage.WordPositionTaggingModel res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                originalText = originalText.Replace(" ", "").Replace(Environment.NewLine, "").Replace("\r", "");
                if (originalText.Length >= 512)
                    originalText = originalText.Substring(0, 512);
                string strGBKText = StringHelper.GetGBKString(originalText);
                param.Add("text", strGBKText);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding encodingGBK = Encoding.GetEncoding("GBK");

                //获取签名
                string signStr = Tools.MakeSign(param, encodingGBK);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param, true, encodingGBK);
                string json = await HttpHelper.SendPostAsync(ApiAddress.naturallanguage_wordpos, data, encodingGBK);
                res = JsonConvert.DeserializeObject<Contract.NaturalLanguage.WordPositionTaggingModel>(json);
                return res;
            }
            catch { }

            return null;
        }

        public static async Task<Contract.NaturalLanguage.WordProperNounsModel> WordProperNounsTagging(string originalText)
        {
            Contract.NaturalLanguage.WordProperNounsModel res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                originalText = originalText.Replace(" ", "").Replace(Environment.NewLine, "").Replace("\r", "");
                if (originalText.Length >= 100)
                    originalText = originalText.Substring(0, 100);
                string strGBKText = StringHelper.GetGBKString(originalText);
                param.Add("text", strGBKText);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding encodingGBK = Encoding.GetEncoding("GBK");

                //获取签名
                string signStr = Tools.MakeSign(param, encodingGBK);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param, true, encodingGBK);
                string json = await HttpHelper.SendPostAsync(ApiAddress.naturallanguage_wordner, data, encodingGBK);
                res = JsonConvert.DeserializeObject<Contract.NaturalLanguage.WordProperNounsModel>(json);
                return res;
            }
            catch { }

            return null;
        }

        public static async Task<Contract.NaturalLanguage.WordSynonymModel> WordSynonymAnalyzing(string originalText)
        {
            Contract.NaturalLanguage.WordSynonymModel res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                originalText = originalText.Replace(" ", "").Replace(Environment.NewLine, "").Replace("\r", "");
                if (originalText.Length >= 512)
                    originalText = originalText.Substring(0, 512);
                string strGBKText = StringHelper.GetGBKString(originalText);
                param.Add("text", strGBKText);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding encodingGBK = Encoding.GetEncoding("GBK");

                //获取签名
                string signStr = Tools.MakeSign(param, encodingGBK);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param, true, encodingGBK);
                string json = await HttpHelper.SendPostAsync(ApiAddress.naturallanguage_wordsyn, data, encodingGBK);
                res = JsonConvert.DeserializeObject<Contract.NaturalLanguage.WordSynonymModel>(json);
                return res;
            }
            catch { }

            return null;
        }
    }
}
