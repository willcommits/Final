using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Co_Mute.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        protected void onSubmit(object sender, EventArgs e)
        {
            string email =Request.Form["inputEmail"];
            Console.WriteLine(email);
            string password = Request.Form["email"];


        }

    }
    }