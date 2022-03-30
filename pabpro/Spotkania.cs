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
    public partial class Spotkania : Form
    {
        private Drużyna aktualna3;
        private Miejsca klik1;
        private Terminarz klik;
        private zadaniepabAEntities db = new zadaniepabAEntities();
        public Spotkania()
        {
            InitializeComponent();
            OdswiezDane();
        }
        private void OdswiezDane()
        {
            meczBindingSource.DataSource = db.Mecz.ToList();
            drużynaBindingSource.DataSource = db.Drużyna.ToList();
            TerminarzbindingSource.DataSource = db.Terminarz.ToList();
            MiejscabindingSource.DataSource = db.Miejsca.ToList();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = TerminarzbindingSource.Current as Terminarz;
            klik1 = MiejscabindingSource.Current as Miejsca;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aktualna3 = drużynaBindingSource.Current as Drużyna;

            meczBindingSource.DataSource = db.Mecz.Where(k => k.Drużyna_ID == aktualna3.Drużyna_ID).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TworzenieSpotkań Tw1 = new TworzenieSpotkań();
            Tw1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
