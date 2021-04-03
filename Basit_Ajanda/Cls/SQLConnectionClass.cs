using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basit_Ajanda.Cls
{
    public class SQLConnectionClass
    {
        private static string SQLConnectionString = @"Server = MUSTAFA\SQL2017; Database = BASIT_AJANDA_DB; Trusted_Connection = True;";
        private static SqlConnection con = new SqlConnection();
        private static SqlDataAdapter da = new SqlDataAdapter();
        private static SqlCommand com = new SqlCommand();
        public static SqlException exception = null;
        public static void Baglanti()
        {
            con = new SqlConnection(SQLConnectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static object Command(string query)
        {
            exception = null; // bir kere dolduktan sonra boşaltmadığımz için uyarı çıkmadı

            // kaydın başarılı olup olmadığıunı anlayacağüımız kontrol eklşeyelim.
            object obj = null;
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand

            try
            {
                obj = com.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                exception = ex;
                MessageBox.Show(ex.GetType().Name + " - " + ex.Message); // alşdığımız hata ' yani tek tırnak hatası. Yine parametre kullanılmadığı için.
                // bu hatanın önüne geçmek için tık tırnakları replace etmemiz lazım. yada farklı bir tek tırnak kullanmak gerekli.
                // mesela şunun gibi ’ ' farklı olduğunu görebiliyorsunz.
            }


            return obj;
        }

        public static DataTable Table(string query)
        {
            exception = null; // bir kere dolduktan sonra boşaltmadığımz için uyarı çıkmadı

            DataTable dt = new DataTable();
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand
            da.SelectCommand = com; // // SqlCommand'ın bir select sorgusu olduğunu belirtiyoruz.
            
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                exception = ex;
                MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
            }


            return dt;
        }
    }
}