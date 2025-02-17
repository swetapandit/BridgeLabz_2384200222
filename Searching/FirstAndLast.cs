/*using System;
using System.Collections.Generic;

public class Solution
{
    public int FirstOccurrence(int[] nums, int target)
    {
        int low = 0, high = nums.Length - 1, mid, first = -1;
        while (low <= high)
        {
            mid = low + (high - low) / 2;
            if (target == nums[mid])
            {
                first = mid;
                high = mid - 1;
            }
            else if (target < nums[mid])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return first;
    }

    public int LastOccurrence(int[] nums, int target)
    {
        int low = 0, high = nums.Length - 1, mid, last = -1;
        while (low <= high)
        {
            mid = low + (high - low) / 2;
            if (target == nums[mid])
            {
                last = mid;
                low = mid + 1;
            }
            else if (target < nums[mid])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return last;
    }

    public int[] SearchRange(int[] nums, int target)
    {
        int first = FirstOccurrence(nums, target);
        int last = LastOccurrence(nums, target);
        return new int[] { first, last };
    }

    public static void Main()
    {
        Solution sol = new Solution();

        Console.WriteLine("Enter the number of elements:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[n];
        Console.WriteLine("Enter the sorted array elements:");
        for (int i = 0; i < n; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter the target element:");
        int target = Convert.ToInt32(Console.ReadLine());

        int[] result = sol.SearchRange(nums, target);
        Console.WriteLine($"First and Last Occurrences: {result[0]} and {result[1]}");
        Console.ReadLine();
    }
}
*/