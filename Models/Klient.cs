using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class Klient
    {
        public Klient()
        {
            Zamowienie = new HashSet<Zamowienie>();
        }

        public int IdKlient { get; set; }
        public string Imie { get; set; }
        public string Nazwisk { get; set; }

        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
