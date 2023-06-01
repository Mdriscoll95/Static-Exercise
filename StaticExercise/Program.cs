namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenhietToCelsius(54);
            Console.WriteLine($"54 Fahrenhieht is {celsius} degrees celsius");
            var fahrenhiet = TempConverter.CelsiusToFahrehiet(celsius);
            Console.WriteLine($"it is {fahrenhiet} converted back to fahrenhiet");
        }
    }
}
