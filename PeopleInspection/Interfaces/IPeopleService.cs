using System.Collections.Generic;
using YourNamespace.Models;

namespace YourNamespace.Interfaces
{
    public interface IPeopleService
    {
        List<Person> GetAllPeople();
        Person GetPersonById(int id);
        void AddPerson(CreatePersonViewModel person);
        void DeletePerson(int id);
        List<Person> Search(string searchString);
    }
}

