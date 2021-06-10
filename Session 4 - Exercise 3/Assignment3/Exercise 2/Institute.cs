using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
        public class Institute {
            //Properties
            public Guid InstitudeID { get; set; }
            public string InstituteName { get; set; }
            public int YearsInService { get; set; }

            //Constructor
            public Institute() {

            }

            //Methods
            public string GetName() {
                return InstituteName;
            }
            public virtual void SetName(string x) {
                InstituteName = x;
            }
        }
    }

