using System;
using System.Collections.Generic;

public class Kata
{
    public static bool IsADistinctDuplicate(char i, List<char> distinctDuplicates)
    {
        foreach (char duplicate in distinctDuplicates)
        {
            if (i == duplicate)
                return false;
        }
        return true;
    }

    public static int DuplicateCount(string str)
    {

        int numberOfDuplicates = 0;
        str = str.ToLower();

        Console.WriteLine(str);
        List<char> distinctDuplicates = new List<char>();

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if ((str[i] == str[j]) && (i != j) && (i > j) && IsADistinctDuplicate(str[i], distinctDuplicates))
                {
                    numberOfDuplicates += 1;
                    distinctDuplicates.Add(str[i]);
                }
            }
        }
        return numberOfDuplicates;
    }
}