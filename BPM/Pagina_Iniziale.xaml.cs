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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
namespace BPM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> bpm = new List<string>();

        private void btnRisultato_Click(object sender, RoutedEventArgs e)
        {
            txtSportivo.IsEnabled = true;
            txtMax.IsEnabled = true;
            txtCalorie.IsEnabled = true;
            txtrisultato.IsEnabled = true;
            string name = txtNome.Text;
            string surname = txtCognome.Text;
            int anni = int.Parse(txtAnni.Text);
            int minuti = int.Parse(txtOre.Text);
            int kg = int.Parse(txtKg.Text);
            int max = CardioLibrary.calcolicuore.Cardio(anni);
            txtMax.Text = max.ToString();
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardioGym(max);
            txtSportivo.Text = frequenza.ToString();
            int bpmriposo = int.Parse(txtriposo.Text);
            string bpmrisultato = CardioLibrary.calcolicuore.Battito(bpmriposo);
            string sesso = "";
            string Kcal = "";
            if (M.IsChecked == true)
            {
                sesso = $"nato";
                double calorie = CardioLibrary.calcolicuore.ConsumoCalorieUomo(kg, max, anni, minuti);
                txtCalorie.Text = calorie.ToString();
                Kcal = $"{calorie}";
            }
            else if (F.IsChecked == true)
            {
                sesso = "nata";
                double calorie = CardioLibrary.calcolicuore.ConsumoCalorieDonna(kg, max, anni, minuti);
                txtCalorie.Text = calorie.ToString();
                Kcal = $"{calorie}";
            }


            lblRisultato.Content = ($"{name} {surname}, {sesso} il {anni}. Si allena {minuti} per il suo peso corporiro di:{kg}, i bpm masimo è {max} per un allenamento efficace deve avere i battiti a {frequenza},i tuoi battiti a riposo sono {bpmriposo} qundi sei {bpmrisultato},le calorie bruciate sono {Kcal} Kcal");
            bpm.Add($"{surname};{name}; {sesso};{anni};{kg};{minuti};{max};{frequenza};{bpmriposo};{bpmrisultato};{Kcal}");
        }

        private void btnNuovo_Click(object sender, RoutedEventArgs e)
        {
            txtNome.Clear();
            txtCognome.Clear();
            txtAnni.Clear();
            txtCalorie.Clear();
            txtKg.Clear();
            txtMax.Clear();
            txtOre.Clear();
            txtSportivo.Clear();
            M.IsChecked = null;
            F.IsChecked = null;
            txtSportivo.IsEnabled = false;
            txtMax.IsEnabled = false;
            txtCalorie.IsEnabled = false;
            txtrisultato.IsEnabled = false;
            txtrisultato.Clear();
            txtriposo.Clear();

        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.office.com/launch/excel?ui=it-IT&rs=IT&auth=1");
            bpm.Sort();
            using (StreamWriter w = new StreamWriter("Bpm.csv", false, Encoding.UTF8))
            {
                w.WriteLine("cognome;nome;sesso;anni;kg;minuti;max;sportivo;bpm riposo;bpm risultato;calorie");
                foreach (string lblRisultato in bpm)

                {
                    w.WriteLine(lblRisultato);
                }
                w.Flush();
                w.Close();


            }

        }

    }

}