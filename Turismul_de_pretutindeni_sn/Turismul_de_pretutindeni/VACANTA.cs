using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Turismul_de_pretutindeni
{
    class VACANTA
    {
        CONNECTION conn = new CONNECTION();

        public string getPret(string nmLoc)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Pret FROM Vacante WHERE NumeVacanta=@nm";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nmLoc;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows[0][0].ToString();
        }
        public string getLocuri(string nmLoc)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT NrLocuri FROM Vacante WHERE NumeVacanta=@nm";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nmLoc;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows[0][0].ToString();
        }
        public string getDescriere(string nmLoc)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Descriere FROM Vacante WHERE NumeVacanta=@nm";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nmLoc;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows[0][0].ToString();
        }
    }
}
