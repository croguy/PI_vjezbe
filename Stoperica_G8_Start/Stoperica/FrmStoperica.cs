using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stoperica.StanjeStoperice;

namespace Stoperica
{
    public partial class FrmStoperica : Form
    {
        Stoperica s;

        public FrmStoperica()
        {
            InitializeComponent();
            s = new Stoperica();
            tmrRefresh.Start();
            OsvjeziGumbe();
        }

        private void OsvjeziPopisVremena()
        {
            lstVremena.DataSource = null;
            lstVremena.DataSource = s.DohvatiProlaznaVremena();
        }

        private void OsvjeziGumbe()
        {
            btnStart.Enabled = s.StartEnabled;
            btnStop.Enabled = s.StopEnabled;
            btnReset.Enabled = s.ResetEnabled;
            btnResume.Enabled = s.ResumeEnabled;
            btnLap.Enabled = s.LapEnabled;
        }

        private void IspisujVrijeme()
        {
            lblVrijeme.Text = s.DohvatiVrijeme();
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            IspisujVrijeme();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //TODO - Izvrsiti prijelaz stanja i osvježiti korisničko sučelje pozivom postojećih metoda
            s.IzvrsiPrijelazStanja(Naredba.Start);
            btnLap.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            lblVrijeme.Refresh();
            IspisujVrijeme();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            //TODO - Izvrsiti prijelaz stanja i osvježiti korisničko sučelje pozivom postojećih metoda
            s.IzvrsiPrijelazStanja(Naredba.Lap);
            lblVrijeme.Refresh();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //TODO - Izvrsiti prijelaz stanja i osvježiti korisničko sučelje pozivom postojećih metoda
            s.IzvrsiPrijelazStanja(Naredba.Stop);
            btnLap.Enabled = false;
            lblVrijeme.Refresh();

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            //TODO - Izvrsiti prijelaz stanja i osvježiti korisničko sučelje pozivom postojećih metoda
            s.IzvrsiPrijelazStanja(Naredba.Resume);
            lblVrijeme.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //TODO - Izvrsiti prijelaz stanja i osvježiti korisničko sučelje pozivom postojećih metoda
            s.IzvrsiPrijelazStanja(Naredba.Reset);
            btnLap.Enabled = false;
            btnStop.Enabled = false;
            lblVrijeme.Refresh();
        }
    }
}
