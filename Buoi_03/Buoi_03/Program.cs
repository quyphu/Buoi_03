using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = SumArrayNonRecursive(array);
        Console.WriteLine("Tong : " + sum);
        Console.ReadKey();
    }

    static int SumArrayNonRecursive(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
        
    }
 
    
}