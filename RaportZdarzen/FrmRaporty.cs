using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace RaportZdarzen
{
    public partial class FrmRaporty : Form
    {
        Zdarzenia modZdarzenia = new Zdarzenia();
        List<ViewZdarzeniaLista> listaViewZdarzenia = new List<ViewZdarzeniaLista>();
        ViewZdarzeniaLista modZdarzeniaView = new ViewZdarzeniaLista();
        ViewZdarzenieFull modZdarzeniaViewFull = new ViewZdarzenieFull();
        Zalaczniki modZalaczniki = new Zalaczniki();
        int IdentyfikatorZdarzenia = 0;
        public FrmRaporty()
        {
            InitializeComponent();
        }
        void WypelnijDataGridView()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {

                dataGridViewRaporty.AutoGenerateColumns = false;
                dataGridViewRaporty.DataSource = listaViewZdarzenia.ToList();
                dataGridViewRaporty.ClearSelection();
                btnDoWorda.Enabled = false;
                btnDoExcela.Enabled = false;

            }
        }

        private void FrmRaporty_Load(object sender, EventArgs e)
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                listaViewZdarzenia = db.ViewZdarzeniaLista.ToList();
            }

            WypelnijcheckedListBoxObiekty();
            WypelnijcheckedListBoxTypyZdarzen();
            WypelnijcheckedListBoxStatus();
            btnSzukaj_Click(sender,e);
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewRaporty_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridViewRaporty.CurrentRow != null)
                {
                    IdentyfikatorZdarzenia = Convert.ToInt32(dataGridViewRaporty.CurrentRow.Cells["IdZdarzenia"].Value);

                    using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                    {
                        modZdarzenia = db.Zdarzenia.Where(x => x.IdZdarzenia == IdentyfikatorZdarzenia).FirstOrDefault();
                    }
                    btnDoWorda.Enabled = true;
                    btnDoExcela.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                btnDoWorda.Enabled = false;
                btnDoExcela.Enabled = false;
            }

        }
        private void WypelnijcheckedListBoxObiekty()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {

                checkedListBoxObiekty.DataSource = db.Obiekty.ToList();
                checkedListBoxObiekty.ValueMember = "IdObiekt";
                checkedListBoxObiekty.DisplayMember = "Nazwa";
                for (int i = 0; i < checkedListBoxObiekty.Items.Count; i++)
                {
                    checkedListBoxObiekty.SetItemChecked(i, true);
                }
            }
        }
        private void WypelnijcheckedListBoxTypyZdarzen()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {

                checkedListBoxTypyZdarzen.DataSource = db.TypyZdarzen.ToList();
                checkedListBoxTypyZdarzen.ValueMember = "IdTypZdarzenia";
                checkedListBoxTypyZdarzen.DisplayMember = "Nazwa";
                for (int i = 0; i < checkedListBoxTypyZdarzen.Items.Count; i++)
                {
                    checkedListBoxTypyZdarzen.SetItemChecked(i, true);
                }
            }
        }
        private void WypelnijcheckedListBoxStatus()
        {
            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {

                checkedListBoxStatus.DataSource = db.StatusZdarzenia.ToList();
                checkedListBoxStatus.ValueMember = "IdStatus";
                checkedListBoxStatus.DisplayMember = "Nazwa";
                for (int i = 0; i < checkedListBoxStatus.Items.Count; i++)
                {
                    checkedListBoxStatus.SetItemChecked(i, true);
                }
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            DateTime datastart = dateTimePickerOd.Value.Date;
            string dataOd = dateTimePickerOd.Value.ToString("yyyyMMdd") + " 00:00:00";
            string dataDo = dateTimePickerDo.Value.ToString("yyyyMMdd") + " 23:59:59.99";

            if (dateTimePickerOd.Value.Date > dateTimePickerDo.Value.Date)  // (datastart > datastop)
            {
                MessageBox.Show("Błąd w datach, \n data końcowa nie może być mniejsza od taty początkowej", "Błąd raportowania");
                return;
            }


            using (ZdarzeniaEntities db = new ZdarzeniaEntities())
            {
                List<TypyZdarzen> ListaTypZdarzen = new List<TypyZdarzen>();
                List<Obiekty> ListaObiekty = new List<Obiekty>();
                List<StatusZdarzenia> ListaStatusy = new List<StatusZdarzenia>();
                String StringListTypZadrzenia = "";
                String StringListObiekty = "";
                String StringListStatusy = "";
                foreach (var wybraneT in checkedListBoxTypyZdarzen.CheckedItems)
                {
                    ListaTypZdarzen.Add((TypyZdarzen)wybraneT);
                }
                bool typBrak = true;
                foreach (var wybraneTyp in ListaTypZdarzen)
                {
                    if (typBrak)
                    {
                        StringListTypZadrzenia = wybraneTyp.IdTypZdarzenia.ToString();
                        typBrak = false;
                    }
                    else
                    {
                        StringListTypZadrzenia += ", ";
                        StringListTypZadrzenia += wybraneTyp.IdTypZdarzenia.ToString();
                    }

                }

                foreach (var wybraneO in checkedListBoxObiekty.CheckedItems)
                {
                    ListaObiekty.Add((Obiekty)wybraneO);

                }
                bool obiektBrak = true;
                foreach (var wybraneObiekt in ListaObiekty)
                {
                    if (obiektBrak)
                    {
                        StringListObiekty = wybraneObiekt.IdObiekt.ToString();
                        obiektBrak = false;
                    }
                    else
                    {
                        StringListObiekty += ", ";
                        StringListObiekty += wybraneObiekt.IdObiekt.ToString();
                    }

                }
                foreach (var wybraneS in checkedListBoxStatus.CheckedItems)
                {
                    ListaStatusy.Add((StatusZdarzenia)wybraneS);
                }
                bool statusBrak = true;
                foreach (var wybraneStatus in ListaStatusy)
                {
                    if (statusBrak)
                    {
                        StringListStatusy = wybraneStatus.IdStatus.ToString();
                        statusBrak = false;
                    }
                    else
                    {
                        StringListStatusy += ", ";
                        StringListStatusy += wybraneStatus.IdStatus.ToString();
                    }

                }

                if (!typBrak && !obiektBrak && !statusBrak)
                {


                    if (txtBoxNazwa.Text.Trim() != "")
                    {

                        string test = $"Select * from ViewZdarzeniaLista where (datazdarzenia between '{dataOd}' and '{dataDo}') and UPPER(Nazwa) like '%{txtBoxNazwa.Text.Trim().ToUpper()}%' and IdTypZdarzenia in ({StringListTypZadrzenia}) and IdObiekt in ({StringListObiekty}) and IdStatus in ({StringListStatusy})";
                        listaViewZdarzenia = db.ViewZdarzeniaLista
                            .SqlQuery($"Select * from ViewZdarzeniaLista where (datazdarzenia between '{dataOd}' and '{dataDo}') and Nazwa like '%{txtBoxNazwa.Text.Trim()}%' and IdTypZdarzenia in ({StringListTypZadrzenia}) and IdObiekt in ({StringListObiekty}) and IdStatus in ({StringListStatusy})") 
                            .ToList();
                    }
                    else
                    {
                        string test = $"Select * from ViewZdarzeniaLista where (datazdarzenia between '{dataOd}' and '{dataDo}') and IdTypZdarzenia in ({StringListTypZadrzenia}) and IdObiekt in ({StringListObiekty}) and IdStatus in ({StringListStatusy})";

                        listaViewZdarzenia = db.ViewZdarzeniaLista
                            .SqlQuery($"Select * from ViewZdarzeniaLista where (datazdarzenia between '{dataOd}' and '{dataDo}') and IdTypZdarzenia in ({StringListTypZadrzenia}) and IdObiekt in ({StringListObiekty}) and IdStatus in ({StringListStatusy})")
                            .ToList();
                    }

                    WypelnijDataGridView();
                }
                else
                {
                    MessageBox.Show("Błędny wybór,\n musi być wybrany conajmniej jeden obiekt, jeden rodzaj zdarzenia i jeden status", "Błąd raportowania");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            przeslijIdDoPokaz(IdentyfikatorZdarzenia);
        }

        public void przeslijIdDoPokaz(int Id)
        {
            int idDoPokaz = Id;
            FrmPokazZdarzenie frmPok = new FrmPokazZdarzenie();
            frmPok.LoadOrders(Id);
            frmPok.MdiParent = this.MdiParent;
            frmPok.Show();
        }
        //[DllImport("user32.dll")]
        //static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessID);
        private void btnDoExcela_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbooks bk = app.Workbooks;
            _Workbook workbook = bk.Add(Type.Missing);
            _Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Lista Zdarzeń";
                for (int i = 1; i < dataGridViewRaporty.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridViewRaporty.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewRaporty.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewRaporty.Columns.Count; j++)
                    {
                        if (dataGridViewRaporty.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dataGridViewRaporty.Rows[i].Cells[j].Value.ToString();
                        else
                            worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
                if (saveFileDialog1.ShowDialog() == DialogResult.OK && Type.GetTypeFromProgID("Excel.Application") != null)
                {
                    app.ActiveWorkbook.SaveAs(saveFileDialog1.FileName);
                    Process.Start(saveFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                app.Quit();
                app = null;
                worksheet = null;

                ////GetWindowTreadProcessID(app.hWnd, out int id)
                //GetWindowThreadProcessId(app.Hwnd, out int id);
                //try
                //{ 
                //    Process.GetProcessById(id).Kill();
                //}
                //catch(Exception ex)
                //{
                //    //Ręczne zamknięcie procesu
                //    //MessageBox.Show(ex.Message, "Konieczne ręczne zamknięcie procesu");
                //}
            }

        }

        private void btnDoWorda_Click(object sender, EventArgs e)
        {

            if (dataGridViewRaporty .CurrentRow.Index != -1)
            {
                IdentyfikatorZdarzenia = Convert.ToInt32(dataGridViewRaporty.CurrentRow.Cells["IdZdarzenia"].Value);

                using (ZdarzeniaEntities db = new ZdarzeniaEntities())
                {
                    modZdarzeniaViewFull = db.ViewZdarzenieFull.Where(f => f.IdZdarzenia == IdentyfikatorZdarzenia).FirstOrDefault();
                }
            }


            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Word Files (*.docx)|*.docx";
            Microsoft.Office.Interop.Word._Application word = new Microsoft.Office.Interop.Word.Application();
            Document doc = word.Documents.Add();
            Microsoft.Office.Interop.Word.Range rng = doc.Range(0, 0);

            try
            {
                doc = word.ActiveDocument;

                doc.Content.Text = doc.Content.Text + "Nr Identyfikacyjne zdarzenia: " + modZdarzeniaViewFull.IdZdarzenia + Environment.NewLine;
                doc.Content.Text = doc.Content.Text + "Data zdarzenia: " + modZdarzeniaViewFull.DataZdarzenia + Environment.NewLine;
                doc.Content.Text = doc.Content.Text + "Nazwa zdarzenia: ";
                doc.Content.Text = doc.Content.Text + modZdarzeniaViewFull.Nazwa + Environment.NewLine;
                doc.Content.Text = doc.Content.Text + "Obiekt zdarzenia: " + modZdarzeniaViewFull.NazwaObiektu;
                doc.Content.Text = doc.Content.Text + modZdarzeniaViewFull.OpisObiektu + Environment.NewLine;
                doc.Content.Text = doc.Content.Text + "Typ zdarzenia: " + modZdarzeniaViewFull.NazwaTyp;
                doc.Content.Text = doc.Content.Text + modZdarzeniaViewFull.OpisTyp + Environment.NewLine;
                doc.Content.Text = doc.Content.Text + "Opis zdarzenia: ";
                doc.Content.Text = doc.Content.Text + modZdarzeniaViewFull.OpisZdarzenia + Environment.NewLine;
                doc.Content.Text = doc.Content.Text + "Podjęte działania: ";
                doc.Content.Text = doc.Content.Text + modZdarzeniaViewFull.Dzialania + Environment.NewLine;
                doc.Content.Text = doc.Content.Text + "Status dokumentów do zdarzenia: " + modZdarzeniaViewFull.NazwaStatus;
                doc.Content.Text = doc.Content.Text + modZdarzeniaViewFull.OpisStatus + Environment.NewLine;
                doc.Content.Text = doc.Content.Text + "Uwagi do dokumentów: ";
                doc.Content.Text = doc.Content.Text + modZdarzeniaViewFull.UwagiDoZdarzenia + Environment.NewLine;
                doc.Content.Text = doc.Content.Text + "Użytkownik wprowadzający zdarzenie: " + modZdarzeniaViewFull.Uzytkownik + Environment.NewLine;




                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    doc.SaveAs2(saveFileDialog1.FileName);
                    Process.Start("winword.exe", saveFileDialog1.FileName);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                word.Quit();
                word = null;
                doc = null;
            }
        }
    }
}
