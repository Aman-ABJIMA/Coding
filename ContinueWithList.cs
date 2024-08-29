namespace Patterns
{
    public static class ContinueWithList
    {
        private static int nth = 0;

        public static List<int> List01(List<int> elements)
        {
            int temp = 0;
            int count = 0;
            elements.Sort();
            List<int> list = new List<int>();
            foreach (var e in elements)
            {
                if (temp == e)
                {
                    count++;
                    if (count >= 2)
                        continue;
                }
                else
                {
                    count = 0;
                }
                temp = e;
                list.Add(e);
            }
            return list;
        }
        public static List<int> List02(List<int> elements)
        {
            int temp = 0;
            for (int i = 0; i < elements.Count - 1; i++)
            {
                for (int j = 0; j < elements.Count - 1; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                    }
                }
            }
            return elements;
        }
        public static int Number(int n)
        {
            if (n > 1)
              Console.WriteLine(Number(n - 1));
            return n;
        }
    }
}
