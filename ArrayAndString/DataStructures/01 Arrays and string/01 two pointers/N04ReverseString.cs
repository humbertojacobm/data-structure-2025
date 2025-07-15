using System.IO.Compression;
using System.Runtime.InteropServices.Marshalling;

namespace ArrayAndString.DataStructures;

public class ReverseString
{
    public static void Run()
    {
        //reverse the string

        var input = "HELLO";

        Console.WriteLine($"the final result {ReverseStringSequence(input)}");
    }

    static string ReverseStringSequence(string world)
    {
        var left = 0;
        var right = world.Length - 1;
        char[] worldArray = world.ToCharArray();

        while (left < right)
        {
            (worldArray[left], worldArray[right]) = (worldArray[right], worldArray[left]);
            left++;
            right--;
        }
        
        return new string(worldArray);
    }
}