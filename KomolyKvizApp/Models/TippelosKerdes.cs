using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomolyKvizApp.Models
{
    [Table(name: "tippelos_kerdesek")]
    public class TippelosKerdes : Kerdes, Interface.IKerdes
    {
        public int Id { get; set; }
        [Column(name: "kerdes")]
        public string KerdesSzoveg { get; set; }
        [Column(name: "helyes_valasz")]
        public double HelyesValasz { get; set; }
        [Column(name: "pontszam")]
        public byte Pontszam { get; set; }
        [Column(name: "tolerancia_szazalek")]
        public double ElteresSzazalek { get; set; }
        public string Temakor { get; set; }
    }
}
