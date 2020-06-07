using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class WyrobCukierniczy
    {
        public WyrobCukierniczy()
        {
            ZamowienieWyrobCukierniczy = new HashSet<ZamowienieWyrobCukierniczy>();
        }

        public int IdWyrobCukierniczego { get; set; }
        public string Nazwa { get; set; }
        public double CenaZaSzt { get; set; }
        public string Typ { get; set; }

        public virtual ICollection<ZamowienieWyrobCukierniczy> ZamowienieWyrobCukierniczy { get; set; }
    }
}
