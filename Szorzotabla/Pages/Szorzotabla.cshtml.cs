using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Szorzotabla.Pages
{
    public class SzorzotablaModel : PageModel
    {
        [BindProperty]
        public int MaxTenyezo { get; set; }
        //static public int MasikMax { get; set; }
        public void OnGet()
        {
        }
        public IActionResult onPost()
        {
            //MasikMax = MaxTenyezo;
            return Page();
        }
    }
}
