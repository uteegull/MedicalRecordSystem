using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRecordSystem.Data
{
    public class Appointment
    {
        public int Id { get; set; }

        
        public DateTime AppointmentDate { get; set; }

        [Required]
        public string Reason { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public bool IsConfirmed { get; set; }

        public string UserName { get; set; }
    }
}
