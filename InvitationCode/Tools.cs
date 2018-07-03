using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InvitationCode
{
    public static class Tools
    {
        /// <summary>
        /// 生成一个随机排序的不重复的字符串
        /// 防止连续调用随机字符串相同，所以加了Thread.Sleep(1),延时1ms。
        /// </summary>
        /// <returns></returns>
        public static string RandomSource()
        {
            string s = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            HashSet<char> set = new HashSet<char>();
            Random r = new Random(DateTime.Now.Millisecond);
            r.Next();
            Thread.Sleep(1);
            while(true)
            {
                var c = s[r.Next(0, s.Length)];
                set.Add(c);
                if(set.Count == s.Length)
                    break;
            }
            return new string(set.ToArray());
        }

        /// <summary>
        /// 生成一个随机字符串。
        /// 因为随机种子用的是毫秒，所以加了一个Thread.Sleep(1),防止连续调用的时候随机的字符串相同。
        /// 根据需求自己添加随机字符串包含的内容
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RandomString(int length = 10)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ABCDEFGHIJKLMNORSTUVWXYZ");
            sb.Append("abcdefghijklmnorstuvwxyz");
            sb.Append("0123456789");
            sb.Append("`~!@#$%^&*-+_=;<.>[]?|");

            string input = sb.ToString();
            Random random = new Random(DateTime.Now.Millisecond);
            random.Next();
            Thread.Sleep(1);
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, input.Length);
                output.Append(input[index]);
            }
            
            return output.ToString();
        }

    }
}
