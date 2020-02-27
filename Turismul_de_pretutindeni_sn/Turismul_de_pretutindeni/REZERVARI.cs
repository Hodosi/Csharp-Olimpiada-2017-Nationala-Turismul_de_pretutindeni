using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Turismul_de_pretutindeni
{
    class REZERVARI
    {
        CONNECTION conn = new CONNECTION();
        public DataTable getRezervari(string nm)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Utilizatori.Nume,Vacante.NumeVacanta,Rezervari.DataInceput,Rezervari.DataSfarsit,Rezervari.NrPersoane,Rezervari.PretTotal FROM Rezervari INNER JOIN Utilizatori ON Rezervari.IdUser=Utilizatori.IdUser INNER JOIN Vacante ON Rezervari.IdVacanta=Vacante.IdVacanta WHERE Vacante.NumeVacanta=@nm";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nm;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public DataTable getRezervariByEmail(string email)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Vacante.NumeVacanta,Rezervari.DataInceput,Rezervari.DataSfarsit,Rezervari.NrPersoane,Rezervari.PretTotal FROM Rezervari INNER JOIN Utilizatori ON Rezervari.IdUser=Utilizatori.IdUser INNER JOIN Vacante ON Rezervari.IdVacanta=Vacante.IdVacanta WHERE Utilizatori.Email=@em";
            command.Connection = conn.GetConnection();

            //command.Parameters.Add("nm", SqlDbType.VarChar).Value = nm;
            command.Parameters.Add("em", SqlDbType.VarChar).Value = email;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public int getNrLocuriRezervate(int id, DateTime din, DateTime dout)
        {
            SqlCommand command = new SqlCommand();
            //command.CommandText = "SELECT Utilizatori.Nume,Vacante.NumeVacanta,Rezervari.DataInceput,Rezervari.DataSfarsit,Rezervari.NrPersoane,Rezervari.PretTotal FROM Rezervari INNER JOIN Utilizatori ON Rezervari.IdUser=Utilizatori.IdUser INNER JOIN Vacante ON Rezervari.IdVacanta=Vacante.IdVacanta";
            command.CommandText = "SELECT SUM(NrPersoane) FROM Rezervari WHERE IdVacanta=@id AND DataSfarsit>@din AND DataInceput<@dout";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("id", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("din", SqlDbType.DateTime).Value = din;
            command.Parameters.Add("dout", SqlDbType.DateTime).Value = dout;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            int.TryParse(table.Rows[0][0].ToString(), out int result);
            return result;
        }


        public int getidUser(string email)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT IdUser FROM Utilizatori WHERE Email=@em";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = email;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return int.Parse(table.Rows[0][0].ToString());
        }
        public int getidVacanta(string nume)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT IdVacanta FROM Vacante WHERE NumeVacanta=@nm";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nume;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return int.Parse(table.Rows[0][0].ToString());
        }

        public bool addRezervari(int IdVac, int idUs, DateTime din, DateTime dout, int nrpers, float pret)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Rezervari(IdVacanta,IdUser,DataInceput,DataSfarsit,NrPersoane,PretTotal) VALUES(@idv,@idu,@din,@dout,@nr,@pret)";
            command.Connection = conn.GetConnection();

            //idv,@idu,@din,@dout,@nr,@pret
            command.Parameters.Add("idv", SqlDbType.Int).Value = IdVac;
            command.Parameters.Add("idu", SqlDbType.Int).Value = idUs;
            command.Parameters.Add("din", SqlDbType.DateTime).Value = din;
            command.Parameters.Add("dout", SqlDbType.DateTime).Value = dout;
            command.Parameters.Add("nr", SqlDbType.Int).Value = nrpers;
            command.Parameters.Add("pret", SqlDbType.Float).Value = pret;

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
        public bool deleteRezervare(int pret)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Rezervari WHERE PretTotal=@pret";
            command.Connection = conn.GetConnection();

            //idv,@idu,@din,@dout,@nr,@pret
            command.Parameters.Add("pret", SqlDbType.Int).Value = pret;


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
