using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Turismul_de_pretutindeni
{
    class UTILIZATORI
    {
        CONNECTION conn = new CONNECTION();

        public bool userExists(string email,string pass)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText ="SELECT * FROM Utilizatori WHERE Email=@em AND Parola=@pass";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
