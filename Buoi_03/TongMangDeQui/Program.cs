using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = SumArrayRecursive(array, 0, array.Length - 1);
        Console.WriteLine("Tong : " + sum);
        Console.ReadKey();
    }

    static int SumArrayRecursive(int[] array, int left, int right)
    {
        if (left == right)
            return array[left];

        int mid = (left + right) / 2;
        int leftSum = SumArrayRecursive(array, left, mid);
        int rightSum = SumArrayRecursive(array, mid + 1, right);

        return leftSum + rightSum;
    }
}