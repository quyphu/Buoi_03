using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 7, 23, 32, 34, 62 };
        int target = 23;
        int result = BinarySearchNonRecursive(array, target);
        Console.WriteLine("Vi Tri Phan Tu " + target + " (Khong Co De Qui): " + result);
        Console.ReadKey();
    }

    static int BinarySearchNonRecursive(int[] array, int target)
    {
        int left = 0, right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;
            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}