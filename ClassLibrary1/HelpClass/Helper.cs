using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpClass
{
    public  class Helper
    {
        /// <summary>
        /// 精确获取当前年龄(Get Current Age Exactly)
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int GetAge(DateTime date)
        {
            string time = (Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")) - Convert.ToInt32(date.ToString("yyyyMMdd"))).ToString();
            if (time.Length < 4)
            {
                return 0;
            }
            return Convert.ToInt32(time.Substring(0, time.Length - 4));
        }
    }
}
