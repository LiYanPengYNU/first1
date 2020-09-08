using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07随机数
{
    class Program
    {
        static void Main(string[] args)

            
        {
            Random r = new Random();//创建能够产生随机数的对象
            while (true)
            {
                int rNumber = r.Next(1, 11);//让产生随机数的这个对象调用方法产生随机数  产生1-10之间的随机数 左闭右开
                Console.WriteLine(rNumber);
                Console.ReadKey();
            }
            
            
        }
    }
}
