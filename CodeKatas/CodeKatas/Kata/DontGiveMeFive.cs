using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Kata
{
    class DontGiveMeFive: IKata
    {
        private int GetCount(int start, int end)
        {
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (!i.ToString().Contains("5"))
                {
                    count++;
                }
            }
            return count;
        }

        public void Run()
        {
            Console.WriteLine(GetCount(1, 20));
            Console.WriteLine(GetCount(20, 27));
            Console.WriteLine(GetCount(12, 50));
        }
    }
}
