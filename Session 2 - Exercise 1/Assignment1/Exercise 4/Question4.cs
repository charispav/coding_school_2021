using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Question4 {
        public static void NumbersProduct() {
            int LoopCounterQ4;

            int NumbersCountQ4 = 3;

            decimal[] NumbersArrayQ4 = new decimal[NumbersCountQ4];

            decimal Product = 1;

            for (LoopCounterQ4 = 0; LoopCounterQ4 < NumbersCountQ4; LoopCounterQ4++) {

                Console.WriteLine("Please give me a number");

                NumbersArrayQ4[LoopCounterQ4] = Convert.ToDecimal(Console.ReadLine());

                Product *= NumbersArrayQ4[LoopCounterQ4];
            }
            
            Console.WriteLine("The product of these numbers is: " + Convert.ToString(Product));

            Console.ReadLine();
        }

    }
}
