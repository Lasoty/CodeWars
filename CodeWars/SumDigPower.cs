using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public class SumDigPower
	{

		public static long[] SumDigPow(long a, long b)
		{
			List<long> result = new List<long>();
			for (long i = a; i <= b; i++)
			{
				int pos = 1;
				if (i.ToString().Sum(digit => (long) Math.Pow(digit - 48, pos++)) == i)
					result.Add(i);
			}
			return result.ToArray();
		}
	}
}
