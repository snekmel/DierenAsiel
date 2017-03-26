using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DierenAsiel.Models;

namespace DierenAsiel.Dal
{
   public interface IDierContext
    {
        void AddDierToList(Dier d);

        List<Dier> GetAllDieren();

        Dier GetDierById(string id);

        void RemoveDierById(string id);

        void UpdateDierById(string id, Dier d);
    }
}
