using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class StudentClassRel {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        [JsonIgnore]
        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }

        public StudentClassRel () {

        }
    }
}
