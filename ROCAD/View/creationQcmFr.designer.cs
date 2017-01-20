namespace ROCAD.View
{
    partial class creationQcmFr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creationQcmFr));
            this.windowTitleLabel = new System.Windows.Forms.Label();
            this.nomEnseignantLabel = new System.Windows.Forms.Label();
            this.nomEnseignantTextBox = new System.Windows.Forms.TextBox();
            this.titreQcmLabel = new System.Windows.Forms.Label();
            this.nomMatiereLabel = new System.Windows.Forms.Label();
            this.nbQuestionsLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.dureeTextBox = new System.Windows.Forms.TextBox();
            this.titreQcmTextBox = new System.Windows.Forms.TextBox();
            this.nomMatiereTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dureeLabel = new System.Windows.Forms.Label();
            this.validerCreaQcmButton = new System.Windows.Forms.Button();
            this.nbQuestionsUpDown = new System.Windows.Forms.NumericUpDown();
            this.progressBarCreaQcm = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nbEtudiants = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuestionsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbEtudiants)).BeginInit();
            this.SuspendLayout();
            // 
            // windowTitleLabel
            // 
            this.windowTitleLabel.AutoSize = true;
            this.windowTitleLabel.Location = new System.Drawing.Point(425, 30);
            this.windowTitleLabel.Name = "windowTitleLabel";
            this.windowTitleLabel.Size = new System.Drawing.Size(88, 13);
            this.windowTitleLabel.TabIndex = 35;
            this.windowTitleLabel.Text = "Création de QCM";
            this.windowTitleLabel.Click += new System.EventHandler(this.windowTitleLabel_Click);
            // 
            // nomEnseignantLabel
            // 
            this.nomEnseignantLabel.AutoSize = true;
            this.nomEnseignantLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nomEnseignantLabel.Location = new System.Drawing.Point(184, 91);
            this.nomEnseignantLabel.Name = "nomEnseignantLabel";
            this.nomEnseignantLabel.Size = new System.Drawing.Size(103, 13);
            this.nomEnseignantLabel.TabIndex = 36;
            this.nomEnseignantLabel.Text = "Nom de l\'enseignant";
            // 
            // nomEnseignantTextBox
            // 
            this.nomEnseignantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomEnseignantTextBox.Location = new System.Drawing.Point(341, 89);
            this.nomEnseignantTextBox.Name = "nomEnseignantTextBox";
            this.nomEnseignantTextBox.Size = new System.Drawing.Size(271, 20);
            this.nomEnseignantTextBox.TabIndex = 37;
            this.nomEnseignantTextBox.TextChanged += new System.EventHandler(this.NomEnseignant_TextChanged);
            // 
            // titreQcmLabel
            // 
            this.titreQcmLabel.AutoSize = true;
            this.titreQcmLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.titreQcmLabel.Location = new System.Drawing.Point(184, 132);
            this.titreQcmLabel.Name = "titreQcmLabel";
            this.titreQcmLabel.Size = new System.Drawing.Size(70, 13);
            this.titreQcmLabel.TabIndex = 40;
            this.titreQcmLabel.Text = "Titre du QCM";
            // 
            // nomMatiereLabel
            // 
            this.nomMatiereLabel.AutoSize = true;
            this.nomMatiereLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nomMatiereLabel.Location = new System.Drawing.Point(184, 175);
            this.nomMatiereLabel.Name = "nomMatiereLabel";
            this.nomMatiereLabel.Size = new System.Drawing.Size(92, 13);
            this.nomMatiereLabel.TabIndex = 52;
            this.nomMatiereLabel.Text = "Nom de la matière";
            // 
            // nbQuestionsLabel
            // 
            this.nbQuestionsLabel.AutoSize = true;
            this.nbQuestionsLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nbQuestionsLabel.Location = new System.Drawing.Point(184, 218);
            this.nbQuestionsLabel.Name = "nbQuestionsLabel";
            this.nbQuestionsLabel.Size = new System.Drawing.Size(107, 13);
            this.nbQuestionsLabel.TabIndex = 56;
            this.nbQuestionsLabel.Text = "Nombre de questions";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTextBox.Location = new System.Drawing.Point(341, 261);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(271, 20);
            this.dateTextBox.TabIndex = 61;
            this.dateTextBox.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // dureeTextBox
            // 
            this.dureeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dureeTextBox.Location = new System.Drawing.Point(341, 304);
            this.dureeTextBox.Name = "dureeTextBox";
            this.dureeTextBox.Size = new System.Drawing.Size(271, 20);
            this.dureeTextBox.TabIndex = 65;
            this.dureeTextBox.TextChanged += new System.EventHandler(this.Duree_TextChanged);
            // 
            // titreQcmTextBox
            // 
            this.titreQcmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titreQcmTextBox.Location = new System.Drawing.Point(341, 132);
            this.titreQcmTextBox.Name = "titreQcmTextBox";
            this.titreQcmTextBox.Size = new System.Drawing.Size(271, 20);
            this.titreQcmTextBox.TabIndex = 49;
            this.titreQcmTextBox.TextChanged += new System.EventHandler(this.TitreQCM_TextChanged);
            // 
            // nomMatiereTextBox
            // 
            this.nomMatiereTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomMatiereTextBox.Location = new System.Drawing.Point(341, 175);
            this.nomMatiereTextBox.Name = "nomMatiereTextBox";
            this.nomMatiereTextBox.Size = new System.Drawing.Size(271, 20);
            this.nomMatiereTextBox.TabIndex = 53;
            this.nomMatiereTextBox.TextChanged += new System.EventHandler(this.NomMatiere_TextChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dateLabel.Location = new System.Drawing.Point(184, 261);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 60;
            this.dateLabel.Text = "Date";
            // 
            // dureeLabel
            // 
            this.dureeLabel.AutoSize = true;
            this.dureeLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dureeLabel.Location = new System.Drawing.Point(184, 304);
            this.dureeLabel.Name = "dureeLabel";
            this.dureeLabel.Size = new System.Drawing.Size(36, 13);
            this.dureeLabel.TabIndex = 64;
            this.dureeLabel.Text = "Durée";
            // 
            // validerCreaQcmButton
            // 
            this.validerCreaQcmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validerCreaQcmButton.Location = new System.Drawing.Point(414, 366);
            this.validerCreaQcmButton.Name = "validerCreaQcmButton";
            this.validerCreaQcmButton.Size = new System.Drawing.Size(99, 35);
            this.validerCreaQcmButton.TabIndex = 70;
            this.validerCreaQcmButton.Text = "Suivant";
            this.validerCreaQcmButton.UseVisualStyleBackColor = false;
            this.validerCreaQcmButton.Click += new System.EventHandler(this.validerCreaQcmButton_Click);
            // 
            // nbQuestionsUpDown
            // 
            this.nbQuestionsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nbQuestionsUpDown.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nbQuestionsUpDown.Location = new System.Drawing.Point(344, 221);
            this.nbQuestionsUpDown.Name = "nbQuestionsUpDown";
            this.nbQuestionsUpDown.Size = new System.Drawing.Size(268, 16);
            this.nbQuestionsUpDown.TabIndex = 71;
            this.nbQuestionsUpDown.ValueChanged += new System.EventHandler(this.NBQuestions_ValueChanged);
            // 
            // progressBarCreaQcm
            // 
            this.progressBarCreaQcm.Location = new System.Drawing.Point(124, 407);
            this.progressBarCreaQcm.Name = "progressBarCreaQcm";
            this.progressBarCreaQcm.Size = new System.Drawing.Size(644, 23);
            this.progressBarCreaQcm.TabIndex = 72;
            this.progressBarCreaQcm.Value = 50;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(519, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 73;
            this.button1.Text = "Suivant";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(184, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nombre d\'étudiants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nbEtudiants
            // 
            this.nbEtudiants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nbEtudiants.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nbEtudiants.Location = new System.Drawing.Point(341, 339);
            this.nbEtudiants.Name = "nbEtudiants";
            this.nbEtudiants.Size = new System.Drawing.Size(268, 16);
            this.nbEtudiants.TabIndex = 75;
            // 
            // creationQcmFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 483);
            this.Controls.Add(this.nbEtudiants);
            this.Controls.Add(this.label1);
         //   this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBarCreaQcm);
            this.Controls.Add(this.nbQuestionsUpDown);
            this.Controls.Add(this.validerCreaQcmButton);
            this.Controls.Add(this.dureeTextBox);
            this.Controls.Add(this.dureeLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nbQuestionsLabel);
            this.Controls.Add(this.nomMatiereTextBox);
            this.Controls.Add(this.nomMatiereLabel);
            this.Controls.Add(this.titreQcmTextBox);
            this.Controls.Add(this.titreQcmLabel);
            this.Controls.Add(this.nomEnseignantTextBox);
            this.Controls.Add(this.nomEnseignantLabel);
            this.Controls.Add(this.windowTitleLabel);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "creationQcmFr";
            this.Text = "Création de QCM (1/2)";
            this.Load += new System.EventHandler(this.creationQcmFr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbQuestionsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbEtudiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label windowTitleLabel;
        private System.Windows.Forms.Label dureeLabel;
        public System.Windows.Forms.TextBox dureeTextBox;
        public System.Windows.Forms.TextBox titreQcmTextBox;
        public System.Windows.Forms.TextBox nomMatiereTextBox;
        public System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.NumericUpDown nbQuestionsUpDown;
        public System.Windows.Forms.Label nomEnseignantLabel;
        public System.Windows.Forms.TextBox nomEnseignantTextBox;
        public System.Windows.Forms.Label titreQcmLabel;
        public System.Windows.Forms.Label nomMatiereLabel;
        public System.Windows.Forms.Label nbQuestionsLabel;
        public System.Windows.Forms.TextBox dateTextBox;
        public System.Windows.Forms.Button validerCreaQcmButton;
        public System.Windows.Forms.ProgressBar progressBarCreaQcm;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbEtudiants;
    }
}