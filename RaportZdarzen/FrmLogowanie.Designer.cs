
namespace RaportZdarzen
{
    partial class FrmLogowanie
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
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(50, 142);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 38);
            this.btnAnuluj.TabIndex = 2;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Location = new System.Drawing.Point(218, 142);
            this.btnZaloguj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(134, 38);
            this.btnZaloguj.TabIndex = 3;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(170, 35);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(172, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // txtHaslo
            // 
            this.txtHaslo.Location = new System.Drawing.Point(170, 74);
            this.txtHaslo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.Size = new System.Drawing.Size(172, 20);
            this.txtHaslo.TabIndex = 5;
            // 
            // FrmLogowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 213);
            this.Controls.Add(this.txtHaslo);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnZaloguj);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtHaslo;
    }
}