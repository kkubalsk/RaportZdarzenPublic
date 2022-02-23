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
    public partial class FrmTypyZdarzen : Form
    {
        TypyZdarzen modTypyZdarzen = new TypyZdarzen();
        public FrmTypyZdarzen()
        {
            InitializeComponent();
        }

        private void FrmTypyZdarzen_Load(object sender, EventArgs e)
        {
            Clear();
            WypelnijDataGridView();
        }
        void Clear()
        {
            txtNazwa.Text = txtOpis.Text = "";
            chkBoxCzyZablokowany.Checked = false;
            btnZapisz.Text = "Zapisz";
            btnUsun.Enabled = false;
            modTypyZdarzen.IdTypZdarzenia = 0;
        }
        void WypelnijDataGridView()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                dataGridTypyZdarzen.AutoGenerateColumns = false;
                dataGridTypyZdarzen.DataSource = db.TypyZdarzen.ToList<TypyZdarzen>();
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Clear();
            WypelnijDataGridView();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            modTypyZdarzen.Nazwa = txtNazwa.Text.Trim();
            modTypyZdarzen.Opis = txtOpis.Text.Trim();
            if (chkBoxCzyZablokowany.Checked)
            {
                modTypyZdarzen.CzyZablokowany = true;
            }
            else
            {
                modTypyZdarzen.CzyZablokowany = false;
            }

            ///================

            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                if (modTypyZdarzen.IdTypZdarzenia == 0)  // Dodanie nowego rekordu (INSERT)
                {
                    TypyZdarzen szukaj = db.TypyZdarzen.Where(x => x.Nazwa == txtNazwa.Text.Trim()).FirstOrDefault();
                    if (szukaj == null) //Sprawdzenie czy niema takiego loginu w bazie
                    {
                        db.TypyZdarzen.Add(modTypyZdarzen);
                        db.SaveChanges();
                        MessageBox.Show("Zapisano nowy rodzaj zdarzenia");
                    }
                    else
                    {
                        MessageBox.Show($"Nazwa zdarzenia '{txtNazwa.Text.Trim()}'jest już w bazie, zmień nazwę");
                    }
                }
                else // Zapisanie zmian w rekordzie (UPDATE)
                {
                    db.Entry(modTypyZdarzen).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Zapisano zmiany w danych rodzaju zdarzenia");
                }
            }
            Clear();
            WypelnijDataGridView();
        }

        private void dataGridTypyZdarzen_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridTypyZdarzen.CurrentRow.Index != -1)
            {
                modTypyZdarzen.IdTypZdarzenia = Convert.ToInt32(dataGridTypyZdarzen.CurrentRow.Cells["IdTypZdarzenia"].Value);
                using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                {
                    modTypyZdarzen = db.TypyZdarzen.Where(x => x.IdTypZdarzenia == modTypyZdarzen.IdTypZdarzenia).FirstOrDefault();
                    txtNazwa.Text = modTypyZdarzen.Nazwa;
                    txtOpis.Text = modTypyZdarzen.Opis;
                    if (modTypyZdarzen.CzyZablokowany)
                    {
                        chkBoxCzyZablokowany.Checked = true;
                    }
                    else
                    {
                        chkBoxCzyZablokowany.Checked = false;
                    }
                }
                btnZapisz.Text = "Zapisz zmiany";
                btnUsun.Enabled = true;
            }
        }
        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien że chcesz usunąć ten rodzaj zdarzeń ?", "Usuń rodzaj zdarzenia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                {
                    var entry = db.Entry(modTypyZdarzen);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.TypyZdarzen.Attach(modTypyZdarzen);
                    db.TypyZdarzen.Remove(modTypyZdarzen);
                    db.SaveChanges();
                    WypelnijDataGridView();
                    Clear();
                    MessageBox.Show("Usunięto rodzaj zdarzenia");
                }
        }
    }
}

