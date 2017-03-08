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
        private List<Dier> _dierenLijst;
        private MainWindow _mw;
        private Formtype _formtype;

        public enum Formtype
        {
            Edit,
            Create
        };

        public DierToevoegen(List<Dier> dierenLijst, MainWindow mw, Formtype cmd)
        {
            InitializeComponent();
            _dierenLijst = dierenLijst;
            _mw = mw;
            _formtype = cmd;
            ViewLoader();
        }

        private void opslaanBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_formtype == Formtype.Create)
            {
                Dier d = new Dier();
                d.Naam = naamTb.Text;
                //  d.GeboorteDatum = (DateTime)geboorteDatum.GetValue();
                d.DierType = Dier.dierType.Hond;
                //eigenaar
                _dierenLijst.Add(d);
                System.Windows.MessageBox.Show("Dier toegevoegd");
            }
            else if (_formtype == Formtype.Edit)
            {
            }

            _mw.ViewLoader();
        }

        public void ViewLoader()
        {
            foreach (Dier.dierType t in Enum.GetValues(typeof(Dier.dierType)))
            {
                dierSoortCb.Items.Add(t);
            }

            foreach (Persoon p in _mw.Personenlijst)
            {
                vorigeEigenaarCb.Items.Add(p.Achternaam);
            }
        }
    }
}