using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _191_MOMENT_1_1.Pages
{
    public class UtbildningModel : PageModel
    {
        private readonly ILogger<UtbildningModel> _logger;

        public UtbildningModel(ILogger<UtbildningModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}