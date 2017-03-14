using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rastrum.Api.Models
{
    public class Engagement
    {
        public Guid Id { get; set; }
        public string InternalReference { get; set; }
        public Person Author { get; set; }

        public List<Person> InternalSecurityContact { get; set; }
        public List<SecurityVendor> SecurityVendor { get; set; }

        public List<TestingEnvironment> EnvironmentsInScope { get; set; }
        public List<EnvironmentTestingAuthorisation> EnvironmentTestingAuthorisations { get; set; }


        public List<Person> GetProductManagers()
        {
            throw new NotImplementedException();
        }
        public List<Person> GetTechnicalContacts()
        {
            throw new NotImplementedException();
        }
        public List<SecurityVendor> GetSecurityFirms()
        {
            throw new NotImplementedException();
        }
    }
}
