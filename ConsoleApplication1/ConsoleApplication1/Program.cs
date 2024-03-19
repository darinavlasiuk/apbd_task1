using System;

namespace ConsoleApplication1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello");
      Console.WriteLine("World");
      Console.WriteLine("Hey");
    }
    
    static double findAvg(int[] arr)
    {
      double avg = 0.0;
      int sum = 0;
      for (int i = 0; i < arr.Length; ++i)
      {
        sum += arr[i];
      }

      avg = (double)sum / arr.Length;
      return avg;
    }
  }
  
}