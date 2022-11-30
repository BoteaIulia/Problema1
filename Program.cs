using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Rezolvare ecuatie gradul I");
		Console.Write("\n");
		float a;
		float b;
		float x;
		Console.Write("a = ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b = ");
		b = Convert.ToInt32(Console.ReadLine());
		if (a != 0)
		{
			x = -b / a;
			Console.Write("x = ");
			Console.Write(x);
		}
		else
		{
			if (b == 0F)
			{
				Console.Write("infinitate de solutii");
			}
			else
			{
				Console.Write("nu are solutie");
			}
		}
	}
}
