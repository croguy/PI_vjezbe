using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_vj4
{
    public partial class Form1 : Form
    {
        BindingList<Nukleobaza> listaBaza = new BindingList<Nukleobaza>();
        Nukleobaza dnkGenerator = new Nukleobaza();
        public Form1()
        {
            InitializeComponent();
        }

        private void gumbUnos_Click(object sender, EventArgs e)
        {
            string novaBaza = boxUnos.Text;
            string noviPar = dnkGenerator.OdrediPar(novaBaza);
            Nukleobaza novaKlasaBaze = new Nukleobaza();
            novaKlasaBaze.Baza = novaBaza;
            novaKlasaBaze.Par = noviPar;
            listaBaza.Add(novaKlasaBaze);
            listBoxDNK.DataSource = null;
            listBoxDNK.DataSource = listaBaza;
        }
    }
}
