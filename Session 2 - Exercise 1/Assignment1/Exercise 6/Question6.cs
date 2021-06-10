using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Question6 {
        public static void StringOutput() {

            Console.WriteLine("Please give me your age");

            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please give me your gender");

            string Gender = Console.ReadLine();

            string space = " ";

            string FinalString = "You are" + space + Gender +space+  "and you look younger than" + space + Convert.ToString(Age);

            Console.WriteLine(FinalString);

            Console.ReadLine();



        }
    }
}
