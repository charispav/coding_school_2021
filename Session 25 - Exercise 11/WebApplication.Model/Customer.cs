using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Model {
    public class Customer {
        
        public int ID { get; set; }

        public string Name {get;set;}

        public string Surname { get; set; }
        public string AFM { get; set; }
        public bool Active { get; set; }
        public Customer() {

        }
    }
}
