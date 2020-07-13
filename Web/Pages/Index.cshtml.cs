using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Web.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public int? Number { get; set; }
        public string Result { get; set; }

        public void OnGet(int? number)
        {
            Number = number;
            Result = FizzBuzz.Play(number ?? 0);
        }
    }
}
