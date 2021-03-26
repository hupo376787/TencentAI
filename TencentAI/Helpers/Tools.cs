///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TencentAI.Helpers
{
    public class Tools
    {
        public static string MakeSign(SortedDictionary<string, object> param, Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.UTF8;

            //转url格式
            string str = HttpBuildQuery(param, true, encoding);
            //在string后加入API KEY
            str += "&app_key=" + Constants.AppKey;

            //MD5加密
            var md5 = MD5.Create();
            var bs = md5.ComputeHash(encoding.GetBytes(str));
            return string.Join("", bs.Select(b => b.ToString("x2"))).ToUpper();
            //var sb = new StringBuilder();
            //foreach (byte b in bs)
            //{
            //    sb.Append(b.ToString("x2"));
            //}
            //return sb.ToString().ToUpper();
        }

        public static string HttpBuildQuery(SortedDictionary<string, object> param, bool bSort = true, Encoding encoding = null)
        {
            if (bSort)
            {
                var list = param.OrderBy(d => d.Key).Select(d => (UrlEncodePair(d.Key, d.Value.ToString(), encoding)));
                return string.Join("&", list.ToArray());
            }
            else
                return string.Join("&", param.OrderBy(d => d.Key).Select(d => (UrlEncodePair(d.Key, d.Value.ToString(), encoding))));
            //var sb = new StringBuilder();

            //foreach (var kvp in param)
            //{
            //    if (sb.Length > 0)
            //    {
            //        sb.Append('&');
            //    }
            //    sb.Append(UrlEncodePair(kvp.Key, kvp.Value.ToString()));
            //}

            //return sb.ToString();
        }

        public static string UrlEncodePair(string k, string v, Encoding encoding = null)
        {
            return string.Format("{0}={1}", k, UrlEncode(v, encoding));
        }

        //public static string UrlEncode(string str)
        //{
        //    int limit = 2000;

        //    StringBuilder sb = new StringBuilder();
        //    int loops = str.Length / limit;

        //    for (int i = 0; i <= loops; i++)
        //    {
        //        if (i < loops)
        //        {
        //            sb.Append(Uri.EscapeDataString(str.Substring(limit * i, limit)));
        //        }
        //        else
        //        {
        //            sb.Append(Uri.EscapeDataString(str.Substring(limit * i)));
        //        }
        //    }
        //    return sb.ToString();
        //}

        public static string UrlEncode(string str, Encoding encoding = null)
        {
            if (encoding == null || encoding == Encoding.UTF8)
            {
                //*号暂时有问题，其他可以参考https://urlencode.org
                return System.Net.WebUtility.UrlEncode(str.Replace("*", ""));
            }
            else
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding encodingGBK = Encoding.GetEncoding("GBK");

                if (string.IsNullOrEmpty(str)) return string.Empty;
                var buffer = new StringBuilder(str.Length);
                byte[] data = encodingGBK.GetBytes(str);
                foreach (byte b in data)
                {
                    var c = (char)b;
                    if (!(('0' <= c && c <= '9') || ('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z'))
                        && "-_.~".IndexOf(c) == -1)
                    {
                        buffer.Append('%' + Convert.ToString(c, 16).ToUpper());
                    }
                    else
                    {
                        buffer.Append(c);
                    }
                }
                return buffer.ToString();



                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    char ch = str[i];
                    if ((str[i] >= 'a' && str[i] <= 'z') ||
                        (str[i] >= 'A' && str[i] <= 'Z') ||
                        (str[i] >= '0' && str[i] <= '9'))
                    {
                        stringBuilder.Append(str[i]);
                    }
                    else
                    {
                        //stringBuilder.AppendFormat("%{0:X2}", (int)str[i]);

                        Char[] chars = new Char[1];
                        chars[0] = str[i];
                        string ss = new string(chars);
                        if (ss == " ")
                            stringBuilder.Append('+');
                        else
                        {
                            foreach (byte b in encodingGBK.GetBytes(ss))
                            {
                                stringBuilder.Append('%' + b.ToString("X"));
                            }
                        }
                    }
                }

                return stringBuilder.ToString();
            }
        }
    }
}
