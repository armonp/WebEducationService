using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class Major {
        public int Id { get; set; }
        [StringLength(30)][Required]
        public string Description { get; set; }
        public int MinSAT { get; set; }

        public Major() { }

    }
}
