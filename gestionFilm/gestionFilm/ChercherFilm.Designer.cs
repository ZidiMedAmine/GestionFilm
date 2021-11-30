namespace gestionFilm
{
    partial class ChercherFilm
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
            this.label2 = new System.Windows.Forms.Label();
            this.RecherchetextBox = new System.Windows.Forms.TextBox();
            this.chercher = new System.Windows.Forms.Button();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.RealisateurTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.retour = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom Film:";
            // 
            // RecherchetextBox
            // 
            this.RecherchetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecherchetextBox.Location = new System.Drawing.Point(109, 35);
            this.RecherchetextBox.Name = "RecherchetextBox";
            this.RecherchetextBox.Size = new System.Drawing.Size(165, 26);
            this.RecherchetextBox.TabIndex = 6;
            // 
            // chercher
            // 
            this.chercher.AutoSize = true;
            this.chercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chercher.Location = new System.Drawing.Point(299, 33);
            this.chercher.Name = "chercher";
            this.chercher.Size = new System.Drawing.Size(84, 30);
            this.chercher.TabIndex = 10;
            this.chercher.Text = "Chercher";
            this.chercher.UseVisualStyleBackColor = true;
            this.chercher.Click += new System.EventHandler(this.chercher_Click);
            // 
            // NomTextBox
            // 
            this.NomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTextBox.Location = new System.Drawing.Point(20, 100);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.ReadOnly = true;
            this.NomTextBox.Size = new System.Drawing.Size(171, 26);
            this.NomTextBox.TabIndex = 11;
            // 
            // RealisateurTextBox
            // 
            this.RealisateurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealisateurTextBox.Location = new System.Drawing.Point(20, 150);
            this.RealisateurTextBox.Name = "RealisateurTextBox";
            this.RealisateurTextBox.ReadOnly = true;
            this.RealisateurTextBox.Size = new System.Drawing.Size(171, 26);
            this.RealisateurTextBox.TabIndex = 12;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextBox.Location = new System.Drawing.Point(20, 200);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.ReadOnly = true;
            this.DateTextBox.Size = new System.Drawing.Size(171, 26);
            this.DateTextBox.TabIndex = 13;
            // 
            // retour
            // 
            this.retour.AutoSize = true;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(95, 246);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 30);
            this.retour.TabIndex = 14;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // fermer
            // 
            this.fermer.AutoSize = true;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(230, 246);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 30);
            this.fermer.TabIndex = 15;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // ChercherFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 301);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.RealisateurTextBox);
            this.Controls.Add(this.NomTextBox);
            this.Controls.Add(this.chercher);
            this.Controls.Add(this.RecherchetextBox);
            this.Controls.Add(this.label2);
            this.Name = "ChercherFilm";
            this.Text = "ChercherFilm";
            this.Load += new System.EventHandler(this.ChercherFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RecherchetextBox;
        private System.Windows.Forms.Button chercher;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.TextBox RealisateurTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button fermer;
    }
}