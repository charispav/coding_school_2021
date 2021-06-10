using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Question3 {
        public static void Operations() {
            short Result1 = -1 + 5 * 6;

            short Result2 = 38 + 5 % 7;

            decimal Result3 = 14 + (-3 * 6) / 7;

            double Result4 = 2 + 13 / 6 * 6 + Math.Sqrt(7);

            double Result5 = (Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);

            Console.WriteLine("The result of -1 + 5 * 6 is: " + Convert.ToString(Result1));

            Console.WriteLine("The result of 38 + 5 mod 7 is: " + Convert.ToString(Result2));

            Console.WriteLine("The result of 14 + (-3 * 6) / 7 is: " + Convert.ToString(Result3));

            Console.WriteLine("The result of 2 + 13 / 6 * 6 + sqrt(7); is: " + Convert.ToString(Result4));

            Console.WriteLine("The result of (6^4 +5^7) / (9 mod 4) is: " + Convert.ToString(Result5));

            Console.ReadLine();
        }

    }
}
