using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211228
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("첫번째 수 입력:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 수 입력:");
            b = int.Parse(Console.ReadLine());
            
            if(a > b)
            {
                Console.WriteLine(a);
            }
            
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
