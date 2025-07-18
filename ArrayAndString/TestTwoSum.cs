using ArrayAndString.DataStructures;

public class TestTwoSum
{
    public static void Main()
    {
        TestCase([2,7,11,15], 9, "Case 1: Basic positive numbers");
        TestCase([3,2,4], 6, "Case 2: Adjacent elements");
        TestCase([3,3], 6, "Case 3: Same values");
        TestCase([-1,-2,-3,-4,-5], -8, "Case 4: Negative numbers");
        TestCase([0,4,-3,0], -3, "Case 5: With zeros");
        TestCase([5,5,5,5], 10, "Case 6: All same values");
    }

    static void TestCase(int[] nums, int target, string description)
    {
        Console.WriteLine($"\n{description}");
        Console.WriteLine($"Array: [{string.Join(",", nums)}], Target: {target}");
        
        var result = GetIndexesThatAddUp(target, nums);
        
        if (result[0] == -1)
        {
            Console.WriteLine("No solution found");
        }
        else
        {
            Console.WriteLine($"Indices: [{result[0]},{result[1]}]");
            Console.WriteLine($"Values: {nums[result[0]]} + {nums[result[1]]} = {nums[result[0]] + nums[result[1]]}");
        }
    }
    
    static int[] GetIndexesThatAddUp(int target, int[] numbers)
    {
        var left = 0;
        Dictionary<int, int> complements = new Dictionary<int, int>();
        var currentComplement = 0;
        var rescuedIndex = 0;
        var currentValue = 0;
        while (left < numbers.Length)
        {
            currentValue = numbers[left];
            if (complements.ContainsKey(currentValue))
            {
                complements.TryGetValue(currentValue, out rescuedIndex);
                return [rescuedIndex, left];
            }
            else
            {
                if (!complements.ContainsKey(currentValue))
                {
                    currentComplement = target - currentValue;
                    complements.Add(currentComplement, left);
                }
            }
            left++;
        }
        return [-1,-1];
    }
}