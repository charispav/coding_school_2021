using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2 {
    class Question6 {
        public int[]  ArraySort() {
            
            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            Array.Sort(array, 0, array.Length-1);

            return array;
        }

    }
}
