/*using System;

public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        // Mark elements that are out of the valid range as n+1 (a number that will never be the first missing positive)
        for (int i = 0; i < n; i++)
        {
            if (nums[i] <= 0 || nums[i] > n)
            {
                nums[i] = n + 1;
            }
        }

        // Mark the indices corresponding to the values in the array (mark them negative)
        for (int i = 0; i < n; i++)
        {
            int num = Math.Abs(nums[i]);
            if (num <= n)
            {
                nums[num - 1] = -Math.Abs(nums[num - 1]);
            }
        }

        // Find the first index that has a positive number
        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0)
            {
                return i + 1; // The first missing positive integer
            }
        }

        return n + 1; // If no missing integer is found, return n+1
    }

    public int BinarySearch(int[] nums, int target)
    {
        int low = 0, high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] == target)
                return mid; // Return index if found
            else if (nums[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1; // Return -1 if target not found
    }

    public static void Main()
    {
        Solution sol = new Solution();

        Console.WriteLine("Enter the number of elements in the list:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[n];
        Console.WriteLine("Enter the list elements:");
        for (int i = 0; i < n; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Find the first missing positive integer using Linear Search
        int firstMissing = sol.FirstMissingPositive(nums);
        Console.WriteLine("First missing positive integer: " + firstMissing);

        // Sort the array for Binary Search
        Array.Sort(nums);
        Console.WriteLine("Enter the target number for Binary Search:");
        int target = Convert.ToInt32(Console.ReadLine());

        // Find the index of the target number using Binary Search
        int targetIndex = sol.BinarySearch(nums, target);
        if (targetIndex != -1)
            Console.WriteLine("Target number found at index: " + targetIndex);
        else
            Console.WriteLine("Target number not found.");
    }
}
*/