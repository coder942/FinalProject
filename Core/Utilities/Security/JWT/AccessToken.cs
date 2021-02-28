using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Toke { get; set; }
        public DateTime Expiration { get; set; }
    }
}
