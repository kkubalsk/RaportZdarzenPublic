
namespace RaportZdarzen
{
    partial class FrmWybierzZdarzenie
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
            this.dataGridWybierzZdarzenie = new System.Windows.Forms.DataGridView();
            this.NrZdarzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdZdarzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uzytkownik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaObiektu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWybierzZdarzenie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWybierzZdarzenie
            // 
            this.dataGridWybierzZdarzenie.AllowUserToAddRows = false;
            this.dataGridWybierzZdarzenie.AllowUserToDeleteRows = false;
            this.dataGridWybierzZdarzenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWybierzZdarzenie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrZdarzenia,
            this.IdZdarzenia,
            this.Nazwa,
            this.Uzytkownik,
            this.NazwaObiektu,
            this.IdStatus});
            this.dataGridWybierzZdarzenie.Location = new System.Drawing.Point(22, 171);
            this.dataGridWybierzZdarzenie.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridWybierzZdarzenie.Name = "dataGridWybierzZdarzenie";
            this.dataGridWybierzZdarzenie.ReadOnly = true;
            this.dataGridWybierzZdarzenie.RowHeadersVisible = false;
            this.dataGridWybierzZdarzenie.RowHeadersWidth = 51;
            this.dataGridWybierzZdarzenie.RowTemplate.Height = 24;
            this.dataGridWybierzZdarzenie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWybierzZdarzenie.Size = new System.Drawing.Size(857, 261);
            this.dataGridWybierzZdarzenie.TabIndex = 0;
            this.dataGridWybierzZdarzenie.Click += new System.EventHandler(this.dataGridWybierzZdarzenie_Click);
            // 
            // NrZdarzenia
            // 
            this.NrZdarzenia.DataPropertyName = "NrZdarzenia";
            this.NrZdarzenia.HeaderText = "Nr Zdarzenia";
            this.NrZdarzenia.MinimumWidth = 6;
            this.NrZdarzenia.Name = "NrZdarzenia";
            this.NrZdarzenia.ReadOnly = true;
            this.NrZdarzenia.Width = 125;
            // 
            // IdZdarzenia
            // 
            this.IdZdarzenia.DataPropertyName = "IdZdarzenia";
            this.IdZdarzenia.HeaderText = "IdZdarzenia";
            this.IdZdarzenia.MinimumWidth = 6;
            this.IdZdarzenia.Name = "IdZdarzenia";
            this.IdZdarzenia.ReadOnly = true;
            this.IdZdarzenia.Visible = false;
            this.IdZdarzenia.Width = 125;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa Zdarzenia";
            this.Nazwa.MinimumWidth = 6;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // Uzytkownik
            // 
            this.Uzytkownik.DataPropertyName = "Uzytkownik";
            this.Uzytkownik.HeaderText = "Użytkownik";
            this.Uzytkownik.MinimumWidth = 6;
            this.Uzytkownik.Name = "Uzytkownik";
            this.Uzytkownik.ReadOnly = true;
            this.Uzytkownik.Width = 125;
            // 
            // NazwaObiektu
            // 
            this.NazwaObiektu.DataPropertyName = "NazwaObiektu";
            this.NazwaObiektu.HeaderText = "Nazwa obiektu";
            this.NazwaObiektu.MinimumWidth = 6;
            this.NazwaObiektu.Name = "NazwaObiektu";
            this.NazwaObiektu.ReadOnly = true;
            this.NazwaObiektu.Width = 125;
            // 
            // IdStatus
            // 
            this.IdStatus.DataPropertyName = "IdStatus";
            this.IdStatus.HeaderText = "Status Zdarzenia";
            this.IdStatus.Name = "IdStatus";
            this.IdStatus.ReadOnly = true;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(715, 478);
            this.btnZamknij.Margin = new System.Windows.Forms.Padding(2);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(164, 35);
            this.btnZamknij.TabIndex = 1;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(517, 478);
            this.btnEdytuj.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(164, 35);
            this.btnEdytuj.TabIndex = 2;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(316, 478);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(164, 35);
            this.btnUsun.TabIndex = 3;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Location = new System.Drawing.Point(265, 114);
            this.txtSzukaj.Margin = new System.Windows.Forms.Padding(2);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.Size = new System.Drawing.Size(396, 20);
            this.txtSzukaj.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szukana nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(294, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wybierz zdarzenie z listy";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(715, 99);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(164, 35);
            this.btnSzukaj.TabIndex = 7;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // FrmWybierzZdarzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 549);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSzukaj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.dataGridWybierzZdarzenie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmWybierzZdarzenie";
            this.Text = "Wybierz zdarzenie";
            this.Load += new System.EventHandler(this.FrmWybierzZdarzenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWybierzZdarzenie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridWybierzZdarzenie;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtSzukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrZdarzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZdarzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uzytkownik;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaObiektu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStatus;
    }
}