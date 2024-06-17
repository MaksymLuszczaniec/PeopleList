


using System.Collections.Generic;
using YourNamespace.Models;

namespace YourNamespace.Interfaces
{
    public interface IPeopleRepo
    {
        List<Person> GetAllPeople();
        Person GetPersonById(int id);
        void AddPerson(Person person);
        void DeletePerson(int id);
        List<Person> Search(string searchString);
    }
}
