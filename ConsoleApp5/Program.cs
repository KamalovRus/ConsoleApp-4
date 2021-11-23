using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                ans += i * 2 - 1;
                Console.WriteLine("Result = {0}", ans);
                
            }
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
