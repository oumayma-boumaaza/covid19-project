using EtatCovid;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace InterfaceGraphique
{
    public partial class DiagramV : UserControl
    {
        public DiagramV()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
                 new LineSeries
                {
                    Title = "Sains",
                    Values = new ChartValues<double> { SainData(3), SainData(4), SainData(5), SainData(6), SainData(7), SainData(8), SainData(9), SainData(10), SainData(11), SainData(12), SainData(1) },
                    PointGeometry = DefaultGeometries.Square,
                     Stroke = System.Windows.Media.Brushes.LimeGreen
                },
                new LineSeries
                {
                    Title = "Porteurs De Virus",
                    Values = new ChartValues<int> { InfectedData(3), InfectedData(4), InfectedData(5), InfectedData(6), InfectedData(7), InfectedData(8), InfectedData(9), InfectedData(10), InfectedData(11), InfectedData(12), InfectedData(1) },
                     PointGeometry = DefaultGeometries.Circle,
                     Stroke = System.Windows.Media.Brushes.Red
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Mois",
                Labels = new[] { "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Decembre", "Janvier" }
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "CAS",
                MinValue = 0
            });
            cartesianChart1.LegendLocation = LegendLocation.Top;

            //rapport

            CasV.Text = EnregistrementsVaccin.Vaccins.Count(c => c.DateVacc.ToShortDateString() == DateTime.Now.ToShortDateString()) + " Vaccins";
            CasS.Text = EnregistrementsEtat.Etats.Count( e => e.etat == Etat.Sain && e.DateEtat.ToShortDateString() == DateTime.Now.ToShortDateString()) + " Cas";
            CasI.Text = EnregistrementsEtat.Etats.Count( e => e.etat == Etat.PorteurDeVirus && e.DateEtat.ToShortDateString() == DateTime.Now.ToShortDateString()) + " Cas";
            NbrT.Text = EnregistrementLabo.Testes.Count( t => t.DateTest.ToShortDateString() == DateTime.Now.ToShortDateString()) + " Tests";
        }
        public int InfectedData(int month)
        {
            int counter = 0;
            for( int i = 0; i < EnregistrementsEtat.Etats.Count; i++)
                if (EnregistrementsEtat.Etats[i].etat == Etat.PorteurDeVirus 
                    && EnregistrementsEtat.Etats[i].DateEtat.Month == month)
                    counter++;
            return counter;
        }
        public int SainData(int month)
        {
            int counter = 0;
            for( int i = 0; i < EnregistrementsEtat.Etats.Count; i++)
                if (EnregistrementsEtat.Etats[i].etat == Etat.Sain 
                    && EnregistrementsEtat.Etats[i].DateEtat.Month == month)
                    counter++;
            return counter;
        }


    }



}

