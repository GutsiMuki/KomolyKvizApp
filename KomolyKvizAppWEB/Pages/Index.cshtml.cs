using KomolyKvizApp.Models;
using KomolyKvizApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KomolyKvizAppWEB.Pages
{
    public class IndexModel : PageModel
    {
        public Feladatlap f { get; set; } = new();

        public List <IgazHamisKerdes> kerdesek { get; set; }
        public void OnGet()
        {
            kerdesek = f.getIgazHamisKerdesOsszes();
        }
    }
}
