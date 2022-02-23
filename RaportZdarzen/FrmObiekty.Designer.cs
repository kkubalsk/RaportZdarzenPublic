
namespace RaportZdarzen
{
    partial class FrmObiekty
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
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dataGridObiekty = new System.Windows.Forms.DataGridView();
            this.IdObiekt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.chkBoxCzyZablokowany = new System.Windows.Forms.CheckBox();
            this.btnZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObiekty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa obiektu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis Obiektu:";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(110, 26);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(174, 20);
            this.txtNazwa.TabIndex = 2;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(110, 63);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(663, 20);
            this.txtOpis.TabIndex = 3;
            // 
            // dataGridObiekty
            // 
            this.dataGridObiekty.AllowUserToAddRows = false;
            this.dataGridObiekty.AllowUserToDeleteRows = false;
            this.dataGridObiekty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridObiekty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdObiekt,
            this.Nazwa,
            this.Opis});
            this.dataGridObiekty.Location = new System.Drawing.Point(18, 115);
            this.dataGridObiekty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridObiekty.Name = "dataGridObiekty";
            this.dataGridObiekty.ReadOnly = true;
            this.dataGridObiekty.RowHeadersWidth = 51;
            this.dataGridObiekty.RowTemplate.Height = 24;
            this.dataGridObiekty.Size = new System.Drawing.Size(807, 241);
            this.dataGridObiekty.TabIndex = 4;
            this.dataGridObiekty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridObiekty_CellClick);
            this.dataGridObiekty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridObiekty_CellDoubleClick);
            this.dataGridObiekty.DoubleClick += new System.EventHandler(this.dataGridObiekty_DoubleClick);
            // 
            // IdObiekt
            // 
            this.IdObiekt.DataPropertyName = "IdObiekt";
            this.IdObiekt.HeaderText = "IdObiekt";
            this.IdObiekt.MinimumWidth = 6;
            this.IdObiekt.Name = "IdObiekt";
            this.IdObiekt.ReadOnly = true;
            this.IdObiekt.Visible = false;
            this.IdObiekt.Width = 125;
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa obiektu";
            this.Nazwa.MinimumWidth = 6;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            this.Nazwa.Width = 125;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis Obiektu";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(161, 394);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(149, 37);
            this.btnZapisz.TabIndex = 6;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(332, 394);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(146, 37);
            this.btnUsun.TabIndex = 7;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(505, 394);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(152, 37);
            this.btnAnuluj.TabIndex = 8;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // chkBoxCzyZablokowany
            // 
            this.chkBoxCzyZablokowany.AutoSize = true;
            this.chkBoxCzyZablokowany.Location = new System.Drawing.Point(679, 28);
            this.chkBoxCzyZablokowany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBoxCzyZablokowany.Name = "chkBoxCzyZablokowany";
            this.chkBoxCzyZablokowany.Size = new System.Drawing.Size(90, 17);
            this.chkBoxCzyZablokowany.TabIndex = 9;
            this.chkBoxCzyZablokowany.Text = "Zablokowany";
            this.chkBoxCzyZablokowany.UseVisualStyleBackColor = true;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(683, 394);
            this.btnZamknij.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(140, 37);
            this.btnZamknij.TabIndex = 10;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // FrmObiekty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 461);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.chkBoxCzyZablokowany);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.dataGridObiekty);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmObiekty";
            this.Text = "Obiekty chronione";
            this.Load += new System.EventHandler(this.FrmObiekty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObiekty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DataGridView dataGridObiekty;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.CheckBox chkBoxCzyZablokowany;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdObiekt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Button btnZamknij;
    }
}