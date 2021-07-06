using EFApp.Model.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace EFApp.Model {
    public class Student : BaseEntity {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; } 
        public string Address { get; set; }
        public Student() {

        }

    }
}
