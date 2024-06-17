// Repositories/PeopleRepo.cs
using System.Collections.Generic;
using System.Linq;
using YourNamespace.Interfaces;
using YourNamespace.Models;

namespace YourNamespace.Repositories
{
    public class PeopleRepo : IPeopleRepo
    {
        // In-memory list to store people data
        private readonly List<Person> _people = new List<Person>();

        public List<Person> GetAllPeople()
        {
            return _people;
        }

        public Person GetPersonById(int id)
        {
            return _people.FirstOrDefault(p => p.Id == id);
        }

        public void AddPerson(Person person)
        {
            // Simulate auto-increment ID
            person.Id = _people.Any() ? _people.Max(p => p.Id) + 1 : 1;
            _people.Add(person);
        }

        public void DeletePerson(int id)
        {
            var person = GetPersonById(id);
            if (person != null)
            {
                _people.Remove(person);
            }
        }

        public List<Person> Search(string searchString)
        {
            return _people
                .Where(p => p.Name.Contains(searchString) || p.City.Contains(searchString))
                .ToList();
        }
    }
}

