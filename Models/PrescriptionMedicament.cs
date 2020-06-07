using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class PrescriptionMedicament
    {
        public int IdPrescription { get; set; }
        public int IdMedicament { get; set; }
        public int Dose { get; set; }
        public string Details { get; set; }
        public int? PrescriptionIdPrescription { get; set; }

        public virtual Medicament IdMedicamentNavigation { get; set; }
        public virtual Prescription PrescriptionIdPrescriptionNavigation { get; set; }
    }
}
