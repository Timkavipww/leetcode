namespace tests;

public static partial class Solution
{
    public static int[] TopKFrequent(int[] nums, int k) 
    {
        var dict = new Dictionary<int, int>();

       foreach(var num in nums)
       {
        if(dict.ContainsKey(num))
            dict[num]++;
        else
            dict[num] = 1;
       }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        for(int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }

        foreach(var pair in dict)
        {
            buckets[pair.Value].Add(pair.Key);
        }
        List<int> result = new List<int>();

        for(int i = nums.Length; i >= 0 && result.Count < k; i--)
        {
            if(buckets[i].Count > 0)
            {
                for(int j = 0; j < buckets[i].Count && result.Count < k; ++j)
                {
                    result.Add(buckets[i][j]);
                }
            }
        }
        return result.ToArray();
    }
}