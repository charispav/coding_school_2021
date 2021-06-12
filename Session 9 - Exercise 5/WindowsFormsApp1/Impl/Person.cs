using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {

    public class Person : Entity {

        public string Name;
       
        public int Age { get; set; }

        //Properties
        public string Surname { get; set; }

        public Person(): base() {

        }
        public virtual string GetName() {
            return Name;

        }

        public void SetName(string x) {
            Name = x;

        }
    }
}
