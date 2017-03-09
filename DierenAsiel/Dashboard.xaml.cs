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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        private List<Dier> _dierenLijst;
        private List<Persoon> _personenLijst;
        private List<Reservering> _reserveringLijst;
        private MainWindow _mw;

        public Dashboard(List<Dier> dierenLijst, List<Persoon> personenLijst, List<Reservering> reserveringLijst, MainWindow mw)
        {
            InitializeComponent();

            _dierenLijst = dierenLijst;
            _personenLijst = personenLijst;
            _reserveringLijst = reserveringLijst;
            _mw = mw;

            ViewLoader();
        }

        private void naamfilterTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            personenListview.Items.Clear();

            if (naamfilterTb.Text != "")
            {
                foreach (Persoon p in _personenLijst)
                {
                    if (p.Naam.Contains(naamfilterTb.Text) || p.Achternaam.Contains(naamfilterTb.Text))
                    {
                        personenListview.Items.Add(p);
                    }
                }
            }
            else
            {
                foreach (Persoon p in _personenLijst)
                {
                    personenListview.Items.Add(p);
                }
            }
        }

        private void PersonenlistviewClick(object sender, MouseButtonEventArgs e)
        {
            Persoon p = (Persoon)personenListview.SelectedItem;
            PersoonToevoegen pscherm = new PersoonToevoegen(_personenLijst, _mw, p, this);
            pscherm.Show();
        }

        public void ViewLoader()
        {
            personenListview.Items.Clear();

            foreach (Persoon p in _personenLijst)
            {
                personenListview.Items.Add(p);
            }
        }
    }
}