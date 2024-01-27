using Microsoft.AspNetCore.Mvc;
using week2_1.Models;

namespace week2_1.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            var projects = new List<Project>()
            {
                new Project { ProjectId = 1, Name = "Project 1", Description = " first project" },
            new Project { ProjectId = 2, Name = "Project 2", Description = " second project" }
        };
        return View(projects);
            } 
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
