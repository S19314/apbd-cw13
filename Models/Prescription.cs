using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class Prescription
    {
        public Prescription()
        {
            PrescriptionMedicament = new HashSet<PrescriptionMedicament>();
        }

        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int IdDoctor { get; set; }
        public int IdPatient { get; set; }

        public virtual Doctors IdDoctorNavigation { get; set; }
        public virtual Patient IdPatientNavigation { get; set; }
        public virtual ICollection<PrescriptionMedicament> PrescriptionMedicament { get; set; }
    }
}
