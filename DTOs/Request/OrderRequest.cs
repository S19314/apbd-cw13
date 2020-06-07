using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przykladowy_kolos_2_version_DbFirst.DTOs.Request
{
    public class OrderRequest
    {
        public DateTime DataPryjecia { get; set; }
        public string  Uwagi { get; set; }
        public List<WyrobyRequest> Wyroby { get; set; }
    }
}
