using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
    public class Program {
        static void Main(string[] args) {

            #region Question 1

            Question1 q1 = new Question1();

            Console.WriteLine("Give me a decimal number");

            decimal number = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));

            decimal integerPart = 0, decimalPart = 0;


            q1.Splitter(number, ref integerPart, ref decimalPart);

            decimal binaryIntegerPart = q1.DecimalToBinaryConvert(integerPart);

            decimal binaryDecimalPart = q1.DecimalToBinaryConvert(decimalPart);



            Console.WriteLine("Binary equivalent: " + Convert.ToString(binaryIntegerPart) + "," + Convert.ToString(binaryDecimalPart));

            Console.ReadLine();

            #endregion
        }
    }
}
