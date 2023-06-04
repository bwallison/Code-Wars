using System;
using System.Linq;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        return int.Parse(new String(num.ToString().ToCharArray().OrderByDescending(x => x).ToArray()));
    }
}