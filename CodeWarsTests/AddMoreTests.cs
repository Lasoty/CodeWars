﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars;

namespace Tests
{
	[TestFixture()]
	public class AddMoreTests
	{
		[Test]
		public void FirstTest()
		{
			List<int> listOfNumbers = new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 };
			Assert.AreEqual((AddMore.AddExtra(listOfNumbers)).Count, listOfNumbers.Count + 1);
		}
	}
}