using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2 {
    class Question4 {
        public int[] PrimeNumbers(int n) {
           
            int[] numbers = new int[n];

            int[] numberOfDivisors = new int[n];

            int[] allPrimeNumbers = new int[n];
            
            int lengthOfFinalArray=0;

            for (int i = 0; i < n; i++) {
                numbers[i] = i+1;
            }
            for (int i = 0; i < n; i++) {

                numberOfDivisors[i] = 0;

                for (int j = 0; j < n; j++) {
                    
                    if (numbers[i] % numbers[j] == 0) {
                        
                        numberOfDivisors[i] += 1;

                    }
                }

                if (numberOfDivisors[i] <= 2) {
                    allPrimeNumbers[i] = numbers[i];
                }

            }
            for (int i = 0; i < n; i++) {
                if (allPrimeNumbers[i] != 0) {
                    lengthOfFinalArray++;
                }
            }

            int[] FinalPrimeNumbers = new int[lengthOfFinalArray];

            int k = 0;
            for (int i = 0; i < n; i++) {
                if (allPrimeNumbers[i] !=0 ) {
                    FinalPrimeNumbers[k] = allPrimeNumbers[i];
                    k++;
                }
            }
            return FinalPrimeNumbers;
        }

    }
}
