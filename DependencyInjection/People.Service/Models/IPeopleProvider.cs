using System.Collections.Generic;
using PeopleViewer.Common;

namespace People.Service.Models
{
    public interface IPeopleProvider
    {
        IEnumerable<Person> GetPeople();
        Person GetPersonById(int id);
    }
}