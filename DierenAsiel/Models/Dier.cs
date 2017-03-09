using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel.Models
{
    public class Dier
    {
        public enum Geslacht
        {
            Man, Vrouw
        }

        //Privates
        private string _naam;

        private DateTime _gebDatum;
        private Persoon _vorigeEigenaar;
        private Geslacht _geslacht;

        //Getters / setters
        public Geslacht DierGeslacht
        {
            get { return _geslacht; }
            set { _geslacht = value; }
        }

        public Persoon VorigeEigenaar
        {
            get { return _vorigeEigenaar; }
            set { _vorigeEigenaar = value; }
        }

        public DateTime GeboorteDatum
        {
            get { return _gebDatum; }
            set { _gebDatum = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
    }
}