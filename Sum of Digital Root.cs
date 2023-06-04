using System;

public class Number
{
    public int DigitalRoot(long n)
    {
        long m = 0;
        for (long i = n; i > 0; m += i % 10, i /= 10) ;

        if (m.ToString().Length > 1)
            return DigitalRoot(m);
        else
            return (int)m;
    }
}