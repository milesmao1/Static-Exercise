namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in Fahrenheit you want to convert?");
            var fahTemp = Convert.ToDouble(Console.ReadLine());
            var convertToCel = TempConverter.FahrenheitToCelsius(fahTemp);

            Console.WriteLine($" That equals {convertToCel} degrees Celcius");
            Console.WriteLine();

            Console.WriteLine("What is the temperature in C you want to convert?");
            var celTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"That equals {TempConverter.CelsiusToFahrenheit (celTemp)} degrees F");
        }
    }
}
