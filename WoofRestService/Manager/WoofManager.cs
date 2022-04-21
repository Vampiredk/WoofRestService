using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoofRestService.Models;

namespace WoofRestService.Manager
{
    public class WoofManager
    {
        private static int _nextId = 1;

        private static List<Woof> _WoofList = new List<Woof>()
        {
        };


        public List<Woof> GetAll()
        {
            return _WoofList;
        }

        public Woof GetById(int ID)
        {
            return _WoofList.Find(Meas => Meas.Id == ID);
        }

        public void Delete(int id)
        {
            Woof woof = _WoofList.Find(woof => woof.Id == id);
            if (woof == null) return;
            _WoofList.Remove(woof);
        }

        public void Add(Woof value)
        {
            value.Id = _nextId++;
            _WoofList.Add(value);
        }

        public Woof Update(int id, Woof value)
        {
            Woof item = _WoofList.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.Id = value.Id;
            item.Emails = value.Emails;
            item.Skole = value.Skole;
            item.Klasse = value.Klasse;
            item.Afdeling = value.Afdeling;
            item.Hund = value.Hund;
            item.KlassensSvar = value.KlassensSvar;
            return item;
        }
    }
}
