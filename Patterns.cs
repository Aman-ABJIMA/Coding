namespace Patterns
{
    public static class Patterns
    {
        public static string Formatter(int n)
        {
            if (n < 10)
                return $"{n.ToString()} ";
            return $"{n.ToString()}";
        }
        public static void Pattern01(int r, int c,string name)
        {
            Console.WriteLine(name);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern02(int r, int c,string name)
        {
            Console.WriteLine(name);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == 0 || i == (r - 1) || j == 0 || j == (c - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Pattern03(int r, int c,string name)
        {
            Console.WriteLine(name);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if (i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Pattern04(int r, int c,string name)
        {
            Console.WriteLine(name);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (j == (c - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                c--;
                Console.WriteLine();
            }
        }
        public static void Pattern05(int r, int c,string name)
        {
            Console.WriteLine(name);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                   Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern06(int r, int c,string name)
        {
            Console.WriteLine(name);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("*");
                }
                c--;
                Console.WriteLine();
            }
        }
        public static void Pattern07(int r, int c,string name)
        {
            Console.WriteLine(name);
            int k = c-1;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (j >= k)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                k--;
                Console.WriteLine();
            }
        }
        public static void Pattern08(int r, int c,string name)
        {
            Console.WriteLine(name);
            int k = -1;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (j > k)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                k++;
                Console.WriteLine();
            }
        }
        public static void Pattern09(int r, int c,string name)
        {
            Console.WriteLine(name);
            for (int i = 1; i <= r; i++)
            {
                for( int k=i; k < r;k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2*i-1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern10(int r, int c,string name)
        {
            Console.WriteLine(name);
            for (int i = 1; i <= r; i++)
            {
                for (int k = i; k < r; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = r-1; i >= 0; i--)
            {
               
                for (int j = r-1; j > (2 * i - 1); j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern11(int r,string name)
        {
            Console.WriteLine(name);
            for (int i = 1; i <= r; i++)
            {
                for (int k = i; k < r; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * i - 1); j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }            
        }
        public static void Pattern12(int r,string name)
        {
            Console.WriteLine(name);
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Pattern13(int r,string name)
        {
            Console.WriteLine(name);
            for (int i = r; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Pattern14(int r,string name)
        {
            Console.WriteLine(name);
            int c = 1;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" "+Formatter(c));
                    c++;
                }
                Console.WriteLine();
            }
        }
        public static void Pattern15(int r,string name)
        {
            Console.WriteLine(name);
            int c = 0;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    c = (c != 1) ? 1 : 0;
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
        public static void Pattern16(int r,string name)
        {
            Console.WriteLine(name);
            for (int i = 1; i <= r; i++)
            {
                for(int k = r; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                for(int j = 2; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Pattern17(int r, string name)
        {
            Console.WriteLine(name);
            for (int i = 1; i <= r; i++)
            {
                for (int k = r; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= r; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 2*r; j > 2 * i - 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}