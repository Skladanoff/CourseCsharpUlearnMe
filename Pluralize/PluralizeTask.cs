﻿namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			if ((count % 100 >= 11) && (count % 100 <= 19)) return "рублей";
			else if (count % 10 == 1) return "рубль";
			else if ((count % 10 >= 2) && (count % 10 <= 4)) return "рубля";
			return "рублей";
		}
	}
}