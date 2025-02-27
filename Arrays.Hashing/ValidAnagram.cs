using System.Security.Cryptography.X509Certificates;

namespace tests;

public static partial class Solution
{
    public static bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
            return false;

        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        foreach(var ch in s)
        {
            if(dict1.ContainsKey(ch))
                dict1[ch]++;
            else
                dict1.Add(ch, 1);
        }
        foreach(var ch in t)
        {
            if(dict2.ContainsKey(ch))
                dict2[ch]++;
            else
                dict2.Add(ch, 1);
        }

        if (dict1.Count != dict2.Count)
            return false;

        foreach(var kvp in dict1)
        {
            if(!dict2.TryGetValue(kvp.Key, out int count) || count != kvp.Value)
                return false;
        }
        return true;
    }
}
