namespace InterfaceGraphique
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.etats = new System.Windows.Forms.Button();
            this.Labo = new System.Windows.Forms.Button();
            this.centre = new System.Windows.Forms.Button();
            this.CITOYEN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DiagramV = new InterfaceGraphique.Diagram();
            this.TestV = new InterfaceGraphique.Labo();
            this.CentreV = new InterfaceGraphique.CentreDeVaccination();
            this.CitoyenV = new InterfaceGraphique.Citoyen();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.etats);
            this.panel1.Controls.Add(this.Labo);
            this.panel1.Controls.Add(this.centre);
            this.panel1.Controls.Add(this.CITOYEN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 590);
            this.panel1.TabIndex = 0;
            // 
            // etats
            // 
            this.etats.Font = new System.Drawing.Font("Lucida Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etats.Location = new System.Drawing.Point(12, 298);
            this.etats.Name = "etats";
            this.etats.Size = new System.Drawing.Size(103, 23);
            this.etats.TabIndex = 3;
            this.etats.Text = "ETATS";
            this.etats.UseVisualStyleBackColor = true;
            this.etats.Click += new System.EventHandler(this.etats_Click);
            // 
            // Labo
            // 
            this.Labo.Font = new System.Drawing.Font("Lucida Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labo.Location = new System.Drawing.Point(12, 172);
            this.Labo.Name = "Labo";
            this.Labo.Size = new System.Drawing.Size(103, 23);
            this.Labo.TabIndex = 2;
            this.Labo.Text = "LABO";
            this.Labo.UseVisualStyleBackColor = true;
            this.Labo.Click += new System.EventHandler(this.Labo_Click);
            // 
            // centre
            // 
            this.centre.Font = new System.Drawing.Font("Lucida Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centre.Location = new System.Drawing.Point(12, 237);
            this.centre.Name = "centre";
            this.centre.Size = new System.Drawing.Size(103, 23);
            this.centre.TabIndex = 1;
            this.centre.Text = "CENTRE";
            this.centre.UseVisualStyleBackColor = true;
            this.centre.Click += new System.EventHandler(this.centre_Click);
            // 
            // CITOYEN
            // 
            this.CITOYEN.Font = new System.Drawing.Font("Lucida Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CITOYEN.Location = new System.Drawing.Point(12, 109);
            this.CITOYEN.Name = "CITOYEN";
            this.CITOYEN.Size = new System.Drawing.Size(103, 23);
            this.CITOYEN.TabIndex = 0;
            this.CITOYEN.Text = "CITOYEN";
            this.CITOYEN.UseVisualStyleBackColor = true;
            this.CITOYEN.Click += new System.EventHandler(this.CITOYEN_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DiagramV);
            this.panel2.Controls.Add(this.TestV);
            this.panel2.Controls.Add(this.CentreV);
            this.panel2.Controls.Add(this.CitoyenV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(139, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 590);
            this.panel2.TabIndex = 1;
            // 
            // DiagramV
            // 
            this.DiagramV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiagramV.Location = new System.Drawing.Point(0, 0);
            this.DiagramV.Name = "DiagramV";
            this.DiagramV.Size = new System.Drawing.Size(728, 590);
            this.DiagramV.TabIndex = 3;
            this.DiagramV.Visible = false;
            // 
            // TestV
            // 
            this.TestV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestV.Location = new System.Drawing.Point(0, 0);
            this.TestV.Name = "TestV";
            this.TestV.Size = new System.Drawing.Size(728, 590);
            this.TestV.TabIndex = 2;
            this.TestV.Visible = false;
            // 
            // CentreV
            // 
            this.CentreV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentreV.Location = new System.Drawing.Point(0, 0);
            this.CentreV.Name = "CentreV";
            this.CentreV.Size = new System.Drawing.Size(728, 590);
            this.CentreV.TabIndex = 1;
            this.CentreV.Visible = false;
            // 
            // CitoyenV
            // 
            this.CitoyenV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CitoyenV.Location = new System.Drawing.Point(0, 0);
            this.CitoyenV.Name = "CitoyenV";
            this.CitoyenV.Size = new System.Drawing.Size(728, 590);
            this.CitoyenV.TabIndex = 0;
            this.CitoyenV.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button etats;
        private System.Windows.Forms.Button Labo;
        private System.Windows.Forms.Button centre;
        private System.Windows.Forms.Button CITOYEN;
        private System.Windows.Forms.Panel panel2;
        private Citoyen CitoyenV;
        private CentreDeVaccination CentreV;
        private Labo TestV;
        private Diagram DiagramV;
    }
}