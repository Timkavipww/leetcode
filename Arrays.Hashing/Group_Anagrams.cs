using System.Dynamic;

namespace tests;

public partial class Solution
{
    public static IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        var grouped = new List<IList<string>>();

        if(strs.Length == 1)
            return new List<IList<string>>(){new List<string>(strs)};

        var dict = new Dictionary<string, List<string>>();

        foreach(var word in strs)
        {
            var sordedChars = word.ToCharArray();
            Array.Sort(sordedChars);

            string sordedWord = new string(sordedChars);

            if(!dict.ContainsKey(sordedWord))
                dict[sordedWord] = new List<string>();

            dict[sordedWord].Add(word);
        }
        return new List<IList<string>>(dict.Values);
    }
}
