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

namespace TencentAI.Vision.Face
{
    public class FaceDetect
    {
        public static async Task<Contract.Vision.Face.FaceDetectResult> DetectFace(StorageFile storageFile, int mode = 1)
        {
            Contract.Vision.Face.FaceDetectResult res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("mode", mode);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.face_detectface, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.Face.FaceDetectResult>(json);
                return res;
            }
            catch { }

            return null;
        }
    }
}
