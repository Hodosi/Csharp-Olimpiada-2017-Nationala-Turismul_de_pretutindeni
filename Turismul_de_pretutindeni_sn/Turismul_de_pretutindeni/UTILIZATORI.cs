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

        public bool userExists(string email, string pass)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Utilizatori WHERE Email=@em AND Parola=@pass";
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
        public bool emailExists(string email)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Utilizatori WHERE Email=@em";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = email;

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

        public bool addUser(string nume, string prenume, string email, string parola, int tip)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Utilizatori(Nume,Prenume,Email,Parola,TipCont) VALUES(@nm,@pn,@em,@pass,@tip)";
            command.Connection = conn.GetConnection();

            //@nm,@pn,@em,@pass,@tip
            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nume;
            command.Parameters.Add("pn", SqlDbType.VarChar).Value = prenume;
            command.Parameters.Add("em", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("pass", SqlDbType.VarChar).Value = parola;
            command.Parameters.Add("tip", SqlDbType.VarChar).Value = tip;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        public DataTable getUser()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Email FROM Utilizatori";
            command.Connection = conn.GetConnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool updateAdmin(string em,int val=0)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE Utilizatori SET TipCont=@val WHERE email=@em";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = em;
            command.Parameters.Add("val", SqlDbType.Int).Value = val;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }


    }
}
