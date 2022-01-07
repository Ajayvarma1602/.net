using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
//{
//    public class Employee : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//} 
{
    public class Emp
    {
        public Emp()
        { }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        List<string> inpCollection = new List<string>();

        [HttpGet]
        public List<Emp> Index()
        {
            List<Emp> lst = new List<Emp>(); 
            lst.Add(new Emp { Id = 2, Name = "A" });
            lst.Add(new Emp { Id = 1, Name = "A" });
            lst.Add(new Emp { Id = 3, Name = "A" });
            return lst;
        }
        [HttpGet]
        [Route("More")]
        public List<Emp> Index1()
        {
            List<Emp> lst = new List<Emp>();
            lst.Add(new Emp { Id = 2, Name = "A" });
            lst.Add(new Emp { Id = 1, Name = "A" });
            lst.Add(new Emp { Id = 3, Name = "asdsadA" });
            lst.Add(new Emp { Id = 3, Name = "asdsad" });
            lst.Add(new Emp { Id = 3, Name = "asdsadsa" });
            return lst;
        }
        [HttpGet]
        [Route("Find")]
        public Emp Index1(int id)
        {
            List<Emp> lst = new List<Emp>(); 
            lst.Add(new Emp { Id = 2, Name = "A" });
            lst.Add(new Emp { Id = 1, Name = "A" });
            lst.Add(new Emp { Id = 3, Name = "asdsadA" });
            lst.Add(new Emp { Id = 4, Name = "asdsad" });
            lst.Add(new Emp { Id = 5, Name = "asdsadsa" });
            return lst.Find(l => l.Id == id);
        } 
        [HttpPost]
        [Route("New")]

        public IActionResult InsertVal(string val)
        {
            var obj = new { FirstName = "vijay", LastName = "Kumar" };
            inpCollection.Add(val);
            return BadRequest("Error");
            //return Ok(obj);
        }
    }
}


