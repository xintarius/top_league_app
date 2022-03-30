using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pabpro
{
    public partial class Statystyki : Form
    {
        private Zdarzenia z1;
        private zadaniepabAEntities db = new zadaniepabAEntities();
        public Statystyki()
        {
            InitializeComponent();
            OdswiezDane();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            z1 = zdarzeniaBindingSource.Current as Zdarzenia;
            tbx1.Text = z1.Wejścia_na_boisko;
            tbx2.Text = z1.Zejścia_z_boiska;
            tbx3.Text = z1.Rzut_rożny;
            tbx4.Text = z1.Strzelone_bramki;
            tbx5.Text = z1.Kary;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zdarzenia nowe = new Zdarzenia();
            nowe.Wejścia_na_boisko= tbx1.Text;
            nowe.Zejścia_z_boiska = tbx2.Text;
            nowe.Rzut_rożny = tbx3.Text;
            nowe.Strzelone_bramki = tbx4.Text;
            nowe.Kary = tbx5.Text;


            db.Zdarzenia.Add(nowe);
            db.SaveChanges();
            OdswiezDane();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            z1 = zdarzeniaBindingSource.Current as Zdarzenia;

            tbx1.Text = z1.Wejścia_na_boisko;
            tbx2.Text = z1.Zejścia_z_boiska;
            tbx3.Text = z1.Rzut_rożny;
            tbx4.Text = z1.Strzelone_bramki;
            tbx5.Text = z1.Kary;
            OdswiezDane();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Zdarzenia.Remove(z1);
            db.SaveChanges();
            OdswiezDane();
        }
        private void OdswiezDane()
        {
            zdarzeniaBindingSource.DataSource = db.Zdarzenia.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dane d1 = new Dane();
            d1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Statystyki S1 = new Statystyki();
            S1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Spotkania Sp1 = new Spotkania();
            Sp1.ShowDialog();
        }
    }
}
