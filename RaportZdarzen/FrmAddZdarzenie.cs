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
    public partial class FrmAddZdarzenie : Form
    {
        Zdarzenia modZdarzenia = new Zdarzenia();
        Obiekty modObiekty = new Obiekty();
        TypyZdarzen modTypyZdarzen = new TypyZdarzen();
        List<Zalaczniki> listaZ = new List<Zalaczniki>();
        Konfigurator konfigurator = Konfigurator.GetInstance();
        public FrmAddZdarzenie()
        {
            InitializeComponent();
        }

        private void FrmAddZdarzenie_Load(object sender, EventArgs e)
        {
            WypelnijDataGridView();
            WypelnijComboBoxObiekty();
            WypelnijComboBoxTypyZdarzen();
            modZdarzenia.IdZdarzenia = 0;
            dTimeZdarzenie.Value = System.DateTime.Now;
         
        }

        void WypelnijDataGridView()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                dataGridView1.AutoGenerateColumns = false;
                listaZ.Clear();
                dataGridView1.DataSource = listaZ.ToList();
                if (listaZ.Count == 0)
                    btnPokaz.Enabled = btnZmienNazwe.Enabled = btnUsunFoto.Enabled = false;
                else
                    btnPokaz.Enabled = btnZmienNazwe.Enabled = btnUsunFoto.Enabled = true;

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
                txtObiektOpis.Text = "Wybierz obiekt z listy";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Nowe zdarzenie";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        void WypelnijComboBoxTypyZdarzen()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                cBoxTypyZdarzen.ValueMember = "IdTypZdarzen";
                cBoxTypyZdarzen.DisplayMember = "Nazwa";
                cBoxTypyZdarzen.DataSource = db.TypyZdarzen.ToList();
                cBoxTypyZdarzen.SelectedIndex = -1;
                txtTypZdarzeniaOpis.Text = "Wybierz obiekt z listy";

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (txtNazwa.Text == "" ||
                rTxtOpis.Text == "" ||
                txtObiektOpis.Text == "Wybierz obiekt z listy" ||
                txtTypZdarzeniaOpis.Text == "Wybierz obiekt z listy")
            {
                MessageBox.Show("Niekompletne dane dla nowego zdarzenia.\n\nWymagane dane: \n\nNazwa zdarzenia \nOpis zdarzenia \nObiekt \nTyp","Nowe zdrzenie");
                return;
            }

            int statusZdarzenia = 1;
            ZapiszZdarzenie(statusZdarzenia);
        }

        void Clear()
        {
            modZdarzenia = new Zdarzenia();
            Obiekty modObiekty = new Obiekty();
            TypyZdarzen modTypyZdarzen = new TypyZdarzen();
            List<Zalaczniki> listaZ = new List<Zalaczniki>();

            modZdarzenia.IdZdarzenia = 0;
            txtNazwa.Text = "";
            rTxtOpis.Text = rTxtDzialania.Text = "";
            cBoxObiekty.SelectedIndex = -1;
            txtObiektOpis.Text = "Wybierz obiekt z listy";
            cBoxTypyZdarzen.SelectedIndex = -1;
            txtTypZdarzeniaOpis.Text = "Wybierz typ zdarzenia z listy";
            dTimeZdarzenie.Value = System.DateTime.Now;
            dataGridView1.DataSource = listaZ.ToList();
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
                listaZ.Add(zal);
                dataGridView1.DataSource = listaZ.ToList();
                if (listaZ.Count == 0)
                    btnPokaz.Enabled = btnZmienNazwe.Enabled = btnUsunFoto.Enabled = false;
                else
                    btnPokaz.Enabled = btnZmienNazwe.Enabled = btnUsunFoto.Enabled = true;
            }

                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1 )
            {
                var wiersz = dataGridView1.CurrentRow;
                Form frmFoto = new Form()
                {
                    Size = new Size(900, 900)
                };
                PictureBox box = new PictureBox()
                
                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 900,
                    Dock = DockStyle.Fill,
                        Image = Image.FromStream(new MemoryStream((byte[])wiersz.Cells["ZalacznikFoto"].Value))
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

        private void btnZmienNazwe_Click(object sender, EventArgs e)
        {
            //============================

            if (dataGridView1.CurrentRow.Index != -1)
            {
                var wiersz = dataGridView1.CurrentRow;
                string fotaNazwa = (string)wiersz.Cells["Nazwa"].Value;
                int idFoto = (int)wiersz.Cells.Count;
                Form frmNazwa = new Form();
                frmNazwa.Size = new Size(600, 200);
                frmNazwa.FormBorderStyle = FormBorderStyle.Fixed3D;
                Label labNazwaZdjecia = new Label()
                {
                    Text = "Podaj nową nazwę:",
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
                    Size = new Size(135, 35),
                    Location = new Point(15, 110)
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

                if (frmNazwa.ShowDialog(this) == DialogResult.OK)
                {
                    foreach (var item in listaZ)
                    {
                        if (item.Nazwa == fotaNazwa)
                        {

                            listaZ.RemoveAll(s => s.Nazwa == fotaNazwa); // Usunięcie zmodyfikowanego elementu z listy
                            item.Nazwa = (string)txtNazwaZdjecia.Text.Trim();
                            listaZ.Add(item); // Dodanie elementu po modyfikacji
                            break;
                        }
                    }
                    dataGridView1.DataSource = listaZ.ToList();
                    if (listaZ.Count == 0)
                        btnPokaz.Enabled = btnZmienNazwe.Enabled = btnUsunFoto.Enabled = false;
                    else
                        btnPokaz.Enabled = btnZmienNazwe.Enabled = btnUsunFoto.Enabled = true;
                }
                frmNazwa.Dispose();
            }

            //============================
        }

        private void btnUsunFoto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                var wiersz = dataGridView1.CurrentRow;
                string fotaNazwa = (string)wiersz.Cells["Nazwa"].Value;
                int idFoto = (int)wiersz.Cells.Count;

                    foreach (var item in listaZ)
                    {
                        if (item.Nazwa == fotaNazwa)
                        {
                            listaZ.RemoveAll(s => s.Nazwa == fotaNazwa); // Usunięcie elementu z listy
                            break;
                        }
                    }
                    dataGridView1.DataSource = listaZ.ToList();
                    if (listaZ.Count == 0)
                        btnPokaz.Enabled = btnZmienNazwe.Enabled = btnUsunFoto.Enabled = false;
                    else
                        btnPokaz.Enabled = btnZmienNazwe.Enabled = btnUsunFoto.Enabled = true;
            }
        }
        private void ZapiszZdarzenie(int statusZdarzenia)
        {

            modZdarzenia.Nazwa = txtNazwa.Text.Trim();
            modZdarzenia.Opis = rTxtOpis.Text;
            modZdarzenia.Dzialania = rTxtDzialania.Text;
            modZdarzenia.DataZdarzenia = dTimeZdarzenie.Value;
            modZdarzenia.Status = statusZdarzenia;
;

            modZdarzenia.Uzytkownik = konfigurator.IdZalogowany;


            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {


                Zdarzenia szukaj = db.Zdarzenia.Where(x => x.Nazwa == txtNazwa.Text.Trim()).FirstOrDefault();
                if (szukaj == null) //Sprawdzenie czy niema takiego loginu w bazie
                {
                    int ostatniNrZdarzenia = db.Zdarzenia.Max(x => x.NrZdarzenia);
                    modZdarzenia.NrZdarzenia = ostatniNrZdarzenia + 1;
                    db.Zdarzenia.Add(modZdarzenia);
                    db.SaveChanges();
                    int id = modZdarzenia.IdZdarzenia;
                    foreach (var item in listaZ)
                    {
                        item.Zdarzenie = id;
                        db.Zalaczniki.Add(item);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Zapisano nowe zdarzenie w bazie");
                }
                else
                {
                    MessageBox.Show($"Nazwa zdarzenia '{txtNazwa.Text.Trim()}'jest już w bazie, zmień nazwę");
                    return;
                }
            }
            Clear();
            WypelnijDataGridView();

        }

        private void btnZakoncz_Click(object sender, EventArgs e)
        {
            if (txtNazwa.Text.Trim() == "" ||
                rTxtOpis.Text.Trim() == "" ||
                txtObiektOpis.Text == "Wybierz obiekt z listy" ||
                txtTypZdarzeniaOpis.Text == "Wybierz typ zdarzenia z listy")
            {
                MessageBox.Show("Niekompletne dane dla nowego zdarzenia.\n\nWymagane dane: \n\nNazwa zdarzenia \nOpis zdarzenia \nObiekt zdarzenia \nTyp zdarzenia", "Nowe zdrzenie");
                return;
            }

            int statusZdarzenia = 2;
            ZapiszZdarzenie(statusZdarzenia);
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Clear();
            WypelnijDataGridView();
        }
    }
}
