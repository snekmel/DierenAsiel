using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel.Models
{
    public class Persoon
    {
        public enum Geslacht
        {
            Man, Vrouw
        }

        private string _naam;
        private string _achternaam;
        private string _woonplaats;
        private string _straat;
        private int _huisnmr;
        private string _postcode;
        private string _telefoonNummer;
        private string _email;

        public Geslacht PersoonGeslacht { get; set; }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefoonnummer
        {
            get { return _telefoonNummer; }
            set { _telefoonNummer = value; }
        }

        public string Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        public int Huisnummer
        {
            get { return _huisnmr; }
            set { _huisnmr = value; }
        }

        public string Straat
        {
            get { return _straat; }
            set { _straat = value; }
        }

        public string Woonplaats
        {
            get { return _woonplaats; }
            set { _woonplaats = value; }
        }

        public string Achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
    }
}