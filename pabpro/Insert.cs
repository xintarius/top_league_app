using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pabpro
{
    class Insert
    {
        private string connString = ConfigurationManager.ConnectionStrings["pabpro.Properties.Settings.zadaniepabAConnectionString"].ConnectionString;




        public string insert_pmecz(Meczmodel p)
        {
            string msg = " ";
            SqlConnection conn = new SqlConnection(connString);



            try
            {
                SqlCommand cmd = new SqlCommand("insert_mecz", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                
               
                if (p.Drużyna_ID == p.Dru_Drużyna_ID)
                {
                    p.Drużyna_ID = 0;
                    p.Dru_Drużyna_ID = 0;

                    msg = "Nie można dodać tych samych wartości";
                }
                else {
                    cmd.Parameters.Add("@Treminarz_ID", SqlDbType.Int).Value = p.Treminarz_ID;
                    cmd.Parameters.Add("@Miejsca_ID", SqlDbType.Int).Value = p.Miejsca_ID;
                    cmd.Parameters.Add("@Drużyna_ID", SqlDbType.Int).Value = p.Drużyna_ID;
                    cmd.Parameters.Add("@Dru_Drużyna_ID", SqlDbType.Int).Value = p.Dru_Drużyna_ID;


                    msg = "Dodano pomyślnie do bazy danych";
                }

                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                //string msg1 = e.Message;
                msg = "Nie udało się dodać Terminu";
            }
            finally
            {
                conn.Close();

            }

            return msg;


        }
    }
}
