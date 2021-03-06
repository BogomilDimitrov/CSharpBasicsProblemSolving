﻿using System;

class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', (n*3+1)/2));


        for (int i = 0; i < n/2+1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', (n * 3 + 1) / 2 - 1 - i),
                new string('.', 1 + 2 * i));
        }

        Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n+2));

        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
               new string('.', 1 + i),
               new string('.', 3 * n - 2 - 2 * i));
        }

        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}",
               new string('.', n / 2 - 1 - i),
               new string('.', n / 2),
               new string('.', 0 + i),
               new string('.', n));
        }

        Console.WriteLine("{0}{1}*{2}*{1}{0}", 
            new string('*', n/2 + 1),
            new string('.', n/2),
            new string('.', n));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string('.', n));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n + 2));
    }
}
