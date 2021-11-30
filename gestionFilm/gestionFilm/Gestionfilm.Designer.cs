namespace gestionFilm
{
    partial class Gestionfilm
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
            this.ajouter = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.recherche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.PaleGreen;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(145, 45);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(100, 30);
            this.ajouter.TabIndex = 0;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.IndianRed;
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(145, 175);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(100, 30);
            this.supprimer.TabIndex = 1;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.DarkOrange;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Location = new System.Drawing.Point(145, 110);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(100, 30);
            this.modifier.TabIndex = 2;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // recherche
            // 
            this.recherche.BackColor = System.Drawing.Color.RoyalBlue;
            this.recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recherche.Location = new System.Drawing.Point(145, 240);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(100, 30);
            this.recherche.TabIndex = 3;
            this.recherche.Text = "Chercher";
            this.recherche.UseVisualStyleBackColor = false;
            this.recherche.Click += new System.EventHandler(this.recherche_Click);
            // 
            // Gestionfilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(389, 311);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.ajouter);
            this.Name = "Gestionfilm";
            this.Text = "Gestionfilm";
            this.Load += new System.EventHandler(this.Gestionfilm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button recherche;
    }
}