using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rastrum.Api.Models;

namespace Rastrum.Api
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> ListAllPeopleAsync();
        Task<Person> GetPersonAsync(int id);
    }
}
