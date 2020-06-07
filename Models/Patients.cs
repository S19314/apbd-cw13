using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class Patients
    {
        public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
