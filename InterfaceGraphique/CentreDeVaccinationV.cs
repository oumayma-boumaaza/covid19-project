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
        List<CentreDeVaccination> centreDeVaccinations;
        public CentreDeVaccinationV()
        {
            InitializeComponent();
            citoyens = LiasonDB.ListerCitoyens();
            CitoyenBox.DataSource = citoyens.Select(citoyen => citoyen.cin).ToList();
            CitoyenBox.SelectedIndex = -1;
            centreDeVaccinations = LiasonDB.ListerCentre();
            CentreBox.DataSource = centreDeVaccinations.Select(centreDeVaccinations => centreDeVaccinations.nomCentre).ToList();
            CentreBox.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCitoyen = (string) CitoyenBox.SelectedItem;
            if( selectedCitoyen == null)
            {
                MessageBox.Show("choisissez un citoyen !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedCentre = (string) CentreBox.SelectedItem;
            if ( selectedCentre == null )
            {
                MessageBox.Show("choisissez un centre !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var citoyen = citoyens.First(c => c.cin == selectedCitoyen);
            var centre = centreDeVaccinations.First(c => c.nomCentre == selectedCentre);
            if(citoyen.Etat == Etat.Vaccine)
            {
                MessageBox.Show("Le Citoyen est déja vacciné!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            centre.Vacciner(citoyen);
            MessageBox.Show("Le Citoyen a été  bien  vacciné!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
