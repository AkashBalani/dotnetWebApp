using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webapp2.Pages
{
    public class RequiemModel : PageModel
    {
        private readonly ILogger<RequiemModel> _logger;

        public RequiemModel(ILogger<RequiemModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}