using System.Collections.Generic;

namespace WebEducationService.Models {
    public class Instructor {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTenured { get; set; }

        

        public Instructor() { }
    }
}