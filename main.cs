using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n, m, l, t, p, q;
            int[] c = new int[1000];
            int[] d = new int[1000];
            int[] a = new int[1000];
            int[] b = new int[1000];
            n = 1000;
            t = 0;
            p = 0;
            q = 0;
            m = 0;
            l = 0;
            for (i = 2; i <= n; i++) // find all primes between 1 and n
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break; // if factor found, not prime
                if ((i % j) == 0)
                {
                    b[l] = i;
                    l++;
                }
                if (j > (i / j))
                {
                    a[m] = i;
                    m++;
                }
            }
            for (i = 0; i < m; i++)
            {
                Console.WriteLine("{0} is prime", a[i]);
            }
            for (i = 0; i < m - 1; i++)
            {
                k = a[i + 1] - a[i];
                Console.WriteLine("{0} is the difference between {1} and {2}", k, a[i], a[i + 1]);
            }
            for (i = 0; i < m - 1; i++)
            {
                k = a[i + 1] - a[i];
                if (k == 2)
                {
                    c[t] = a[i];
                    t++;
                }
            }
            for (i = 0; i < m; i++)
            {
                k = a[i];
                while (k > 0)
                {
                    j = k % 10;
                    k = k / 10;
                    d[p] = j;
                    p++;
                }
                if (d[0] == d[p - 1])
                {
                    Console.WriteLine("{0} is a balanced prime", a[i]);
                    q++;
                }
                p = 0;
            }
            for (i = 0; i < l; i++)
            {
                //Console.WriteLine("{0} is non-prime", b[i]);
            }
            for (i = 0; i < t; i++)
            {
                Console.WriteLine("{0} is twin prime", c[i]);
            }
            Console.WriteLine("There are {0} non-primes between 1 and {1}", l, n);
            Console.WriteLine("There are {0} primes between 1 and {1}", m, n);
            Console.WriteLine("There are {0} twin primes between 1 and {1}", t, n);
            Console.WriteLine("There are {0} balanced primes between 1 and {1}", q, n);

        }
    }