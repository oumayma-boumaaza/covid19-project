namespace InterfaceGraphique
{
    partial class CitoyenV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.citoyensBox = new System.Windows.Forms.ComboBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.etat = new System.Windows.Forms.Label();
            this.Boxprenom = new System.Windows.Forms.TextBox();
            this.dateNaissance = new System.Windows.Forms.TextBox();
            this.boxetat = new System.Windows.Forms.TextBox();
            this.img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CITOYEN";
            // 
            // citoyensBox
            // 
            this.citoyensBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citoyensBox.FormattingEnabled = true;
            this.citoyensBox.Location = new System.Drawing.Point(89, 100);
            this.citoyensBox.Name = "citoyensBox";
            this.citoyensBox.Size = new System.Drawing.Size(439, 28);
            this.citoyensBox.TabIndex = 1;
            this.citoyensBox.Text = "Selectionez un Citoyen";
            this.citoyensBox.SelectedIndexChanged += new System.EventHandler(this.citoyensBox_SelectedIndexChanged);
            // 
            // nom
            // 
            this.nom.Enabled = false;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(309, 174);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(219, 23);
            this.nom.TabIndex = 2;
            this.nom.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOM: ";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(84, 227);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(103, 25);
            this.prenom.TabIndex = 4;
            this.prenom.Text = "PRENOM: ";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(84, 281);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(209, 25);
            this.date.TabIndex = 5;
            this.date.Text = "DATE DE NAISSANCE: ";
            // 
            // etat
            // 
            this.etat.AutoSize = true;
            this.etat.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etat.Location = new System.Drawing.Point(84, 338);
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(65, 25);
            this.etat.TabIndex = 6;
            this.etat.Text = "ETAT: ";
            // 
            // Boxprenom
            // 
            this.Boxprenom.Enabled = false;
            this.Boxprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boxprenom.Location = new System.Drawing.Point(309, 227);
            this.Boxprenom.Name = "Boxprenom";
            this.Boxprenom.Size = new System.Drawing.Size(219, 23);
            this.Boxprenom.TabIndex = 7;
            this.Boxprenom.Text = "prenom";
            // 
            // dateNaissance
            // 
            this.dateNaissance.Enabled = false;
            this.dateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNaissance.Location = new System.Drawing.Point(309, 281);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(219, 23);
            this.dateNaissance.TabIndex = 8;
            this.dateNaissance.Text = "date de naissance";
            // 
            // boxetat
            // 
            this.boxetat.Enabled = false;
            this.boxetat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxetat.Location = new System.Drawing.Point(309, 338);
            this.boxetat.Name = "boxetat";
            this.boxetat.Size = new System.Drawing.Size(219, 23);
            this.boxetat.TabIndex = 10;
            this.boxetat.Text = "etat";
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(309, 390);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(219, 126);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 11;
            this.img.TabStop = false;
            // 
            // CitoyenV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(134)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.img);
            this.Controls.Add(this.boxetat);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.Boxprenom);
            this.Controls.Add(this.etat);
            this.Controls.Add(this.date);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.citoyensBox);
            this.Controls.Add(this.label1);
            this.Name = "CitoyenV";
            this.Size = new System.Drawing.Size(629, 528);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox citoyensBox;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label etat;
        private System.Windows.Forms.TextBox Boxprenom;
        private System.Windows.Forms.TextBox dateNaissance;
        private System.Windows.Forms.TextBox boxetat;
        private System.Windows.Forms.PictureBox img;
    }
}
