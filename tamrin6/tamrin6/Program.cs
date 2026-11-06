using System;

class Program
{
    static int Search(int[] a, int x, int l, int r)
    {
        if (l > r)
            return -1;

        int mid = (l + r) / 2;

        if (a[mid] == x)
            return mid;

        if (x < a[mid])
            return Search(a, x, l, mid - 1);

        return Search(a, x, mid + 1, r);
    }

    static void Main()
    {
        int[] a = { 1, 3, 5, 7, 9 };

        Console.WriteLine(Search(a, 7, 0, 4));
    }
}