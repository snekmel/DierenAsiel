using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel.Models
{
    public class Dier
    {
        //Enum
        public enum dierType
        {
            Hond, Kat
        }

        //Privates
        private string _naam;

        private DateTime _gebDatum;
        private DateTime _uitlaatDatum;
        private string _extraInfo;
        private dierType _diertype;
        private Persoon _vorigeEigenaar;

        //Getters / setters
        public Persoon VorigeEigenaar
        {
            get { return _vorigeEigenaar; }
            set { _vorigeEigenaar = value; }
        }

        public dierType DierType
        {
            get { return _diertype; }
            set { _diertype = value; }
        }

        public string ExtraInfo
        {
            get { return _extraInfo; }
            set { _extraInfo = value; }
        }

        public DateTime UitlaatDatum
        {
            get { return _uitlaatDatum; }
            set { _uitlaatDatum = value; }
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

        //Functions
    }
}