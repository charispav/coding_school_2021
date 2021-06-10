using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Question5 {
        public static void NumbersAverage() { 

        int LoopCounterQ5;

        int NumbersCountQ5 = 5;

        decimal[] NumbersArrayQ5 = new decimal[NumbersCountQ5];

        decimal Sum = 0;

            for (LoopCounterQ5 = 0; LoopCounterQ5<NumbersCountQ5; LoopCounterQ5++) {

                Console.WriteLine("Please give me a number");

                NumbersArrayQ5[LoopCounterQ5] = Convert.ToDecimal(Console.ReadLine());

                Sum += NumbersArrayQ5[LoopCounterQ5];
            }
            decimal Average = Sum / NumbersCountQ5;

            Console.WriteLine("The average of these numbers is: " + Convert.ToString(Average));

            Console.ReadLine();

        }
    }
}

