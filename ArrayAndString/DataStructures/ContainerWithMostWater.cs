namespace ArrayAndString.DataStructures;

public class ContainerWithMostWater
{
    public static void Run()
    {
        //Given an array of heights, find two lines that together with the x-axis form a container that holds the most water.
        //Input: height = [1,8,6,2,5,4,8,3,7]
        //Output: 49 (between indices 1 and 8)

        int[] heights = {1,8,6,2,5,4,8,3,7};

        Console.WriteLine($"the final result {FindMaximunContainer(heights)}");
    }

    static int FindMaximunContainer(int[] heights)
    {
        //we need to think the result is the max value of a rectangule base x height
        //if base is 1, the result will be height
        //if height is 1, the result will be base
        var lenght = heights.Length;
        var left = 0;
        var right = lenght - 1;
        //math.floor() round down.
        //math.ceil() round up.
        //math.round(), round to nearest integer, it means .5 will be 1.
        //math.trunc(), it remove the decimal part.
        //var middle = (int)Math.Floor(lenght / 2.0);
        var maxArea = 0;

        while (left < right)
        {
            var minHeight = Math.Min(heights[left], heights[right]);
            var currentBase = right - left;
            var stepArea = minHeight * currentBase;
            if (stepArea > maxArea)
                maxArea = stepArea;

            if (heights[left] < heights[right])
                left++;
            else
                right--;

            Console.WriteLine($"the intermiates max area is {maxArea}, the left is {left} and the right is {right}, the height is {minHeight}");
        }
        
        return maxArea;//fake value
    }
}