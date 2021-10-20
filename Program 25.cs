using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 0, count = 0;
            for (int i = 1; i<=N; i++){
                if (i % 2 == 0)
                {
                    a = a + i;
                    count = count + 1;
                         
                }

            }
            Console.WriteLine(count);
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
