using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_project.Models
{
    public interface IPersonRepository
    {
        IQueryable<Person> Persons{get;}

    }
}