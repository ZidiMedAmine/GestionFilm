namespace gestionFilm
{
    partial class ModiferFilm
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
            this.NomtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RealisateurtextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.modifer = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.retour = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom Film:";
            // 
            // NomtextBox
            // 
            this.NomtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomtextBox.Location = new System.Drawing.Point(32, 72);
            this.NomtextBox.Name = "NomtextBox";
            this.NomtextBox.Size = new System.Drawing.Size(231, 26);
            this.NomtextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Realisateur:";
            // 
            // RealisateurtextBox
            // 
            this.RealisateurtextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.RealisateurtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealisateurtextBox.Location = new System.Drawing.Point(32, 160);
            this.RealisateurtextBox.Name = "RealisateurtextBox";
            this.RealisateurtextBox.Size = new System.Drawing.Size(231, 26);
            this.RealisateurtextBox.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(32, 224);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(231, 26);
            this.dateTimePicker.TabIndex = 8;
            // 
            // modifer
            // 
            this.modifer.AutoSize = true;
            this.modifer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifer.Location = new System.Drawing.Point(56, 284);
            this.modifer.Name = "modifer";
            this.modifer.Size = new System.Drawing.Size(75, 30);
            this.modifer.TabIndex = 9;
            this.modifer.Text = "Modifer";
            this.modifer.UseVisualStyleBackColor = true;
            this.modifer.Click += new System.EventHandler(this.modifer_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(158, 291);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(105, 21);
            this.comboBox.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(330, 35);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(350, 215);
            this.dataGridView.TabIndex = 11;
            // 
            // retour
            // 
            this.retour.AutoSize = true;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(429, 284);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 30);
            this.retour.TabIndex = 12;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // fermer
            // 
            this.fermer.AutoSize = true;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(579, 284);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 30);
            this.fermer.TabIndex = 13;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // ModiferFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.modifer);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.RealisateurtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomtextBox);
            this.Controls.Add(this.label2);
            this.Name = "ModiferFilm";
            this.Text = "ModiferFilm";
            this.Load += new System.EventHandler(this.ModiferFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RealisateurtextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button modifer;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button fermer;
    }
}