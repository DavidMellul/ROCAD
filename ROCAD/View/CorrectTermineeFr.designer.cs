namespace ROCAD.View
{
    partial class CorrectTermineeFr
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
            this.label1 = new System.Windows.Forms.Label();
            this.OuvrirCorrection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correction terminée !";
            // 
            // OuvrirCorrection
            // 
            this.OuvrirCorrection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.OuvrirCorrection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.OuvrirCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OuvrirCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OuvrirCorrection.ForeColor = System.Drawing.Color.Linen;
            this.OuvrirCorrection.Location = new System.Drawing.Point(53, 64);
            this.OuvrirCorrection.Name = "OuvrirCorrection";
            this.OuvrirCorrection.Size = new System.Drawing.Size(136, 44);
            this.OuvrirCorrection.TabIndex = 91;
            this.OuvrirCorrection.Text = "Ouvrir la correction";
            this.OuvrirCorrection.UseVisualStyleBackColor = false;
            this.OuvrirCorrection.Click += new System.EventHandler(this.button1_Click);
            // 
            // CorrectTermineeFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(242, 142);
            this.Controls.Add(this.OuvrirCorrection);
            this.Controls.Add(this.label1);
            this.Name = "CorrectTermineeFr";
            this.Text = "R.O.C.A.D.E";
            this.Load += new System.EventHandler(this.CorrectTermineeFr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button OuvrirCorrection;
    }
}