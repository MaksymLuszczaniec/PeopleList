// Services/PeopleService.cs
using System.Collections.Generic;
using YourNamespace.Interfaces;
using YourNamespace.Models;

namespace YourNamespace.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepo _peopleRepo;

        public PeopleService(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }

        public List<Person> GetAllPeople()
        {
            return _peopleRepo.GetAllPeople();
        }

        public Person GetPersonById(int id)
        {
            return _peopleRepo.GetPersonById(id);
        }

        public void AddPerson(CreatePersonViewModel model)
        {
            var person = new Person
            {
                Name = model.Name,
                City = model.City
            };
            _peopleRepo.AddPerson(person);
        }

        public void DeletePerson(int id)
        {
            _peopleRepo.DeletePerson(id);
        }

        public List<Person> Search(string searchString)
        {
            return _peopleRepo.Search(searchString);
        }
    }
}

