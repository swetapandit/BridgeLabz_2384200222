using System;
namespace ReviewGoingOn
{
	public interface IEmployee
	{
		void DisplayByName(string name);
		void SortByAge(int low, int high, List<int> nums);
	}
}

