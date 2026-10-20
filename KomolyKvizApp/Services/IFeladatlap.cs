using KomolyKvizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomolyKvizApp.Services
{
    public interface IFeladatlap
    {

        /*public List<FeleletValasztosKerdes> getFeleletValasztosKerdes(int kerdesdb);
        public List<FeleletValasztosKerdes> getFeleletValasztosKerdesTema(int kerdesdb, string tema);
        */

        public HashSet<IgazHamisKerdes> getIgazHamisKerdes(int kerdesdb);
        public HashSet<IgazHamisKerdes> getIgazHamisKerdesTema(int kerdesdb, string tema);

        public HashSet<string> getKerdesTemak();

        public List<IgazHamisKerdes> getIgazHamisKerdesOsszes();

        public List<FeleletValasztosKerdes> getFeleletValasztosKerdesOsszes();

        public void saveKerdes(IgazHamisKerdes kerdes);

        public void saveKerdes(FeleletValasztosKerdes kerdes);

        public void saveKerdes(TippelosKerdes kerdes);

        /*public List<IgazHamisKerdes> getIgazHamisKerdes();
        public List<TippelosKerdes> getTippelosKerdes();
        public List<Kerdes> getVegyesKerdesek();*/
    }
}
