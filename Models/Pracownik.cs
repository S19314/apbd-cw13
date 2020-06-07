using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class Pracownik
    {
        public Pracownik()
        {
            Zamowienie = new HashSet<Zamowienie>();
        }

        public int IdPracown { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
