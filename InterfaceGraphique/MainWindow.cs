using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceGraphique
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void CITOYEN_Click(object sender, EventArgs e)
        {
            CentreV.Hide();
            TestV.Hide();
            DiagramV.Hide();
            CitoyenV.Show();
        }

        private void Labo_Click(object sender, EventArgs e)
        {
            CentreV.Hide();
            TestV.Show();
            DiagramV.Hide();
            CitoyenV.Hide();
        }

        private void centre_Click(object sender, EventArgs e)
        {
            CentreV.Show();
            TestV.Hide();
            DiagramV.Hide();
            CitoyenV.Hide();
        }

        private void etats_Click(object sender, EventArgs e)
        {
            CentreV.Hide();
            TestV.Hide();
            DiagramV.Show();
            CitoyenV.Hide();
        }
    }
}
