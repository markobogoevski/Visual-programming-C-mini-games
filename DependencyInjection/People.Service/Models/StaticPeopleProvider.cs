using PeopleViewer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Service.Models
{
    public class StaticPeopleProvider : IPeopleProvider
    {
        public IEnumerable<Person> GetPeople()
        {
            var p = new List<Person>
            {
                new Person(){Id=1,GivenName="John",FamilyName="Koenig",StartDate=new DateTime(1975,10,17),Rating=5},
                new Person(){Id=2,GivenName="Marko",FamilyName="Bogoevski",StartDate=new DateTime(1995,10,7),Rating=6},
                new Person(){Id=3,GivenName="Darko",FamilyName="Ristovski",StartDate=new DateTime(1945,10,1),Rating=4},
                new Person(){Id=4,GivenName="Ilina",FamilyName="Krstevska",StartDate=new DateTime(1915,12,17),Rating=3},
                new Person(){Id=5,GivenName="Jovan",FamilyName="Velkovski",StartDate=new DateTime(1925,8,11),Rating=10},
                new Person(){Id=6,GivenName="Beku",FamilyName="Galveski",StartDate=new DateTime(2010,14,12),Rating=9},
            };

            return p;
        }

        public Person GetPersonById(int id)
        {
            var person = GetPeople().Where(p => p.Id == id).FirstOrDefault();
            return person;
        }
    }
}
