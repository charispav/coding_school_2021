using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2 {
    public class Question1 {
        public string LongestWord() {
            string initialString = "lorem ipsum dolor sit amet consectetur adipiscing elit";

            string[] words = initialString.Split(new[] { " " }, StringSplitOptions.None);

            string word = "";

            int ctr = 0;
            foreach (String s in words) {
                
                if (s.Length > ctr) {
                    word = s;
                    ctr = s.Length;
                }
            
            }

            return word;

        }
    }
}
