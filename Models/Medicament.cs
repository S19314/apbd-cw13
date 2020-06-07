using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class Medicament
    {
        public Medicament()
        {
            PrescriptionMedicament = new HashSet<PrescriptionMedicament>();
        }

        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public virtual ICollection<PrescriptionMedicament> PrescriptionMedicament { get; set; }
    }
}
