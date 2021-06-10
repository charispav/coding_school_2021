using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2 {
    class Program {
        static void Main(string[] args) {

            //Question 1----------------------------------------------------------

            Question1 q1 = new Question1();

            string word = q1.LongestWord();

            Console.WriteLine(word.ToUpper());

            Console.ReadLine();

            //Question 2----------------------------------------------------------

            Console.WriteLine("Question 2 : Give me your string");

            Question2 q2 = new Question2();

            string outputString = q2.StringReverse(Console.ReadLine());

            Console.WriteLine("Final string: " + outputString);

            Console.ReadLine();

            //Question 3----------------------------------------------------------

            Console.WriteLine("Question 3 : Give me an integer");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type 1 for sum or 2 for product");

            int option = Convert.ToInt32(Console.ReadLine());

            Question3 q3 = new Question3();

            int result = q3.SumOrProduct(number, option);

            Console.WriteLine(result);

            Console.ReadLine();

            //Question 4----------------------------------------------------------

            Console.WriteLine("Question 4 : Give me an integer");

            int numberQ4 = Convert.ToInt32(Console.ReadLine());

            Question4 q4 = new Question4();


            Console.WriteLine("All prime numbers between 1 and {0}:\n", Convert.ToString(numberQ4));

            int[] primeNumbers = q4.PrimeNumbers(numberQ4);

            for (int i = 0; i < primeNumbers.Length; i++) {
                Console.WriteLine(Convert.ToString(primeNumbers[i]));
            }

            Console.ReadLine();

            //Question 5----------------------------------------------------------

            Question5 q5 = new Question5();

            Console.WriteLine("Product of all array elements:\n");

            int[] outputArray = q5.ArraysProduct();

            for (int i = 0; i < outputArray.Length; i++) {
                Console.WriteLine(Convert.ToString(outputArray[i]));
            }
            Console.ReadLine();

            //Question 6----------------------------------------------------------

            Question6 q6 = new Question6();

            int[] finalArray = q6.ArraySort();

            Console.WriteLine("Sorted array:\n");

            for (int i = 0; i < finalArray.Length; i++) {
                Console.WriteLine(Convert.ToString(finalArray[i]));
            }

            Console.ReadLine();

        }
    }
}

