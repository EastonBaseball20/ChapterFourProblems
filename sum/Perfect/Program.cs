using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 1000; i++)
            {
                for (int n = 1; n <= i; n++)
                {
                    int ans = n * n;
                    if (i == ans)
                    {
                        Console.WriteLine(n);
                    }
                }
            }

           
        }
    }
}
