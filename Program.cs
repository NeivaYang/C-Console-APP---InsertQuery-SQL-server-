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
                sqlConnection.Open();
                Console.WriteLine("Success");
                List<listaNomes> lista = Nomes.GetlistaNomes();
                lista.ForEach(ln => Console.WriteLine ("ID: "+ln.Id+ ", Nome: " +ln.Nome));
                Console.WriteLine("Informe qual nome da lista deseja inserir");
                string name = Console.ReadLine();
                int ID = int.Parse(Console.ReadLine());
                DateTime data = new DateTime.Now;
                string insertQuery = "INSERT INTO DETAILS(ID, NOME, DATA_CREACAO) VALUES("+ ID +", "+ name +", "+ data +")" ;
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Insert Succesfully");
                sqlConnection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}