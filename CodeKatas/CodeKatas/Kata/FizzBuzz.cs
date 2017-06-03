using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Kata
{
    class FizzBuzz : IKata
    {
        public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = (i % 3 == 0);
                bool buzz = (i % 5 == 0);

                if (fizz)
                {
                    Console.Write("Fizz");
                }

                if (buzz)
                {
                    Console.Write("Buzz");
                }

                if (!fizz && !buzz)
                {
                    Console.Write(i.ToString());
                }

                Console.WriteLine();
            }
        }
    }
}
