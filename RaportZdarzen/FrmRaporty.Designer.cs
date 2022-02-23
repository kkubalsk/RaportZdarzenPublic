
namespace RaportZdarzen
{
    partial class FrmRaporty
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
            this.dataGridViewRaporty = new System.Windows.Forms.DataGridView();
            this.IdZdarzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrZdarzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataZdarzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uzytkownik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaObiektu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxStatus = new System.Windows.Forms.CheckedListBox();
            this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxTypyZdarzen = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxObiekty = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.txtBoxNazwa = new System.Windows.Forms.TextBox();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnDoWorda = new System.Windows.Forms.Button();
            this.btnDoExcela = new System.Windows.Forms.Button();
            this.btnPokaz = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaporty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRaporty
            // 
            this.dataGridViewRaporty.AllowUserToAddRows = false;
            this.dataGridViewRaporty.AllowUserToDeleteRows = false;
            this.dataGridViewRaporty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaporty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdZdarzenia,
            this.NrZdarzenia,
            this.Nazwa,
            this.DataZdarzenia,
            this.Uzytkownik,
            this.NazwaObiektu});
            this.dataGridViewRaporty.Location = new System.Drawing.Point(33, 255);
            this.dataGridViewRaporty.Name = "dataGridViewRaporty";
            this.dataGridViewRaporty.ReadOnly = true;
            this.dataGridViewRaporty.RowHeadersVisible = false;
            this.dataGridViewRaporty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRaporty.Size = new System.Drawing.Size(1244, 260);
            this.dataGridViewRaporty.TabIndex = 0;
            this.dataGridViewRaporty.Click += new System.EventHandler(this.dataGridViewRaporty_Click);
            // 
            // IdZdarzenia
            // 
            this.IdZdarzenia.DataPropertyName = "IdZdarzenia";
            this.IdZdarzenia.HeaderText = "IdZdarzenia";
            this.IdZdarzenia.Name = "IdZdarzenia";
            this.IdZdarzenia.ReadOnly = true;
            this.IdZdarzenia.Visible = false;
            // 
            // NrZdarzenia
            // 
            this.NrZdarzenia.DataPropertyName = "NrZdarzenia";
            this.NrZdarzenia.HeaderText = "Nr zdarzenia";
            this.NrZdarzenia.Name = "NrZdarzenia";
            this.NrZdarzenia.ReadOnly = true;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa zdarzenia";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // DataZdarzenia
            // 
            this.DataZdarzenia.DataPropertyName = "DataZdarzenia";
            this.DataZdarzenia.HeaderText = "Data Zdarzenia";
            this.DataZdarzenia.Name = "DataZdarzenia";
            this.DataZdarzenia.ReadOnly = true;
            // 
            // Uzytkownik
            // 
            this.Uzytkownik.DataPropertyName = "Uzytkownik";
            this.Uzytkownik.HeaderText = "Użytkownik";
            this.Uzytkownik.Name = "Uzytkownik";
            this.Uzytkownik.ReadOnly = true;
            // 
            // NazwaObiektu
            // 
            this.NazwaObiektu.DataPropertyName = "NazwaObiektu";
            this.NazwaObiektu.FillWeight = 150F;
            this.NazwaObiektu.HeaderText = "Nazwa Obiektu";
            this.NazwaObiektu.Name = "NazwaObiektu";
            this.NazwaObiektu.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkedListBoxStatus);
            this.groupBox1.Controls.Add(this.dateTimePickerDo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerOd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkedListBoxTypyZdarzen);
            this.groupBox1.Controls.Add(this.checkedListBoxObiekty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSzukaj);
            this.groupBox1.Controls.Add(this.txtBoxNazwa);
            this.groupBox1.Location = new System.Drawing.Point(33, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1244, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz szczegóły dotyczące raportu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(569, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status zdarzenia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rodzje zdarzeń:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Obiekty:";
            // 
            // checkedListBoxStatus
            // 
            this.checkedListBoxStatus.FormattingEnabled = true;
            this.checkedListBoxStatus.Location = new System.Drawing.Point(572, 54);
            this.checkedListBoxStatus.Name = "checkedListBoxStatus";
            this.checkedListBoxStatus.Size = new System.Drawing.Size(236, 154);
            this.checkedListBoxStatus.TabIndex = 9;
            // 
            // dateTimePickerDo
            // 
            this.dateTimePickerDo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDo.Location = new System.Drawing.Point(1022, 83);
            this.dateTimePickerDo.Name = "dateTimePickerDo";
            this.dateTimePickerDo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(977, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Do:";
            // 
            // dateTimePickerOd
            // 
            this.dateTimePickerOd.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOd.Location = new System.Drawing.Point(1022, 33);
            this.dateTimePickerOd.Name = "dateTimePickerOd";
            this.dateTimePickerOd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zdarzenia od:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkedListBoxTypyZdarzen
            // 
            this.checkedListBoxTypyZdarzen.FormattingEnabled = true;
            this.checkedListBoxTypyZdarzen.Location = new System.Drawing.Point(299, 54);
            this.checkedListBoxTypyZdarzen.Name = "checkedListBoxTypyZdarzen";
            this.checkedListBoxTypyZdarzen.Size = new System.Drawing.Size(255, 154);
            this.checkedListBoxTypyZdarzen.TabIndex = 4;
            // 
            // checkedListBoxObiekty
            // 
            this.checkedListBoxObiekty.FormattingEnabled = true;
            this.checkedListBoxObiekty.Location = new System.Drawing.Point(19, 54);
            this.checkedListBoxObiekty.Name = "checkedListBoxObiekty";
            this.checkedListBoxObiekty.Size = new System.Drawing.Size(265, 154);
            this.checkedListBoxObiekty.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(840, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa zdarzenia:";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(1105, 174);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(117, 36);
            this.btnSzukaj.TabIndex = 1;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // txtBoxNazwa
            // 
            this.txtBoxNazwa.Location = new System.Drawing.Point(843, 138);
            this.txtBoxNazwa.Name = "txtBoxNazwa";
            this.txtBoxNazwa.Size = new System.Drawing.Size(379, 20);
            this.txtBoxNazwa.TabIndex = 0;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(1099, 534);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(178, 43);
            this.btnZamknij.TabIndex = 2;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnDoWorda
            // 
            this.btnDoWorda.Location = new System.Drawing.Point(33, 534);
            this.btnDoWorda.Name = "btnDoWorda";
            this.btnDoWorda.Size = new System.Drawing.Size(232, 43);
            this.btnDoWorda.TabIndex = 3;
            this.btnDoWorda.Text = "Zapisz zdarzenie do pliku";
            this.btnDoWorda.UseVisualStyleBackColor = true;
            this.btnDoWorda.Click += new System.EventHandler(this.btnDoWorda_Click);
            // 
            // btnDoExcela
            // 
            this.btnDoExcela.Location = new System.Drawing.Point(308, 534);
            this.btnDoExcela.Name = "btnDoExcela";
            this.btnDoExcela.Size = new System.Drawing.Size(232, 43);
            this.btnDoExcela.TabIndex = 4;
            this.btnDoExcela.Text = "Zapisz listę do pliku";
            this.btnDoExcela.UseVisualStyleBackColor = true;
            this.btnDoExcela.Click += new System.EventHandler(this.btnDoExcela_Click);
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(584, 534);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(232, 43);
            this.btnPokaz.TabIndex = 5;
            this.btnPokaz.Text = "Pokaż zdarzenie";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRaporty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 604);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.btnDoExcela);
            this.Controls.Add(this.btnDoWorda);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewRaporty);
            this.Name = "FrmRaporty";
            this.Text = "Raporty zdarzeń";
            this.Load += new System.EventHandler(this.FrmRaporty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaporty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRaporty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.TextBox txtBoxNazwa;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnDoWorda;
        private System.Windows.Forms.Button btnDoExcela;
        private System.Windows.Forms.CheckedListBox checkedListBoxObiekty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxTypyZdarzen;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZdarzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrZdarzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataZdarzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uzytkownik;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaObiektu;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.CheckedListBox checkedListBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}