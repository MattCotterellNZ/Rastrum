using System.Collections.Generic;

namespace Rastrum.Api.Models
{
    public class TestingEnvironment
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public List<TestingEnvironmentVendor> Vendor { get; set; }
    }
}
