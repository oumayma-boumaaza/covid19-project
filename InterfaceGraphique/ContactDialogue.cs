using EtatCovid;
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
    public partial class ContactDialogue : Form
    {
        public static List<Citoyen> citoyens;
        public string resultat;
        public ContactDialogue()
        {
            InitializeComponent();
           
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
        }
        public void FillData(string first)
        {
            List<string> data = new List<string>();
            for (int i = 0; i < citoyens.Count; i++)
            {
                if (citoyens[i].cin != first)
                    data.Add(citoyens[i].cin);
            }
            citoyensBox.DataSource = null;
            citoyensBox.DataSource = data;

            citoyensBox.SelectedIndex = -1;
        }

        private void citoyensBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(citoyensBox.SelectedItem != null)
            {
                resultat = (string)citoyensBox.SelectedItem;
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
