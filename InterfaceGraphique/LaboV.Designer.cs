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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.testerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "TESTER UN CITOYEN";
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(103, 160);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(424, 38);
            this.comboBox.TabIndex = 2;
            this.comboBox.Text = "Selectionnez un Citoyen";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(424, 38);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Selectionnez un Laboratoire";
            // 
            // testerbtn
            // 
            this.testerbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.testerbtn.Font = new System.Drawing.Font("Nirmala UI", 23.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testerbtn.Location = new System.Drawing.Point(229, 335);
            this.testerbtn.Name = "testerbtn";
            this.testerbtn.Size = new System.Drawing.Size(130, 57);
            this.testerbtn.TabIndex = 4;
            this.testerbtn.Text = "Tester";
            this.testerbtn.UseVisualStyleBackColor = false;
            // 
            // Labo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(134)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.testerbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.Name = "Labo";
            this.Size = new System.Drawing.Size(629, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button testerbtn;
    }
}
