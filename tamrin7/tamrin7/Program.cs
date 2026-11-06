using System;

class Program
{
    static int Max(int[] a, int l, int r)
    {
        if (l == r)
            return a[l];

        int mid = (l + r) / 2;

        int x = Max(a, l, mid);
        int y = Max(a, mid + 1, r);

        if (x > y)
            return x;
        else
            return y;
    }

    static void Main()
    {
        int[] a = { 4, 8, 2, 10, 5 };

        Console.WriteLine(Max(a, 0, 4));
    }
}