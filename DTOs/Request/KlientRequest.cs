using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Przykladowy_kolos_2_version_DbFirst.DTOs.Request
{
    public class KlientRequest
    {
        public int IdKlient { get; set; }
        public string Imie { get; set; }
        public string Nazwisk { get; set; }

    }
}
