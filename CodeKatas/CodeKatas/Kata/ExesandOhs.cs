using System;
using System.Linq;

namespace CodeKatas.Kata
{
    public class ExesAndOhs: IKata
    {
        public bool XO(string input)
        {
            var chars = input.ToCharArray();
            return chars.Count(c => Char.ToLower(c) == 'o') == chars.Count(c => Char.ToLower(c) == 'x');
        }

        public void Run()
        {
            Console.WriteLine(XO("xo"));
            Console.WriteLine(XO("xxxm"));
            Console.WriteLine(XO("xxoo"));
            Console.WriteLine(XO("xxMoo"));
            Console.WriteLine(XO("xxvvoo"));
        }
    }
}
