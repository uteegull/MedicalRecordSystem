using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRecordSystem.Data
{
    public class MedicalHistory
    {
        [Key]
        public int U_Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0,120)]
        public int Age { get; set;}
        [Required]
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Allergies { get; set; }
        [Required]
        public string MedicalCondition { get; set; }
        [Required]
        public string Medication { get; set; }
        public string UserId { get; set; }
        public string UserEmail { get; set; }
    }
}
