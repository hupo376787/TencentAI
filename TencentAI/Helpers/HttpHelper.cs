///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Windows.Web;
using System.IO;
using TencentAI.Helpers;

namespace TencentAI.Helpers
{
    public class HttpHelper
    {
        public static async Task<string> SendPostAsync(string url, string data, Encoding encoding = null)
        {
            try
            {
                if (encoding == null)
                    encoding = Encoding.UTF8;

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "POST";
                byte[] bt = encoding.GetBytes(data);
                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers["ContentLength"] = bt.Length.ToString();
                using (Stream stream = await request.GetRequestStreamAsync())
                {
                    stream.Write(bt, 0, bt.Length);
                }
                WebResponse response = await request.GetResponseAsync();
                Stream streamResponse = response.GetResponseStream();

                StreamReader sr = new StreamReader(streamResponse, encoding);
                string result = sr.ReadToEnd();
                streamResponse.Dispose();
                sr.Dispose();
                return result;
                //return StreamHelper.Buffer2String(StreamHelper.Stream2Buffer(streamResponse));
            }
            catch (WebException e)
            {
                throw new WebException(e.Message);
            }
        }
    }
}
