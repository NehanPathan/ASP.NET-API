using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Vidly.Views.Movies
{
    public class Random : PageModel
    {
        private readonly ILogger<Random> _logger;

        public Random(ILogger<Random> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}