using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _191_MOMENT_1_1.Pages
{
    public class OmModel : PageModel
    {
        private readonly ILogger<OmModel> _logger;

        public OmModel(ILogger<OmModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}