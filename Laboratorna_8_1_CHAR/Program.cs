using System;

public class Program
{
    public static int Count(char[] s)
    {
        int count = 0;
        int pos = 0;
        string searchString = "while";

        while ((pos = new string(s).IndexOf(searchString, pos, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            pos += searchString.Length;
        }

        return count;
    }

    public static char[] Change(char[] s)
    {
        int whileGroupsCount = Count(s);
        char[] result = new char[s.Length + (2 * whileGroupsCount)];

        int pos1 = 0, pos2 = 0, resultPos = 0;
        string searchString = "while";

        while ((pos1 = new string(s).IndexOf(searchString, pos1, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            Array.Copy(s, pos2, result, resultPos, pos1 - pos2);
            Array.Copy("**".ToCharArray(), 0, result, resultPos + pos1 - pos2, 2);

            resultPos += pos1 - pos2 + 2;
            pos2 = pos1 + searchString.Length;
            pos1 = pos2;
        }

        Array.Copy(s, pos2, result, resultPos, s.Length - pos2);

        return result;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter string:");
        char[] str = Console.ReadLine().ToCharArray();

        int whileGroupsCount = Count(str);
        Console.WriteLine($"The string contains {whileGroupsCount} occurrences of 'while'");

        char[] dest = Change(str);
        Console.WriteLine($"Modified string: {new string(dest)}");
    }
}
