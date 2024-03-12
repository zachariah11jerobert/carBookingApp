using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace carBookingApp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        public string Heading { get; set; }

        public string Message { get; set; }

        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
     
        public void OnGet()
        {
            Heading = "List Cars get Loaded - from Variable";
            Message = this._configuration["Message"];
        }
    }
}
