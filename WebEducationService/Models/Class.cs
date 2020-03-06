using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class Class {

        public int Id { get; set; }
        [Required] public string Subject { get; set; }
        public int Section { get; set; }
        public int? InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; }
        //public virtual IEnumerable<Student> Students {get; set;}

        public Class() { }
    }
}
