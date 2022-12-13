namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Farenheit to be converted to Celsius: ");
            double temp = double.Parse(Console.ReadLine());
            double answer = TempConverter.FarenheitToCelsius(temp);
            Console.WriteLine($"{temp} Farenheit converted to Celsius is {answer}");

            Console.WriteLine("Enter a temperature in Celsius to be converted to Farenheit: ");
            double newTemp = double.Parse(Console.ReadLine());
            double answer2 = TempConverter.CelsiusToFarenheit(newTemp);
            Console.WriteLine($"{newTemp} Celsius converted to Farenheit is {answer2}");

        }
    }
}
