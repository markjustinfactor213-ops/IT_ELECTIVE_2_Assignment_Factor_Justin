using System.Diagnostics;
using IT_ELECTIVE_2_Midterm_A1_Tumala_Neil.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_Midterm_A1_Tumala_Neil.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["info 1"] = "Hello! I am Justin Factor, a passionate developer dedicated to building scalable and clean web applications. My journey into programming started with a profound curiosity about how systems interact behind the scenes, which quickly transformed into a focused educational and career path. Over the past few years, I have worked hard to establish a solid foundation in software engineering principles, specializing in creating sleek, responsive layouts backed by highly optimized back end systems.";
            ViewData["info 2"] = "My educational background includes focusing on Information Technology, where I consistently explore advanced topics like systems architecture, software design patterns, and database management systems. Looking ahead, my primary career goal is to join an innovative engineering team where I can contribute to impactful software solutions and refine my full stack skillset. Outside of writing code, I enjoy staying updated with the latest tech blogs, experimenting with open-source tools, and problem solving through strategy games.";
            ViewData["Fact1"] = "BS in Information Technology";
            ViewData["Fact2"] = "ASP.NET Core & Web Dev";
            ViewData["Fact3"] = "Software Architecture, UI/UX";
            return View();
        }

        public IActionResult Skills()
        {
            ViewData["skill 1"] = "A breakdown of the tools and technologies I utilize to bring projects to life.";
            ViewData["Prog 1"] = "Programming Languages";
            ViewData["Prog 2"] = "C#, JavaScript, Python, C++";
            ViewData["Web 1"] = "Web Technologies";
            ViewData["Web 2"] = "ASP.NET Core MVC, HTML5, CSS3, Bootstrap 5";
            ViewData["Data 1"] = "Databases";
            ViewData["Data 2"] = "SQL Server, MySQL, PostgreSQL";
            ViewData["Dev 1"] = "Development Tools";
            ViewData["Dev 2"] = "Git, GitHub, Visual Studio, VS Code";
            return View();
        }

        public IActionResult Projects()
        {
            ViewData["Proj 1"] = "Some of the interactive projects I have designed and built.";
            ViewData["Proj 2"] = "A fully responsive e-commerce web platform featuring product listings, shopping cart updates, and user registration.";
            ViewData["Proj 3"] = "ASP.NET Core";
            ViewData["Proj 4"] = "SQL Server";
            ViewData["Proj 5"] = "Bootstrap";
            ViewData["Proj 6"] = "Task Management Board";
            ViewData["Proj 7"] = "A layout framework designed to assist productivity tracking, project task grouping, and organizational timelines.";
            ViewData["Proj 8"] = "JavaScript";
            ViewData["Proj 9"] = "HTML5/CSS3";
            ViewData["Proj 10"] = "Bootstrap";
            ViewData["Proj 11"] = "Student Progress Tracker";
            ViewData["Proj 12"] = "An academic management engine tracking semester grades, course completion rates, and historical analytics charts.";
            ViewData["Proj 13"] = "Detailed information about the application system database architectures, custom admin interfaces, and integration details.";
            ViewData["Proj 14"] = "Provides modular task swimlanes that dynamically adapt across custom viewport screen breakpoints effortlessly.";
            ViewData["Proj 15"] = "Includes functional data structures built to format statistical course metrics neatly inside tables and visual rows.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Cont 1"] = "I am always open to discussing new opportunities, prospective projects, or answering questions. Connect with me across any of these channels!";
            ViewData["Cont 2"] = "Email Me";
            ViewData["Cont 3"] = "factorjustin@gmail.com";
            ViewData["Cont 4"] = "Mobile Number";
            ViewData["Cont 5"] = "+9124141508";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Priv"] = "Use this page to detail your site's privacy policy.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}