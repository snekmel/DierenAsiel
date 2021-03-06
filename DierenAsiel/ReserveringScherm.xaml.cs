﻿using System;
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
    /// Interaction logic for ReserveringScherm.xaml
    /// </summary>
    public partial class ReserveringScherm : Window
    {
        private MainWindow _mw;
        private Reservering _selectedReservering;

        public ReserveringScherm(MainWindow mw, Reservering r)
        {
            InitializeComponent();
            _mw = mw;
            _selectedReservering = r;

            ViewLoader();
        }

        private void ViewLoader()
        {
            //Vul de reserveringdata
            ophaaldatumDatepicker.SelectedDate = _selectedReservering.Ophaaldatum.Date;
            notitiesTb.Document.Blocks.Add(new Paragraph(new Run(_selectedReservering.Note)));

            if (_selectedReservering.IsOpgehaald)
            {
                cbJa.IsSelected = true;
            }
            else
            {
                cbNee.IsSelected = true;
            }

            //Vul de persoongroupbox
            naamLabel.Content = _selectedReservering.Persoon.Naam;
            achternaamLabel.Content = _selectedReservering.Persoon.Achternaam;
            straatLabel.Content = _selectedReservering.Persoon.Straat;
            postcodeLabel.Content = _selectedReservering.Persoon.Postcode;
            woonplaatsLabel.Content = _selectedReservering.Persoon.Woonplaats;
            telefoonNummerLabel.Content = _selectedReservering.Persoon.Telefoonnummer;
            emailLabel.Content = _selectedReservering.Persoon.Email;

            //Vul de dierengroupbox
            dierNaamLabel.Content = _selectedReservering.Dier.Naam;
            dierSoortLabel.Content = _selectedReservering.Dier.GetType().Name;
            dierGebDatumLabel.Content = _selectedReservering.Dier.GeboorteDatum.ToString();
            dierGeslachtLabel.Content = _selectedReservering.Dier.DierGeslacht.ToString();
        }

        private void reserveringOpslaanButton_Click(object sender, RoutedEventArgs e)
        {
            _selectedReservering.Ophaaldatum = (DateTime)ophaaldatumDatepicker.SelectedDate;
            //Combobox
            if (cbJa.IsSelected)
            {
                _selectedReservering.IsOpgehaald = true;
            }
            if (cbNee.IsSelected)
            {
                _selectedReservering.IsOpgehaald = false;
            }
            TextRange allTextRange = new TextRange(notitiesTb.Document.ContentStart, notitiesTb.Document.ContentEnd);
            _selectedReservering.Note = allTextRange.Text;
            _mw.ViewLoader();

            System.Windows.MessageBox.Show("Opgeslagen");
        }
    }
}