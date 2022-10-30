namespace strings;
public class MSD
{
    private const int R = 256;
    private const int CUTOFF = 0;
    private static string[] aux = new string[0];

    private static int charAt(string s, int d)
    {
        if (d < s.Length)
        {
            return s[d];
        }
        else
        {
            return -1;
        }
    }

    public static void sort(string[] a)
    {
        int n = a.Length;
        Console.WriteLine("N is " + n.ToString());
        aux = new string[n];
        sort(a, 0, n - 1, 0);
    }

    private static void sort(string[] a, int lo, int hi, int d)
    {
        if (hi <= lo + CUTOFF)
        {
            // sort(a, lo, hi, d);
            return;
        }

        int[] count = new int[R + 2];
        for (int i = lo; i <= hi; i++)
        {
            count[charAt(a[i], d) + 2]++;
        }

        for (int r = 0; r < R + 1; r++)
        {
            count[r + 1] += count[r];
        }

        // Distribute.
        for (int i = lo; i <= hi; i++)
        {
            aux[count[charAt(a[i], d) + 1]++] = a[i];
        }

        // Copy back.
        for (int i = lo; i <= hi; i++)
        {
            a[i] = aux[i - lo];
        }

        // Recursively sort for each character (excluding -1).
        for (int r = 0; r < R; r++)
        {
            sort(a, lo + count[r], lo + count[r + 1] - 1, d + 1);
        }
    }
}
