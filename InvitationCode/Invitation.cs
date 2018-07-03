using System.Text;

namespace InvitationCode
{
    public static class Invitation
    {
        /// <summary>
        /// 邀请码包含的内容。如果区分大小写可以把小写字母加进去。
        /// 注意：这个字符串不能包含重复字符，建议用Tools.RandomSource()生成
        /// </summary>
        private static readonly string SOURCE = "FGSBP0MA4X21HD3OY68K5RVETUZCLIW7JQN9";

        /// <summary>
        /// 将ID转换成邀请码
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string IdToCode(long id)
        {
            StringBuilder sb = new StringBuilder();
            int dec = SOURCE.Length - 1;
            while(id > 0)
            {
                sb.Insert(0, SOURCE[(int)(id % dec)]);
                id /= dec;
            }

            return Encrypt(sb.ToString());
        }

        /// <summary>
        /// 将邀请码转换成ID
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static long CodeToId(string code)
        {
            string str = Decrypt(code);
            long id = 0;
            int dec = SOURCE.Length - 1;
            for(int i = 0; i < code.Length; i++)
            {
                id = SOURCE.IndexOf(code[i]) + id * dec;
            }

            return id;
        }

        /// <summary>
        /// 二次加密。如果对上述邀请码不放心，可以自己写一个加密算法。但是一定要对应下面解密方法一起写。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string Encrypt(string s)
        {
            return s;
        }

        /// <summary>
        /// 解密。如果对生成的邀请码有加密，这里要写一下解密算法。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string Decrypt(string s)
        {
            return s;
        }
    }
}
