using System;
using System.Collections.Generic;

namespace Przykladowy_kolos_2_version_DbFirst.Models
{
    public partial class RefreshToken
    {
        public string Id { get; set; }
        public string HashingPassword { get; set; }
        public string Salt { get; set; }
    }
}
