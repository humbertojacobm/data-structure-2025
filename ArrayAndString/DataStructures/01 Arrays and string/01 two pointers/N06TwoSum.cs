
namespace ArrayAndString.DataStructures;

public static class TwoSum
{
    public static void Run()
    {
        //PROBLEM:
        // given an array of integers nums and an integer target, return indices of two numbers such that they add up to target.

        // you may assume that each input would have exactly one solution, and you may not use the same element twice. You can return target answer in any order.

        int[] numbers = [3, 1, 7, 9, 2, 4];//WE CAN TEST ANOTHER TESTS TOO.
        var targetNumber = 6;
        Console.WriteLine($"the array is {String.Join(",", numbers)}");
        Console.WriteLine($"the target number is {targetNumber}");
        int[] indexes = GetIndexesThatAddUp(targetNumber, numbers); 
        if (indexes[0]==-1)
            Console.WriteLine($"there is not result");
        Console.WriteLine($"the index is {String.Join(",", indexes)}");
    }

    static int[] GetIndexesThatAddUp(int target, int[] numbers)
    {
        var left = 0;
        // var right = numbers.Length - 1;//TODO: WE WILL NOT USE THIS THIS TIME, BUT GOOD HAVIT TO HAVE IT
        Dictionary<int, int> complements = new Dictionary<int, int>();
        var currentComplement = 0;
        var rescuedIndex = 0;
        var currentValue = 0;
        while (left < numbers.Length)
        {
            if (numbers[left] < target)
            {
                currentValue = numbers[left];
                if (complements.ContainsKey(currentValue))//INFO: CHECK IF THE VALUE EXIST IN THE HISTORY
                {
                    complements.TryGetValue(currentValue, out rescuedIndex);
                    return [left, rescuedIndex];
                }
                else//INFO: IF NOT EXIST, WE SHOULD ADD THE COMPLMENT AND INDEX
                {
                    currentComplement = target - currentValue;
                    complements.Add(currentComplement, left);
                }
            }
            left++;
            // right--;//we have this stuck, we need in that way
        }
        return [-1,-1];//TODO: THIS MEANS THAT THERE IS NOT A RESULT
    }
}