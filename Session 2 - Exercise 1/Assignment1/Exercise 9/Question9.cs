using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Question9 {
        public static void CelsiusToKelvinAndFahrenheit() {

            Console.WriteLine("Please give me the temperature in Celcius");

            double TempC = Convert.ToDouble(Console.ReadLine());

            double TempK = TempC + 273.15;

            double TempF = TempC * 9 / 5 + 32;

            Console.WriteLine("Temperature in Kelvin: " + Convert.ToString(TempK) + "\n");

            Console.WriteLine("Temperature in Fahrenheit: " + Convert.ToString(TempF) + "\n");

            Console.ReadLine();
        }
    }
}
