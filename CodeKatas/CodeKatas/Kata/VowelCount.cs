using System;
using System.Linq;

namespace CodeKatas.Kata
{
    public class VowelCount: IKata
    {
        private int GetVowelCount(string str)
        {            
            return str.Count(f => "aeiou".Contains(f));           
        }

        public void Run()
        {
            Console.WriteLine(GetVowelCount("fish"));
            Console.WriteLine(GetVowelCount("one"));
            Console.WriteLine(GetVowelCount("package"));
            Console.WriteLine(GetVowelCount("codekata"));
            Console.WriteLine(GetVowelCount("onetwothree"));
        }
    }
}
