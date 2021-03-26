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

namespace TencentAI.Vision.OCR
{
    public class OCR
    {
        //0-正面，1-反面
        public static async Task<Contract.Vision.OCR.IDCard> IDCardOCR(StorageFile storageFile, int card_type)
        {
            Contract.Vision.OCR.IDCard res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("card_type", card_type);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.ocr_idcardocr, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.OCR.IDCard>(json);
                return res;
            }
            catch { }

            return null;
        }

        public static async Task<Contract.Vision.OCR.BusinessCard> BusinessCardOCR(StorageFile storageFile)
        {
            Contract.Vision.OCR.BusinessCard res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.ocr_bcocr, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.OCR.BusinessCard>(json);
                return res;
            }
            catch { }

            return null;
        }

        //0-行驶证识别，1-驾驶证识别
        public static async Task<Contract.Vision.OCR.DriverLicense> DriverLicenseOCR(StorageFile storageFile, int type)
        {
            Contract.Vision.OCR.DriverLicense res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("type", type);
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.ocr_driverlicenseocr, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.OCR.DriverLicense>(json);
                return res;
            }
            catch { }

            return null;
        }

        public static async Task<Contract.Vision.OCR.BizLicense> BizLicenseOCR(StorageFile storageFile)
        {
            Contract.Vision.OCR.BizLicense res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.ocr_bizlicenseocr, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.OCR.BizLicense>(json);
                return res;
            }
            catch { }

            return null;
        }

        public static async Task<Contract.Vision.OCR.CreditCard> CreditCardOCR(StorageFile storageFile)
        {
            Contract.Vision.OCR.CreditCard res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.ocr_creditcardocr, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.OCR.CreditCard>(json);
                return res;
            }
            catch { }

            return null;
        }

        public static async Task<Contract.Vision.OCR.PlateNumber> PlateNumberOCR(StorageFile storageFile)
        {
            Contract.Vision.OCR.PlateNumber res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.ocr_platenumberocr, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.OCR.PlateNumber>(json);
                return res;
            }
            catch { }

            return null;
        }

        public static async Task<Contract.Vision.OCR.General> HandWritingOCR(StorageFile storageFile)
        {
            Contract.Vision.OCR.General res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.ocr_handwritingocr, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.OCR.General>(json);
                return res;
            }
            catch { }

            return null;
        }

        public static async Task<Contract.Vision.OCR.General> GeneralOCR(StorageFile storageFile)
        {
            Contract.Vision.OCR.General res = null;

            try
            {
                SortedDictionary<string, object> param = new SortedDictionary<string, object>();
                param.Add("app_id", Constants.AppID);
                param.Add("image", await ImageHelper.GetBase64(storageFile));
                param.Add("nonce_str", StringHelper.GenerateNonceStr());
                param.Add("time_stamp", TimeHelper.ToUnixTimestamp(DateTime.Now));

                //获取签名
                string signStr = Tools.MakeSign(param);
                param.Add("sign", signStr);
                string data = Tools.HttpBuildQuery(param);

                string json = await HttpHelper.SendPostAsync(ApiAddress.ocr_generalocr, data);
                res = JsonConvert.DeserializeObject<Contract.Vision.OCR.General>(json);
                return res;
            }
            catch { }

            return null;
        }
    }
}
