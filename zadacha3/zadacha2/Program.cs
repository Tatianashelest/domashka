using System;

class Program {
  public static void Main (string[] args) {
            int[] GenerateRandomArray(int size, int start, int end)
            {
                int[] RandomArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    RandomArray[i] = new Random().Next(start, end + 1);
                }
                return RandomArray;
            }
            void ShowArray(int[] Array1)
            {
                for (int i = 0; i < Array1.Length; i++)
                {
                    Console.WriteLine(Convert.ToString(Array1[i]));
                }
            }
            int CountOfEven(int[] myArray2)
            {
                int Count = 0;
                for (int i = 0; i < myArray2.Length; i++)
                    if (myArray2[i] % 2 == 0)
                    {
                        Count = Count + 1;
                    }
                return Count;
            }
            int[] myArray = new int[5];
            myArray = GenerateRandomArray(5, 100, 999);
            ShowArray(myArray);
            Console.WriteLine("количество четных чисел массива " + CountOfEven(myArray));
           
  }
}