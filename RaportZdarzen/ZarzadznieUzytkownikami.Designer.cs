
namespace RaportZdarzen
{
    partial class frmZarzadznieUzytkownikami
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.dgvUzytkownicy = new System.Windows.Forms.DataGridView();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStop = new System.Windows.Forms.DateTimePicker();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.chkBoxKierownik = new System.Windows.Forms.CheckBox();
            this.chkBoxZablokowany = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkBoxZmienHaslo = new System.Windows.Forms.CheckBox();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataKoniec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyAdministrator = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CzyKierownik = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CzyZablokowany = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUzytkownicy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imię:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(84, 119);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(203, 20);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(70, 122);
            this.txtNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(312, 20);
            this.txtNazwisko.TabIndex = 4;
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(70, 159);
            this.txtImie.Margin = new System.Windows.Forms.Padding(2);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(312, 20);
            this.txtImie.TabIndex = 5;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(517, 535);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(2);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(183, 41);
            this.btnZapisz.TabIndex = 6;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(289, 535);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(185, 42);
            this.btnUsun.TabIndex = 7;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(736, 536);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(180, 41);
            this.btnAnuluj.TabIndex = 8;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // dgvUzytkownicy
            // 
            this.dgvUzytkownicy.AllowUserToAddRows = false;
            this.dgvUzytkownicy.AllowUserToDeleteRows = false;
            this.dgvUzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUzytkownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.login,
            this.Nazwisko,
            this.Imie,
            this.DataKoniec,
            this.CzyAdministrator,
            this.CzyKierownik,
            this.CzyZablokowany});
            this.dgvUzytkownicy.Location = new System.Drawing.Point(424, 32);
            this.dgvUzytkownicy.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUzytkownicy.Name = "dgvUzytkownicy";
            this.dgvUzytkownicy.ReadOnly = true;
            this.dgvUzytkownicy.RowHeadersVisible = false;
            this.dgvUzytkownicy.RowHeadersWidth = 51;
            this.dgvUzytkownicy.RowTemplate.Height = 24;
            this.dgvUzytkownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUzytkownicy.Size = new System.Drawing.Size(695, 486);
            this.dgvUzytkownicy.TabIndex = 9;
            this.dgvUzytkownicy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUzytkownicy_CellContentClick);
            this.dgvUzytkownicy.DoubleClick += new System.EventHandler(this.dgvUzytkownicy_DoubleClick);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(162, 29);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerStart.TabIndex = 10;
            // 
            // dateTimePickerStop
            // 
            this.dateTimePickerStop.Location = new System.Drawing.Point(162, 75);
            this.dateTimePickerStop.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStop.Name = "dateTimePickerStop";
            this.dateTimePickerStop.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerStop.TabIndex = 11;
            // 
            // txtHaslo
            // 
            this.txtHaslo.Location = new System.Drawing.Point(84, 148);
            this.txtHaslo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.Size = new System.Drawing.Size(203, 20);
            this.txtHaslo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hasło:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkBoxAdministrator
            // 
            this.chkBoxAdministrator.AutoSize = true;
            this.chkBoxAdministrator.Location = new System.Drawing.Point(157, 332);
            this.chkBoxAdministrator.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxAdministrator.Name = "chkBoxAdministrator";
            this.chkBoxAdministrator.Size = new System.Drawing.Size(86, 17);
            this.chkBoxAdministrator.TabIndex = 14;
            this.chkBoxAdministrator.Text = "Administrator";
            this.chkBoxAdministrator.UseVisualStyleBackColor = true;
            this.chkBoxAdministrator.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkBoxKierownik
            // 
            this.chkBoxKierownik.AutoSize = true;
            this.chkBoxKierownik.Location = new System.Drawing.Point(297, 332);
            this.chkBoxKierownik.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxKierownik.Name = "chkBoxKierownik";
            this.chkBoxKierownik.Size = new System.Drawing.Size(72, 17);
            this.chkBoxKierownik.TabIndex = 15;
            this.chkBoxKierownik.Text = "Kierownik";
            this.chkBoxKierownik.UseVisualStyleBackColor = true;
            // 
            // chkBoxZablokowany
            // 
            this.chkBoxZablokowany.AutoSize = true;
            this.chkBoxZablokowany.Location = new System.Drawing.Point(121, 112);
            this.chkBoxZablokowany.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxZablokowany.Name = "chkBoxZablokowany";
            this.chkBoxZablokowany.Size = new System.Drawing.Size(140, 17);
            this.chkBoxZablokowany.TabIndex = 16;
            this.chkBoxZablokowany.Text = "Użytownik zablokowany";
            this.chkBoxZablokowany.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(25, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Zarządzanie użytkownikami";
            // 
            // chkBoxZmienHaslo
            // 
            this.chkBoxZmienHaslo.AutoSize = true;
            this.chkBoxZmienHaslo.Location = new System.Drawing.Point(310, 151);
            this.chkBoxZmienHaslo.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxZmienHaslo.Name = "chkBoxZmienHaslo";
            this.chkBoxZmienHaslo.Size = new System.Drawing.Size(85, 17);
            this.chkBoxZmienHaslo.TabIndex = 18;
            this.chkBoxZmienHaslo.Text = "Zmień hasło";
            this.chkBoxZmienHaslo.UseVisualStyleBackColor = true;
            this.chkBoxZmienHaslo.CheckedChanged += new System.EventHandler(this.chkBoxZmienHaslo_CheckedChanged);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(940, 535);
            this.btnZamknij.Margin = new System.Windows.Forms.Padding(2);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(180, 41);
            this.btnZamknij.TabIndex = 19;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 4;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 15;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Login";
            this.login.MinimumWidth = 6;
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 70;
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwisko.DataPropertyName = "Nazwisko";
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.MinimumWidth = 6;
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            // 
            // Imie
            // 
            this.Imie.DataPropertyName = "Imie";
            this.Imie.HeaderText = "Imię";
            this.Imie.MinimumWidth = 6;
            this.Imie.Name = "Imie";
            this.Imie.ReadOnly = true;
            this.Imie.Width = 125;
            // 
            // DataKoniec
            // 
            this.DataKoniec.DataPropertyName = "DataKoniec";
            this.DataKoniec.HeaderText = "Data Ważności";
            this.DataKoniec.MinimumWidth = 6;
            this.DataKoniec.Name = "DataKoniec";
            this.DataKoniec.ReadOnly = true;
            this.DataKoniec.Width = 125;
            // 
            // CzyAdministrator
            // 
            this.CzyAdministrator.DataPropertyName = "CzyAdministrator";
            this.CzyAdministrator.HeaderText = "Admin.";
            this.CzyAdministrator.Name = "CzyAdministrator";
            this.CzyAdministrator.ReadOnly = true;
            this.CzyAdministrator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CzyAdministrator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CzyAdministrator.Width = 50;
            // 
            // CzyKierownik
            // 
            this.CzyKierownik.DataPropertyName = "CzyKierownik";
            this.CzyKierownik.HeaderText = "Kierow.";
            this.CzyKierownik.Name = "CzyKierownik";
            this.CzyKierownik.ReadOnly = true;
            this.CzyKierownik.Width = 50;
            // 
            // CzyZablokowany
            // 
            this.CzyZablokowany.DataPropertyName = "CzyZablokowany";
            this.CzyZablokowany.HeaderText = "Zablokow.";
            this.CzyZablokowany.Name = "CzyZablokowany";
            this.CzyZablokowany.ReadOnly = true;
            this.CzyZablokowany.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNazwisko);
            this.groupBox1.Controls.Add(this.txtImie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 211);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane użytkownika";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 53);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uprawnienie użutkownika";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateTimePickerStart);
            this.groupBox3.Controls.Add(this.dateTimePickerStop);
            this.groupBox3.Controls.Add(this.chkBoxZablokowany);
            this.groupBox3.Location = new System.Drawing.Point(13, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 145);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ważność konta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Data wygaśnięcia uprawnień:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Data rozpoczęcia uprawnień:";
            // 
            // frmZarzadznieUzytkownikami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 596);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.chkBoxZmienHaslo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkBoxKierownik);
            this.Controls.Add(this.chkBoxAdministrator);
            this.Controls.Add(this.txtHaslo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvUzytkownicy);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmZarzadznieUzytkownikami";
            this.Text = "Zarzadznie Uzytkownikami";
            this.Load += new System.EventHandler(this.frmZarzadznieUzytkownikami_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUzytkownicy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.DataGridView dgvUzytkownicy;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerStop;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBoxAdministrator;
        private System.Windows.Forms.CheckBox chkBoxKierownik;
        private System.Windows.Forms.CheckBox chkBoxZablokowany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBoxZmienHaslo;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataKoniec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CzyAdministrator;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CzyKierownik;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CzyZablokowany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}