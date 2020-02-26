using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Turismul_de_pretutindeni
{
    class QUERYS
    {
        CONNECTION conn = new CONNECTION();

        public bool dbccVacante()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DBCC CHECKIDENT (Vacante,RESEED,0)";
            command.Connection = conn.GetConnection();

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
