/*using System;

public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int n = nums.Length;
        if (n == 1) return 0;
        if (nums[0] > nums[1]) return 0;
        if (nums[n - 1] > nums[n - 2]) return n - 1;

        int low = 1, high = n - 2, mid;

        while (low <= high)
        {
            mid = low + (high - low) / 2;

            if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                return mid;
            else if (nums[mid] > nums[mid - 1])
                low = mid + 1;
            else
                high = mid - 1;
        }

        return low; // Mid is not guaranteed to be assigned, so returning low as a fallback.
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

        int peakIndex = sol.FindPeakElement(nums);
        Console.WriteLine("Peak element found at index: " + peakIndex);
        Console.ReadLine();
    }
}
*/