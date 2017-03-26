using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DierenAsiel.Models;

namespace DierenAsiel.Dal
{
    public class PersoonRepository
    {

        private IPersoonContext _interface;

        public PersoonRepository(IPersoonContext i)
        {
            _interface = i;
        }

        public void AddPersoon(Persoon p)
        {
            _interface.AddPersoon(p);
        }


        public Persoon GetPersoonById(string id)
        {
            return _interface.GetPersoonById(id);
        }

        public void UpdatePersoonById(string id, Persoon p)
        {
            _interface.UpdatePersoonById(id,p);
        }

        public void DeletePersoonById(string id)
        {
            _interface.DeletePersoonById(id);
        }
    }
}
