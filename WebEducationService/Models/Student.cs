using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class Student {

        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [ForeignKey("MajorId")]
        public int? MajorId { get; set; }
        public decimal GPA { get; set; }

        public virtual Major Major {get; set;}

        public Student() { }
    }
}
