using System;
using System.Numerics;
public class Kata
{
	public static int StringToNumber(String str)
	{
		int result = 0;
		bool minus = false;
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] == '-')
			{
				minus = true;
				continue;
			}
			result += (str[i] - 48) * (int)Math.Pow(10, (str.Length - 1) - i);
		}
		return minus ? result * -1 : result;
	}

	public static string Add(string a, string b)
	{
		return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
	}

	public static string ToCamelCase(string str)
	{
		int i = 0;
		foreach (char c in str)
		{
			if (c == '_' || c== '-')
			{
				string uC = str[i + 1].ToString().ToUpper();
				str = str.Remove(i + 1, 1).Insert(i + 1, uC);
			}
			i++;
		}
		return str.Replace("_", "").Replace("-", ""); ;
	}
}