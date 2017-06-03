using CodeKatas.Kata;
using System;
using System.Reflection;

namespace CodeKatas
{
    class Program
    {
        private static IKata GetKata()
        {
            Console.Write("Name of kata to run: ");
            string name = Console.ReadLine().Replace(Environment.NewLine, "");           
            Type t = Type.GetType("CodeKatas.Kata." + name);
            return t != null ? (IKata)Activator.CreateInstance(t) : null;          
        }

        static void Main(string[] args)
        {
            IKata kata = GetKata();
            if (kata == null)
            {
                Console.WriteLine("No kata found, press Enter to exit...");
            }
            else
            {
                kata.Run();
            }            
            Console.Read();
        }
    }
}
