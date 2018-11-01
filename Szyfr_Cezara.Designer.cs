namespace SzyfrCezara
{
    partial class Szyfr_Cezara
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Odszyfruj = new System.Windows.Forms.Button();
            this.Zakodowany = new System.Windows.Forms.TextBox();
            this.Normalny = new System.Windows.Forms.TextBox();
            this.Przesunięcie = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Przesunięcie)).BeginInit();
            this.SuspendLayout();
            // 
            // Odszyfruj
            // 
            this.Odszyfruj.Location = new System.Drawing.Point(166, 119);
            this.Odszyfruj.Name = "Odszyfruj";
            this.Odszyfruj.Size = new System.Drawing.Size(113, 58);
            this.Odszyfruj.TabIndex = 0;
            this.Odszyfruj.Text = "ODSZYFRUJ";
            this.Odszyfruj.UseVisualStyleBackColor = true;
            this.Odszyfruj.Click += new System.EventHandler(this.Odszyfruj_Click);
            // 
            // Zakodowany
            // 
            this.Zakodowany.Location = new System.Drawing.Point(32, 26);
            this.Zakodowany.Multiline = true;
            this.Zakodowany.Name = "Zakodowany";
            this.Zakodowany.Size = new System.Drawing.Size(247, 58);
            this.Zakodowany.TabIndex = 1;
            // 
            // Normalny
            // 
            this.Normalny.Location = new System.Drawing.Point(32, 212);
            this.Normalny.Multiline = true;
            this.Normalny.Name = "Normalny";
            this.Normalny.Size = new System.Drawing.Size(247, 58);
            this.Normalny.TabIndex = 2;
            // 
            // Przesunięcie
            // 
            this.Przesunięcie.Location = new System.Drawing.Point(32, 140);
            this.Przesunięcie.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Przesunięcie.Name = "Przesunięcie";
            this.Przesunięcie.Size = new System.Drawing.Size(120, 20);
            this.Przesunięcie.TabIndex = 3;
            // 
            // Szyfr_Cezara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 305);
            this.Controls.Add(this.Przesunięcie);
            this.Controls.Add(this.Normalny);
            this.Controls.Add(this.Zakodowany);
            this.Controls.Add(this.Odszyfruj);
            this.Name = "Szyfr_Cezara";
            this.Text = "Szyfr Cezara";
            ((System.ComponentModel.ISupportInitialize)(this.Przesunięcie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Odszyfruj;
        private System.Windows.Forms.TextBox Zakodowany;
        private System.Windows.Forms.TextBox Normalny;
        private System.Windows.Forms.NumericUpDown Przesunięcie;
    }
}

