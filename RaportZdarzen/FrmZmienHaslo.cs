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
    public partial class FrmZmienHaslo : Form
    {
        Konfigurator konfigurator = Konfigurator.GetInstance();
        public FrmZmienHaslo()
        {
            InitializeComponent();
        }

        private void FrmZmienHaslo_Load(object sender, EventArgs e)
        {
           
            this.Owner.Enabled = false;

        }

        private void FrmZmienHaslo_FormClosed(object sender, FormClosedEventArgs e)
        {
           this.Owner.Enabled = true;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
         
            using (ZdarzeniaEntities lg = new ZdarzeniaEntities())
            {
                if (txtOldPass.Text.Trim() != "")
                {
                    Users szukaj = lg.Users.Where(x => x.Id == konfigurator.IdZalogowany).FirstOrDefault();
                    if (szukaj != null)
                    {
                        using (SHA256 sha256Hash = SHA256.Create())
                        {
                            if (szukaj.haslo == Ochrona.Szyfruj(sha256Hash, txtOldPass.Text.Trim()))
                            {
                                if (txtNewPass.Text.Trim() != "")
                                {
                                    if (txtNewPass.Text.Trim() == txtPotwierdzPass.Text.Trim())
                                    {
                                        szukaj.haslo = Ochrona.Szyfruj(sha256Hash, txtNewPass.Text.Trim());
                                        szukaj.CzyNoweHaslo = false;
                                    
                                        lg.Entry(szukaj).State = System.Data.Entity.EntityState.Modified;
                                        lg.SaveChanges();

                                        string wiadomosc = $"Hasło użytkownika: {szukaj.login} zostało poprawnie zmienione";
                                        if (ZapiszLog.ZapiszLogUzytkownika(szukaj.Id, wiadomosc))
                                        {
                                            MessageBox.Show(wiadomosc);
                                            konfigurator.NoweHaslo = false;
                                            this.Close();
                                        }

                                    }
                                    else
                                    {
                                        string wiadomosc = "Błąd zmiany hasła, nowe hasło i powtórzenie są różne";
                                        if (ZapiszLog.ZapiszLogUzytkownika(konfigurator.IdZalogowany, wiadomosc))
                                        {
                                            MessageBox.Show(wiadomosc);
                                        }

                                    }
                                }
                                else
                                {
                                    string wiadomosc = "Błąd zmiany hasła, Nie wprowadzono nowego hasła użutkownika";
                                    if (ZapiszLog.ZapiszLogUzytkownika(konfigurator.IdZalogowany, wiadomosc))
                                    {
                                        MessageBox.Show(wiadomosc);
                                    }

                                }
                            }
                            else
                            {
                                string wiadomosc = "Błąd zmiany hasła, wprowadzono złe obecne hasło użutkownika";
                                if (ZapiszLog.ZapiszLogUzytkownika(konfigurator.IdZalogowany, wiadomosc))
                                {
                                    MessageBox.Show(wiadomosc);
                                }
                            }


                        }
                    }
                }
                else
                {
                    string wiadomosc = "Błąd zmiany hasła, nie wprowadzono obecnego hasła użutkownika";
                    if (ZapiszLog.ZapiszLogUzytkownika(konfigurator.IdZalogowany, wiadomosc))
                    {
                        MessageBox.Show(wiadomosc);
                    }
                }
            }
        }

         
    }
}
