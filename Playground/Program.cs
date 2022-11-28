using System;

namespace HelloWorld
{
  class Program
  {
    static string ArrayToString(int[] numbers)
    {
      string output = "Array: ";
      foreach (var number in numbers) {
        output += $"{number} | ";
      }
      return output;
    }

    static int Minimum(int[] numbers)
    {
      int currentSmallest = int.MaxValue;

      // Can crash if array is empty or null
      // int currentSmallest = numbers[0];

      foreach (var number in numbers)
      {
        if (number < currentSmallest) {
          currentSmallest = number;
        }
      }

      return currentSmallest;
    }

    static int IndexOfMaximum(int[] values)
    {
      if (values == null || values.Length == 0)
      {
        return -1;
      }

      int indexMaximum = 0;
      for (int i = 0; i < values.Length; i++) {
        if (values[i] > values[indexMaximum]) {
          indexMaximum = i;
        }
      }

      return indexMaximum;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World");

      int[] numbers = { 2, 5, 0, 13, 7, -23 };

      int smallest = Minimum(numbers);
      Console.WriteLine($"Smallest = {smallest}");
      Console.WriteLine(ArrayToString(numbers));

      int max = numbers[IndexOfMaximum(numbers)];
      Console.WriteLine("Max = " + max);

      int[] empty = {};
      smallest = Minimum(empty);
      Console.WriteLine($"Smallest = {smallest}");
      Console.WriteLine(ArrayToString(empty));

      // Array is null !!!!!
      int[] nothing = null;
      smallest = Minimum(nothing);
      Console.WriteLine($"Smallest = {smallest}");
      Console.WriteLine(ArrayToString(nothing));

    }
  }
}