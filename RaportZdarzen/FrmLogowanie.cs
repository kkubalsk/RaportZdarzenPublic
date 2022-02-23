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
    public partial class FrmLogowanie : Form
    {
        //Users modUsers = new Users();
        //LogiUzytkownikow modLogi = new LogiUzytkownikow();
        Konfigurator konfigurator = Konfigurator.GetInstance();
        public FrmLogowanie()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if (SprawdzLogin(txtLogin.Text.Trim(), txtHaslo.Text.Trim()))
            {
                //this.Close();
                if (konfigurator.NoweHaslo)
                {
                    FrmZmienHaslo frmZmien = new FrmZmienHaslo();
                    //frmZmien.MdiParent = this.MdiParent;
                    frmZmien.Owner = this.MdiParent;
                    frmZmien.Show();
                }
                this.Close();
                // MessageBox.Show($"Użytkownik {konfigurator.loginZalogowany} Zalogowany");
            }
            else
            {
               // MessageBox.Show($"Błąd logowania dla: {txtLogin.Text.Trim()}");
                txtLogin.Text = txtHaslo.Text = "";
            }
        }

        public bool SprawdzLogin(string login, string passwd)
        {
            //LogiUzytkownikow modLogi = new LogiUzytkownikow();
            //Konfigurator konfigurator = Konfigurator.GetInstance();
            konfigurator.CzyZalogowany = false;
            string thisLogin = login;
            string thisHaslo = passwd;
            bool nieWaznyUser = false;
            using (ZdarzeniaEntities lg = new ZdarzeniaEntities())

            {
                foreach (var ktos in lg.Users)
                {
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        if (ktos.login == thisLogin && ktos.haslo == Ochrona.Szyfruj(sha256Hash, thisHaslo))
                        {
                            //zalogowany = login;

                            if ((ktos.DataKoniec > System.DateTime.Now) && (ktos.DataDodania < System.DateTime.Now) && (!ktos.CzyZablokowany))
                            {

                                konfigurator.CzyZalogowany = true;
                                konfigurator.loginZalogowany = ktos.login;
                                konfigurator.IdZalogowany = ktos.Id;
                                konfigurator.komputerek = Environment.MachineName;
                                //konfigurator.komputerek = Environment.UserName;
                                konfigurator.CzyAdministratorZalogowany = ktos.CzyAdministrator;
                                konfigurator.CzyKierownikZalogowany = ktos.CzyKierownik;
                                konfigurator.CzyZablokowanyZalogowany = ktos.CzyZablokowany;
                                konfigurator.NoweHaslo = ktos.CzyNoweHaslo;

                                string wiadomosc = $"Udane logowanie użytkownika: {ktos.login}";
                                if (ZapiszLog.ZapiszLogUzytkownika(ktos.Id, wiadomosc))
                                {
                                    MessageBox.Show(wiadomosc);
                                }

                                //modLogi.IdLogi = 0;
                                //modLogi.Uzytkownik = ktos.Id;
                                //modLogi.Opis = $"Udane logowanie użytkownika: {ktos.login}";
                                //modLogi.Komputer = konfigurator.komputerek;
                                //modLogi.DataCzasLogu = System.DateTime.Now;
                                //lg.LogiUzytkownikow.Add(modLogi);
                                
                            }
                            else
                            {
                                string wiadomosc = $" Nie udane logowanie nieważnego użytkownika: {ktos.login}";
                                if (ZapiszLog.ZapiszLogUzytkownika(ktos.Id, wiadomosc))
                                {

                                    nieWaznyUser = true; 
                                    MessageBox.Show(wiadomosc);
                                }

                                //nieWaznyUser = true;
                                //modLogi.IdLogi = 0;
                                //modLogi.Uzytkownik = ktos.Id;
                                //modLogi.Opis = $" Nie udane logowanie nieważnego użytkownika: {ktos.login}";
                                //modLogi.Komputer = Environment.MachineName;
                                //modLogi.DataCzasLogu = System.DateTime.Now;
                                //lg.LogiUzytkownikow.Add(modLogi);
                                ////lg.SaveChanges();

                            }
                            break;
                        }
                    }
                }
                if (konfigurator.CzyZalogowany)
                { 
                    lg.SaveChanges();
                    return true;
                }
                else
                {
                    if (!nieWaznyUser)
                    {
                        Users szukaj = lg.Users.Where(x => x.login == thisLogin).FirstOrDefault();
                        if (szukaj != null) //Sprawdzenie czy niema takiego loginu w bazie
                        {

                            string wiadomosc = $"Nie udane logowanie użytkownika: {thisLogin}";
                            if (ZapiszLog.ZapiszLogUzytkownika(szukaj.Id, wiadomosc))
                            {
                                MessageBox.Show(wiadomosc);
                            }

                            //modLogi.IdLogi = 0;
                            //modLogi.Uzytkownik = szukaj.Id;
                            //modLogi.Opis = $"Nie udane logowanie użytkownika: {thisLogin}";
                            //modLogi.Komputer = Environment.MachineName;
                            //modLogi.DataCzasLogu = System.DateTime.Now;
                            //lg.LogiUzytkownikow.Add(modLogi);
                            ////lg.SaveChanges();
                        }
                        else
                        {
                            int anyuser = -1;
                            string wiadomosc = $"Nie udane logowanie nieznanego użytkownika: {thisLogin}. Użytkownik systemu: {Environment.UserName}";
                            if (ZapiszLog.ZapiszLogUzytkownika(anyuser, wiadomosc))
                            {
                                MessageBox.Show(wiadomosc);
                            }

                            //modLogi.IdLogi = 0;
                            //modLogi.Uzytkownik = -1;
                            //modLogi.Opis = $"Nie udane logowanie nieznanego użytkownika: {thisLogin}. Użytkownik systemu: {Environment.UserName}";
                            ////modLogi.Opis = $"Nie udane logowanie nieznanego";
                            //modLogi.Komputer = Environment.MachineName;
                            //modLogi.DataCzasLogu = System.DateTime.Now;
                            //lg.LogiUzytkownikow.Add(modLogi);
                            ////lg.SaveChanges();
                        }
                    }
                    //lg.SaveChanges();
                    return false;
                }
               
            }
            
        }
    }
}
