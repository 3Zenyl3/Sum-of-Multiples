public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> res = new List<int>();
        foreach (int multiple in multiples)
        {
            if (multiple == 0)
            {
                continue;
            }
            for (int i = 0; i < max; i+= multiple)
            {
                res.Add(i);
            }
            res.Sort();
            for (int i = 0; i < res.Count-1;i++)
            {
                if (res[i] == res[i + 1])
                {
                    res.RemoveAt(i);
                    i--;
                }
            }
        }
        return res.Sum();
    }
}
