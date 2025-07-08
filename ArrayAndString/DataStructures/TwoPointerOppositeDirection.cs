namespace ArrayAndString.DataStructures;

public class TwoPointerOppositeDirection
{
    public static void Run()
    {
        //Given a sorted array of integers and a target sum, find two numbers that add up to the target. Return their indices.
        int[] numbers = { 2, 7, 11, 15 };
        var target = 9;

        var result = TwoSum(numbers, target);
        Console.WriteLine(String.Join(", ", result));
    }

    static int[] TwoSum(int[] numbers, int target)
    {
        //because this is ordered, we can use a two-pointer approach using oposite directions.
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return new int[] { left, right };
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return new int[] { -1, -1 };
    }
}