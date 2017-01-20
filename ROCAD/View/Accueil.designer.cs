using System.Drawing;

namespace ROCAD.View
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.accueilPanel = new System.Windows.Forms.Panel();
            this.toggleButtonLabelS = new System.Windows.Forms.Label();
            this.toggleButtonTheme = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.correctQCM = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.creerQcmButton = new System.Windows.Forms.Button();
            this.pastProjectsPanel = new System.Windows.Forms.Panel();
            this.Projet2 = new System.Windows.Forms.Button();
            this.Projet1 = new System.Windows.Forms.Button();
            this.openQCM = new System.Windows.Forms.Button();
            this.accueilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButtonTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pastProjectsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accueilPanel
            // 
            this.accueilPanel.Controls.Add(this.toggleButtonLabelS);
            this.accueilPanel.Controls.Add(this.toggleButtonTheme);
            this.accueilPanel.Controls.Add(this.openQCM);
            this.accueilPanel.Controls.Add(this.pictureBox3);
            this.accueilPanel.Controls.Add(this.pictureBox2);
            this.accueilPanel.Controls.Add(this.pictureBox1);
            this.accueilPanel.Controls.Add(this.correctQCM);
            this.accueilPanel.Controls.Add(this.help);
            this.accueilPanel.Controls.Add(this.creerQcmButton);
            this.accueilPanel.Location = new System.Drawing.Point(265, 0);
            this.accueilPanel.Name = "accueilPanel";
            this.accueilPanel.Size = new System.Drawing.Size(634, 490);
            this.accueilPanel.TabIndex = 0;
            this.accueilPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.accueilPanel_Paint);
            // 
            // toggleButtonLabelS
            // 
            this.toggleButtonLabelS.AutoSize = true;
            this.toggleButtonLabelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButtonLabelS.Location = new System.Drawing.Point(454, 448);
            this.toggleButtonLabelS.Name = "toggleButtonLabelS";
            this.toggleButtonLabelS.Size = new System.Drawing.Size(103, 17);
            this.toggleButtonLabelS.TabIndex = 17;
            this.toggleButtonLabelS.Text = "Theme sombre";
            this.toggleButtonLabelS.Click += new System.EventHandler(this.toggleButtonLabelS_Click);
            // 
            // toggleButtonTheme
            // 
            this.toggleButtonTheme.Image = ((System.Drawing.Image)(resources.GetObject("toggleButtonTheme.Image")));
            this.toggleButtonTheme.Location = new System.Drawing.Point(563, 446);
            this.toggleButtonTheme.Name = "toggleButtonTheme";
            this.toggleButtonTheme.Size = new System.Drawing.Size(56, 25);
            this.toggleButtonTheme.TabIndex = 16;
            this.toggleButtonTheme.TabStop = false;
            this.toggleButtonTheme.Click += new System.EventHandler(this.toggleButtonTheme_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(71, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(486, 144);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 448);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 23);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 23);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // correctQCM
            // 
            this.correctQCM.BackColor = System.Drawing.Color.Transparent;
            this.correctQCM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.correctQCM.FlatAppearance.BorderSize = 0;
            this.correctQCM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.correctQCM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.correctQCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.correctQCM.Image = ((System.Drawing.Image)(resources.GetObject("correctQCM.Image")));
            this.correctQCM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.correctQCM.Location = new System.Drawing.Point(364, 256);
            this.correctQCM.Name = "correctQCM";
            this.correctQCM.Size = new System.Drawing.Size(194, 52);
            this.correctQCM.TabIndex = 11;
            this.correctQCM.UseVisualStyleBackColor = false;
            this.correctQCM.Click += new System.EventHandler(this.correctQCM_Click);
            this.correctQCM.MouseLeave += new System.EventHandler(this.correctQCM_MouseLeaver);
            this.correctQCM.MouseHover += new System.EventHandler(this.correctQCM_MouseOver);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(291, 354);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(195, 52);
            this.help.TabIndex = 9;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            this.help.MouseLeave += new System.EventHandler(this.help_MouseLeaver);
            this.help.MouseHover += new System.EventHandler(this.help_MouseOver);
            // 
            // creerQcmButton
            // 
            this.creerQcmButton.BackColor = System.Drawing.Color.Transparent;
            this.creerQcmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creerQcmButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.creerQcmButton.FlatAppearance.BorderSize = 0;
            this.creerQcmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.creerQcmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.creerQcmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creerQcmButton.Image = ((System.Drawing.Image)(resources.GetObject("creerQcmButton.Image")));
            this.creerQcmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.creerQcmButton.Location = new System.Drawing.Point(154, 256);
            this.creerQcmButton.Name = "creerQcmButton";
            this.creerQcmButton.Size = new System.Drawing.Size(195, 52);
            this.creerQcmButton.TabIndex = 5;
            this.creerQcmButton.UseVisualStyleBackColor = false;
            this.creerQcmButton.Click += new System.EventHandler(this.creerQcmButton_Click);
            this.creerQcmButton.MouseLeave += new System.EventHandler(this.creerQCM_MouseLeaver);
            this.creerQcmButton.MouseHover += new System.EventHandler(this.creerQCM_MouseOver);
            // 
            // pastProjectsPanel
            // 
            this.pastProjectsPanel.Controls.Add(this.Projet2);
            this.pastProjectsPanel.Controls.Add(this.Projet1);
            this.pastProjectsPanel.Location = new System.Drawing.Point(-28, 0);
            this.pastProjectsPanel.Name = "pastProjectsPanel";
            this.pastProjectsPanel.Size = new System.Drawing.Size(305, 490);
            this.pastProjectsPanel.TabIndex = 1;
            // 
            // Projet2
            // 
            this.Projet2.BackColor = System.Drawing.Color.Transparent;
            this.Projet2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Projet2.FlatAppearance.BorderSize = 0;
            this.Projet2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Projet2.Location = new System.Drawing.Point(0, 63);
            this.Projet2.Name = "Projet2";
            this.Projet2.Size = new System.Drawing.Size(295, 66);
            this.Projet2.TabIndex = 5;
            this.Projet2.UseVisualStyleBackColor = false;
            this.Projet2.Click += new System.EventHandler(this.Projet2_Click);
            // 
            // Projet1
            // 
            this.Projet1.BackColor = System.Drawing.Color.Transparent;
            this.Projet1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Projet1.FlatAppearance.BorderSize = 0;
            this.Projet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Projet1.Location = new System.Drawing.Point(0, 0);
            this.Projet1.Name = "Projet1";
            this.Projet1.Size = new System.Drawing.Size(295, 66);
            this.Projet1.TabIndex = 4;
            this.Projet1.UseVisualStyleBackColor = false;
            this.Projet1.Click += new System.EventHandler(this.Projet1_Click);
            // 
            // openQCM
            // 
            this.openQCM.BackColor = System.Drawing.Color.Transparent;
            this.openQCM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openQCM.FlatAppearance.BorderSize = 0;
            this.openQCM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openQCM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openQCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openQCM.Image = ((System.Drawing.Image)(resources.GetObject("openQCM.Image")));
            this.openQCM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openQCM.Location = new System.Drawing.Point(607, 12);
            this.openQCM.Name = "openQCM";
            this.openQCM.Size = new System.Drawing.Size(10, 10);
            this.openQCM.TabIndex = 8;
            this.openQCM.UseVisualStyleBackColor = false;
            this.openQCM.Click += new System.EventHandler(this.openQCM_Click);
            this.openQCM.MouseLeave += new System.EventHandler(this.openQCM_MouseLeaver);
            this.openQCM.MouseHover += new System.EventHandler(this.open_MouseOver);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 483);
            this.Controls.Add(this.accueilPanel);
            this.Controls.Add(this.pastProjectsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "R.O.C.A.D.E";
            this.Activated += new System.EventHandler(this.mainWindow_Activated);
            this.Deactivate += new System.EventHandler(this.mainWindow_Deactivate);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.accueilPanel.ResumeLayout(false);
            this.accueilPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButtonTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pastProjectsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel accueilPanel;
        public System.Windows.Forms.Button creerQcmButton;
        public System.Windows.Forms.Panel pastProjectsPanel;
        private System.Windows.Forms.Button correctQCM;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button Projet2;
        private System.Windows.Forms.Button Projet1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label toggleButtonLabelS;
        private System.Windows.Forms.PictureBox toggleButtonTheme;
        private System.Windows.Forms.Button openQCM;
    }
}

