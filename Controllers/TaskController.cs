using Microsoft.AspNetCore.Mvc;
using Mission08.Models;

namespace Mission08.Controllers
{
    public class TaskController : Controller
    {
        public Mission08Context _context;

        public TaskController(Mission08Context db) {
            _context = db;
        }
        public IActionResult Index()
        {
            var incompleteTasks = _context.Tasks.Where(x => x.IsCompleted == false);
            return View(incompleteTasks);
        }

        // Create
        public IActionResult Create()
        {
            ViewBag.Categories = new List<string>() { "Home", "School", "Work", "Church"};
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mission08.Models.Task newTask)
        {
            _context.Tasks.Add(newTask);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // Edit
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new List<string>() { "Home", "School", "Work", "Church"};
            var task = _context.Tasks.FirstOrDefault(x => x.id == id);
            return View(task);
        }
        [HttpPost]
        public IActionResult Edit(Mission08.Models.Task existingTask)
        { 
            _context.Tasks.Update(existingTask);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var task = _context.Tasks.FirstOrDefault(x => x.id == id);
            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Completed(int id)
        {
            var task = _context.Tasks.FirstOrDefault(x => x.id == id);
            task.IsCompleted = true;
            _context.Tasks.Update(task);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}