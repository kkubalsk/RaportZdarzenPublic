
namespace RaportZdarzen
{
    partial class FrmPokazZdarzenie
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
            this.btnPokaz = new System.Windows.Forms.Button();
            this.dataGridViewPokaz = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZalacznikFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdZalacznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zdarzenie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTypZdarzeniaOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTypNazwa = new System.Windows.Forms.TextBox();
            this.txtObiektOpis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dTimeZdarzenie = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObiektNazwa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rTxtDzialania = new System.Windows.Forms.RichTextBox();
            this.rTxtOpis = new System.Windows.Forms.RichTextBox();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStatusNazwa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rTxtUwagi = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokaz)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(762, 497);
            this.btnPokaz.Margin = new System.Windows.Forms.Padding(2);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(130, 33);
            this.btnPokaz.TabIndex = 55;
            this.btnPokaz.Text = "Pokaż zdjęcie";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // dataGridViewPokaz
            // 
            this.dataGridViewPokaz.AllowUserToAddRows = false;
            this.dataGridViewPokaz.AllowUserToDeleteRows = false;
            this.dataGridViewPokaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.ZalacznikFoto,
            this.IdZalacznik,
            this.Zdarzenie});
            this.dataGridViewPokaz.Location = new System.Drawing.Point(102, 497);
            this.dataGridViewPokaz.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPokaz.Name = "dataGridViewPokaz";
            this.dataGridViewPokaz.ReadOnly = true;
            this.dataGridViewPokaz.RowHeadersVisible = false;
            this.dataGridViewPokaz.RowHeadersWidth = 51;
            this.dataGridViewPokaz.RowTemplate.Height = 24;
            this.dataGridViewPokaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPokaz.Size = new System.Drawing.Size(644, 148);
            this.dataGridViewPokaz.TabIndex = 53;
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
            // txtTypZdarzeniaOpis
            // 
            this.txtTypZdarzeniaOpis.Location = new System.Drawing.Point(935, 353);
            this.txtTypZdarzeniaOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypZdarzeniaOpis.Multiline = true;
            this.txtTypZdarzeniaOpis.Name = "txtTypZdarzeniaOpis";
            this.txtTypZdarzeniaOpis.ReadOnly = true;
            this.txtTypZdarzeniaOpis.Size = new System.Drawing.Size(255, 56);
            this.txtTypZdarzeniaOpis.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(931, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Rodzaj zdarzenia:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTypNazwa);
            this.groupBox2.Location = new System.Drawing.Point(922, 274);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(281, 158);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // txtTypNazwa
            // 
            this.txtTypNazwa.Location = new System.Drawing.Point(12, 48);
            this.txtTypNazwa.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypNazwa.Multiline = true;
            this.txtTypNazwa.Name = "txtTypNazwa";
            this.txtTypNazwa.ReadOnly = true;
            this.txtTypNazwa.Size = new System.Drawing.Size(255, 27);
            this.txtTypNazwa.TabIndex = 49;
            // 
            // txtObiektOpis
            // 
            this.txtObiektOpis.Location = new System.Drawing.Point(935, 190);
            this.txtObiektOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtObiektOpis.Multiline = true;
            this.txtObiektOpis.Name = "txtObiektOpis";
            this.txtObiektOpis.ReadOnly = true;
            this.txtObiektOpis.Size = new System.Drawing.Size(255, 56);
            this.txtObiektOpis.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(931, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Obiekt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(869, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Czas wystąpienia zdarzenia:";
            // 
            // dTimeZdarzenie
            // 
            this.dTimeZdarzenie.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dTimeZdarzenie.CustomFormat = "yyyy-MM-dd HH:MM:ss";
            this.dTimeZdarzenie.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimeZdarzenie.Location = new System.Drawing.Point(1020, 62);
            this.dTimeZdarzenie.Margin = new System.Windows.Forms.Padding(2);
            this.dTimeZdarzenie.Name = "dTimeZdarzenie";
            this.dTimeZdarzenie.Size = new System.Drawing.Size(136, 20);
            this.dTimeZdarzenie.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObiektNazwa);
            this.groupBox1.Location = new System.Drawing.Point(923, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(281, 158);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // txtObiektNazwa
            // 
            this.txtObiektNazwa.Location = new System.Drawing.Point(13, 51);
            this.txtObiektNazwa.Margin = new System.Windows.Forms.Padding(2);
            this.txtObiektNazwa.Multiline = true;
            this.txtObiektNazwa.Name = "txtObiektNazwa";
            this.txtObiektNazwa.ReadOnly = true;
            this.txtObiektNazwa.Size = new System.Drawing.Size(255, 27);
            this.txtObiektNazwa.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Podjęte działania:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Opis zdarzenia:";
            // 
            // rTxtDzialania
            // 
            this.rTxtDzialania.Location = new System.Drawing.Point(211, 296);
            this.rTxtDzialania.Name = "rTxtDzialania";
            this.rTxtDzialania.ReadOnly = true;
            this.rTxtDzialania.Size = new System.Drawing.Size(560, 113);
            this.rTxtDzialania.TabIndex = 40;
            this.rTxtDzialania.Text = "";
            // 
            // rTxtOpis
            // 
            this.rTxtOpis.Location = new System.Drawing.Point(211, 115);
            this.rTxtOpis.Name = "rTxtOpis";
            this.rTxtOpis.ReadOnly = true;
            this.rTxtOpis.Size = new System.Drawing.Size(560, 151);
            this.rTxtOpis.TabIndex = 39;
            this.rTxtOpis.Text = "";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(211, 63);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.ReadOnly = true;
            this.txtNazwa.Size = new System.Drawing.Size(442, 20);
            this.txtNazwa.TabIndex = 38;
            this.txtNazwa.TextChanged += new System.EventHandler(this.txtNazwa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nazwa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(531, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Pokaż zdarzenie";
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(923, 601);
            this.btnZamknij.Margin = new System.Windows.Forms.Padding(2);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(281, 44);
            this.btnZamknij.TabIndex = 35;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(931, 465);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Status zdarzenia:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStatusNazwa);
            this.groupBox3.Location = new System.Drawing.Point(923, 446);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(281, 104);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            // 
            // txtStatusNazwa
            // 
            this.txtStatusNazwa.Location = new System.Drawing.Point(13, 51);
            this.txtStatusNazwa.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatusNazwa.Multiline = true;
            this.txtStatusNazwa.Name = "txtStatusNazwa";
            this.txtStatusNazwa.ReadOnly = true;
            this.txtStatusNazwa.Size = new System.Drawing.Size(255, 27);
            this.txtStatusNazwa.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Uwagi:";
            // 
            // rTxtUwagi
            // 
            this.rTxtUwagi.Location = new System.Drawing.Point(211, 426);
            this.rTxtUwagi.Name = "rTxtUwagi";
            this.rTxtUwagi.ReadOnly = true;
            this.rTxtUwagi.Size = new System.Drawing.Size(560, 52);
            this.rTxtUwagi.TabIndex = 59;
            this.rTxtUwagi.Text = "";
            // 
            // FrmPokazZdarzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 703);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rTxtUwagi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.dataGridViewPokaz);
            this.Controls.Add(this.txtTypZdarzeniaOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtObiektOpis);
            this.Controls.Add(this.label6);
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
            this.Name = "FrmPokazZdarzenie";
            this.Text = "FrmPokazZdarzenie";
            this.Load += new System.EventHandler(this.FrmPokazZdarzenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokaz)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.DataGridView dataGridViewPokaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZalacznikFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZalacznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zdarzenie;
        private System.Windows.Forms.TextBox txtTypZdarzeniaOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObiektOpis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTimeZdarzenie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTxtDzialania;
        private System.Windows.Forms.RichTextBox rTxtOpis;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.TextBox txtTypNazwa;
        private System.Windows.Forms.TextBox txtObiektNazwa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStatusNazwa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rTxtUwagi;
    }
}