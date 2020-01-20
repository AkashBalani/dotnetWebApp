using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webapp2.Pages
{
    public class PrivacyModel2 : PageModel
    {
        private readonly ILogger<PrivacyModel2> _logger;

        public PrivacyModel2(ILogger<PrivacyModel2> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}