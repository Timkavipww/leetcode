namespace tests;
public static class Program
{
public static void Main(string[] args)
    {
        #if false
        var nums = new int[]{3,2,3};
        var target = 6;
        var result  = Solution.TwoSum(nums, target);
        Console.WriteLine(string.Join(", ", result));
        #endif

        
        #if false
        var list = new LinkedList<string>();

        
        Solution.GetValue(list);
        #endif

        #if false
        var s = "anagram";
        var t = "nagrama";
        var result = Solution.IsAnagram(s,t);
        Console.WriteLine(result);

        #endif


        #if false
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        var result = Solution.GroupAnagrams(strs);

        foreach (var group in result)
        {
            Console.WriteLine(string.Join(", ", group));
        }
        #endif

        #if false
        int[] nums = {-1,-1};
        var k = 1;
        var result = Solution.TopKFrequent(nums, k);
        Console.WriteLine(string.Join(", ", result));

        #endif

        #if false
        var nums = new int[]{-1,1,0,-3,3};
        var result = Solution.ProductExceptSelf(nums);
        Console.WriteLine(string.Join(",", result));

        #endif

        var sudoku = new char[][]{
        ['5','3','.','.','7','.','.','.','.'],
        ['6','.','.','1','9','5','.','.','.'],
        ['.','9','8','.','.','.','.','6','.'],
        ['8','.','.','.','6','.','.','.','3'],
        ['4','.','.','8','.','3','.','.','1'],
        ['7','.','.','.','2','.','.','.','6'],
        ['.','6','.','.','.','.','2','8','.'],
        ['.','.','.','4','1','9','.','.','5'],
        ['.','.','.','.','8','.','.','7','9']
        };
        
        Solution.IsValidSudoku(sudoku);

    }
    
}
