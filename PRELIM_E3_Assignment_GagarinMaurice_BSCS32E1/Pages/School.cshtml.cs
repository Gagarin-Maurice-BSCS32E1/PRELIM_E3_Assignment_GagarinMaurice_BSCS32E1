using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PRELIM_E3_Assignment_GagarinMaurice_BSCS32E1.Pages
{
    public class School : PageModel
    {
        private readonly ILogger<School> _logger;

        public School(ILogger<School> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}