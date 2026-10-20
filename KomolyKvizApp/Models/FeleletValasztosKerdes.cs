using KomolyKvizApp.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomolyKvizApp.Models
{
    [Table(name: "feleletvalasztos_kerdesek")]
    public class FeleletValasztosKerdes : Kerdes, IKerdes
    {
        public int Id { get; set; }
        [NotMapped]
        public List<string> Valaszok { get; set; }
        [Column(name:"valasz_1")]
        public string V1 { get; set; }
        [Column(name: "valasz_2")]
        public string V2 { get; set; }
        [Column(name: "valasz_3")]
        public string V3 { get; set; }
        [Column(name: "valasz_4")]
        public string V4 { get; set; }
        [Column(name: "kerdes")]
        public string KerdesSzoveg { get; set; }
        [Column(name:"helyes_valasz_index")]
        public byte HelyesValasz { get; set; }
        [Column(name:"pontszam")]
        public byte Pontszam { get; set; }
        public string Temakor { get; set; }

        private List<string> ValaszLista()
        {
            return Valaszok = new List<string> { V1, V2, V3, V4 };
        }
    }

    
}
