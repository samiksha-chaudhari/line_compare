using System;

class DISTANCE
{
	// Function to calculate distance
	static double distance(int x1, int y1, int x2, int y2)
	{
		// Calculating distance
		return Math.Sqrt(Math.Pow(x2 - x1, 2) +
					Math.Pow(y2 - y1, 2) * 1.0);
	}


	public static void Main()
	{
		double a = (Math.Round(distance(10, 8, 12, 6) * 100000.0) / 100000.0);
		double b = (Math.Round(distance(1, 8, 12, 6) * 100000.0) / 100000.0);
		Console.WriteLine("distance of first line :" + a);
		Console.WriteLine("distance of second line :" + b);
		if (a == b)
		{
			Console.WriteLine("lines are same");
		}
		else if (a > b)
		{
			Console.WriteLine("first line is greater then second line");
		}
		else
		{
			Console.WriteLine("second line is greater then first line");
		}
	}
}