
namespace RaportZdarzen
{
    partial class frmEdytujZdarzenie
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
            this.btnZamknij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.rTxtOpis = new System.Windows.Forms.RichTextBox();
            this.rTxtDzialania = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTypZdarzeniaOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxTypyZdarzen = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObiektOpis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxObiekty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dTimeZdarzenie = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPokaz = new System.Windows.Forms.Button();
            this.btnDodajFoto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZalacznikFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdZalacznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zdarzenie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdytujNazwe = new System.Windows.Forms.Button();
            this.btnUsunFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rTxtUwagi = new System.Windows.Forms.RichTextBox();
            this.labelUwagi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOdrzuc = new System.Windows.Forms.Button();
            this.btnZatwierdz = new System.Windows.Forms.Button();
            this.btnPrzekaz = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lablStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(966, 664);
            this.btnZamknij.Margin = new System.Windows.Forms.Padding(2);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(153, 44);
            this.btnZamknij.TabIndex = 0;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa zdarzenia:";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(117, 73);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(560, 20);
            this.txtNazwa.TabIndex = 3;
            // 
            // rTxtOpis
            // 
            this.rTxtOpis.Location = new System.Drawing.Point(117, 110);
            this.rTxtOpis.Name = "rTxtOpis";
            this.rTxtOpis.Size = new System.Drawing.Size(560, 151);
            this.rTxtOpis.TabIndex = 4;
            this.rTxtOpis.Text = "";
            // 
            // rTxtDzialania
            // 
            this.rTxtDzialania.Location = new System.Drawing.Point(117, 291);
            this.rTxtDzialania.Name = "rTxtDzialania";
            this.rTxtDzialania.Size = new System.Drawing.Size(560, 113);
            this.rTxtDzialania.TabIndex = 5;
            this.rTxtDzialania.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis zdarzenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Podjęte działania:";
            // 
            // txtTypZdarzeniaOpis
            // 
            this.txtTypZdarzeniaOpis.Location = new System.Drawing.Point(841, 363);
            this.txtTypZdarzeniaOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypZdarzeniaOpis.Multiline = true;
            this.txtTypZdarzeniaOpis.Name = "txtTypZdarzeniaOpis";
            this.txtTypZdarzeniaOpis.ReadOnly = true;
            this.txtTypZdarzeniaOpis.Size = new System.Drawing.Size(255, 56);
            this.txtTypZdarzeniaOpis.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Wybierz rodzaj zdarzenia:";
            // 
            // cBoxTypyZdarzen
            // 
            this.cBoxTypyZdarzen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTypyZdarzen.FormattingEnabled = true;
            this.cBoxTypyZdarzen.Location = new System.Drawing.Point(839, 326);
            this.cBoxTypyZdarzen.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxTypyZdarzen.Name = "cBoxTypyZdarzen";
            this.cBoxTypyZdarzen.Size = new System.Drawing.Size(257, 21);
            this.cBoxTypyZdarzen.TabIndex = 25;
            this.cBoxTypyZdarzen.SelectedIndexChanged += new System.EventHandler(this.cBoxTypyZdarzen_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(828, 284);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(281, 158);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // txtObiektOpis
            // 
            this.txtObiektOpis.Location = new System.Drawing.Point(841, 200);
            this.txtObiektOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtObiektOpis.Multiline = true;
            this.txtObiektOpis.Name = "txtObiektOpis";
            this.txtObiektOpis.ReadOnly = true;
            this.txtObiektOpis.Size = new System.Drawing.Size(255, 56);
            this.txtObiektOpis.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(837, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Wybierz obiekt:";
            // 
            // cBoxObiekty
            // 
            this.cBoxObiekty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxObiekty.FormattingEnabled = true;
            this.cBoxObiekty.Location = new System.Drawing.Point(839, 163);
            this.cBoxObiekty.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxObiekty.Name = "cBoxObiekty";
            this.cBoxObiekty.Size = new System.Drawing.Size(257, 21);
            this.cBoxObiekty.TabIndex = 21;
            this.cBoxObiekty.SelectedIndexChanged += new System.EventHandler(this.cBoxObiekty_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(775, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Czas wystąpienia zdarzenia:";
            // 
            // dTimeZdarzenie
            // 
            this.dTimeZdarzenie.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dTimeZdarzenie.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dTimeZdarzenie.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimeZdarzenie.Location = new System.Drawing.Point(926, 72);
            this.dTimeZdarzenie.Margin = new System.Windows.Forms.Padding(2);
            this.dTimeZdarzenie.Name = "dTimeZdarzenie";
            this.dTimeZdarzenie.Size = new System.Drawing.Size(136, 20);
            this.dTimeZdarzenie.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(829, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(281, 158);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(713, 585);
            this.btnPokaz.Margin = new System.Windows.Forms.Padding(2);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(130, 33);
            this.btnPokaz.TabIndex = 31;
            this.btnPokaz.Text = "Pokaż zdjęcie";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // btnDodajFoto
            // 
            this.btnDodajFoto.Location = new System.Drawing.Point(713, 545);
            this.btnDodajFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajFoto.Name = "btnDodajFoto";
            this.btnDodajFoto.Size = new System.Drawing.Size(130, 36);
            this.btnDodajFoto.TabIndex = 30;
            this.btnDodajFoto.Text = "Dodaj zdjęcia";
            this.btnDodajFoto.UseVisualStyleBackColor = true;
            this.btnDodajFoto.Click += new System.EventHandler(this.btnDodajFoto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.ZalacznikFoto,
            this.IdZalacznik,
            this.Zdarzenie});
            this.dataGridView1.Location = new System.Drawing.Point(37, 544);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 148);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa pliku";
            this.Nazwa.MinimumWidth = 6;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // ZalacznikFoto
            // 
            this.ZalacznikFoto.DataPropertyName = "ZalacznikFoto";
            this.ZalacznikFoto.HeaderText = "ZalacznikFoto";
            this.ZalacznikFoto.MinimumWidth = 6;
            this.ZalacznikFoto.Name = "ZalacznikFoto";
            this.ZalacznikFoto.ReadOnly = true;
            this.ZalacznikFoto.Visible = false;
            this.ZalacznikFoto.Width = 125;
            // 
            // IdZalacznik
            // 
            this.IdZalacznik.DataPropertyName = "IdZalacznik";
            this.IdZalacznik.HeaderText = "IdZalacznik";
            this.IdZalacznik.Name = "IdZalacznik";
            this.IdZalacznik.ReadOnly = true;
            // 
            // Zdarzenie
            // 
            this.Zdarzenie.DataPropertyName = "Zdarzenie";
            this.Zdarzenie.HeaderText = "Zdarzenie";
            this.Zdarzenie.Name = "Zdarzenie";
            this.Zdarzenie.ReadOnly = true;
            // 
            // btnEdytujNazwe
            // 
            this.btnEdytujNazwe.Location = new System.Drawing.Point(713, 622);
            this.btnEdytujNazwe.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdytujNazwe.Name = "btnEdytujNazwe";
            this.btnEdytujNazwe.Size = new System.Drawing.Size(130, 33);
            this.btnEdytujNazwe.TabIndex = 32;
            this.btnEdytujNazwe.Text = "Edytuj nazwę";
            this.btnEdytujNazwe.UseVisualStyleBackColor = true;
            this.btnEdytujNazwe.Click += new System.EventHandler(this.btnEdytujNazwe_Click);
            // 
            // btnUsunFoto
            // 
            this.btnUsunFoto.Location = new System.Drawing.Point(713, 659);
            this.btnUsunFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsunFoto.Name = "btnUsunFoto";
            this.btnUsunFoto.Size = new System.Drawing.Size(130, 33);
            this.btnUsunFoto.TabIndex = 33;
            this.btnUsunFoto.Text = "Usuń zdjęcie";
            this.btnUsunFoto.UseVisualStyleBackColor = true;
            this.btnUsunFoto.Click += new System.EventHandler(this.btnUsunFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(966, 470);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(2);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(153, 44);
            this.btnZapisz.TabIndex = 34;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(410, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "E d y c j a    z d a r z e n i a";
            // 
            // rTxtUwagi
            // 
            this.rTxtUwagi.Location = new System.Drawing.Point(117, 427);
            this.rTxtUwagi.Name = "rTxtUwagi";
            this.rTxtUwagi.Size = new System.Drawing.Size(560, 46);
            this.rTxtUwagi.TabIndex = 36;
            this.rTxtUwagi.Text = "";
            // 
            // labelUwagi
            // 
            this.labelUwagi.AutoSize = true;
            this.labelUwagi.Location = new System.Drawing.Point(19, 430);
            this.labelUwagi.Name = "labelUwagi";
            this.labelUwagi.Size = new System.Drawing.Size(92, 13);
            this.labelUwagi.TabIndex = 37;
            this.labelUwagi.Text = "Wprowadź uwagi:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(20, 510);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(858, 203);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // btnOdrzuc
            // 
            this.btnOdrzuc.Location = new System.Drawing.Point(966, 616);
            this.btnOdrzuc.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdrzuc.Name = "btnOdrzuc";
            this.btnOdrzuc.Size = new System.Drawing.Size(153, 44);
            this.btnOdrzuc.TabIndex = 39;
            this.btnOdrzuc.Text = "Odrzuć";
            this.btnOdrzuc.UseVisualStyleBackColor = true;
            this.btnOdrzuc.Click += new System.EventHandler(this.btnOdrzuc_Click);
            // 
            // btnZatwierdz
            // 
            this.btnZatwierdz.Location = new System.Drawing.Point(966, 518);
            this.btnZatwierdz.Margin = new System.Windows.Forms.Padding(2);
            this.btnZatwierdz.Name = "btnZatwierdz";
            this.btnZatwierdz.Size = new System.Drawing.Size(153, 44);
            this.btnZatwierdz.TabIndex = 40;
            this.btnZatwierdz.Text = "Zatwierdź";
            this.btnZatwierdz.UseVisualStyleBackColor = true;
            this.btnZatwierdz.Click += new System.EventHandler(this.btnZatwierdz_Click);
            // 
            // btnPrzekaz
            // 
            this.btnPrzekaz.Location = new System.Drawing.Point(966, 568);
            this.btnPrzekaz.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrzekaz.Name = "btnPrzekaz";
            this.btnPrzekaz.Size = new System.Drawing.Size(153, 44);
            this.btnPrzekaz.TabIndex = 41;
            this.btnPrzekaz.Text = "Zapisz i przekaż dalej";
            this.btnPrzekaz.UseVisualStyleBackColor = true;
            this.btnPrzekaz.Click += new System.EventHandler(this.btnPrzekaz_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Status zdarzenia:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lablStatus
            // 
            this.lablStatus.AutoSize = true;
            this.lablStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lablStatus.Location = new System.Drawing.Point(114, 486);
            this.lablStatus.Name = "lablStatus";
            this.lablStatus.Size = new System.Drawing.Size(0, 13);
            this.lablStatus.TabIndex = 43;
            // 
            // frmEdytujZdarzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 724);
            this.Controls.Add(this.lablStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPrzekaz);
            this.Controls.Add(this.btnZatwierdz);
            this.Controls.Add(this.btnOdrzuc);
            this.Controls.Add(this.labelUwagi);
            this.Controls.Add(this.rTxtUwagi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsunFoto);
            this.Controls.Add(this.btnEdytujNazwe);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.btnDodajFoto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTypZdarzeniaOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxTypyZdarzen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtObiektOpis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxObiekty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dTimeZdarzenie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rTxtDzialania);
            this.Controls.Add(this.rTxtOpis);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEdytujZdarzenie";
            this.Text = "Edytuj Zdarzenie";
            this.Load += new System.EventHandler(this.frmEdytujZdarzenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.RichTextBox rTxtOpis;
        private System.Windows.Forms.RichTextBox rTxtDzialania;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTypZdarzeniaOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxTypyZdarzen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObiektOpis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxObiekty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTimeZdarzenie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.Button btnDodajFoto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdytujNazwe;
        private System.Windows.Forms.Button btnUsunFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZalacznikFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZalacznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zdarzenie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rTxtUwagi;
        private System.Windows.Forms.Label labelUwagi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOdrzuc;
        private System.Windows.Forms.Button btnZatwierdz;
        private System.Windows.Forms.Button btnPrzekaz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lablStatus;
    }
}