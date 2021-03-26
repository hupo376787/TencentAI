///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentAI.Helpers;
using Windows.Storage;

namespace TencentAI.Vision.ImageIdentify
{
    public class ImageIdentify
    {
        //1-车辆识别，2-花草识别
        public static async Task<Contract.Vision.ImageIdentify.ImageIdentifyResult> IdentifyFlowersGrassCars(StorageFile storageFile, int scene = 2)
        {
            Contract.Vision.ImageIdentify.ImageIdentifyResult res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("scene", scene);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.vision_imgidentify, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.ImageIdentify.ImageIdentifyResult>(json);
                return res;
            }
            catch { }

            return null;
        }
    }
}
