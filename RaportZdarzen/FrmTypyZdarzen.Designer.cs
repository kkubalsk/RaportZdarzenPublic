
namespace RaportZdarzen
{
    partial class FrmTypyZdarzen
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
            this.chkBoxCzyZablokowany = new System.Windows.Forms.CheckBox();
            this.dataGridTypyZdarzen = new System.Windows.Forms.DataGridView();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.IdTypZdarzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyZablokowany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypyZdarzen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa zdarzenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis zdarzenia:";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(177, 65);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(275, 22);
            this.txtNazwa.TabIndex = 2;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(177, 114);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(581, 22);
            this.txtOpis.TabIndex = 3;
            // 
            // chkBoxCzyZablokowany
            // 
            this.chkBoxCzyZablokowany.AutoSize = true;
            this.chkBoxCzyZablokowany.Location = new System.Drawing.Point(640, 67);
            this.chkBoxCzyZablokowany.Name = "chkBoxCzyZablokowany";
            this.chkBoxCzyZablokowany.Size = new System.Drawing.Size(113, 21);
            this.chkBoxCzyZablokowany.TabIndex = 4;
            this.chkBoxCzyZablokowany.Text = "Zablokowany";
            this.chkBoxCzyZablokowany.UseVisualStyleBackColor = true;
            // 
            // dataGridTypyZdarzen
            // 
            this.dataGridTypyZdarzen.AllowUserToAddRows = false;
            this.dataGridTypyZdarzen.AllowUserToDeleteRows = false;
            this.dataGridTypyZdarzen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTypyZdarzen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTypZdarzenia,
            this.Nazwa,
            this.Opis,
            this.CzyZablokowany});
            this.dataGridTypyZdarzen.Location = new System.Drawing.Point(30, 166);
            this.dataGridTypyZdarzen.Name = "dataGridTypyZdarzen";
            this.dataGridTypyZdarzen.ReadOnly = true;
            this.dataGridTypyZdarzen.RowHeadersWidth = 51;
            this.dataGridTypyZdarzen.RowTemplate.Height = 24;
            this.dataGridTypyZdarzen.Size = new System.Drawing.Size(728, 212);
            this.dataGridTypyZdarzen.TabIndex = 5;
            this.dataGridTypyZdarzen.DoubleClick += new System.EventHandler(this.dataGridTypyZdarzen_DoubleClick);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(177, 404);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(191, 34);
            this.btnZapisz.TabIndex = 6;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(416, 404);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(164, 34);
            this.btnUsun.TabIndex = 7;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(626, 404);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(132, 34);
            this.btnAnuluj.TabIndex = 8;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // IdTypZdarzenia
            // 
            this.IdTypZdarzenia.DataPropertyName = "IdTypZdarzenia";
            this.IdTypZdarzenia.HeaderText = "IdTypZdarzenia";
            this.IdTypZdarzenia.MinimumWidth = 6;
            this.IdTypZdarzenia.Name = "IdTypZdarzenia";
            this.IdTypZdarzenia.ReadOnly = true;
            this.IdTypZdarzenia.Visible = false;
            this.IdTypZdarzenia.Width = 125;
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa zdarzenia";
            this.Nazwa.MinimumWidth = 6;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            this.Nazwa.Width = 125;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis zdarzenia";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // CzyZablokowany
            // 
            this.CzyZablokowany.DataPropertyName = "CzyZablokowany";
            this.CzyZablokowany.HeaderText = "Zablokowany";
            this.CzyZablokowany.MinimumWidth = 6;
            this.CzyZablokowany.Name = "CzyZablokowany";
            this.CzyZablokowany.ReadOnly = true;
            this.CzyZablokowany.Width = 125;
            // 
            // FrmTypyZdarzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.dataGridTypyZdarzen);
            this.Controls.Add(this.chkBoxCzyZablokowany);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTypyZdarzen";
            this.Text = "Typy zdarzeń";
            this.Load += new System.EventHandler(this.FrmTypyZdarzen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypyZdarzen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.CheckBox chkBoxCzyZablokowany;
        private System.Windows.Forms.DataGridView dataGridTypyZdarzen;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTypZdarzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyZablokowany;
    }
}