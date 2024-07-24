using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 7, 23, 32, 34, 62 };
        int target = 23;
        int result = BinarySearchRecursive(array, target, 0, array.Length - 1);
        Console.WriteLine("Vi tri cua phan tu " + target + " (de quy): " + result);
        Console.ReadKey();
    }

    static int BinarySearchRecursive(int[] array, int target, int left, int right)
    {
        if (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;
            if (array[mid] < target)
                return BinarySearchRecursive(array, target, mid + 1, right);
            else
                return BinarySearchRecursive(array, target, left, mid - 1);
        }

        return -1;
    }
}