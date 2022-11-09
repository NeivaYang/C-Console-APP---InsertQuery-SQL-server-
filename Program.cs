using koniaE1;
using koniaE1.services;
using System;
using System.Data.SqlClient;

namespace koniaE1
{
    public class program
    {
        static void Main(string[], args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.; Initial Catalog=KoniaDB;Itegrated Security=true";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message)
            }
            List<listaNomes> lista = Nomes.GetlistaNomes();
            lista.ForEach(ln => Console.WriteLine ("ID: "+ln.Id+ ", Nome: " +ln.Nome));
            Console.WriteLine("Informe qual nome da lista deseja inserir(Informe o id correspondente ao nome): ");
            Console.ReadKey();
        }
    }
}