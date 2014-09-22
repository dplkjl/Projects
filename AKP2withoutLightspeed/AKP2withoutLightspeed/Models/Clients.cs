using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AKP2withoutLightspeed.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string Provider { get; set; }
        public string LastName { get; set; }
        public string FirstNames { get; set; }
        public string Gender { get; set; }
        public string Address2  { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string HomePhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Status { get; set; }
        public int DoctorId { get; set; }
        public int StaffId { get; set; }

    }

}