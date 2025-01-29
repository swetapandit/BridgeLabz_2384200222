/*using System;

class OTPGenerator
{
    // Method to generate a 6-digit OTP number
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);  // Generates a number between 100000 and 999999
    }

    // Method to check if the OTP numbers are unique
    public static bool AreOTPUnique(int[] otpArray)
    {
        for (int i = 0; i < otpArray.Length; i++)
        {
            for (int j = i + 1; j < otpArray.Length; j++)
            {
                if (otpArray[i] == otpArray[j]) // If any two OTPs are the same, return false
                {
                    return false;
                }
            }
        }
        return true; // All OTPs are unique
    }

    static void Main()
    {
        int[] otps = new int[10]; // Array to store 10 OTPs

        // Generate OTPs 10 times and store them in the array
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOTP();
        }

        // Check if all OTPs are unique
        if (AreOTPUnique(otps))
        {
            Console.WriteLine("All OTPs are unique!");
        }
        else
        {
            Console.WriteLine("There are duplicate OTPs.");
        }

        // Display all generated OTPs
        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }
    }
}
*/