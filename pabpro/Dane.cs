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
    public partial class Dane : Form
    {
        private Zawodnik z1;
        private Trener t1;
        private Przynależność p1;
        private zadaniepabAEntities db = new zadaniepabAEntities();
        public Dane()
        {
            InitializeComponent();
            OdswiezDane();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            z1 = zawodnikBindingSource.Current as Zawodnik;
            tbxz1.Text = z1.Zawodnik_Imię;
            tbxz2.Text = z1.Zawodnik_Nazwisko;
        }

        private void Dane_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zawodnik nowy = new Zawodnik();
            nowy.Zawodnik_Imię = tbxz1.Text;
            nowy.Zawodnik_Nazwisko = tbxz2.Text;


            db.Zawodnik.Add(nowy);
            db.SaveChanges();
            OdswiezDane();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            z1 = zawodnikBindingSource.Current as Zawodnik;

            tbxz1.Text = z1.Zawodnik_Imię;
            tbxz2.Text = z1.Zawodnik_Nazwisko;
            OdswiezDane();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Zawodnik.Remove(z1);
            db.SaveChanges();
            OdswiezDane();
        }
        private void OdswiezDane()
        {
            zawodnikBindingSource.DataSource = db.Zawodnik.ToList();
            trenerBindingSource.DataSource = db.Trener.ToList();
            przynależnośćdodrużynyBindingSource.DataSource = db.Przynależność.ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            t1 = trenerBindingSource.Current as Trener;
            tbxt1.Text = t1.Trener_Imię;
            tbxt2.Text = t1.Trener_Nazwisko;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Trener nowy1 = new Trener();
            nowy1.Trener_Imię = tbxt1.Text;
            nowy1.Trener_Nazwisko = tbxt2.Text;
            db.Trener.Add(nowy1);
            db.SaveChanges();
            OdswiezDane();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            t1 = trenerBindingSource.Current as Trener;

            tbxt1.Text = t1.Trener_Imię;
            tbxz2.Text = t1.Trener_Nazwisko;
            OdswiezDane();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            db.Trener.Remove(t1);
            db.SaveChanges();
            OdswiezDane();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p1 = przynależnośćdodrużynyBindingSource.Current as Przynależność;
            tbxp1.Text = p1.Pozycja;
            tbxp2.Text = p1.Stawka;
            dtp1.Value = p1.Od_kiedy;
            dtp2.Value = p1.Do_kiedy;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Przynależność nowy2 = new Przynależność();
            nowy2.Pozycja = tbxp1.Text;
            nowy2.Stawka = tbxp2.Text;
            nowy2.Od_kiedy = dtp1.Value.Date;
            nowy2.Do_kiedy = dtp2.Value.Date;

            db.Przynależność.Add(nowy2);
            db.SaveChanges();
            OdswiezDane();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p1 = przynależnośćdodrużynyBindingSource.Current as Przynależność;

            p1.Pozycja = tbxp1.Text;
            p1.Stawka = tbxp2.Text;
            dtp1.Value = p1.Od_kiedy;
            dtp2.Value = p1.Do_kiedy;
            OdswiezDane();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            db.Przynależność.Remove(p1);
            db.SaveChanges();
            OdswiezDane();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dane d1 = new Dane();
            d1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Statystyki S1 = new Statystyki();
            S1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Spotkania Sp1 = new Spotkania();
            Sp1.ShowDialog();
        }
    }
}
