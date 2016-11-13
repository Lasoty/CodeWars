using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public class Fracts
	{
		public static string convertFrac(long[,] lst)
		{
			if (lst.Length <= 0) return string.Empty;
			List<long> counters = new List<long>();
			List<long> denominations = new List<long>();

			for (int i = 0; i < lst.Length/2; i++)
			{
				counters.Add(lst[i, 0]);
				denominations.Add(lst[i, 1]);
			}

			long lcm = denominations.Aggregate(LCM);
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < lst.Length/2; i++)
			{
				sb.Append($"({lst[i, 0]*(lcm/lst[i, 1])},{lcm})");
			}

			return sb.ToString();
		}

		static long GCD(long a, long b)
		{
			return b == 0 ? a : GCD(b, a%b);
		}

		static long LCM(long a, long b)
		{
			return a*b/GCD(a, b);
		}
	}
}
