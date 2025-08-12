using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem_assignmet.Data;
using StudentManagementSystem_assignmet.Models;

namespace StudentManagementSystem_assignmet.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // READ: Show students age > 18 using LINQ 
        public IActionResult Index()
        {
            var students = _context.Students
                .Where(s => s.Age > 18)
                .ToList();

            ViewBag.StudentCount = students.Count();
            return View(students);
        }

        // CREATE: Show form
        public IActionResult Create() => View();

        // CREATE: Save new student
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // UPDATE: Show edit form
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();
            return View(student);
        }

        // UPDATE: Save changes
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // DELETE: Show confirmation page (GET)
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();
            return View(student);
        }

        // DELETE: Perform actual delete (POST)
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // SEARCH: By name using LINQ 
        public IActionResult Search(string name)
        {
            var result = _context.Students
                .Where(s => s.FirstName.Contains(name) || s.LastName.Contains(name))
                .ToList();

            ViewBag.StudentCount = result.Count();
            return View("Index", result);
        }
    }
}