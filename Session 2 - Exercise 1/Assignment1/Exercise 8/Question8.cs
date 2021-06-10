using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Question8 {
        public static void SecondsAlternative() {
            Console.WriteLine("Please give an integer that represents seconds for Question 8");

            decimal Seconds = Convert.ToDecimal(Console.ReadLine());

            TimeSpan time = TimeSpan.FromSeconds(Convert.ToDouble(Seconds));

            double Minutes = time.TotalMinutes;

            double Hours = time.TotalHours;

            double Days = time.TotalDays;

            double Years = Math.Floor(Days / 365);

            Console.WriteLine("Minutes: " + Convert.ToString(Minutes) + "\n");

            Console.WriteLine("Hours: " + Convert.ToString(Hours) + "\n");

            Console.WriteLine("Days: " + Convert.ToString(Days) + "\n");

            Console.WriteLine("Years: " + Convert.ToString(Years) + "\n");

            Console.ReadLine();
        }
       

    }
}
