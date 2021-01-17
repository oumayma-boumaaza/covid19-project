using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EtatCovid;

namespace InterfaceGraphique
{
    public partial class CentreDeVaccinationV : UserControl
    {
        List<Citoyen> citoyens;
        List<CentreDeVaccinationV> centreDeVaccinations;
        public CentreDeVaccinationV()
        {
            InitializeComponent();
            citoyens = LiasonDB.ListerCitoyens();
            CitoyenBox.DataSource = citoyens.Select(citoyen => citoyen.cin).ToList();
            CitoyenBox.SelectedIndex = -1;
            centreDeVaccinations = LiasonDB.ListerCentre();
            CentreBox.DataSource = centreDeVaccinations.Select(centreDeVaccinations => centreDeVaccinations.Name).ToList();
            CentreBox.SelectedIndex = -1;

        }
    }
}
