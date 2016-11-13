using NUnit.Framework;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
	[TestFixture()]
	public class FractsTests
	{
		[Test()]
		public void convertFracTest()
		{
			long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
			Assert.AreEqual("(6,12)(4,12)(3,12)", Fracts.convertFrac(lst));
		}

		[Test()]
		public void convertFracTest2()
		{
			long[,] lst = new long[,] { };
			Assert.AreEqual("", Fracts.convertFrac(lst));
		}
	}
}