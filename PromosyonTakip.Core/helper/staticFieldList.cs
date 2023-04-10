using PromosyonTakip.Core.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.helper
{
    public class staticFieldList
    {
        public static int magazaID { get; set; }

        public static List<cinsiyet> cinsiyetYukle()
        {
            List<cinsiyet> cinsiyetListe = new List<cinsiyet>();
            cinsiyetListe.Add(new cinsiyet() { id = 1, tanim = "Erkek" });
            cinsiyetListe.Add(new cinsiyet() { id = 2, tanim = "Kadın" });
            return cinsiyetListe;
        }

    }
}
