using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalSystem
{
    class Database
    {
        SqlConnection con;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        DataSet ds;
        SqlCommandBuilder sql;
        SqlCommand querySyntax;

        public void openConnection()
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=NSBA-PC\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True";
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error In Open Connection" + ex.Message);
            }
        }

        public void closeConnection()
        {
            con.Close();
        }
        public void select(string queryStatement)
        {
            dataAdapter = new SqlDataAdapter(queryStatement, con);
        }


        public DataTable fetch()
        {
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataSet resultSelect()
        {
            ds = new System.Data.DataSet();
            dataAdapter.Fill(ds, "Customer_data");
            return ds;
        }

        public string[] queryNoReturn(string sql)
        {
            querySyntax = new SqlCommand(sql, con);
            string[] dataArray = new string[100];
            SqlDataReader reader = querySyntax.ExecuteReader();

            while (reader.Read())
            {

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dataArray[i] = reader[i].ToString();
                }
            }
            reader.Close();
            return dataArray;

        }

        public int query(string sql)
        {
            try
            {
                querySyntax = new SqlCommand(sql, con);
                return querySyntax.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }


        public void updateButton()
        {
            try
            {
                sql = new SqlCommandBuilder();
                dataAdapter.Update(ds, "Customer_data");
                MessageBox.Show("Data Updated !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error In Update from Button" + ex.Message);

            }

        }
    }
}
