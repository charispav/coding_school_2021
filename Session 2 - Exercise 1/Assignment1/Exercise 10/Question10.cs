using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Question10 {
        public static void RemoveAfromString() {

            Console.WriteLine("Please give me your String");

            string InitialString = Console.ReadLine();

            //InitialString = InitialString.Filte

            var str = InitialString;
            var charsToRemove = new string[] {"a"};
            foreach (var c in charsToRemove) {
                str = str.Replace(c, string.Empty);
            }
            Console.WriteLine("Final String:" + Convert.ToString(str));
            Console.ReadLine();


        }

    }
}
