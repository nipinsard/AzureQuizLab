using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureQuizLab.Pages
{
    public class IndexModel : PageModel
    {
        public bool MaintenanceMode { get; set; }

        public void OnGet()
        {
            var configurationManager = new ConfigurationManager();
            MaintenanceMode = configurationManager.GetValue<bool>("MaintenanceMode", false);
        }
    }
}
