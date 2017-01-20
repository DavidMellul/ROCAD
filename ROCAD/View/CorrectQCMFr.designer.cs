namespace ROCAD.View
{
    partial class CorrectQCMFr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorrectQCMFr));
            this.label1 = new System.Windows.Forms.Label();
            this.NomCorrection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LancerCorrection = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.ParcourirQCM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(122, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correction QCM";
            // 
            // NomCorrection
            // 
            this.NomCorrection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.NomCorrection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NomCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomCorrection.Location = new System.Drawing.Point(166, 156);
            this.NomCorrection.Name = "NomCorrection";
            this.NomCorrection.Size = new System.Drawing.Size(209, 22);
            this.NomCorrection.TabIndex = 77;
            this.NomCorrection.TextChanged += new System.EventHandler(this.NomCorrection_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(21, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nom de la correction";
            // 
            // LancerCorrection
            // 
            this.LancerCorrection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.LancerCorrection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.LancerCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LancerCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancerCorrection.ForeColor = System.Drawing.Color.Linen;
            this.LancerCorrection.Location = new System.Drawing.Point(127, 212);
            this.LancerCorrection.Name = "LancerCorrection";
            this.LancerCorrection.Size = new System.Drawing.Size(150, 38);
            this.LancerCorrection.TabIndex = 90;
            this.LancerCorrection.Text = "Lancer la correction";
            this.LancerCorrection.UseVisualStyleBackColor = false;
            this.LancerCorrection.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 266);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(380, 23);
            this.progressBar1.TabIndex = 91;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 92;
            this.label3.Text = "Ouvrir un QCM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ParcourirQCM
            // 
            this.ParcourirQCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ParcourirQCM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ParcourirQCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParcourirQCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParcourirQCM.ForeColor = System.Drawing.Color.Linen;
            this.ParcourirQCM.Location = new System.Drawing.Point(166, 92);
            this.ParcourirQCM.Name = "ParcourirQCM";
            this.ParcourirQCM.Size = new System.Drawing.Size(96, 28);
            this.ParcourirQCM.TabIndex = 93;
            this.ParcourirQCM.Text = "Parcourir";
            this.ParcourirQCM.UseVisualStyleBackColor = false;
            this.ParcourirQCM.Click += new System.EventHandler(this.button2_Click);
            // 
            // CorrectQCMFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(404, 301);
            this.Controls.Add(this.ParcourirQCM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LancerCorrection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomCorrection);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CorrectQCMFr";
            this.Text = "R.O.C.A.D.E";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox NomCorrection;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button LancerCorrection;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button ParcourirQCM;
    }
}