using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoofRestService.Models
{
    public class Woof
    {
        public string Emails { get; set; }
        public string Skole { get; set; }
        public string Klasse { get; set; }
        public string Afdeling { get; set; }
        public string Hund { get; set; }
        public string KlassensSvar { get; set; }
        public int Id { get; set; }

        public Woof(string emails, string skole, string klasse, string afdeling, string hund, string klassensvar, int id)
        {
            Emails = emails;
            Skole = skole;
            Klasse = klasse;
            Afdeling = afdeling;
            Hund = hund;
            KlassensSvar = klassensvar;
            Id = id;
        }
        public Woof() { }

        public override string ToString()
        {
            return Emails + ", " + Skole + ", " + Klasse + " " + Afdeling + ", " + Hund + ", " + KlassensSvar;
        }

    }
}
