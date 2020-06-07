using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przykladowy_kolos_2_version_DbFirst.DTOs.Request
{
    public class WyrobyRequest
    {
        public int Ilosc { get; set; }
        public string Wyrob { get; set; }
        public string Uwagi { get; set; }
    }
}
