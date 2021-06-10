using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2 {
    public class Question3 {
        public int SumOrProduct(int n,int o){
            
            int result = 0;
            for (int i = 1; i <= n; i++) {
                if (o==1) {
                    result += i;
                }
                else {
                    if (result == 0) {
                        result = 1;
                    }
                    result *= i;
                }
            }
            if (o==1) {
                Console.WriteLine("Sum= ");
            }
            else {
                Console.WriteLine("Product= ");
            }
            return result;
        }


    }
}
