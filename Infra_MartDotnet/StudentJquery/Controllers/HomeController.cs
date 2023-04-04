using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentJquery.DBContext;
using StudentJquery.Models;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json.Serialization;


namespace StudentJquery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly CollectionContex _ctx;

        public HomeController(ILogger<HomeController> logger,CollectionContex ctx,IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _ctx = ctx;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }
      //  [Route("CreateStudent"), HttpPost]
        [HttpPost]
        public  string CreateStudent([FromBody] StudentModel student)
        {
           
            Console.WriteLine("Inside the CreateStudent");
            Console.WriteLine(student);
            
           // if (!ModelState.IsValid) return BadRequest("Enter required fields");
            //Write your Insert code here;
          //  return this.Ok("Form Data received!");
            return "data received";
        }


        public IActionResult AddStudentWihImage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudentWihImage([FromForm] ImageData studimage)
        {
            string imageurl = UploadFile(studimage);
            var Student = new StudentModel()
            {
                Name = studimage.Name,
                Email = studimage.Email,
                Phone = studimage.Phone,
                Image = imageurl
            };
            _ctx.Student.Add(Student);
            _ctx.SaveChanges();
            return RedirectToAction("ShowAllStudent", "Home");
          //  return "Method Execute Successfully";

        }

        private string UploadFile(ImageData studimage)
        {
            string file = null;
            if(studimage!=null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                file = Guid.NewGuid().ToString() + "-" + studimage.Files.FileName;
                string filepath=Path.Combine(uploadDir, file);
                using(var fileStream=new FileStream(filepath,FileMode.Create))
                {
                    studimage.Files.CopyTo(fileStream);
                }
            }
            return file;

        }

        public IActionResult ShowAllStudent()
        {
           var students= _ctx.Student.ToList();
            ViewData["student"]=students;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}