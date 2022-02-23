using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RaportZdarzen
{
    public partial class frmEdytujZdarzenie : Form
    {
        Zdarzenia modZdarzenia = new Zdarzenia();
        Obiekty modObiekty = new Obiekty();
        Zalaczniki modZalaczniki = new Zalaczniki();
        TypyZdarzen modTypyZdarzen = new TypyZdarzen();
        StatusZdarzenia modStatusZdarzenia = new StatusZdarzenia();
        List<Zalaczniki> listaZ = new List<Zalaczniki>();
        List<Zalaczniki> listaUsun = new List<Zalaczniki>();
        Konfigurator konfigurator = Konfigurator.GetInstance();
        int licznikListaNowe = 0;
        int IdentyfikatorZdarzenia = 0;
        internal void LoadOrders(int Id)
        {
            IdentyfikatorZdarzenia = Id;
            label1.Text = IdentyfikatorZdarzenia.ToString();

            if (konfigurator.CzyZalogowany)
            {

                btnZapisz.Enabled = btnZapisz.Visible = true;
                btnZamknij.Enabled = btnZamknij.Visible = true;

                if (konfigurator.CzyKierownikZalogowany)
                {
                    btnPrzekaz.Enabled = btnPrzekaz.Visible = false;
                    btnOdrzuc.Enabled = btnOdrzuc.Visible = true;
                    btnZatwierdz.Enabled = btnZatwierdz.Visible = true;
                }
                else
                {
                    btnPrzekaz.Enabled = btnPrzekaz.Visible = true;
                    btnOdrzuc.Enabled = btnOdrzuc.Visible = false;
                    btnZatwierdz.Enabled = btnZatwierdz.Visible = false;
                }
            }
            else
            {
                //dla Niezalogowanego
                btnZapisz.Enabled = btnZapisz.Visible = false;
                btnZamknij.Enabled = btnZamknij.Visible = true;
                btnOdrzuc.Enabled = btnOdrzuc.Visible = false;
                btnZatwierdz.Enabled = btnZatwierdz.Visible = false;
            }


        }
        public frmEdytujZdarzenie()
        {
            InitializeComponent();
        }

        private void zamknijOkno()
        {
            FrmWybierzZdarzenie fWybierzZdarzenie = new FrmWybierzZdarzenie();
            fWybierzZdarzenie.MdiParent = this.MdiParent;
            fWybierzZdarzenie.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)  //TO Anuluj
        {
            zamknijOkno();
        }

        private void frmEdytujZdarzenie_Load(object sender, EventArgs e)
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                modZdarzenia = db.Zdarzenia.Where(x => x.IdZdarzenia == IdentyfikatorZdarzenia).FirstOrDefault();
                txtNazwa.Text = modZdarzenia.Nazwa;
                rTxtOpis.Text = modZdarzenia.Opis;
                rTxtDzialania.Text = modZdarzenia.Dzialania;
                dTimeZdarzenie.Value = modZdarzenia.DataZdarzenia;
                rTxtUwagi.Text = modZdarzenia.UwagiDoZdarzenia;
            }

            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                listaZ = db.Zalaczniki.Where(x => x.Zdarzenie == IdentyfikatorZdarzenia).ToList();
            }
            WypelnijDataGridView();
            WypelnijComboBoxObiekty();
            WypelnijComboBoxTypyZdarzen();
            WypelnijNazweStatusu();
        }

        void WypelnijNazweStatusu()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                modStatusZdarzenia = db.StatusZdarzenia.Where(x => x.IdStatus == modZdarzenia.Status).FirstOrDefault();
                lablStatus.Text = modStatusZdarzenia.Nazwa.ToString();

            }
        }
        void WypelnijDataGridView()
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = listaZ.ToList();


            if (listaZ.Count == 0)      
            {
                btnPokaz.Enabled = false;
                btnUsunFoto.Enabled = false;
                btnEdytujNazwe.Enabled = false;
            }
            else
            {
                btnPokaz.Enabled = true;
                btnUsunFoto.Enabled = true;
                btnEdytujNazwe.Enabled = true;
            }
        }

        void WypelnijComboBoxObiekty()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                cBoxObiekty.ValueMember = "IdObiekt";
                cBoxObiekty.DisplayMember = "Nazwa";
                cBoxObiekty.DataSource = db.Obiekty.ToList();
                cBoxObiekty.SelectedIndex = -1;
                txtObiektOpis.Text = "W celu zmiany wybierz obiekt z listy";


                int index = -1; ;
                for (int i = 0; i < cBoxObiekty.Items.Count; i++)
                {
                    int ido = ((Obiekty)(cBoxObiekty.Items[i])).IdObiekt;
                    if (ido == modZdarzenia.Obiekt)
                    {
                        index = i;
                        cBoxObiekty.SelectedIndex = index;
                        return;
                    }

                }
            }
        }

        void WypelnijComboBoxTypyZdarzen()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                cBoxTypyZdarzen.ValueMember = "IdTypZdarzen";
                cBoxTypyZdarzen.DisplayMember = "Nazwa";
                cBoxTypyZdarzen.DataSource = db.TypyZdarzen.ToList();
                cBoxTypyZdarzen.SelectedIndex = -1;
                txtTypZdarzeniaOpis.Text = "W celu zmiany wybierz rodzaj z listy";

                int index = -1; ;
                for (int i = 0; i < cBoxTypyZdarzen.Items.Count; i++)
                {
                    int ido = ((TypyZdarzen)(cBoxTypyZdarzen.Items[i])).IdTypZdarzenia;
                    if (ido == modZdarzenia.TypZdarz)   
                    {
                        index = i;
                        cBoxTypyZdarzen.SelectedIndex = index;
                        return;
                    }

                }

            }
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Index != -1)
            {
                var wiersz = dataGridView1.CurrentRow;
                Form frmFoto = new Form()
                {
                    Size = new Size(900, 900)
                };
                PictureBox box = new PictureBox()

                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 500,
                    Image = Image.FromStream(new MemoryStream((byte[])wiersz.Cells["ZalacznikFoto"].Value)),
                    Dock = DockStyle.Fill
                };
                TextBox txtNazwaObrazka = new TextBox()
                {
                    //Dock = DockStyle.Fill,
                };
                frmFoto.Controls.Add(box);
                frmFoto.Controls.Add(txtNazwaObrazka);
                frmFoto.Show();

            }
        }

        private void btnDodajFoto_Click(object sender, EventArgs e)
        {
            Zalaczniki zal = new Zalaczniki();

            openFileDialog1.Filter = "JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpge|PNG (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] fotka = File.ReadAllBytes(openFileDialog1.FileName);
                zal.ZalacznikFoto = fotka;
                zal.Nazwa = openFileDialog1.FileName;
                licznikListaNowe--;
                zal.IdZalacznik = licznikListaNowe;
                listaZ.Add(zal);

                WypelnijDataGridView();
            }

        }

        private void cBoxObiekty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Obiekty obWybrany = cBoxObiekty.SelectedItem as Obiekty;
            if (obWybrany != null)
            {
                txtObiektOpis.Text = obWybrany.Opis + " - " + obWybrany.IdObiekt.ToString();
                modZdarzenia.Obiekt = obWybrany.IdObiekt;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cBoxTypyZdarzen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            TypyZdarzen typWybrany = cBoxTypyZdarzen.SelectedItem as TypyZdarzen;
            if (typWybrany != null)
            {
                txtTypZdarzeniaOpis.Text = typWybrany.Opis + " - " + typWybrany.IdTypZdarzenia.ToString();
                modZdarzenia.TypZdarz = typWybrany.IdTypZdarzenia;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnUsunFoto_Click(object sender, EventArgs e)
        {
            Zalaczniki zal = new Zalaczniki();
            if (dataGridView1.CurrentRow.Index != -1)
            {
                if (MessageBox.Show("Czy jesteś pewien że chcesz usunąć ten załącznik ?", "Usuń Załącznik", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var wiersz = dataGridView1.CurrentRow;
                    int idFoto = (int)wiersz.Cells["IdZalacznik"].Value;
                    if (idFoto > 0)
                    { 
                        using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                        {
                            zal = db.Zalaczniki.Where(x => x.IdZalacznik == idFoto).FirstOrDefault();
                        }
                        listaUsun.Add(zal);
                    }

                    listaZ.RemoveAll(s =>s.IdZalacznik == idFoto);  ///CZy napewno tak
                    //listaZ.Remove(ListaZ.IdZalacznik = idFoto);

                    WypelnijDataGridView();

                    //dataGridView1.DataSource = listaZ.ToList();

                    //if (listaZ.Count == 0)
                    //    btnPokaz.Enabled = false;
                    //else
                    //    btnPokaz.Enabled = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // /////////
        }

        private void btnEdytujNazwe_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                var wiersz = dataGridView1.CurrentRow;
                string fotaNazwa = (string)wiersz.Cells["Nazwa"].Value;
                int idFoto = (int)wiersz.Cells["IdZalacznik"].Value;
                Form frmNazwa = new Form();
                frmNazwa.Size = new Size(600, 200);
                frmNazwa.FormBorderStyle = FormBorderStyle.Fixed3D;
                Label labNazwaZdjecia = new Label()
                {
                    Text = "Podaj nową nazwę:",
                    //Dock = DockStyle.Top,
                    Margin = new Padding(10, 10, 10, 10),
                    Location = new Point(20, 20)
                };
                TextBox txtNazwaZdjecia = new TextBox()
                {
                    Text = fotaNazwa,
                    Margin = new Padding(10, 10, 10, 10),
                    Size = new Size(400, 30),
                    Location = new Point(20, 65)
                };
                Button btnZapiszNazwe = new Button()
                {
                    Margin = new Padding(10, 10, 10, 10),
                    Text = "Zapisz",
                    AutoSize = false,
                    Size = new Size(135,35),
                    Location = new Point(15,110)
                };
                Button btnZamknijNazwe = new Button()
                {
                    Text = "Anuluj",
                    AutoSize = false,
                    Size = new Size(135, 35),
                    Location = new Point(435, 110)
                };
                btnZapiszNazwe.DialogResult = DialogResult.OK;
                btnZamknijNazwe.DialogResult = DialogResult.Cancel;
                frmNazwa.Controls.Add(labNazwaZdjecia);
                frmNazwa.Controls.Add(txtNazwaZdjecia);
                frmNazwa.Controls.Add(btnZapiszNazwe);
                frmNazwa.Controls.Add(btnZamknijNazwe);

                //frmNazwa.Show();
                if (frmNazwa.ShowDialog(this) == DialogResult.OK)
                {
                    foreach (var item in listaZ)
                    {
                        if (item.Nazwa == fotaNazwa)
                        {

                            listaZ.RemoveAll(s => s.IdZalacznik == idFoto);
                            item.Nazwa = (string)txtNazwaZdjecia.Text.Trim();
                            //item.Nazwa = txtNazwaZdjecia;
                            listaZ.Add(item);
                            break;
                        }

                    }
                    WypelnijDataGridView();
                }
                frmNazwa.Dispose();
            }
        }
        private void btnZapiszNazwe_Click(object sender, EventArgs e)
        {
            var wiersz = dataGridView1.CurrentRow;
            string fotaNazwa = (string)wiersz.Cells["Nazwa"].Value;
            int idFoto = (int)wiersz.Cells["IdZalacznik"].Value; 
            foreach (var item in listaZ)
            {
                if (item.Nazwa == fotaNazwa)
                {
                    
                    listaZ.RemoveAll(s => s.IdZalacznik == idFoto);
                    item.Nazwa = "Nowa nazwa dokumentu - załącznika";
                    listaZ.Add(item);
                    break;
                }
                
            }

            WypelnijDataGridView();
        }
        private void ZapiszZmiany(int statusZdarzenia, Boolean nowaNazwa)
        {
            //modZdarzenia.Nazwa = txtNazwa.Text.Trim();
            modZdarzenia.Opis = rTxtOpis.Text;
            modZdarzenia.Dzialania = rTxtDzialania.Text;
            modZdarzenia.UwagiDoZdarzenia = rTxtUwagi.Text;


            bool sprawdzNazwa = nowaNazwa;


            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                Zdarzenia szukaj = new Zdarzenia();
                if (nowaNazwa) 
                {
                    szukaj = db.Zdarzenia.Where(x => x.Nazwa == txtNazwa.Text.Trim()).FirstOrDefault();
                }
                else
                {
                    szukaj = null;
                }
                if (szukaj == null) //
                {
                    //MessageBox.Show($"TO ZAPISUJEMY", ";-)");
                    modZdarzenia.Nazwa = txtNazwa.Text.Trim(); // Przypisanie nowej nazwy po weryfikacji
                    modZdarzenia.DataZdarzenia = dTimeZdarzenie.Value;
                    modZdarzenia.Status = statusZdarzenia;
                    db.Entry(modZdarzenia).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    foreach (var item in listaUsun)
                    {
                        var entry = db.Entry(item);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                            db.Zalaczniki.Attach(item);
                        db.Zalaczniki.Remove(item);
                    }

                    int id = modZdarzenia.IdZdarzenia;
                    foreach (var item in listaZ)
                    {
                        if (item.IdZalacznik < 0)
                        {
                            item.Zdarzenie = id;
                            item.IdZalacznik = 0;
                            db.Zalaczniki.Add(item);
                        }
                        else
                            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();

                }
                else
                {
                    if (nowaNazwa) /////(txtNazwa.Text.Trim() != modZdarzenia.Nazwa.Trim())
                    {
                        MessageBox.Show($"Nieudana zmiana nazwy, taka nazwa zdarzenia: \n'{txtNazwa.Text.Trim()}'\n jest już w bazie, zmień nazwę","Błąd zmiany nazwy");
                    }
                    return;
                }
            }
            zamknijOkno();
        }
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            bool zmianaNazwy;
            if (txtNazwa.Text.Trim() == "" ||
                rTxtOpis.Text.Trim() == "" ||
                txtObiektOpis.Text == "Wybierz obiekt z listy" ||
                txtTypZdarzeniaOpis.Text == "Wybierz typ zdarzenia z listy")
            {
                MessageBox.Show("Niekompletne dane dla tego zdarzenia.\n\nWymagane dane: \n\nNazwa zdarzenia \nOpis zdarzenia \nObiekt zdarzenia \nTyp zdarzenia", "Nowe zdrzenie");
                return;
            }
            if (txtNazwa.Text.Trim() != modZdarzenia.Nazwa.Trim())
            {
                zmianaNazwy = true;
            }
            else
            {
                zmianaNazwy = false;
            }
            int statusZdarzenia = modZdarzenia.Status;
            ZapiszZmiany(statusZdarzenia, zmianaNazwy);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////
        }

        private void btnPrzekaz_Click(object sender, EventArgs e)
        {
            bool zmianaNazwy;
            if (txtNazwa.Text == "" ||
                rTxtOpis.Text == "" ||
                txtObiektOpis.Text == "Wybierz obiekt z listy" ||
                txtTypZdarzeniaOpis.Text == "Wybierz typ zdarzenia z listy")
            {
                MessageBox.Show("Niekompletne dane dla tego zdarzenia.\n\nWymagane dane: \n\nNazwa zdarzenia \nOpis zdarzenia \nObiekt zdarzenia \nTyp zdarzenia", "Przekazanie zdarzenia do zatwierdzenia");
                return;
            }
            if (txtNazwa.Text.Trim() != modZdarzenia.Nazwa.Trim())
            {
                zmianaNazwy = true;
            }
            else
            {
                zmianaNazwy = false;
            }
            int statusZdarzenia = 2;
            ZapiszZmiany(statusZdarzenia, zmianaNazwy);
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            bool zmianaNazwy;
            if (txtNazwa.Text == "" ||
                rTxtOpis.Text == "" ||
                txtObiektOpis.Text == "Wybierz obiekt z listy" ||
                txtTypZdarzeniaOpis.Text == "Wybierz typ zdarzenia z listy")
            {
                MessageBox.Show("Niekompletne dane dla tego zdarzenia.\n\nWymagane dane: \n\nNazwa zdarzenia \nOpis zdarzenia \nObiekt zdarzenia \nTyp zdarzenia", "Zatwierdzenie zdrzenia");
                return;
            }
            if (txtNazwa.Text.Trim() != modZdarzenia.Nazwa.Trim())
            {
                zmianaNazwy = true;
            }
            else
            {
                zmianaNazwy = false;
            }
            int statusZdarzenia = 4;
            ZapiszZmiany(statusZdarzenia, zmianaNazwy);
        }

        private void btnOdrzuc_Click(object sender, EventArgs e)
        {
            bool zmianaNazwy;
            if (txtNazwa.Text.Trim() == "" ||
                rTxtOpis.Text.Trim() == "" ||
                txtObiektOpis.Text == "Wybierz obiekt z listy" ||
                txtTypZdarzeniaOpis.Text == "Wybierz typ zdarzenia z listy")
            {
                MessageBox.Show("Niekompletne dane dla tego zdarzenia.\n\nWymagane dane: \n\nNazwa zdarzenia \nOpis zdarzenia \nObiekt zdarzenia \nTyp zdarzenia", "Odrzucenie zdarzenia");
                return;
            }
            if (rTxtUwagi.Text.Trim() == "")
            {
                MessageBox.Show("W przypadku odrzucenia dokumentacji zdarzenia do poprawieni\nkonieczne jest wprowadzenie uwag do dokumentacji", "Odrzucenia zdrzenia");
                return;
            }
            if (txtNazwa.Text.Trim() != modZdarzenia.Nazwa.Trim())
            {
                zmianaNazwy = true;
            }
            else
            {
                zmianaNazwy = false;
            }
            int statusZdarzenia = 3;
            ZapiszZmiany(statusZdarzenia, zmianaNazwy);
        }
    }
}
