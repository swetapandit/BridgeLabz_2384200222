/*using System;

public class Solution
{
    public int FindRotationPoint(int[] nums)
    {
        int low = 0, high = nums.Length - 1, mid;

        while (low < high)
        {
            mid = low + (high - low) / 2;

            if (nums[mid] > nums[high])
                low = mid + 1;
            else
                high = mid;
        }

        return low;
    }

    public static void Main()
    {
        Solution sol = new Solution();

        Console.WriteLine("Enter the number of elements:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[n];
        Console.WriteLine("Enter the array elements:");
        for (int i = 0; i < n; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int rotationIndex = sol.FindRotationPoint(nums);
        Console.WriteLine("Rotation point index: " + rotationIndex);
        Console.ReadLine();
    }
}
*/