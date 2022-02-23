
namespace RaportZdarzen
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zdarzeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajZdarzeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdytujZdarzeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UzytkownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ObiektyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypyZdarzeńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zalogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmienSwojeHasloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarzadzanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladajZdarzeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zdarzeniaToolStripMenuItem,
            this.administracjaToolStripMenuItem,
            this.operatorToolStripMenuItem,
            this.zarzadzanieToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1201, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.menuStrip1_Click);
            // 
            // zdarzeniaToolStripMenuItem
            // 
            this.zdarzeniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DodajZdarzeniaToolStripMenuItem,
            this.EdytujZdarzeniaToolStripMenuItem});
            this.zdarzeniaToolStripMenuItem.Name = "zdarzeniaToolStripMenuItem";
            this.zdarzeniaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zdarzeniaToolStripMenuItem.Text = "Zdarzenia";
            // 
            // DodajZdarzeniaToolStripMenuItem
            // 
            this.DodajZdarzeniaToolStripMenuItem.Name = "DodajZdarzeniaToolStripMenuItem";
            this.DodajZdarzeniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DodajZdarzeniaToolStripMenuItem.Text = "Dodaj zdarzenia";
            this.DodajZdarzeniaToolStripMenuItem.Click += new System.EventHandler(this.DodajZdarzeniaToolStripMenuItem_Click);
            // 
            // EdytujZdarzeniaToolStripMenuItem
            // 
            this.EdytujZdarzeniaToolStripMenuItem.Name = "EdytujZdarzeniaToolStripMenuItem";
            this.EdytujZdarzeniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EdytujZdarzeniaToolStripMenuItem.Text = "Edytuj zdarzenia";
            this.EdytujZdarzeniaToolStripMenuItem.Click += new System.EventHandler(this.EdytujZdarzeniaToolStripMenuItem_Click);
            // 
            // administracjaToolStripMenuItem
            // 
            this.administracjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UzytkownicyToolStripMenuItem,
            this.ObiektyToolStripMenuItem,
            this.TypyZdarzeńToolStripMenuItem});
            this.administracjaToolStripMenuItem.Name = "administracjaToolStripMenuItem";
            this.administracjaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administracjaToolStripMenuItem.Text = "Administracja";
            // 
            // UzytkownicyToolStripMenuItem
            // 
            this.UzytkownicyToolStripMenuItem.Name = "UzytkownicyToolStripMenuItem";
            this.UzytkownicyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UzytkownicyToolStripMenuItem.Text = "Użytkownicy";
            this.UzytkownicyToolStripMenuItem.Click += new System.EventHandler(this.UzytkownicyToolStripMenuItem_Click);
            // 
            // ObiektyToolStripMenuItem
            // 
            this.ObiektyToolStripMenuItem.Name = "ObiektyToolStripMenuItem";
            this.ObiektyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ObiektyToolStripMenuItem.Text = "Obiekty";
            this.ObiektyToolStripMenuItem.Click += new System.EventHandler(this.ObiektyToolStripMenuItem_Click);
            // 
            // TypyZdarzeńToolStripMenuItem
            // 
            this.TypyZdarzeńToolStripMenuItem.Name = "TypyZdarzeńToolStripMenuItem";
            this.TypyZdarzeńToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TypyZdarzeńToolStripMenuItem.Text = "Typy zdarzeń";
            this.TypyZdarzeńToolStripMenuItem.Click += new System.EventHandler(this.TypyZdarzeńToolStripMenuItem_Click);
            // 
            // operatorToolStripMenuItem
            // 
            this.operatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zalogujToolStripMenuItem,
            this.zmienSwojeHasloToolStripMenuItem,
            this.wylogujToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
            this.operatorToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operatorToolStripMenuItem.Text = "Operator";
            // 
            // zalogujToolStripMenuItem
            // 
            this.zalogujToolStripMenuItem.Name = "zalogujToolStripMenuItem";
            this.zalogujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zalogujToolStripMenuItem.Text = "Zaloguj";
            this.zalogujToolStripMenuItem.Click += new System.EventHandler(this.zalogujToolStripMenuItem_Click);
            // 
            // zmienSwojeHasloToolStripMenuItem
            // 
            this.zmienSwojeHasloToolStripMenuItem.Name = "zmienSwojeHasloToolStripMenuItem";
            this.zmienSwojeHasloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zmienSwojeHasloToolStripMenuItem.Text = "Zmień swoje hasło";
            this.zmienSwojeHasloToolStripMenuItem.Click += new System.EventHandler(this.zmienSwojeHasloToolStripMenuItem_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zamknijToolStripMenuItem.Text = " Zamknij program";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // zarzadzanieToolStripMenuItem
            // 
            this.zarzadzanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przegladajZdarzeniaToolStripMenuItem,
            this.raportyToolStripMenuItem});
            this.zarzadzanieToolStripMenuItem.Name = "zarzadzanieToolStripMenuItem";
            this.zarzadzanieToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.zarzadzanieToolStripMenuItem.Text = "Zarządzanie";
            this.zarzadzanieToolStripMenuItem.Click += new System.EventHandler(this.ądzanieToolStripMenuItem_Click);
            // 
            // przegladajZdarzeniaToolStripMenuItem
            // 
            this.przegladajZdarzeniaToolStripMenuItem.Name = "przegladajZdarzeniaToolStripMenuItem";
            this.przegladajZdarzeniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.przegladajZdarzeniaToolStripMenuItem.Text = "Przeglądaj zdarzenia";
            // 
            // raportyToolStripMenuItem
            // 
            this.raportyToolStripMenuItem.Name = "raportyToolStripMenuItem";
            this.raportyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raportyToolStripMenuItem.Text = "Raporty";
            this.raportyToolStripMenuItem.Click += new System.EventHandler(this.raportyToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 483);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Raport Zdarzeń";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zdarzeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UzytkownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ObiektyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TypyZdarzeńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DodajZdarzeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdytujZdarzeniaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zalogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmienSwojeHasloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarzadzanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladajZdarzeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
    }
}

