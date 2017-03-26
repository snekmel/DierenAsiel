using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DierenAsiel.Models;

namespace DierenAsiel.Dal
{


    public class PersoonMemoryContext : IPersoonContext
    {
        private List<Persoon> _personen;

        public PersoonMemoryContext()
        {
            _personen = new List<Persoon>();
        }

        public int PersonenCount()
        {
            return _personen.Count;
        }

        public void AddPersoon(Persoon p)
        {
            _personen.Add(p);
        }

        public Persoon GetPersoonById(string id)
        {
            var persoon = _personen.Single(p => p.Id == id);

            if (persoon != null)
            {
                return persoon;
            }
            else
            {
                return null;
            }
        }

        public void UpdatePersoonById(string id, Persoon p)
        {
            _personen.RemoveAll(persoon => persoon.Id == id);
            _personen.Add(p);

        }

        public void DeletePersoonById(string id)
        {
            _personen.RemoveAll(p => p.Id == id);
        }
    }
}
