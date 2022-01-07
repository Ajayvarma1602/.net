using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication15.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IMath _Maths;

        private readonly IStudents _Student;

       

        public IndexModel(ILogger<IndexModel> logger,IMath maths,IStudents names)
        {
            _logger = logger;
            _Maths = maths;
            _Student = names;
            

        }

        public void OnGet()
        {

        }
    }
}
