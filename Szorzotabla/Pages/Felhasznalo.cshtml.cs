using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Szorzotabla.Models;

namespace Szorzotabla.Pages
{
    public class FelhasznaloModel : PageModel
    {
        [BindProperty]
        public Felhasznalok ujFelhasznalo { get; set; } = new Felhasznalok();

        public List<Felhasznalok> felhasznalok { get; set; } = new List<Felhasznalok>();

        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            felhasznalok.Add(ujFelhasznalo);
            return Page();
        }
    }
}
