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
using Windows.Storage;

namespace TencentAI.NaturalLanguage
{
    public class ImageTrans
    {
        // http://ai.qq.com/doc/imagetranslate.shtml
        public static async Task<Contract.NaturalLanguage.ImageTransModel> ImageTranslate(StorageFile storageFile, string scene = "doc", string sourceLang = "auto", string targetLang = "auto")
        {
            Contract.NaturalLanguage.ImageTransModel res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("session_id", StringHelper.GenerateNonceStr());
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));
                param.Add("scene", scene);
                param.Add("source", sourceLang);
                param.Add("target", targetLang);

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.naturallanguage_imagetranslate, data);
                res = JsonConvert.DeserializeObject<Contract.NaturalLanguage.ImageTransModel>(json);
                return res;
            }
            catch { }

            return null;
        }
    }
}
