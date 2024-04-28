namespace IsraelObakpolorTestSolution
{
    public class Program
    {
      public static void Main(string[] args)
        {
            Console.WriteLine(TestAnswer.Rob(new int[] { 1, 2, 3, 1 }));  // Output: 4
            Console.WriteLine(TestAnswer.Rob(new int[] { 2, 7, 9, 3, 1 }));  // Output: 12
        }
    }
}
