namespace InterfaceGraphique
{
    partial class LaboV
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
            this.citoyenBox = new System.Windows.Forms.ComboBox();
            this.LaboBox = new System.Windows.Forms.ComboBox();
            this.testerbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "TESTER UN CITOYEN";
            // 
            // citoyenBox
            // 
            this.citoyenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citoyenBox.FormattingEnabled = true;
            this.citoyenBox.Location = new System.Drawing.Point(168, 178);
            this.citoyenBox.Name = "citoyenBox";
            this.citoyenBox.Size = new System.Drawing.Size(424, 32);
            this.citoyenBox.TabIndex = 2;
            this.citoyenBox.Text = "Selectionnez un Citoyen";
            // 
            // LaboBox
            // 
            this.LaboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaboBox.FormattingEnabled = true;
            this.LaboBox.Location = new System.Drawing.Point(168, 288);
            this.LaboBox.Name = "LaboBox";
            this.LaboBox.Size = new System.Drawing.Size(424, 32);
            this.LaboBox.TabIndex = 3;
            this.LaboBox.Text = "Selectionnez un Laboratoire";
            // 
            // testerbtn
            // 
            this.testerbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.testerbtn.Font = new System.Drawing.Font("Nirmala UI", 23.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testerbtn.Location = new System.Drawing.Point(321, 373);
            this.testerbtn.Name = "testerbtn";
            this.testerbtn.Size = new System.Drawing.Size(130, 57);
            this.testerbtn.TabIndex = 4;
            this.testerbtn.Text = "Tester";
            this.testerbtn.UseVisualStyleBackColor = false;
            this.testerbtn.Click += new System.EventHandler(this.testerbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Choisissez Un Citoyen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choisissez Un Laboratoire:";
            // 
            // LaboV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(134)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.testerbtn);
            this.Controls.Add(this.LaboBox);
            this.Controls.Add(this.citoyenBox);
            this.Controls.Add(this.label1);
            this.Name = "LaboV";
            this.Size = new System.Drawing.Size(781, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox citoyenBox;
        private System.Windows.Forms.ComboBox LaboBox;
        private System.Windows.Forms.Button testerbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
