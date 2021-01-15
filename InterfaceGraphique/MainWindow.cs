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
            NameV.Visible = false;
            HomeV.Visible = false;
            CentreV.Visible = false;
            TestV.Visible = false;
            DiagramV.Visible = false;
            CitoyenV.Visible = true;
        }

        private void Labo_Click(object sender, EventArgs e)
        {
            NameV.Visible = false;
            HomeV.Visible = false;
            CentreV.Visible = false;
            TestV.Visible = true;
            DiagramV.Visible = false;
            CitoyenV.Visible = false;
        }

        private void centre_Click(object sender, EventArgs e)
        {
            NameV.Visible = false;
            HomeV.Visible = false;
            CentreV.Visible = true;
            TestV.Visible = false;
            DiagramV.Visible = false;
            CitoyenV.Visible = false;
        }

        private void etats_Click(object sender, EventArgs e)
        {
            NameV.Visible = false;
            HomeV.Visible = false;
            CentreV.Visible = false;
            TestV.Visible = false;
            DiagramV.Visible = true;
            CitoyenV.Visible = false;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
