using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static int Find(int[] integers)
    {
        int odd = integers.Select(x => x - '0').Count(x => x % 2 == 0);
        int even = integers.Select(x => x - '0').Count(x => x % 2 != 0);

        if (odd > even)
            return integers.Where(n => n % 2 != 0).ToArray()[0];
        else
            return integers.Where(n => n % 2 == 0).ToArray()[0];
    }
}