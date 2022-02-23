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
    public partial class FrmWybierzZdarzenie : Form
    {
        Zdarzenia modZdarzenia = new Zdarzenia();
        ViewZdarzeniaLista modZdarzeniaView = new ViewZdarzeniaLista();
        Zalaczniki modZalaczniki = new Zalaczniki();
        List<Zalaczniki> listaZa = new List<Zalaczniki>();
        Konfigurator konfigurator = Konfigurator.GetInstance();
        int IdentyfikatorZdarzenia = 0;
        string szukajText = "";

        public FrmWybierzZdarzenie()
        {
            InitializeComponent();
        }
        void WypelnijDataGridView()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                //modZdarzenia = (Zdarzenia)db.Zdarzenia.Where(x => x.CzyZamkniete == false);
                //modZdarzeniaView = (ViewZdarzeniaLista)db.ViewZdarzeniaLista.Where(x => x.CzyZamkniete == false);

                dataGridWybierzZdarzenie.AutoGenerateColumns = false;

                if (konfigurator.CzyZalogowany)
                {

                    btnSzukaj.Enabled = true;
                    btnUsun.Enabled = true;
                    btnEdytuj.Enabled = true;

                    if (konfigurator.CzyKierownikZalogowany || konfigurator.CzyAdministratorZalogowany)
                    {
                        if (szukajText == "")
                        {
                            dataGridWybierzZdarzenie.DataSource = db.ViewZdarzeniaLista.Where(
                                s => s.IdStatus > 0 &&
                                     s.IdStatus < 4
                                ).ToList<ViewZdarzeniaLista>();
                        }
                        else
                        {
                            dataGridWybierzZdarzenie.DataSource = db.ViewZdarzeniaLista.Where(
                                s => s.Nazwa.Contains(szukajText) &&
                                     s.IdStatus > 0 &&
                                     s.IdStatus < 3
                                ).ToList<ViewZdarzeniaLista>();
                            //dataGridWybierzZdarzenie.DataSource = db.ViewZdarzeniaLista.Where(s => s.Nazwa.Contains(szukajText)).ToList<ViewZdarzeniaLista>();

                            //where e.Title.Contains("developer")
                        }
                    }
                    else
                    {
                        if (szukajText == "")
                        {
                            dataGridWybierzZdarzenie.DataSource = db.ViewZdarzeniaLista.Where(
                                s => s.IdStatus == 1 ||
                                     s.IdStatus == 3
                                ).ToList<ViewZdarzeniaLista>();
                        }
                        else
                        {
                            dataGridWybierzZdarzenie.DataSource = db.ViewZdarzeniaLista.Where(
                                s => s.Nazwa.Contains(szukajText) &&
                                     s.IdStatus == 1 ||
                                     s.IdStatus == 3
                                ).ToList<ViewZdarzeniaLista>();
                            // dataGridWybierzZdarzenie.DataSource = db.ViewZdarzeniaLista.Where(s => s.Nazwa.Contains(szukajText)).ToList<ViewZdarzeniaLista>();


                            //dataGridWybierzZdarzenie.DataSource = db.ViewZdarzeniaLista.Where(s => s.Nazwa.Contains(szukajText)).ToList<ViewZdarzeniaLista>();
                        }
                    }
                }
                else
                {
                    //dla Niezalogowanego
                    btnSzukaj.Enabled = false;
                    btnUsun.Enabled = false;
                    btnEdytuj.Enabled = false;
                }



                //dataGridWybierzZdarzenie.DataSource = (ViewZdarzeniaLista)db.ViewZdarzeniaLista.Where(x => x.CzyZamkniete == false);
                dataGridWybierzZdarzenie.ClearSelection();
                btnUsun.Enabled = false;
                btnEdytuj.Enabled = false;
                //modZdarzenia = null;
                //modZalaczniki = null;

            }
        }

        private void FrmWybierzZdarzenie_Load(object sender, EventArgs e)
        {
            WypelnijDataGridView();
        
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien że chcesz usunąć to zdarzenie ?", "Usuń zdarzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                {

                    //context.Entry(newStudent).State = newStudent.StudentID == 0 ? EntityState.Added : EntityState.Modified;
                    //context.Entry(existingStudent).State = existingStudent.StudentID == 0 ? EntityState.Added : EntityState.Modified;
                    bool czysc = true;
                    do
                    {
                        modZalaczniki = db.Zalaczniki.Where(x => x.Zdarzenie == IdentyfikatorZdarzenia).FirstOrDefault();
                        if (modZalaczniki != null)
                        {
                            var entry1 = db.Entry(modZalaczniki);
                            if (entry1.State == System.Data.Entity.EntityState.Detached)
                            {
                                db.Zalaczniki.Attach(modZalaczniki);
                            }
                            else
                            { czysc = true; }
                            db.Zalaczniki.Remove(modZalaczniki);
                            db.SaveChanges();
                            //modZalaczniki.IdZalacznik = 0;
                        }
                        else {czysc = false;}
                    }
                        
                    while (czysc);
                    //var entry1 = db.Entry(modZalaczniki);
                    //if (entry1.State == System.Data.Entity.EntityState.Detached)
                    //    db.Zalaczniki.Attach(modZalaczniki);
                    //db.Zalaczniki.Remove(modZalaczniki);
                    //db.SaveChanges();


                    var entry = db.Entry(modZdarzenia);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Zdarzenia.Attach(modZdarzenia);
                    db.Zdarzenia.Remove(modZdarzenia);

                    //context.Students.Remove(newStudent);
                    //context.SaveChanges(); // Executes Delete command

                    db.SaveChanges();
                    IdentyfikatorZdarzenia = 0;

                    szukajText = "";
                    WypelnijDataGridView();
                    //Clear();   // TODO WYCZYŚĆ POLE SZUKAJ
                    MessageBox.Show("Usunięto zdarzenie","Usuwanie zdarzeń");
                }
        }

        private void dataGridWybierzZdarzenie_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridWybierzZdarzenie.CurrentRow != null)
                {
                    IdentyfikatorZdarzenia = Convert.ToInt32(dataGridWybierzZdarzenie.CurrentRow.Cells["IdZdarzenia"].Value);

                    using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                    {
                        modZdarzenia = db.Zdarzenia.Where(x => x.IdZdarzenia == IdentyfikatorZdarzenia).FirstOrDefault();
                    }
                    btnUsun.Enabled = true;
                    btnEdytuj.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            przeslijIdDoEdycji(IdentyfikatorZdarzenia);
        }
        public void przeslijIdDoEdycji(int Id)
        {
            //int idDoEdycji;
            // idDoEdycji = Id;
            frmEdytujZdarzenie frmWyb = new frmEdytujZdarzenie();
            frmWyb.LoadOrders(Id);
            frmWyb.MdiParent = this.MdiParent;
            frmWyb.Show();
            this.Close();
            
            
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            szukajText = txtSzukaj.Text.Trim();
            WypelnijDataGridView();
        }
    }
}


