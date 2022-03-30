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
   
    public partial class Modyfikacja : Form
    {
        private Miejsca m1;
        private Drużyna d1;
        private Terminarz t1;
        private zadaniepabAEntities db = new zadaniepabAEntities();
        public Modyfikacja()
        {
            InitializeComponent();
            OdswiezDane();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m1= miejscaBindingSource.Current as Miejsca;
            m1.Miejscowość = tbx1.Text;
        }
        private void OdswiezDane()
        {
            miejscaBindingSource.DataSource = db.Miejsca.ToList();
            drużynaBindingSource.DataSource = db.Drużyna.ToList();
            terminarzBindingSource.DataSource = db.Terminarz.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Miejsca nowe = new Miejsca();
            nowe.Miejscowość = tbx1.Text;
            db.Miejsca.Add(nowe);
            db.SaveChanges();
            OdswiezDane();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m1 = miejscaBindingSource.Current as Miejsca;

            m1.Miejscowość = tbx1.Text;

            OdswiezDane();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Miejsca.Remove(m1);
            db.SaveChanges();
            OdswiezDane();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Drużyna nowa = new Drużyna();
            nowa.Drużyna1 = tbx3.Text;
            db.Drużyna.Add(nowa);
            db.SaveChanges();
            OdswiezDane();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            d1 = drużynaBindingSource.Current as Drużyna;
            d1.Drużyna1 = tbx3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            d1 = drużynaBindingSource.Current as Drużyna;

            d1.Drużyna1 = tbx3.Text;

            OdswiezDane();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            db.Drużyna.Remove(d1);
            db.SaveChanges();
            OdswiezDane();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Terminarz nowy = new Terminarz();
            nowy.Data = dtp1.Value.Date;
            db.Terminarz.Add(nowy);
            db.SaveChanges();
            OdswiezDane();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t1 = terminarzBindingSource.Current as Terminarz;

            t1.Data = dtp1.Value.Date;

            OdswiezDane();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            db.Terminarz.Remove(t1);
            db.SaveChanges();
            OdswiezDane();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            t1 = terminarzBindingSource.Current as Terminarz;
            t1.Data = dtp1.Value.Date;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TworzenieSpotkań Sp1 = new TworzenieSpotkań();
            Sp1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
