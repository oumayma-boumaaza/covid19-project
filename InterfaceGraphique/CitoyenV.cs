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
using QRCoder;
using System.Windows.Media;
using System.IO;
using System.Windows.Media.Imaging;
using Color = System.Drawing.Color;

namespace InterfaceGraphique
{
    public partial class CitoyenV : UserControl
    {
        List<Citoyen> citoyens;

        public CitoyenV()
        {
            InitializeComponent();
            citoyens = LiasonDB.ListerCitoyens();
            citoyensBox.DataSource = citoyens.Select(citoyen => citoyen.cin).ToList();
            citoyensBox.SelectedIndex = -1;
        }

        private void citoyensBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string) citoyensBox.SelectedItem;


            if(selected != null)
            {
                Citoyen citoyen = citoyens.First(c => c.cin == selected);

                nom.Text = citoyen.last;
                Boxprenom.Text = citoyen.first;
                dateNaissance.Text = citoyen.dateDeNaissaance.ToShortDateString();
                string etatStr;
                switch (citoyen.Etat) {
                    case Etat.Inexplore:
                        etatStr = "Inexploré";
                        QRCode(citoyen.GetInformation(), Color.Black);
                        break;
                    case Etat.PorteurDeVirus:
                        etatStr = "Porteur De Virus";
                        QRCode(citoyen.GetInformation(), Color.Red);
                        break;
                    case Etat.Symptomatique:
                        etatStr = "Symptomatique";
                        QRCode(citoyen.GetInformation(), Color.OrangeRed);
                        break;
                    case Etat.Vaccine:
                        etatStr = "Vacciné";
                        QRCode(citoyen.GetInformation(), Color.LimeGreen);
                        break;
                    case Etat.Sain:
                        etatStr = "Sain";
                        QRCode(citoyen.GetInformation(), Color.Lime);
                        break;
                    default:
                        etatStr = string.Empty;
                        QRCode(string.Empty, Color.White);
                        break;
                }
                boxetat.Text = etatStr;

            }
            else
            {
                QRCode(string.Empty, Color.White);
                nom.Text = string.Empty;
                Boxprenom.Text = string.Empty;
                dateNaissance.Text = string.Empty;
                boxetat.Text = string.Empty;
            }
            }
        private void QRCode(string data, Color color)
        {
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.M);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap QRCodeImg = qRCode.GetGraphic(20, color, Color.White, true);
            img.Image = QRCodeImg;

        }


      
    }
}
