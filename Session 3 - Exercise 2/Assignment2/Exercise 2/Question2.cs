using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2 {
    public class Question2 {
        public string StringReverse(string x) {
           
            char[] finalString = x.ToCharArray();

            Array.Reverse(finalString);
           
            return new string (finalString);


        }
    }
}
