using System;
namespace ReviewGoingOn
{
    public class Employee : IEmployee
    {
        private List<int> id;
        private List<string> name;
        private List<int> age;

        public Employee()
        {
            id = new List<int>();
            name = new List<string>();
            age = new List<int>();
        }
        public void DisplayByName(List<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void SortByAge(int low, int high, List<int> age)
        {
            if (low >= high) return;
            int n = age.Count;
            int mid = (low + high) / 2;
            SortByAge(low, mid, age);
            SortByAge(mid + 1, high, age);

            // let's merge it
            List<int> l = new List<int>();

            int i = low, j = mid + 1;
            while (i <= mid && j <= high)
            {
                if (age[i] <= age[j])
                {
                    l.Add(age[i]);
                    i++;
                }
                else
                {
                    l.Add(age[j]);
                    j++;
                }

            }

            while (i <= mid)
            {
                l.Add(age[i]);
                i++;

            }

            while (j <= high)
            {
                l.Add(age[j]);
                j++;

            }

            int ind = 0;
            for (int k = low; k <= high; k++)
            {
                age[k] = l[ind];
                ind++;
            }
        }
        public void Display()
        {
            foreach (int l in age)
            {
                Console.WriteLine(l + " ");
            }
        }
    }
}

