using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    public class Person {

        //Properties
        public Guid PersonID { get; set; }
        public int Age { get; set; }
        public string Name;

        //Constructor
        public Person() {
            PersonID = Guid.NewGuid();
        }

        //Methods

        public virtual string GetName() {
            return Name;

        }

        public void SetName(string x) {
            Name = x;

        }
    }
}
