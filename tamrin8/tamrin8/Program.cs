using System;

class Program
{
    static void Sort(int[] a, int l, int r)
    {
        if (l < r)
        {
            int mid = (l + r) / 2;

            Sort(a, l, mid);
            Sort(a, mid + 1, r);

            int[] b = new int[r - l + 1];

            int i = l, j = mid + 1, k = 0;

            while (i <= mid && j <= r)
            {
                if (a[i] < a[j])
                    b[k++] = a[i++];
                else
                    b[k++] = a[j++];
            }

            while (i <= mid)
                b[k++] = a[i++];

            while (j <= r)
                b[k++] = a[j++];

            for (i = 0; i < b.Length; i++)
                a[l + i] = b[i];
        }
    }

    static void Main()
    {
        int[] a = { 5, 2, 8, 1, 4 };

        Sort(a, 0, 4);

        foreach (int x in a)
            Console.Write(x + " ");
    }
}