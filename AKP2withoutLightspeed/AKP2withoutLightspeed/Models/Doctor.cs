using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AKP2withoutLightspeed.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }
}