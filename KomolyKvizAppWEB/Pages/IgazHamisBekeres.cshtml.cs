using KomolyKvizApp.Models;
using KomolyKvizApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KomolyKvizAppWEB.Pages
{
    public class IgazHamisBekeresModel : PageModel
    {
        public Feladatlap f = new Feladatlap();
        public void OnGet()
        {

        }
        public void OnPost(IgazHamisKerdes kerdes)
        {

            Console.WriteLine(kerdes.KerdesSzoveg + " " + kerdes.HelyesValasz);
            f.saveKerdes(kerdes);
        }
    }
}
