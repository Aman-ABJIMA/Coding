namespace Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            string patternName = string.Empty;
            patternName = "Square Fill Pattern";
            Patterns.Pattern01(5, 5, patternName);
            Console.WriteLine();

            patternName = "Square Hollow Pattern";
            Patterns.Pattern02(15, 10, patternName);
            Console.WriteLine();

            patternName = "Right-aligned line pattern";
            Patterns.Pattern03(5,5, patternName);
            Console.WriteLine();

            patternName = "Left-aligned line pattern";
            Patterns.Pattern04(5,5, patternName);
            Console.WriteLine();

            patternName = "Right Half Pyramid Pattern";
            Patterns.Pattern05(5, 5 , patternName);
            Console.WriteLine();

            patternName = "Reverse Right Half Pyramid Pattern";
            Patterns.Pattern06(5, 5 , patternName);
            Console.WriteLine();

            patternName = "Left Half Pyramid Pattern";
            Patterns.Pattern07(5, 5 , patternName);
            Console.WriteLine();

            patternName = "Reverse Left Half Pyramid Pattern";
            Patterns.Pattern08(5, 5 , patternName);
            Console.WriteLine();

            patternName = "Triangle Star Pattern or Pyramid Pattern";
            Patterns.Pattern09(5, 5 , patternName);
            Console.WriteLine();

            patternName = "";
            Patterns.Pattern10(5, 5 , patternName);
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

            Console.WriteLine();

            Console.Write(ContinueWithList.Number(5));
            Console.WriteLine();

            patternName = "Number Triangle Pattern";
            Patterns.Pattern11(5, patternName);
            Console.WriteLine();

            patternName = "Number-increasing Pyramid Pattern";
            Patterns.Pattern12(5, patternName);
            Console.WriteLine();

            patternName = "Number-increasing reverse Pyramid Pattern";
            Patterns.Pattern13(5 , patternName);
            Console.WriteLine();

            patternName = "Number-changing Pyramid Pattern";
            Patterns.Pattern14(5 , patternName);
            Console.WriteLine();

            patternName = "Zero-One Triangle Pattern";
            Patterns.Pattern15(5 , patternName);
            Console.WriteLine();

            patternName = "Palindrome Triangle Pattern";
            Patterns.Pattern16(5 , patternName);
            Console.WriteLine();

            patternName = "Palindrome Triangle Pattern";
            Patterns.Pattern17(5, patternName);
            Console.WriteLine();

        }
    }
}
