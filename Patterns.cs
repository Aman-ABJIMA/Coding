namespace Patterns
{
    public static class Patterns
    {
        public static void Pattern01(int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern02(int r, int c)
        {
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
        public static void Pattern03(int r, int c)
        {
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
        public static void Pattern04(int r, int c)
        {
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
        public static void Pattern05(int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                   Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern06(int r, int c)
        {
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
        public static void Pattern07(int r, int c)
        {
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
        public static void Pattern08(int r, int c)
        {
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
        public static void Pattern09(int r, int c)
        {
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
        public static void Pattern10(int r, int c)
        {
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
       
    }
}