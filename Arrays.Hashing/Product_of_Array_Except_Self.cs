namespace tests;

public static partial class Solution {
    public static int[] ProductExceptSelf(int[] nums) 
    {
    int[] result = new int[nums.Length];


    result[0] = 1;

    for (int i = 1; i < nums.Length; i++) {
        result[i] = result[i - 1] * nums[i - 1];
    }
    

    int right = 1;

    for (int i = nums.Length - 1; i >= 0; i--) {
        result[i] *= right;
        right *= nums[i];
    }
    
    return result;
    }
}