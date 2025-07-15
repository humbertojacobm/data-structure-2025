namespace ArrayAndString.DataStructures;

public class ValidPalindrome
{
    public static void Run()
    {
        //Given a string, determine if it's a palindrome considering only alphanumeric characters and ignoring case.
        // Input: "A man, a plan, a canal: Panama"
        // Output: true


        var input = "A man, a plan, a canal: Panama";



        Console.WriteLine(IsPalindrome(input).ToString());
    }

    static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        //in this case in one iteration the sub whiles just are moving the left and right to the next position is not iterating again in the same left or in the same right.
        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;
            while (left < right && !char.IsLetterOrDigit(s[right]))
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }
        return true;
    }
}