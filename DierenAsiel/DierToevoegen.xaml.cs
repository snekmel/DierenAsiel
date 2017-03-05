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

        public DierToevoegen(List<Dier> dierenLijst, MainWindow mw)
        {
            InitializeComponent();
            _dierenLijst = dierenLijst;
            _mw = mw;
            ViewLoader();
        }

        private void opslaanBtn_Click(object sender, RoutedEventArgs e)
        {
            Dier d = new Dier();
            d.Naam = naamTb.Text;
            //  d.GeboorteDatum = (DateTime)geboorteDatum.GetValue();
            d.DierType = Dier.dierType.Hond;
            //eigenaar
            _dierenLijst.Add(d);
            System.Windows.MessageBox.Show(_dierenLijst.Count + "");
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