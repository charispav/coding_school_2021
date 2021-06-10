using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Question7 {
        public static void  Seconds() {

            Console.WriteLine("Please give an integer that represents seconds");

            decimal Seconds = Convert.ToDecimal(Console.ReadLine());

            decimal Minutes = Math.Floor(Seconds / 60);

            Console.WriteLine("Minutes: " + Convert.ToString(Minutes) + "\n");

            decimal Hours = Math.Floor(Seconds / 3600);

            Console.WriteLine("Hours: " + Convert.ToString(Hours) + "\n");

            decimal Days = Math.Floor(Seconds / (3600*24));

            Console.WriteLine("Days: " + Convert.ToString(Days) + "\n");

            decimal Years = Math.Floor(Seconds / (3600 * 24 * 365));

            Console.WriteLine("Years: " + Convert.ToString(Years) + "\n");

            Console.ReadLine();

        }
       
    }
}
