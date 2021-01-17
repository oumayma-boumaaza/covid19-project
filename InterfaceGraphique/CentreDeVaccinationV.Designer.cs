namespace InterfaceGraphique
{
    partial class CentreDeVaccinationV
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
            this.CitoyenBox = new System.Windows.Forms.ComboBox();
            this.CentreBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "VACCIN";
            // 
            // CitoyenBox
            // 
            this.CitoyenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitoyenBox.FormattingEnabled = true;
            this.CitoyenBox.Location = new System.Drawing.Point(74, 121);
            this.CitoyenBox.Name = "CitoyenBox";
            this.CitoyenBox.Size = new System.Drawing.Size(477, 32);
            this.CitoyenBox.TabIndex = 3;
            this.CitoyenBox.Text = "Selectionnez un Citoyen";
            // 
            // CentreBox
            // 
            this.CentreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CentreBox.FormattingEnabled = true;
            this.CentreBox.Location = new System.Drawing.Point(74, 227);
            this.CentreBox.Name = "CentreBox";
            this.CentreBox.Size = new System.Drawing.Size(477, 32);
            this.CentreBox.TabIndex = 4;
            this.CentreBox.Text = "Selectionnez un Centre de Vaccination";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(237, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "VACCINER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CentreDeVaccinationV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(134)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CentreBox);
            this.Controls.Add(this.CitoyenBox);
            this.Controls.Add(this.label1);
            this.Name = "CentreDeVaccinationV";
            this.Size = new System.Drawing.Size(629, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CitoyenBox;
        private System.Windows.Forms.ComboBox CentreBox;
        private System.Windows.Forms.Button button1;
    }
}
