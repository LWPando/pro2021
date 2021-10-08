using System;

public class JePalindrome
{
    public static bool IsPalindrome(string text)
    {
        if (text.Length <= 1)
            return true;
        else
        {
            if (text[0] != text[text.Length - 1])
                return false;
            else
                return IsPalindrome(text.Substring(1, text.Length - 2));
        }
    }
    public static void Main()
    {
        Console.Write("\n\n Preveri, ali je beseda palindrom ali ne :\n");
        Console.Write("---------------------------------------------------------------\n");
        string str1;
        bool tf;

        Console.Write(" Vpisi besedo : ");
        str1 = Console.ReadLine();
        tf = IsPalindrome(str1);
        if (tf == true)
        {
            Console.WriteLine(" Beseda je palindrom.\n");
        }
        else
        {
            Console.WriteLine(" Beseda ni palindrom.\n");
        }
    }
}
