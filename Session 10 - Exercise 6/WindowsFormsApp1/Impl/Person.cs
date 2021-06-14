using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {

    public class Person : Entity {

        //Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        //Constructor
        public Person(): base() {

        }
        public virtual string GetName() {

            return Name;
        }

    }
}
