using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DierenAsiel.Models;

namespace DierenAsiel.Dal
{
    public class DierRepository
    {
        private IDierContext _dierInterface;
        public DierRepository(IDierContext d)
        {
            _dierInterface = d;
        }
        public List<Dier> GetAllDieren()
        {
          return  _dierInterface.GetAllDieren();
        }

        public void AddDierToList(Dier d)
        {
            _dierInterface.AddDierToList(d);
        }
    }
}
