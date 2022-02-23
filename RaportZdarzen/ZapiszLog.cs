using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaportZdarzen
{
    public class ZapiszLog
    {
        Konfigurator konfigurator = Konfigurator.GetInstance();
        public static bool ZapiszLogUzytkownika(int logUzytkownik, string logOpis)
        {
            //bool rezultat;
            LogiUzytkownikow modLogi = new LogiUzytkownikow();
            using (ZdarzeniaEntities lgUser = new ZdarzeniaEntities())
            {
                modLogi.IdLogi = 0;
                modLogi.Uzytkownik = logUzytkownik;
                modLogi.Opis = logOpis;
                modLogi.Komputer = Environment.MachineName;
                modLogi.DataCzasLogu = System.DateTime.Now;
                lgUser.LogiUzytkownikow.Add(modLogi);
                try
                {
                    lgUser.SaveChanges();
                }
                catch (Exception e)
                {
                    //odLogi.Opis = $"Nie udane logowanie użytkownika: {thisLogin}";
                    MessageBox.Show($"Coś poszło nie tak przy zapisie logu dla użytkownika: {logUzytkownik}, {e}");
                }
            }

            return true;
        }
    }
}
