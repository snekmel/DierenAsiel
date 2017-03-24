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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DierenAsiel.Dal;
using DierenAsiel.Models;

namespace DierenAsiel
{
    public partial class MainWindow : Window
    {

        private Models.DierenAsiel _dierenAsiel = new Models.DierenAsiel();

        public Models.DierenAsiel DierenAsiel
        {
            get { return _dierenAsiel; }
            set { _dierenAsiel = value; }
        }


        public MainWindow()
        {
            InitializeComponent();
            datepicker.SelectedDate = DateTime.Today.Date;        

            //----------------------------DAL
            DierMemoryContext dmc = new DierMemoryContext();
            DierRepository dr = new DierRepository(dmc);

            foreach (var dier in dr.GetAllDieren())
            {
                _dierenAsiel.DierToevoegen(dier);
            }
            //----------------------------
            
            ViewLoader();
        }

        private void PersoonToevoegenBtn_Click(object sender, RoutedEventArgs e)
        {
            PersoonToevoegen s = new PersoonToevoegen(this, DierenAsiel);
            s.Show();
        }

        private void DierToevoegenBtn_Click(object sender, RoutedEventArgs e)
        {
            DierToevoegen s = new DierToevoegen(DierenAsiel, this, DierToevoegen.Formtype.Create);
            s.Show();
        }

        public void ViewLoader()
        {
            //Leeg de listviews
            ReserveringListview.Items.Clear();
            personenListview.Items.Clear();
            dierenListview.Items.Clear();

            //Vul de personenlistview
            /*
            foreach (Persoon p in dierenAsiel.Personen)
            {
                personenListview.Items.Add(p);
            }
            */
            //Vul de dierenlistview
         
            foreach (Dier d in _dierenAsiel.Dieren)
            {
                dierenListview.Items.Add(d);
            }

            //Vul de reserveringen
            foreach (Reservering r in _dierenAsiel.Reserveringen)
            {
                if (r.Ophaaldatum == datepicker.SelectedDate)
                {
                    ReserveringListview.Items.Add(r);
                }
            }
          
        }

        public void TestData()
        {
            Persoon p = new Persoon();
            p.Naam = "Naam";
            p.Achternaam = "achternaam";
            p.Woonplaats = "Eindhoven";
            p.Straat = "Straat";
            p.Huisnummer = 10;
            p.Telefoonnummer = "0634810013";
            DierenAsiel.PersoonToevoegen(p);

    
        }

        private void reserveerBtnClick(object sender, RoutedEventArgs e)
        {
            //Haal geselecteerde objecten op
            Persoon p = (Persoon)personenListview.SelectedItem;
            Dier d = (Dier)dierenListview.SelectedItem;

            //Maak reservering aan en voeg toe aan de lijst
            Reservering r = new Reservering();
            r.Dier = d;
            r.Persoon = p;
            r.Reserveerdatum = DateTime.Now.Date;
            TextRange allTextRange = new TextRange(notitieTextbox.Document.ContentStart, notitieTextbox.Document.ContentEnd);
            r.Note = allTextRange.Text;
            r.Ophaaldatum = reserveringDatum.SelectedDate.Value;
            DierenAsiel.ReserveringToevoegen(r);
            ViewLoader();
        }

        private void datepicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewLoader();
        }

        private void beheerschermBtn_Click(object sender, RoutedEventArgs e)
        {
            Dashboard db = new Dashboard(DierenAsiel, this);
            db.Show();
        }

        private void ReserveringListview_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Reservering r = (Reservering)ReserveringListview.SelectedItem;

            if (r != null)
            {
                ReserveringScherm s = new ReserveringScherm(this, r);
                s.Show();
            }
        }
    }
}