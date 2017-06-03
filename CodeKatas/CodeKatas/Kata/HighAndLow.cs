using System;
using System.Linq;

namespace CodeKatas.Kata
{
    public class HighAndLow: IKata
    {
        private string GetHighLow1(string numbers) // With Linq.
        {
            var arr = numbers.Split().Select(int.Parse);
            return String.Format("{0} {1}", arr.Max(), arr.Min());
        }

        private string GetHighLow2(string numbers) // Without Linq.
        {
            int? highest = null;
            int? lowest = null;
            foreach (string numStr in numbers.Split(null))
            {
                int num = int.Parse(numStr);
                if (highest == null || num > highest)
                {
                    highest = num;
                }

                if (lowest == null || num < lowest)
                {
                    lowest = num;
                }
            }
            return String.Format("{0} {1}", highest, lowest);
        }

        public void Run()
        {
            Console.WriteLine(GetHighLow1("1 2 3 4 5"));
            Console.WriteLine(GetHighLow1("2 4 8 16 32"));
            Console.WriteLine(GetHighLow1("2 5 3 1 4"));
            Console.WriteLine(GetHighLow1("-10 99 2"));

            Console.WriteLine(GetHighLow2("1 2 3 4 5"));
            Console.WriteLine(GetHighLow2("2 4 8 16 32"));
            Console.WriteLine(GetHighLow2("2 5 3 1 4"));
            Console.WriteLine(GetHighLow2("-10 99 2"));
        }
    }
}
