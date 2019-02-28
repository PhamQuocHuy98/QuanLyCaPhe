using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF.DAO
{
    class DataProvider
    {
        private static DataProvider instance;
        static string source = FormChonCSDL.source;
        static string database = FormChonCSDL.database;
        static string user = FormChonCSDL.user;
        static string pass = FormChonCSDL.pass;


        //string kk = "";

        private string constr = "Data Source=" + source + ";Initial Catalog=" + database + ";Integrated Security=True";


        private DataProvider() { }
        public static DataProvider Instance
        {
           
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            if(user!="")
            {
                constr = "Source ="+source+"; Database ="+database+"; User Id ="+user+";Password ="+pass;
            }
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null) // kieemr tra cập nhật thành công hay k
        {
            int data = 0;
            if (user != "")
            {
                constr = "SERVER =" + source + "; Database =" + database + "; User Id =" + user + ";Password =" + pass;
            }

            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
    }
}
