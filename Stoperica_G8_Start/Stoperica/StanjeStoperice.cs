using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stoperica
{
    class StanjeStoperice
    {
        public enum Stanje
        {
            Neaktivna,
            Aktivna,
            Zaustavljena
        }

        public enum Naredba
        {
            Start,
            Lap,
            Stop,
            Resume,
            Reset
        }

        Dictionary<PrijelazStanja, Stanje> prijelaziStanja;
        public Stanje TrenutnoStanje { get; private set; }

        public StanjeStoperice()
        {
            TrenutnoStanje = Stanje.Neaktivna;

            prijelaziStanja = new Dictionary<PrijelazStanja, Stanje>()
            {   
                {new PrijelazStanja(TrenutnoStanje, Naredba.Start), Stanje.Aktivna}, //neaktivna
                {new PrijelazStanja(TrenutnoStanje, Naredba.Lap), Stanje.Aktivna}, //aktivna
                {new PrijelazStanja(TrenutnoStanje, Naredba.Stop), Stanje.Zaustavljena}, //aktivna
                {new PrijelazStanja(TrenutnoStanje, Naredba.Resume), Stanje.Aktivna}, //zaustavljena
                {new PrijelazStanja(TrenutnoStanje, Naredba.Reset), Stanje.Neaktivna} //zaustavljena
            };

            //TODO - definirati listu (riječnik) prijelaza stanja...
            //prijelaziStanja = new Dictionary<PrijelazStanja, Stanje>
            //{
            //    ...
            //};
        }

        public void PromijeniStanje(Naredba naredba)
        {
            PrijelazStanja prijelazStanja = new PrijelazStanja(TrenutnoStanje, naredba);
            Stanje buduceStanje;
            if (!prijelaziStanja.TryGetValue(prijelazStanja, out buduceStanje))
                throw new Exception("Prijelaz nije moguć: " + TrenutnoStanje + " -> " + naredba);
            TrenutnoStanje = buduceStanje;
        }

        class PrijelazStanja
        {
            readonly Stanje TrenutnoStanje;
            readonly Naredba Naredba;

            public PrijelazStanja(Stanje trenutnoStanje, Naredba naredba)
            {
                TrenutnoStanje = trenutnoStanje;
                Naredba = naredba;
            }

            public override int GetHashCode()
            {
                return 17 + 31 * TrenutnoStanje.GetHashCode() + 31 * Naredba.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                PrijelazStanja drugi = obj as PrijelazStanja;
                return drugi != null && this.TrenutnoStanje == drugi.TrenutnoStanje && this.Naredba == drugi.Naredba;
            }
        }

    }
}
