using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            var celTemp = (fTemp - 32) * (5.0 / 9.0); // to ensure it doesn't round the result to zero, use 5.0/9.0 instead of 5/9//
            return celTemp;
        }
        
        public static double CelsiusToFahrenheit(double cTemp)
        {
            var fahTemp = (cTemp * (9d / 5d)) + 32; // use the lowercase d notation like the m used in decimal to do the same as comment above//
            return fahTemp;
        }



    }
}
