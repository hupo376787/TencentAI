///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentAI.Helpers
{
    public class TimeHelper
    {
        public static DateTime ToDateTime(long unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp);
            return dtDateTime;
        }

       public static long ToUnixTimestamp(DateTime time)
        {
            var date = new DateTime(1970, 1, 1, 0, 0, 0);
            var unixTimestamp = Convert.ToInt64((time.ToUniversalTime() - date).TotalSeconds);

            return unixTimestamp;
            //return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }
    }
}
