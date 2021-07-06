using EFApp.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp.Model {
   public class Course : BaseEntity {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; } 
        public int Duration { get; set; }
        public Course() {

        }
    }
}
