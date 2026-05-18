namespace TwoSum;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            
            if (dict.TryGetValue(target - nums[i], out int Index))
            {
                return new int[2]{i, Index};
            }

            dict[nums[i]] = i;
            
        }

        return new int[2]{-1, -1};
    }
}