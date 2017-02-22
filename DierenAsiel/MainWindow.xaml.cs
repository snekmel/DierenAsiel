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
using DierenAsiel.Models;

namespace DierenAsiel
{
    public partial class MainWindow : Window
    {
        private List<Persoon> _personenLijst;
        private List<Dier> _dierenLijst;

        public MainWindow()
        {
            InitializeComponent();
            _personenLijst = new List<Persoon>();
            _dierenLijst = new List<Dier>();
        }

        private void PersoonToevoegenBtn_Click(object sender, RoutedEventArgs e)
        {
            PersoonToevoegen s = new PersoonToevoegen(_personenLijst);
            s.Show();
        }

        private void DierToevoegenBtn_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}