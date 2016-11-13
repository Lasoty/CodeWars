using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public class ToSmallest
	{
		public static long[] Smallest(long n)
		{
			string s = n.ToString();
			char smallest = s.Where(x => x > '0').Min();
			int pos = s.LastIndexOf(smallest);
			s = s.Remove(pos, 1).Insert(0, (smallest - 48).ToString()); 
			return new[] {long.Parse(s), smallest - 48, pos};
		}
	}
}
