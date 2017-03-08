using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DierenAsiel.Models;

namespace DierenAsiel
{
    /// <summary>
    /// Interaction logic for PersoonToevoegen.xaml
    /// </summary>
    public partial class PersoonToevoegen : Window
    {
        private List<Persoon> _personenLijst;
        private MainWindow _mw;
        private Persoon _selectedPerson;

        public PersoonToevoegen(List<Persoon> personenLijst, MainWindow mw)
        {
            InitializeComponent();
            _personenLijst = personenLijst;
            _mw = mw;

            ViewLoader();
        }

        public PersoonToevoegen(List<Persoon> personenLijst, MainWindow mw, Persoon selectedPersoon)
        {
            InitializeComponent();
            _personenLijst = personenLijst;
            _mw = mw;
            _selectedPerson = selectedPersoon;

            ViewLoader();
        }

        private void PersoonTvgnBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedPerson == null)
            {
                Persoon p = new Persoon();
                p.Naam = naamTb.Text;
                p.Achternaam = achternaamTb.Text;
                p.Woonplaats = woonplaatsTb.Text;
                p.Straat = straatTb.Text;
                p.Huisnummer = int.Parse(huisnmrTb.Text);
                p.Postcode = postcodeTb.Text;
                p.Telefoonnummer = telefoonnmrTb.Text;
                p.Email = emailTb.Text;

                _personenLijst.Add(p);

                System.Windows.MessageBox.Show("Gebruiker " + p.Naam + " toegevoegd");
            }

            _mw.ViewLoader();
        }

        private void ViewLoader()
        {
            //Wanneer er een persoon object is meegegeven.
            if (_selectedPerson != null)
            {
                naamTb.Text = _selectedPerson.Naam;
                achternaamTb.Text = _selectedPerson.Achternaam;
                straatTb.Text = _selectedPerson.Straat;
                huisnmrTb.Text = _selectedPerson.Huisnummer.ToString();
                postcodeTb.Text = _selectedPerson.Postcode;
                telefoonnmrTb.Text = _selectedPerson.Telefoonnummer;
                emailTb.Text = _selectedPerson.Email;
            }
        }
    }
}