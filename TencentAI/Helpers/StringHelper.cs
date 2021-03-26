///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentAI.Helpers
{
    public class StringHelper
    {
        public static string GenerateNonceStr()
        {
            return Guid.NewGuid().ToString("N");
        }

        public static string GetUtf8String(string input)
        {
            //byte[] array = Encoding.UTF8.GetBytes(input);
            //MemoryStream stream = new MemoryStream(array);
            //StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            //string s = reader.ReadToEnd();
            //reader.Dispose();
            //return s;

            //byte[] buffer = Encoding.UTF8.GetBytes(input);
            //string str = "";
            //foreach (byte b in buffer)
            //    str += string.Format("%{0:X}", b);
            //return str;

            byte[] array = Encoding.UTF8.GetBytes(input);
            MemoryStream stream = new MemoryStream(array);
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string s = reader.ReadToEnd();
            reader.Dispose();
            return s;
        }

        public static string GetGBKString(string input)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encodingGbk = Encoding.GetEncoding("GBK");

            byte[] array = encodingGbk.GetBytes(input);
            MemoryStream stream = new MemoryStream(array);
            StreamReader reader = new StreamReader(stream, encodingGbk);
            string s = reader.ReadToEnd();
            reader.Dispose();
            return s;
        }
    }
}
