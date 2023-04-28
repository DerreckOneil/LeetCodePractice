using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    
    public static void Main(string[]args)
    {
        Console.WriteLine("Hello world");
        Console.WriteLine("PalindromeSeq: " + LongestPalindromeSubseq("aaaaaaaaa"));
    }

    public static int LongestPalindromeSubseq(string s)
    {
        int palindromeSubseq = 1;

        Dictionary<char, int> map = new Dictionary<char, int>();
        char[] chars = s.ToCharArray();
        foreach(char i in chars)
        {
            int occurance = 0;
            Console.WriteLine(i);// gives ya 'a'
            foreach(char j in chars)
            {

                if (i == j)
                {
                    occurance++;
                    //map.Add(i, occurance);
                }
            }
            map.Add(i, occurance);
            Console.WriteLine("Character: " + i + "Occurance: " + occurance);
        }
        
        

        return palindromeSubseq;
    }
}