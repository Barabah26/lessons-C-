using System;

namespace OOP_2.second_part
{
	public static class ListExtension
	{

		public static List<int> TakeEverySecond(this List<int> source)
		{
			var result = new List<int>();

			for (int i = 0; i < source.Count; i += 2)
			{
				result.Add(source[i]);
			}

			return result;
		}

	}
}