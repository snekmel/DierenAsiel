using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel.Models
{
    public class DierenAsiel
    {
        public List<Dier> Dieren { get; private set; }
        public List<Persoon> Personen { get; private set; }
        public List<Reservering> Reserveringen { get; private set; }

        public DierenAsiel()
        {
            Dieren = new List<Dier>();
            Personen = new List<Persoon>();
            Reserveringen = new List<Reservering>();
        }

        public void DierToevoegen(Dier d)
        {
            this.Dieren.Add(d);
        }

        public void PersoonToevoegen(Persoon p)
        {
            this.Personen.Add(p);

        }

        public void ReserveringToevoegen(Reservering r) {
            this.Reserveringen.Add(r);
        }
    }

}
