using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DierenAsiel.Models;

namespace DierenAsiel.Dal
{
    public interface IPersoonContext
    {


        //all
        List<Persoon> GetAllPersonen();

        //create
        void AddPersoon(Persoon p);

        //read
        Persoon GetPersoonById(string id);

        //update
        void UpdatePersoonById(string id, Persoon p);

        //delete
        void DeletePersoonById(string id);

    }
}
