using System;

namespace InvitationCode
{
    class Program
    {
        static void Main(string[] args)
        {
            long id = 531347133124609;
            string code = Invitation.IdToCode(id);

            Console.WriteLine($"输入的ID是 '{id}'， 生成的邀请码是 '{code}'");
            Console.WriteLine($"邀请码 '{code}' 转化后的ID是 '{Invitation.CodeToId(code)}'");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
