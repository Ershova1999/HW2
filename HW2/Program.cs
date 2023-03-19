using System;
public class Program
{
    public static void Main(String[] args)
    {
        int[] v = { 1, 5, 5, 2, 4 };

        SortedSet<int> s = new SortedSet<int>();

        for (int i = 0; i < v.Length; i++)
            s.Add(v[i]);

        List<int> ans = new List<int>();

        foreach (int res in s)
        {
            ans.Add(res);
        }

        int n = ans.Count;

        Console.Write("Второй наибольший элемент:");
        Console.Write(ans[n - 2]);
    }
}