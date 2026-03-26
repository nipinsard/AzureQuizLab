using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureQuizLab.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public bool MaintenanceMode { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            MaintenanceMode = _configuration.GetValue<bool>("MaintenanceMode", false);
        }
    }
}
