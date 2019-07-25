[![996.icu](https://img.shields.io/badge/link-996.icu-red.svg)](https://996.icu)    [![LICENSE](https://img.shields.io/badge/license-Anti%20996-blue.svg)](https://github.com/996icu/996.ICU/blob/master/LICENSE)

# 邀请码 #

	
- 主要功能
	
	- 根据ID（long）生成一个邀请码（string）
	- 根据邀请码（string）反算出对应的ID（long）




> 

        static void Main(string[] args)
        {
            long id = 531347133124609;
            string code = Invitation.IdToCode(id);

            Console.WriteLine($"输入的ID是 '{id}'， 生成的邀请码是 '{code}'");
            Console.WriteLine($"邀请码 '{code}' 转化后的ID是 '{Invitation.CodeToId(code)}'");

            Console.WriteLine();
            Console.ReadLine();
        }


> 输出结果：
>
> `输入的ID是 '531347133124609'， 生成的邀请码是 'MUQ8S6PKDP'` 
>
> `邀请码 'MUQ8S6PKDP' 转化后的ID是 '531347133124609'`


