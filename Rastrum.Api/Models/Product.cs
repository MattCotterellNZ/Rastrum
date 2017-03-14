using System.Collections.Generic;

namespace Rastrum.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> ProjectManagers { get; set; }
        public List<Person> TechnicalContacts { get; set; }
    }
}
