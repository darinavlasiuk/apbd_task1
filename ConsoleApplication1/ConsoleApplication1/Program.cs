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
      double avg;
      int sum = 0;
      for (int i = 0; i < arr.Length; ++i)
      {
        sum += arr[i];
      }
      avg=(double)sum / arr.Length;
      return avg;
    }
    
    static int findMax(int[] arr)
    {
      int max = arr[0];
      for (int i = 1; i < arr.Length; ++i)
      {
        if (arr[i] > max)
          max = arr[i];
      }

      return max;
    }
  }
  
}