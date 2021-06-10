using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Question2 {
        public static void Numbers() {
            int LoopCounter;
            int NumbersCount = 2;
            decimal[] NumbersArray = new decimal[NumbersCount];

            for (LoopCounter = 0; LoopCounter < NumbersCount; LoopCounter++) {
                
                Console.WriteLine("Please give me a number");

                NumbersArray[LoopCounter] = Convert.ToDecimal(Console.ReadLine());

            }
            decimal Sum = NumbersArray.Sum();

            Console.WriteLine("The sum of these numbers is: " + Convert.ToString(Sum));

            decimal Division = NumbersArray[0];

            for (LoopCounter = 1; LoopCounter < NumbersCount; LoopCounter++) {
             
                Division = Division / NumbersArray[LoopCounter]; 
                
            }
            Console.WriteLine("The division of these numbers is: " + Convert.ToString(Division));

        }
    }
}
