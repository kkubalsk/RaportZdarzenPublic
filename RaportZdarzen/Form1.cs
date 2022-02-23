using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaportZdarzen
{
    public partial class FrmMain : Form
    {
        //Users model = new Users();
        Konfigurator konfigurator = Konfigurator.GetInstance();
        public FrmMain()
        {
            InitializeComponent();
            konfigurator.CzyZalogowany = false;
            UstawMenu();


            //dla usera
            //if (konfigurator.CzyZalogowany)
            //    zalogujToolStripMenuItem.Enabled = false;
            //else
            //    zalogujToolStripMenuItem.Enabled = true;
            //DodajZdarzeniaToolStripMenuItem.Enabled = false;
            //EdytujZdarzeniaToolStripMenuItem.Enabled = false;

            ////dla admin 
            //TypyZdarzeńToolStripMenuItem.Enabled = false;
            //UzytkownicyToolStripMenuItem.Enabled = false;
            //ObiektyToolStripMenuItem.Enabled = false;

            //// dla kierownika
            ///


            //FrmRaporty frmRap = new FrmRaporty();
            //frmRap.MdiParent = this;
            //frmRap.Show();

            FrmLogowanie frmlg = new FrmLogowanie();
            frmlg.MdiParent = this;
            frmlg.Show();
        }

        private void UzytkownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (konfigurator.CzyZalogowany)
            {
                frmZarzadznieUzytkownikami frm = new frmZarzadznieUzytkownikami();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Musisz być zalogowany");
            }
        }

        private void ObiektyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmObiekty fObiekty = new FrmObiekty();
            fObiekty.MdiParent = this;
            fObiekty.Show();
        }

        private void TypyZdarzeńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTypyZdarzen fTypyZdarzen = new FrmTypyZdarzen();
            fTypyZdarzen.MdiParent = this;
            fTypyZdarzen.Show();
        }

        private void DodajZdarzeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DodajZdarzeniaToolStripMenuItem
            FrmAddZdarzenie fAddZdarzenie = new FrmAddZdarzenie();
            fAddZdarzenie.MdiParent = this;
            fAddZdarzenie.Show();

        }

        private void EdytujZdarzeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWybierzZdarzenie fWybierzZdarzenie = new FrmWybierzZdarzenie();
            fWybierzZdarzenie.MdiParent = this;
            fWybierzZdarzenie.Show();
          }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //sprawdzasz czy ma uprawnienia w bazie try catch

            try
            {
                
            }
            catch (Exception)
            {
                e.Result = false;
                throw;
            }
  
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool uprw = (bool)e.Result;
            //if (uprw)
            //singltert
            
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            logoutUser();
        }

        private void logoutUser()
        {
            LogiUzytkownikow modLogi = new LogiUzytkownikow();

            using (ZdarzeniaEntities lg = new ZdarzeniaEntities())
            {
                if (konfigurator.CzyZalogowany)
                {
                    modLogi.Uzytkownik = konfigurator.IdZalogowany;
                    modLogi.Opis = $" Wylogowanie użytkownika: {konfigurator.loginZalogowany}";

                    konfigurator.CzyZalogowany = false;
                    konfigurator.loginZalogowany = "";
                    konfigurator.IdZalogowany = 0;
                    konfigurator.komputerek = "";
                    konfigurator.CzyAdministratorZalogowany = false;
                    konfigurator.CzyKierownikZalogowany = false;
                    konfigurator.CzyZablokowanyZalogowany = true;
                }
                else
                {
                    modLogi.Uzytkownik = -1;
                    modLogi.Opis = " Zamknięcie systemu zdarzenia";
                }
                modLogi.IdLogi = 0;
                modLogi.Komputer = Environment.MachineName;
                modLogi.DataCzasLogu = System.DateTime.Now;
                lg.LogiUzytkownikow.Add(modLogi);
                lg.SaveChanges();
            }
        }

        private void zalogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogowanie frmlg = new FrmLogowanie();
            frmlg.MdiParent = this;
            frmlg.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logoutUser();
        }

        private void zmienSwojeHasloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZmienHaslo frmWyloguj = new FrmZmienHaslo();
            //frmWyloguj.MdiParent = this;
            frmWyloguj.Owner = this;
            frmWyloguj.Show();
            //frmWyloguj.ShowDialog();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            UstawMenu();
        }
        public void UstawMenu()
        {
            if (konfigurator.CzyZalogowany)
            {

                zalogujToolStripMenuItem.Enabled = false;
                wylogujToolStripMenuItem.Enabled = true;
                zmienSwojeHasloToolStripMenuItem.Enabled = true;
                DodajZdarzeniaToolStripMenuItem.Enabled = true;
                EdytujZdarzeniaToolStripMenuItem.Enabled = true;
                
                if (konfigurator.CzyAdministratorZalogowany)
                {
                    TypyZdarzeńToolStripMenuItem.Enabled = true;
                    UzytkownicyToolStripMenuItem.Enabled = true;
                    ObiektyToolStripMenuItem.Enabled = true;
                }
                else
                {
                    TypyZdarzeńToolStripMenuItem.Enabled = false;
                    UzytkownicyToolStripMenuItem.Enabled = false;
                    ObiektyToolStripMenuItem.Enabled = false;
                }

                if (konfigurator.CzyKierownikZalogowany)
                {
                    raportyToolStripMenuItem.Enabled = true;
                }
                else
                {
                    raportyToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                //dla wszystkich
                zalogujToolStripMenuItem.Enabled = true;
                wylogujToolStripMenuItem.Enabled = false;
                zmienSwojeHasloToolStripMenuItem.Enabled = false;
                //dla uzytkownika
                DodajZdarzeniaToolStripMenuItem.Enabled = false;
                EdytujZdarzeniaToolStripMenuItem.Enabled = false;
                //dla admina
                TypyZdarzeńToolStripMenuItem.Enabled = false;
                UzytkownicyToolStripMenuItem.Enabled = false;
                ObiektyToolStripMenuItem.Enabled = false;
                //dla kierownika
                raportyToolStripMenuItem.Enabled = false;
            }
        }

        private void ądzanieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raportyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRaporty frmRap = new FrmRaporty();
            frmRap.MdiParent = this;
            frmRap.Show();
        }
    }
}
