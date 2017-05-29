using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test___Kursprow
{
    public partial class Form1 : Form
    {
        Bankkonto bankkonto = new Bankkonto();
        List<Bankkonto> Kontolista = new List<Bankkonto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkapaKonto_Click(object sender, EventArgs e)
        {
            bankkonto.Namn = tbxNamn.Text;
            bankkonto.Saldo = int.Parse(tbxSaldo.Text);
            Kontolista.Add(bankkonto);

            tbxKonton.AppendText(bankkonto.Namn);

            UppdateraKontofönster();
        }
        private void UppdateraKontofönster()
        {
            tbxKonton.Text = "";
            for (int i = 0; i < Kontolista.Count; i++)
            {
                tbxKonton.AppendText(Kontolista.ElementAt(i) + "\n");
            }
        }
    }
}
