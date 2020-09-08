using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串类型初始化
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] n = { '你','是','谁' };//利用字符数组对字符串进行初始化
            //string str = new string(n);
            string str = new string(n, 1, 2);//提取字符数组中的一部分进行初始化
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
