using EtatCovid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InterfaceGraphique
{
    public partial class LaboV : UserControl
    {
        List<Citoyen> citoyens;
        List<Labo> labos;
        public LaboV()
        {
            InitializeComponent();
            citoyens = LiasonDB.ListerCitoyens();
            citoyenBox.DataSource = citoyens.Select(citoyen => citoyen.cin).ToList();
            citoyenBox.SelectedIndex = -1;
            labos = LiasonDB.ListerLabo();
            LaboBox.DataSource = labos.Select(labos => labos.nom).ToList();
            LaboBox.SelectedIndex = -1;
        }

        private void testerbtn_Click(object sender, EventArgs e)
        {
            string selectedCit = (string)citoyenBox.SelectedItem;
            string selectedLabo = (string)LaboBox.SelectedItem;
            if (selectedCit == null)
            {
                MessageBox.Show("Choisissez un citoyen", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selectedLabo == null)
            {
                MessageBox.Show("Choisissez un laboratoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var citoyen = citoyens.First(c => c.cin == selectedCit);
                var labo = labos.First(l => l.nom == selectedLabo);
  
                if (labo.TesterLeCitoyen(citoyen))
                {
                    MessageBox.Show("Le Test est Postif", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Le Test est negatif", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
    }
}
