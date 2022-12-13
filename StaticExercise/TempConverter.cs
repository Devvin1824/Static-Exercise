using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelsius(double number)
        {
            double celsius = (number - 32) * 5 / 9; 
            return celsius;
        }

        public static double CelsiusToFarenheit(double number)
        {
            double far = (number * 9 / 5) + 32;
            return far;
        }
    }
}
