using System.Collections.Generic;
using System.Net;

namespace Rastrum.Api.Models
{
    public class SecurityVendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<byte[]> PgpKeys { get; set; }
        public List<IPAddress> IPAddresses { get; set; }
        public bool HasSignedNda { get; set; }
    }
}
