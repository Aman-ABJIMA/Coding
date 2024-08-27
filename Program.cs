namespace Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Patterns.Pattern01(5, 5);
            Console.WriteLine();
          
            Patterns.Pattern02(15, 10);
            Console.WriteLine();
            
            Patterns.Pattern03(5,5);
            Console.WriteLine();

            Patterns.Pattern04(5,5);
            Console.WriteLine();

            Patterns.Pattern05(5, 5);
            Console.WriteLine();

            Patterns.Pattern06(5, 5);
            Console.WriteLine();

            Patterns.Pattern07(5, 5);
            Console.WriteLine();

            Patterns.Pattern08(5, 5);
            Console.WriteLine();

            Patterns.Pattern09(5, 5);
            Console.WriteLine();

            Patterns.Pattern10(5, 5);
            Console.WriteLine();

            List<int> list = new List<int>() {11,2,13,1,4,14,4,14,5,5,15,6};
            var result = ContinueWithList.List01(list);
            foreach(var e in result)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            List<int> list1 = new List<int>() { 11, 2, 13, 1, 4, 14, 4, 14, 5, 5, 15, 6 };
            var result2 = ContinueWithList.List02(list1);
            foreach (var e in result2)
            {
                Console.WriteLine(e);
            }
        }
    }
}
