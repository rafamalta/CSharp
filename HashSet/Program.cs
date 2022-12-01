using System;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Malta"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}