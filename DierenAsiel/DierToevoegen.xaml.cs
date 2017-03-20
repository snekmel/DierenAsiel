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
    /// Interaction logic for DierToevoegen.xaml
    /// </summary>
    public partial class DierToevoegen : Window
    {
        private Models.DierenAsiel _dierenAsiel;
        private MainWindow _mw;
        private Formtype _formtype;

        public enum Formtype
        {
            Edit,
            Create
        };

        public DierToevoegen(Models.DierenAsiel da, MainWindow mw, Formtype cmd)
        {
            InitializeComponent();
            _dierenAsiel = da;
            _mw = mw;
            _formtype = cmd;
            ViewLoader();
        }

        private void opslaanBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_formtype == Formtype.Create)
            {
                var d = new Dog();
                d.Naam = naamTb.Text;
                //  d.GeboorteDatum = (DateTime)geboorteDatum.GetValue();

                //eigenaar
                _dierenAsiel.Dieren.Add(d);
                System.Windows.MessageBox.Show("Dier toegevoegd");
            }
            else if (_formtype == Formtype.Edit)
            {
            }

            _mw.ViewLoader();
        }

        public void ViewLoader()
        {
            dierSoortCb.Items.Add("Hond");
            dierSoortCb.Items.Add("Kat");

            foreach (Persoon p in _dierenAsiel.Personen)
            {
                vorigeEigenaarCb.Items.Add(p.Achternaam);
            }
        }
    }
}