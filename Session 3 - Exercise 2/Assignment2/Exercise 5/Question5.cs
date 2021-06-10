using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2 {
    public class Question5 {
        public int[] ArraysProduct() {
            int[] array1 = { 2, 4, 9, 12 };

            int[] array2 = { 1, 3, 7, 10 };

            int length = array1.Length * array2.Length;

            int[] finalArray = new int[length];

            for (int k = 0; k < length; k++) {
                for (int i = 0; i < array1.Length; i++) {
                    for (int j = 0; j < array2.Length; j++) {
                        finalArray[k] = array1[i] * array2[j];
                        k++;
                    }
                }
            }

            return finalArray;
        } 


    }
}
