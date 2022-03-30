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
    
    public partial class TworzenieSpotkań : Form

    {
        private Drużyna kolejny;
        private Miejsca kolejny1;
        private Terminarz kolejny2;
        private zadaniepabAEntities db = new zadaniepabAEntities();
        public TworzenieSpotkań()
        {
            InitializeComponent();
            OdswiezDane();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string myString = drużynaBindingSource.ToString();
            // d.Id_Lokalizacja = Convert.ToInt32(cbLokalizacja.SelectedValue);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zadaniepabADataSet5.Mecz' . Możesz go przenieść lub usunąć.
            this.meczTableAdapter1.Fill(this.zadaniepabADataSet5.Mecz);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zadaniepabADataSet4.Terminarz' . Możesz go przenieść lub usunąć.
            this.terminarzTableAdapter.Fill(this.zadaniepabADataSet4.Terminarz);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zadaniepabADataSet3.Miejsca' . Możesz go przenieść lub usunąć.
            this.miejscaTableAdapter.Fill(this.zadaniepabADataSet3.Miejsca);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zadaniepabADataSet2.Drużyna' . Możesz go przenieść lub usunąć.
            this.drużynaTableAdapter1.Fill(this.zadaniepabADataSet2.Drużyna);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zadaniepabADataSet1.Drużyna' . Możesz go przenieść lub usunąć.
            this.drużynaTableAdapter.Fill(this.zadaniepabADataSet1.Drużyna);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zadaniepabADataSet.Mecz' . Możesz go przenieść lub usunąć.
            this.meczTableAdapter.Fill(this.zadaniepabADataSet.Mecz);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Insert i = new Insert();
                Meczmodel p = new Meczmodel();

                p.Drużyna_ID = Convert.ToInt32(Cb1.SelectedValue);
                p.Dru_Drużyna_ID = Convert.ToInt32(Cb2.SelectedValue);
                p.Miejsca_ID = Convert.ToInt32(Cb3.SelectedValue);
                p.Treminarz_ID = Convert.ToInt32(Cb4.SelectedValue);

                MessageBox.Show(i.insert_pmecz(p));
               
                OdswiezDane();
            }
            
        }
        private void OdswiezDane()
        {
            meczBindingSource2.DataSource = db.Mecz.ToList();
            drużynaBindingSource.DataSource = db.Drużyna.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spotkania dw1 = new Spotkania();
            dw1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kolejny = drużynaBindingSource.Current as Drużyna;
            kolejny.Drużyna1 = Cb1.Text;

            OdswiezDane();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Modyfikacja mw1 = new Modyfikacja();
            mw1.ShowDialog();
        }

        
    }
}
