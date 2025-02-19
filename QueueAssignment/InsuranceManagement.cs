using System;
using System.Collections.Generic;

namespace InsuranceManagement
{
    public class InsurancePolicy
    {
        public string PolicyNumber { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }

        public InsurancePolicy(string policyNumber, string coverageType, DateTime expiryDate)
        {
            PolicyNumber = policyNumber;
            CoverageType = coverageType;
            ExpiryDate = expiryDate;
        }

        // Override Equals and GetHashCode for HashSet to ensure uniqueness based on PolicyNumber
        public override bool Equals(object obj)
        {
            return obj is InsurancePolicy policy &&
                   PolicyNumber == policy.PolicyNumber;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }
    }

    public class InsurancePolicyManagementSystem
    {
        // HashSet for quick lookups
        private HashSet<InsurancePolicy> uniquePolicies = new HashSet<InsurancePolicy>();

        // LinkedHashSet for maintaining insertion order (Using List to mimic LinkedHashSet)
        private List<InsurancePolicy> orderedPolicies = new List<InsurancePolicy>();

        // SortedSet to maintain policies sorted by expiry date
        private SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>(Comparer<InsurancePolicy>.Create((a, b) => a.ExpiryDate.CompareTo(b.ExpiryDate)));

        // Add Policy method to all sets
        public void AddPolicy(InsurancePolicy policy)
        {
            if (uniquePolicies.Add(policy))
            {
                orderedPolicies.Add(policy);
                sortedPolicies.Add(policy);
            }
        }

        // Retrieve All unique policies
        public void PrintUniquePolicies()
        {
            Console.WriteLine("Unique Policies:");
            foreach (var policy in uniquePolicies)
            {
                Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate.ToShortDateString()}");
            }
        }

        // Retrieve Policies expiring soon (within next 30 days)
        public void PrintExpiringSoonPolicies()
        {
            DateTime now = DateTime.Now;
            DateTime futureDate = now.AddDays(30);

            Console.WriteLine("\nPolicies Expiring Soon (within 30 days):");
            foreach (var policy in sortedPolicies)
            {
                if (policy.ExpiryDate <= futureDate)
                {
                    Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate.ToShortDateString()}");
                }
            }
        }

        // Retrieve policies with specific coverage type
        public void PrintPoliciesByCoverage(string coverageType)
        {
            Console.WriteLine($"\nPolicies with coverage type '{coverageType}':");
            foreach (var policy in uniquePolicies)
            {
                if (policy.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate.ToShortDateString()}");
                }
            }
        }

        // Retrieve duplicate policies based on Policy Number
        public void PrintDuplicatePolicies()
        {
            Console.WriteLine("\nDuplicate Policies based on Policy Number:");
            HashSet<string> seenPolicyNumbers = new HashSet<string>();
            foreach (var policy in orderedPolicies)
            {
                if (seenPolicyNumbers.Contains(policy.PolicyNumber))
                {
                    Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate.ToShortDateString()}");
                }
                else
                {
                    seenPolicyNumbers.Add(policy.PolicyNumber);
                }
            }
        }

        public static void Main()
        {
            InsurancePolicyManagementSystem system = new InsurancePolicyManagementSystem();

            // Adding policies
            system.AddPolicy(new InsurancePolicy("P123", "Health", DateTime.Now.AddMonths(1)));
            system.AddPolicy(new InsurancePolicy("P124", "Life", DateTime.Now.AddMonths(2)));
            system.AddPolicy(new InsurancePolicy("P125", "Car", DateTime.Now.AddMonths(3)));
            system.AddPolicy(new InsurancePolicy("P123", "Health", DateTime.Now.AddMonths(1))); // Duplicate

            // Print unique policies
            system.PrintUniquePolicies();

            // Print policies expiring soon
            system.PrintExpiringSoonPolicies();

            // Print policies by specific coverage type
            system.PrintPoliciesByCoverage("Health");

            // Print duplicate policies
            system.PrintDuplicatePolicies();

            Console.ReadLine();
        }
    }
}
