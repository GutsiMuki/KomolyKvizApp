using KomolyKvizApp.Models;
using KomolyKvizApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.PortableExecutable;

namespace KomolyKvizAppWEB.Pages
{
    public class FeleletValasztosModel : PageModel
    {
        public List<FeleletValasztosKerdes> kerdesek{ get; set; }

        public Feladatlap f { get; set; } = new();
        public void OnGet()
        {
            kerdesek = f.getFeleletValasztosKerdesOsszes();

        }
    }
}
