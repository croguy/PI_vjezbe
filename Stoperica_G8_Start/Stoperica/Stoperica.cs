using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stoperica.StanjeStoperice;

namespace Stoperica
{
    class Stoperica : Stopwatch
    {
        List<string> prolaznaVremena = new List<string>();

        public StanjeStoperice stanje = new StanjeStoperice();

        public bool StartEnabled { get { return stanje.TrenutnoStanje == Stanje.Neaktivna; } }
        public bool LapEnabled { get { return stanje.TrenutnoStanje == Stanje.Aktivna; } }
        public bool StopEnabled { get { return stanje.TrenutnoStanje == Stanje.Aktivna; } }
        public bool ResetEnabled { get { return stanje.TrenutnoStanje == Stanje.Zaustavljena; } }
        public bool ResumeEnabled { get { return stanje.TrenutnoStanje == Stanje.Zaustavljena; } }


        public void IzvrsiPrijelazStanja(Naredba naredba)
        {
            stanje.PromijeniStanje(naredba);
            if(this.StartEnabled == true)
            {
                ResetirajSvaVremena();
                ZapocniOdbrojavanje();
            }
            if(this.LapEnabled == true)
            {

            }
            if (this.StopEnabled == true)
            {

            }
            if (this.ResetEnabled == true)
            {

            }
            if (this.ResumeEnabled == true)
            {

            }
            //TODO - Ovisno o naredbi pozvati odgovarajuće, već postojeće metode
        }

        public string DohvatiVrijeme()
        {
            return Elapsed.ToString(@"hh\:mm\:ss\.fff");
        }

        public List<string> DohvatiProlaznaVremena()
        {
            return prolaznaVremena;
        }

        private void ZapocniOdbrojavanje()
        {
            this.Start();
        }

        private void ZaustaviOdbrojvanje()
        {
            this.Stop();
        }

        private void ZabiljeziVrijeme()
        {
            prolaznaVremena.Add(DohvatiVrijeme());
        }

        private void ResetirajSvaVremena()
        {
            this.Reset();
            prolaznaVremena.Clear();
        }
    }
}
