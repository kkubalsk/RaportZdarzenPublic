
namespace RaportZdarzen
{
    partial class FrmAddZdarzenie
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
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.rTxtOpis = new System.Windows.Forms.RichTextBox();
            this.rTxtDzialania = new System.Windows.Forms.RichTextBox();
            this.dTimeZdarzenie = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxObiekty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZakoncz = new System.Windows.Forms.Button();
            this.txtObiektOpis = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTypZdarzeniaOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxTypyZdarzen = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZalacznikFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDodajFoto = new System.Windows.Forms.Button();
            this.btnPokaz = new System.Windows.Forms.Button();
            this.btnZmienNazwe = new System.Windows.Forms.Button();
            this.btnUsunFoto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(280, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "W p r o w a d ź   n o w e   z d a r z e n i e";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa zdarzenia:";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(125, 66);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazwa.Multiline = true;
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(501, 28);
            this.txtNazwa.TabIndex = 3;
            // 
            // rTxtOpis
            // 
            this.rTxtOpis.Location = new System.Drawing.Point(125, 128);
            this.rTxtOpis.Margin = new System.Windows.Forms.Padding(2);
            this.rTxtOpis.Name = "rTxtOpis";
            this.rTxtOpis.Size = new System.Drawing.Size(578, 104);
            this.rTxtOpis.TabIndex = 4;
            this.rTxtOpis.Text = "";
            // 
            // rTxtDzialania
            // 
            this.rTxtDzialania.Location = new System.Drawing.Point(125, 274);
            this.rTxtDzialania.Margin = new System.Windows.Forms.Padding(2);
            this.rTxtDzialania.Name = "rTxtDzialania";
            this.rTxtDzialania.Size = new System.Drawing.Size(578, 102);
            this.rTxtDzialania.TabIndex = 5;
            this.rTxtDzialania.Text = "";
            // 
            // dTimeZdarzenie
            // 
            this.dTimeZdarzenie.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dTimeZdarzenie.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dTimeZdarzenie.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimeZdarzenie.Location = new System.Drawing.Point(829, 64);
            this.dTimeZdarzenie.Margin = new System.Windows.Forms.Padding(2);
            this.dTimeZdarzenie.Name = "dTimeZdarzenie";
            this.dTimeZdarzenie.Size = new System.Drawing.Size(170, 20);
            this.dTimeZdarzenie.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Czas wystąpienia zdarzenia:";
            // 
            // cBoxObiekty
            // 
            this.cBoxObiekty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxObiekty.FormattingEnabled = true;
            this.cBoxObiekty.Location = new System.Drawing.Point(742, 155);
            this.cBoxObiekty.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxObiekty.Name = "cBoxObiekty";
            this.cBoxObiekty.Size = new System.Drawing.Size(257, 21);
            this.cBoxObiekty.TabIndex = 10;
            this.cBoxObiekty.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wybierz obiekt:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(893, 565);
            this.btnZamknij.Margin = new System.Windows.Forms.Padding(2);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(139, 37);
            this.btnZamknij.TabIndex = 12;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(893, 442);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(2);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(139, 37);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(893, 524);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(139, 37);
            this.btnAnuluj.TabIndex = 12;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZakoncz
            // 
            this.btnZakoncz.Location = new System.Drawing.Point(893, 483);
            this.btnZakoncz.Margin = new System.Windows.Forms.Padding(2);
            this.btnZakoncz.Name = "btnZakoncz";
            this.btnZakoncz.Size = new System.Drawing.Size(139, 37);
            this.btnZakoncz.TabIndex = 12;
            this.btnZakoncz.Text = "Zapisz i przekaż dalej";
            this.btnZakoncz.UseVisualStyleBackColor = true;
            this.btnZakoncz.Click += new System.EventHandler(this.btnZakoncz_Click);
            // 
            // txtObiektOpis
            // 
            this.txtObiektOpis.Location = new System.Drawing.Point(744, 192);
            this.txtObiektOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtObiektOpis.Multiline = true;
            this.txtObiektOpis.Name = "txtObiektOpis";
            this.txtObiektOpis.ReadOnly = true;
            this.txtObiektOpis.Size = new System.Drawing.Size(255, 56);
            this.txtObiektOpis.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(732, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(281, 140);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTypZdarzeniaOpis
            // 
            this.txtTypZdarzeniaOpis.Location = new System.Drawing.Point(744, 335);
            this.txtTypZdarzeniaOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypZdarzeniaOpis.Multiline = true;
            this.txtTypZdarzeniaOpis.Name = "txtTypZdarzeniaOpis";
            this.txtTypZdarzeniaOpis.ReadOnly = true;
            this.txtTypZdarzeniaOpis.Size = new System.Drawing.Size(255, 56);
            this.txtTypZdarzeniaOpis.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Wybierz rodzaj zdarzenia:";
            // 
            // cBoxTypyZdarzen
            // 
            this.cBoxTypyZdarzen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTypyZdarzen.FormattingEnabled = true;
            this.cBoxTypyZdarzen.Location = new System.Drawing.Point(742, 303);
            this.cBoxTypyZdarzen.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxTypyZdarzen.Name = "cBoxTypyZdarzen";
            this.cBoxTypyZdarzen.Size = new System.Drawing.Size(257, 21);
            this.cBoxTypyZdarzen.TabIndex = 15;
            this.cBoxTypyZdarzen.SelectedIndexChanged += new System.EventHandler(this.cBoxTypyZdarzen_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(732, 264);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(281, 141);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Opis zdarzenia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Podjęte działania:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 411);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Załączone pliki:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.ZalacznikFoto});
            this.dataGridView1.Location = new System.Drawing.Point(58, 442);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 137);
            this.dataGridView1.TabIndex = 22;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDodajFoto
            // 
            this.btnDodajFoto.Location = new System.Drawing.Point(732, 443);
            this.btnDodajFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajFoto.Name = "btnDodajFoto";
            this.btnDodajFoto.Size = new System.Drawing.Size(130, 35);
            this.btnDodajFoto.TabIndex = 23;
            this.btnDodajFoto.Text = "Dodaj zdjęcia";
            this.btnDodajFoto.UseVisualStyleBackColor = true;
            this.btnDodajFoto.Click += new System.EventHandler(this.btnDodajFoto_Click);
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(732, 480);
            this.btnPokaz.Margin = new System.Windows.Forms.Padding(2);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(130, 34);
            this.btnPokaz.TabIndex = 24;
            this.btnPokaz.Text = "Pokaż zdjęcie";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // btnZmienNazwe
            // 
            this.btnZmienNazwe.Location = new System.Drawing.Point(732, 517);
            this.btnZmienNazwe.Name = "btnZmienNazwe";
            this.btnZmienNazwe.Size = new System.Drawing.Size(130, 32);
            this.btnZmienNazwe.TabIndex = 25;
            this.btnZmienNazwe.Text = "Zmień nazwę";
            this.btnZmienNazwe.UseVisualStyleBackColor = true;
            this.btnZmienNazwe.Click += new System.EventHandler(this.btnZmienNazwe_Click);
            // 
            // btnUsunFoto
            // 
            this.btnUsunFoto.Location = new System.Drawing.Point(732, 551);
            this.btnUsunFoto.Name = "btnUsunFoto";
            this.btnUsunFoto.Size = new System.Drawing.Size(130, 29);
            this.btnUsunFoto.TabIndex = 26;
            this.btnUsunFoto.Text = "Usuń zdjęcie";
            this.btnUsunFoto.UseVisualStyleBackColor = true;
            this.btnUsunFoto.Click += new System.EventHandler(this.btnUsunFoto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(26, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(853, 191);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // FrmAddZdarzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 631);
            this.Controls.Add(this.btnUsunFoto);
            this.Controls.Add(this.btnZmienNazwe);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.btnDodajFoto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTypZdarzeniaOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxTypyZdarzen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtObiektOpis);
            this.Controls.Add(this.btnZakoncz);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxObiekty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTimeZdarzenie);
            this.Controls.Add(this.rTxtDzialania);
            this.Controls.Add(this.rTxtOpis);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAddZdarzenie";
            this.Text = "Nowe zdarzenie";
            this.Load += new System.EventHandler(this.FrmAddZdarzenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.RichTextBox rTxtOpis;
        private System.Windows.Forms.RichTextBox rTxtDzialania;
        private System.Windows.Forms.DateTimePicker dTimeZdarzenie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxObiekty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZakoncz;
        private System.Windows.Forms.TextBox txtObiektOpis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTypZdarzeniaOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxTypyZdarzen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDodajFoto;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZalacznikFoto;
        private System.Windows.Forms.Button btnZmienNazwe;
        private System.Windows.Forms.Button btnUsunFoto;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}