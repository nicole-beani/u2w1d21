using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Azienda.Models
{
    public class Db
    {
        public static List<Dipendenti> getAllDipendenti()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Dipendenti", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Dipendenti> dipendenti = new List<Dipendenti>();
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Dipendenti dipendente = new Dipendenti();
                dipendente.Id = Convert.ToInt32(sqlDataReader["IdDipendenti"]);
                dipendente.Nome = sqlDataReader["Nome"].ToString();
                dipendente.Cognome = sqlDataReader["Cognome"].ToString();
                dipendente.Indirizzo = sqlDataReader["Indirizzo"].ToString();
                dipendente.CF = sqlDataReader["CF"].ToString();
                dipendente.Coniugato = Convert.ToBoolean(sqlDataReader["Sposato"]);
                dipendente.NumFigli = Convert.ToInt16(sqlDataReader["Figli"]);
                dipendente.Mansione = sqlDataReader["Mansione"].ToString();
                dipendenti.Add(dipendente);
            }

            conn.Close();
            return dipendenti;
        }
    }
}