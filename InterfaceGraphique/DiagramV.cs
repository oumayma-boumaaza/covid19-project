using LiveCharts;
using LiveCharts.Wpf;
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
                    Values = new ChartValues<double> {6, 7, 3, 4, 6},
                    PointGeometry = DefaultGeometries.Square,
                     Stroke = System.Windows.Media.Brushes.LimeGreen

                },
                new LineSeries
                {
                    Title = "Infectés",
                    Values = new ChartValues<double> {4, 6, 5, 2, 7},
                     PointGeometry = DefaultGeometries.Circle,
                     Stroke = System.Windows.Media.Brushes.Red
                }

            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Mois",
                Labels = new[] { "Mars", "Avr", "Mai", "Juin", "Juil", "Aout", "Sept", "Oct", "Nov", "Dec", "Janv" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "CAS",
                //LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Top;

            //modifying the series collection will animate and update the chart


            //modifying any series values will also animate and update the chart



        }


    }



}

