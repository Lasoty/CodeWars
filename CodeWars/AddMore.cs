using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
	public static class AddMore
	{
		public static List<int> AddExtra(List<int> listOfNumbers)
		{
			List<int> newList = new List<int>(listOfNumbers);
			newList.Add(listOfNumbers.Count + 1);
			return newList;
		}
	}
}