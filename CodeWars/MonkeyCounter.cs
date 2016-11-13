using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public static class MonkeyCounter
	{
		public static int[] MonkeyCount(int n)
		{
			int i = 0;
			return new int[n].Select(x =>
			{
				x = ++i;
				return x;
			}).ToArray();
		}
	}
}
