using System.IO.Compression;
using System.Runtime.InteropServices.Marshalling;

namespace ArrayAndString.DataStructures;

public class SortedSquare
{
    public static void Run()
    {
        //reverse the string

        int[] numbers = [-4, -1, 0, 3, 10];

        int[] sortedNumbers = SortedSquareNumber(numbers);

        Console.WriteLine($"the final result {string.Join(",",sortedNumbers)}");
    }

    static int[] SortedSquareNumber(int[] number)
    {
        var left = 0;
        var right = number.Length - 1;
        var lastPosition = right;
        int[] newSortedNumber = new int[lastPosition+1];

        while (left < right)
        {
            var newLeft = number[left] * number[left];
            var newRight = number[right] * number[right];

            if (newLeft > newRight)
            {
                newSortedNumber[lastPosition] = newLeft;
                left++;
            }
            else
            {
                newSortedNumber[lastPosition] = newRight;
                right--;
            }
            lastPosition--;
        }

        return newSortedNumber;
    }
}