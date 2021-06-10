using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
    public class Question1 {
        public decimal DecimalToBinaryConvert(decimal decimalNumber) {

            decimal res;

            if (Math.Floor(decimalNumber) == 0) {
                return 0;
            }
            else {

                res = Math.Floor(decimalNumber % 2 + 10 * DecimalToBinaryConvert(decimalNumber / 2));

                return res;
            }
        }
        public void Splitter(decimal number, ref decimal integerPart, ref decimal decimalPart) {
            integerPart = Math.Truncate(number);

            string sInteger = Convert.ToString(integerPart);

            char[] finalStringInteger = sInteger.ToCharArray();

            int numberOfIntegerDigits = finalStringInteger.Length;

            decimalPart = number - integerPart;

            string sDecimal = Convert.ToString(decimalPart);

            char[] finalStringDecimal = sDecimal.ToCharArray();

            int numberOfDecimalDigits = finalStringDecimal.Length - 1;

            double decimalPartFinal = (double)decimalPart * Math.Pow(10, numberOfDecimalDigits - numberOfIntegerDigits);

            decimalPart = Convert.ToDecimal(decimalPartFinal);

            Console.WriteLine("");

        }



    }

}
