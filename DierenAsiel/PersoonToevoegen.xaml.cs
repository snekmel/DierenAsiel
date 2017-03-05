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

        public PersoonToevoegen(List<Persoon> PersonenLijst, MainWindow mw)
        {
            InitializeComponent();
            _personenLijst = PersonenLijst;
            _mw = mw;
        }

        private void PersoonTvgnBtn_Click(object sender, RoutedEventArgs e)
        {
            Persoon p = new Persoon();
            p.Naam = naamTb.Text;
            p.Achternaam = achternaamTb.Text;
            p.Woonplaats = woonplaatsTb.Text;
            p.Straat = straatTb.Text;
            p.Huisnummer = int.Parse(huisnmrTb.Text);
            p.Postcode = postcodeTb.Text;
            p.Telefoonnummer = int.Parse(telefoonnmrTb.Text);
            p.Email = emailTb.Text;

            _personenLijst.Add(p);
            System.Windows.MessageBox.Show("Gebruiker" + p.Naam + "toegevoegd");
            _mw.ViewLoader();
        }
    }
}