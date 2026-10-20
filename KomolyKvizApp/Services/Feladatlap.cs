using KomolyKvizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomolyKvizApp.Services
{
    public class Feladatlap : IFeladatlap
    {
        Random r = new Random();
        KerdesContext KerdesContext = new KerdesContext();
        /*public List<FeleletValasztosKerdes> getFeleletValasztosKerdes(int kerdesdb)
        {
            List<FeleletValasztosKerdes> kerdesek = new List<FeleletValasztosKerdes>();

            kerdesek = KerdesContext.FeleletValasztosKerdesek.OrderBy(x => r.Next()).Take(kerdesdb).ToList();

            return kerdesek;
        }*/

        /*public List<FeleletValasztosKerdes> getFeleletValasztosKerdesTema(int kerdesdb, string tema)
        {
            List<FeleletValasztosKerdes> kerdesek = new List<FeleletValasztosKerdes>();

            kerdesek = KerdesContext.FeleletValasztosKerdesek.Where(x => x.Temakor == tema).OrderBy(x => r.Next()).Take(kerdesdb).ToList();

            return kerdesek;
        }*/

        public HashSet<IgazHamisKerdes> getIgazHamisKerdes(int kerdesdb)
        {
            HashSet<IgazHamisKerdes> kerdesek = new HashSet<IgazHamisKerdes>();
            List<IgazHamisKerdes> lista = KerdesContext.IgazHamisKerdesek.ToList();

            for (int i = 0; i < kerdesdb; i++)
            {
                kerdesek.Add(lista[r.Next(lista.Count())]);
            }


            return kerdesek;
        }
        public List<IgazHamisKerdes> getIgazHamisKerdesTema(int kerdesdb, string tema)
        {
            List<IgazHamisKerdes> kerdesek = new List<IgazHamisKerdes>();

            kerdesek = KerdesContext.IgazHamisKerdesek.Where(x => x.Temakor == tema).OrderBy(x => r.Next()).Take(kerdesdb).ToList();

            return kerdesek;
        }

        HashSet<IgazHamisKerdes> IFeladatlap.getIgazHamisKerdesTema(int kerdesdb, string tema)
        {
            throw new NotImplementedException();
        }

        public HashSet<string> getKerdesTemak()
        {
            HashSet<string> temak = new HashSet<string>();
            List<IgazHamisKerdes> lista = KerdesContext.IgazHamisKerdesek.ToList();
            foreach (var item in lista)
            {
                temak.Add(item.Temakor);
            }
            return temak;
        }

        public ICollection<Kerdes> getVegyesKerdes(int kerdesdb)
        {

            List<Kerdes> kerdesek = new List<Kerdes>();
            List<Kerdes> kerdesek2 = new List<Kerdes>();

            foreach (var item in KerdesContext.TippelosKerdesek)
            {
                kerdesek.Add(item);
            }
            foreach (var item in KerdesContext.FeleletValasztosKerdesek)
            {
                kerdesek.Add(item);
            }
            foreach (var item in KerdesContext.IgazHamisKerdesek)
            {
                kerdesek.Add(item);
            }

            for (int i = 0; i < kerdesdb; i++)
            {
                kerdesek2.Add(kerdesek[r.Next(kerdesek.Count())]);
            }

            return kerdesek2;
        }

        public ICollection<Kerdes> getVegyesKerdesTema(int kerdesdb, string tema)
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            List<Kerdes> kerdesek2 = new List<Kerdes>();
            foreach (var item in KerdesContext.TippelosKerdesek.Where(x => x.Temakor == tema))
            {
                kerdesek.Add(item);
            }
            foreach (var item in KerdesContext.FeleletValasztosKerdesek.Where(x => x.Temakor == tema))
            {
                kerdesek.Add(item);
            }
            foreach (var item in KerdesContext.IgazHamisKerdesek.Where(x => x.Temakor == tema))
            {
                kerdesek.Add(item);
            }
            for (int i = 0; i < kerdesdb; i++)
            {
                kerdesek2.Add(kerdesek[r.Next(kerdesek.Count())]);
            }
            return kerdesek2;
        }

        public List<IgazHamisKerdes> getIgazHamisKerdesOsszes()
        {
            return KerdesContext.IgazHamisKerdesek.ToList();

        }

        public List<FeleletValasztosKerdes> getFeleletValasztosKerdesOsszes()
        {
            return KerdesContext.FeleletValasztosKerdesek.ToList();
        }

        public void saveKerdes(IgazHamisKerdes kerdes)
        {
            KerdesContext.IgazHamisKerdesek.Add(kerdes);
            KerdesContext.SaveChanges();
        }

        public void saveKerdes(FeleletValasztosKerdes kerdes)
        {
            KerdesContext.FeleletValasztosKerdesek.Add(kerdes);
        }

        public void saveKerdes(TippelosKerdes kerdes)
        {
            KerdesContext.TippelosKerdesek.Add(kerdes);
        }
    }
}
