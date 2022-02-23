using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaportZdarzen
{
    class Konfigurator 
    {

        private Konfigurator() { }

        private static Konfigurator _instance;

        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new object();

        public static Konfigurator GetInstance()
        {
            // This conditional is needed to prevent threads stumbling over the
            // lock once the instance is ready.
            if (_instance == null)
            {
                // Now, imagine that the program has just been launched. Since
                // there's no Singleton instance yet, multiple threads can
                // simultaneously pass the previous conditional and reach this
                // point almost at the same time. The first of them will acquire
                // lock and will proceed further, while the rest will wait here.
                lock (_lock)
                {
                    // The first thread to acquire the lock, reaches this
                    // conditional, goes inside and creates the Singleton
                    // instance. Once it leaves the lock block, a thread that
                    // might have been waiting for the lock release may then
                    // enter this section. But since the Singleton field is
                    // already initialized, the thread won't create a new
                    // object.
                    if (_instance == null)
                    {
                        _instance = new Konfigurator();

                    }
                }
            }
            return _instance;
        }

        // We'll use this property to prove that our Singleton really works.
        public bool CzyZalogowany { get; set; }
        public int IdZalogowany { get; set; }
        public string loginZalogowany { get; set; }
        public string hasloZalogowany { get; set; }
        public string NazwiskoZalogowany { get; set; }
        public string ImieZalogowany { get; set; }
        public System.DateTime DataDodaniaZalogowany { get; set; }
        public System.DateTime DataKoniecZalogowany { get; set; }
        public bool CzyAdministratorZalogowany { get; set; }
        public bool CzyKierownikZalogowany { get; set; }
        public bool CzyZablokowanyZalogowany { get; set; }
        public string komputerek { get; set; }
        public bool NoweHaslo { get; set; }

    }

}
