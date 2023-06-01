using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenhietToCelsius(double faherenheit)
		{
			return (faherenheit - 32) / 1.8;
		}
		public static double CelsiusToFahrehiet(double celsius)
		{
			return (celsius * 9) / 5 + 32;
		}
		
	
	}
}

