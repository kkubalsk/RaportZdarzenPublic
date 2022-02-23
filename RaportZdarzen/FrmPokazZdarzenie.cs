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
    public partial class FrmPokazZdarzenie : Form
    {
        Obiekty modObiekty = new Obiekty();
        Zalaczniki modZalaczniki = new Zalaczniki();
        TypyZdarzen modTypyZdarzen = new TypyZdarzen();
        List<Zalaczniki> listaZ = new List<Zalaczniki>();
        ViewZdarzenieFull modZdarzenieFull = new ViewZdarzenieFull();

        Konfigurator konfigurator = Konfigurator.GetInstance();
        int IdentyfikatorZdarzenia = 0;
        internal void LoadOrders(int Id)
        {
            IdentyfikatorZdarzenia = Id;

        }
        public FrmPokazZdarzenie()
        {
            InitializeComponent();
        }
        private void zamknijOkno()
        {
            this.Close();
        }



        private void txtNazwa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            zamknijOkno();
        }

        private void FrmPokazZdarzenie_Load(object sender, EventArgs e)
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                modZdarzenieFull = db.ViewZdarzenieFull.Where(x => x.IdZdarzenia == IdentyfikatorZdarzenia).FirstOrDefault();
                txtNazwa.Text = modZdarzenieFull.Nazwa;
                rTxtOpis.Text = modZdarzenieFull.OpisZdarzenia;
                rTxtDzialania.Text = modZdarzenieFull.Dzialania;
                txtObiektNazwa.Text = modZdarzenieFull.NazwaObiektu;
                txtObiektOpis.Text = modZdarzenieFull.OpisObiektu;
                txtTypNazwa.Text = modZdarzenieFull.NazwaTyp;
                txtTypZdarzeniaOpis.Text = modZdarzenieFull.OpisTyp;
                txtStatusNazwa.Text = modZdarzenieFull.OpisStatus;
                dTimeZdarzenie.Value = modZdarzenieFull.DataZdarzenia;

            }

            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                listaZ = db.Zalaczniki.Where(x => x.Zdarzenie == IdentyfikatorZdarzenia).ToList();
            }
            WypelnijDataGridView();
        }
        void WypelnijDataGridView()
        {

            dataGridViewPokaz.AutoGenerateColumns = false;
            dataGridViewPokaz.DataSource = listaZ.ToList();


            if (listaZ.Count == 0)      
            {
                btnPokaz.Enabled = false;
            }
            else
            {
                btnPokaz.Enabled = true;
            }
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            
                if (dataGridViewPokaz.CurrentRow.Index != -1)
                {
                    var wiersz = dataGridViewPokaz.CurrentRow;
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
    }
}
