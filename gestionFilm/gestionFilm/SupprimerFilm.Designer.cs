namespace gestionFilm
{
    partial class SupprimerFilm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.retour = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.suprimer = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(220, 35);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(350, 215);
            this.dataGridView.TabIndex = 12;
            // 
            // retour
            // 
            this.retour.AutoSize = true;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(319, 285);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 30);
            this.retour.TabIndex = 13;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // fermer
            // 
            this.fermer.AutoSize = true;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(469, 285);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 30);
            this.fermer.TabIndex = 14;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // suprimer
            // 
            this.suprimer.AutoSize = true;
            this.suprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suprimer.Location = new System.Drawing.Point(46, 285);
            this.suprimer.Name = "suprimer";
            this.suprimer.Size = new System.Drawing.Size(92, 30);
            this.suprimer.TabIndex = 15;
            this.suprimer.Text = "Supprimer";
            this.suprimer.UseVisualStyleBackColor = true;
            this.suprimer.Click += new System.EventHandler(this.suprimer_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(46, 108);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(105, 21);
            this.comboBox.TabIndex = 16;
            // 
            // SupprimerFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 361);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.suprimer);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.dataGridView);
            this.Name = "SupprimerFilm";
            this.Text = "SupprimerFilm";
            this.Load += new System.EventHandler(this.SupprimerFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button suprimer;
        private System.Windows.Forms.ComboBox comboBox;
    }
}