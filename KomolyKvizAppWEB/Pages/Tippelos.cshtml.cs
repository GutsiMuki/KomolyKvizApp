using KomolyKvizApp.Models;
using KomolyKvizApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KomolyKvizAppWEB.Pages
{
    public class TippelosModel : PageModel
    {
        public Feladatlap f { get; set; } = new();

        public List<TippelosKerdes> kerdesek { get; set; }

        public void OnGet()
        {
        }
    }
}
