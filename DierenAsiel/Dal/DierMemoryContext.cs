using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DierenAsiel.Models;

namespace DierenAsiel.Dal
{

    public class DierMemoryContext : IDierContext
    {
        private List<Dier> _dieren;

        public DierMemoryContext()
        {
            _dieren = new List<Dier>();

            var d = new Dog();
            d.Naam = "DierNaam";
            d.GeboorteDatum = DateTime.Now.Date;
            _dieren.Add(d);

            var k = new Cat();
            k.Naam = "test";
            k.GeboorteDatum = DateTime.Now.Date;
            _dieren.Add(k);
        }

        public void AddDierToList(Dier d)
        {
            _dieren.Add(d);
        }

        public List<Dier> GetAllDieren()
        {
            return _dieren;
        }

        public Dier GetDierById(DateTime id)
        {
            foreach (var d in _dieren)
            {
                if (d.Id == id)
                {
                    return d;
                }
            }

            return null;
        }

        public void RemoveDierById(DateTime id)
        {
            foreach (var d in _dieren)
            {
                if (d.Id == id)
                {
                    _dieren.Remove(d);
                }
            }
        }

        public void UpdateDierById(DateTime id, Dier d)
        {
                //
        }

    }
}
