using CodingPractice;
using System.Reflection;

namespace Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type myClassType1 = typeof(Patterns);
            Type myClassType2 = typeof(Constant);

            int constantCount = 0;
            string methodName = string.Empty;
            string patternName = string.Empty;
            string constantName = string.Empty;
            string constantValue = string.Empty;

            FieldInfo[] fields = myClassType2.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

            // Filter the constants (IsLiteral is true for constants)
            foreach (var field in fields)
            {
                if (field.IsLiteral && !field.IsInitOnly)  // Ensure the field is a constant and not readonly
                {
                    constantCount++;
                }
            }


            for (int i = 1; i <= constantCount; i++)
            {
                constantName = methodName = i < 10 ? $"Pattern0{i}" : $"Pattern{i}";
                // Get the MethodInfo for the static method
                MethodInfo methodInfo = myClassType1.GetMethod(methodName, BindingFlags.Public | BindingFlags.Static);
                // Get the fieldInfo for the static fields
                FieldInfo fieldInfo = myClassType2.GetField(constantName, BindingFlags.Public | BindingFlags.Static);

                if (fieldInfo != null)
                {
                    // Access the constant value (cast to the appropriate type)
                    constantValue = (string)fieldInfo.GetValue(null);  // null because it's static
                }
                if (methodInfo != null)
                {
                    methodInfo.Invoke(null, [5, 5, constantValue]);
                    Console.WriteLine();

                }
            }

          
            //List<int> list = new List<int>() { 11, 2, 13, 1, 4, 14, 4, 14, 5, 5, 15, 6 };
            //var result = ContinueWithList.List01(list);
            //foreach (var e in result)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine();

            //List<int> list1 = new List<int>() { 11, 2, 13, 1, 4, 14, 4, 14, 5, 5, 15, 6 };
            //var result2 = ContinueWithList.List02(list1);
            //foreach (var e in result2)
            //{
            //    Console.WriteLine(e);
            //}

            //Console.WriteLine();

            //Console.Write(ContinueWithList.Number(5));
            //Console.WriteLine();

        }
    }
}
