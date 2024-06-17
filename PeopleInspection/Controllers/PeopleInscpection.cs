using Microsoft.AspNetCore.Mvc;
using YourNamespace.Interfaces;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    public class PeopleInspection : Controller
    {
        private readonly IPeopleService _peopleService;

        public PeopleInspection(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        public IActionResult Index(string searchString)
        {
            var people = string.IsNullOrEmpty(searchString) ?
                         _peopleService.GetAllPeople() :
                         _peopleService.Search(searchString);

            var model = new SearchViewModel
            {
                SearchString = searchString,
                People = people
            };

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreatePersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                _peopleService.AddPerson(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var person = _peopleService.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        public IActionResult Delete(int id)
        {
            _peopleService.DeletePerson(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
