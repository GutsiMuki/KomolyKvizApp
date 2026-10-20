using KomolyKvizApp.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomolyKvizApp.Models
{
    [Table(name: "igaz_hamis_kerdesek")]
    public class IgazHamisKerdes : Kerdes, IKerdes
    {
        public int Id { get; set; }

        [Column(name: "kerdes")]
        public string KerdesSzoveg { get; set; }
        [Column(name: "helyes_valasz")]
        public bool HelyesValasz { get; set; }
        [Column(name: "pontszam")]
        public byte Pont { get; set; }
        [Column(name: "temakor")]
        public string Temakor { get; set; }
    }
}
