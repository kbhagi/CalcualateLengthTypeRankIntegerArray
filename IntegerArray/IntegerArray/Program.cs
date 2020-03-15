using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Type=" + array.GetType());
            Console.WriteLine("Rank=" + array.Rank);
            Console.WriteLine("Length=" + array.Length);
            Console.ReadKey();

        }
    }
}
