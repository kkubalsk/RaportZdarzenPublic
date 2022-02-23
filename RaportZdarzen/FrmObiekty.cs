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
    public partial class FrmObiekty : Form
    {
        Obiekty modObiekty = new Obiekty();
        ViewObiekty modViewObiekty = new ViewObiekty();
        public FrmObiekty()
        {
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {

            modObiekty.Nazwa = txtNazwa.Text.Trim();
            modObiekty.Opis = txtOpis.Text.Trim();
            if (chkBoxCzyZablokowany.Checked)
            {
                modObiekty.CzyZablokowany = true;
            }
            else
            {
                modObiekty.CzyZablokowany = false;
            }

            ///================

            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                if (modObiekty.IdObiekt == 0)  // Dodanie nowego rekordu (INSERT)
                {
                    Obiekty szukaj = db.Obiekty.Where(x => x.Nazwa == txtNazwa.Text.Trim()).FirstOrDefault();
                    if (szukaj == null) //Sprawdzenie czy niema takiego loginu w bazie
                    {
                        db.Obiekty.Add(modObiekty);
                        db.SaveChanges();
                        MessageBox.Show("Zapisano nowy obiekt");
                    }
                    else
                    {
                        MessageBox.Show($"Login '{txtNazwa.Text.Trim()}'jest już w bazie zmień nazwę");
                    }
                }
                else // Zapisanie zmian w rekordzie (UPDATE)
                {
                    db.Entry(modObiekty).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Zapisano zmiany w danych obiektu");
                }
            }
            Clear();
            WypelnijDataGridView();


        }

        void Clear()
        {
            txtNazwa.Text = txtOpis.Text = "";
            chkBoxCzyZablokowany.Checked = false;
            btnZapisz.Text = "Zapisz";
            btnUsun.Enabled = false;
            modObiekty.IdObiekt = 0;
        }
        void WypelnijDataGridView()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                dataGridObiekty.AutoGenerateColumns = false;
                dataGridObiekty.DataSource = db.Obiekty.ToList<Obiekty>();
                //dataGridObiekty.DataSource = db.ViewObiekty.ToList<ViewObiekty>();
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Clear();
            WypelnijDataGridView();

        }

        private void FrmObiekty_Load(object sender, EventArgs e)
        {
            Clear();
            WypelnijDataGridView();
        }

        private void dataGridObiekty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridObiekty_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridObiekty.CurrentRow.Index != -1)
            {
                modObiekty.IdObiekt = Convert.ToInt32(dataGridObiekty.CurrentRow.Cells["IdObiekt"].Value);
                using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                {
                    modObiekty = db.Obiekty.Where(x => x.IdObiekt == modObiekty.IdObiekt).FirstOrDefault();
                    txtNazwa.Text = modObiekty.Nazwa;
                    txtOpis.Text = modObiekty.Opis;
                    if (modObiekty.CzyZablokowany)
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
            if (MessageBox.Show("Czy jesteś pewien że chcesz usunąć ten objekt ?", "Usuń obiekt", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                {
                    var entry = db.Entry(modObiekty);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Obiekty.Attach(modObiekty);
                    db.Obiekty.Remove(modObiekty);
                    db.SaveChanges();
                    WypelnijDataGridView();
                    Clear();
                    MessageBox.Show("Usunięto obiekt");
                }

        }

        private void dataGridObiekty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // modObiekty =(Obiekty)dataGridObiekty.CurrentRow.DataBoundItem;
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
