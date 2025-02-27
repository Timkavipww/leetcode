using System.Diagnostics.SymbolStore;
using System.Xml.Schema;

namespace tests;

public static partial class Solution {
    public static bool hasDuplicate(int[] nums) 
    {

        if(!nums.Any())
            return false;

        var set = new HashSet<int>();
        bool hasDuplicate = false;

        foreach(var num in nums)
        {
            if(!set.Add(num))
            {
                return true;
            }
        }
        return false;
    }
}
