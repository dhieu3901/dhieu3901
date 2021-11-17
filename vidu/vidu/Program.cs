using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vidu
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
