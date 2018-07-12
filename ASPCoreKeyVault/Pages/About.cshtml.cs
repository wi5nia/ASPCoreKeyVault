using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace ASPCoreKeyVault.Pages
{
    public class AboutModel : PageModel
    {
        public AboutModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private readonly IConfiguration _configuration = null;
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "My key val = " + _configuration["AppSecret"];
        }
    }
}
