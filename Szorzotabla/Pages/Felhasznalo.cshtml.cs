using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Szorzotabla.Models;

namespace Szorzotabla.Pages
{
    public class FelhasznaloModel : PageModel
    {
        [BindProperty]
        public Fehasznalo ujFelhasznalo { get; set; } = new Fehasznalo();

        public List<Fehasznalo> felhasznalok { get; set; } = new List<Fehasznalo>();

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
