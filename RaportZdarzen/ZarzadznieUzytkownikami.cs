using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RaportZdarzen
{
    public partial class frmZarzadznieUzytkownikami : Form
    {
        Users model = new Users();
        public frmZarzadznieUzytkownikami()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Clear();
            WypelnijDataGridView();
        }

        void Clear()
        {
            txtLogin.Text = txtNazwisko.Text = txtHaslo.Text = txtImie.Text = "";
            chkBoxAdministrator.Checked = chkBoxKierownik.Checked = chkBoxZablokowany.Checked = false;
            dateTimePickerStart.Value = System.DateTime.Today;
            dateTimePickerStop.Value = System.DateTime.Today.AddDays(1);
            chkBoxZmienHaslo.Enabled = false;
            chkBoxZmienHaslo.Visible = false;
            btnZapisz.Text = "Zapisz";
            btnUsun.Enabled = false;
            model.Id = 0;
        }

        private void frmZarzadznieUzytkownikami_Load(object sender, EventArgs e)
        {
            Clear();
            WypelnijDataGridView();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtNazwisko.Text == "" || txtHaslo.Text == "" || txtImie.Text == "")
            {
                MessageBox.Show("Niekompletne dane nowego użytkownika.\n\nWymagane dane: \n\nLogin \nHasło \nNazwisko \nImie", "Nowy użytkownik");
                return;
            }                
            model.login = txtLogin.Text.Trim();
            model.Nazwisko = txtNazwisko.Text.Trim();
            model.Imie = txtImie.Text.Trim();
            model.CzyNoweHaslo = true;
            ///====================
            model.DataDodania = dateTimePickerStart.Value;    //System.DateTime.Now;
            model.DataKoniec = dateTimePickerStop.Value;      //System.DateTime.Now;
            if (chkBoxAdministrator.Checked)
            {
                model.CzyAdministrator = true;
            }
            else
            {
                model.CzyAdministrator = false;
            }
            if (chkBoxKierownik.Checked)
            {
                model.CzyKierownik = true;
            }
            else
            {
                model.CzyKierownik = false;
            }
            if (chkBoxZablokowany.Checked)
            {
                model.CzyZablokowany = true;
            }
            else
            {
                model.CzyZablokowany = false;
            }

            ///================

            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                if (model.Id == 0)  // Dodanie nowego rekordu (INSERT)
                {
                    Users szukaj = db.Users.Where(x => x.login == txtLogin.Text.Trim()).FirstOrDefault();
                    if (szukaj == null) //Sprawdzenie czy niema takiego loginu w bazie
                    {
                        using (SHA256 sha256Hash = SHA256.Create())
                        {
                            model.haslo = Ochrona.Szyfruj(sha256Hash, txtHaslo.Text.Trim());
                        }
                        db.Users.Add(model);
                        db.SaveChanges();
                        MessageBox.Show("Zapisano nowego użytkownika");
                    }
                    else
                    {
                        MessageBox.Show($"Login '{txtLogin.Text.Trim()}'jest już w bazie przypisany jest do użytkownika '{szukaj.Nazwisko} {szukaj.Imie}' jest już w bazie zmień login");
                    }
                }
                else // Zapisanie zmian w rekordzie (UPDATE)
                {
                    if (chkBoxZmienHaslo.Checked)
                        using (SHA256 sha256Hash = SHA256.Create())
                        {
                            model.haslo = Ochrona.Szyfruj(sha256Hash, txtHaslo.Text.Trim());
                            model.CzyNoweHaslo = true;
                        }
                    else
                    {

                    }
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified; 
                    db.SaveChanges();
                    MessageBox.Show("Zapisano zmiany w danych użytkownika");
                }
            }
            Clear();
            WypelnijDataGridView();
            
        }

        void WypelnijDataGridView()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                dgvUzytkownicy.AutoGenerateColumns = false;
                dgvUzytkownicy.DataSource = db.Users.ToList<Users>();
            }
        }


        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUzytkownicy_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUzytkownicy.CurrentRow.Index != -1)
            {
                model.Id = Convert.ToInt32(dgvUzytkownicy.CurrentRow.Cells["Id"].Value);
                using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                {
                    model = db.Users.Where(x => x.Id == model.Id).FirstOrDefault();
                    txtLogin.Text = model.login;
                    txtHaslo.Text = "******";
                    txtHaslo.Enabled = false;
                    chkBoxZmienHaslo.Enabled = true;
                    chkBoxZmienHaslo.Visible = true;
                    txtNazwisko.Text = model.Nazwisko;
                    txtImie.Text = model.Imie;
                    dateTimePickerStart.Value = model.DataDodania;
                    dateTimePickerStop.Value = model.DataKoniec; 
                    if (model.CzyAdministrator)
                    {
                        chkBoxAdministrator.Checked = true;
                    }
                    else
                    {
                        chkBoxAdministrator.Checked = false;
                    }
                    if (model.CzyKierownik)
                    {
                        chkBoxKierownik.Checked = true;
                    }
                    else
                    {
                        chkBoxKierownik.Checked = false;
                    }
                    if (model.CzyZablokowany)
                    {
                        chkBoxZablokowany.Checked = true;
                    }
                    else
                    {
                        chkBoxZablokowany.Checked = false;
                    }
                }
                btnZapisz.Text = "Zapisz zmiany";
                btnUsun.Enabled = true;
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien że chcesz usunąć tego użytkownika ?", "Usuń użytkownika", MessageBoxButtons.YesNo) == DialogResult.Yes)
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Users.Attach(model);
                    db.Users.Remove(model);
                    db.SaveChanges();
                    WypelnijDataGridView();
                    Clear();
                    MessageBox.Show("Usunięto użytkownika");
                }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvUzytkownicy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkBoxZmienHaslo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxZmienHaslo.Checked)
            {
                txtHaslo.Enabled = true;
            }
            else
            {
                txtHaslo.Enabled = false;
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////
        }
    }
}
