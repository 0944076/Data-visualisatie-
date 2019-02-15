//Standard imports:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Additional imports:
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace MssqlConnectionWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Lets get ourselfs some data!...");
            Console.WriteLine();

            DataTable data = GrabData("select count(*) from  Metro");
            int counter = 0;

            foreach (DataRow row in data.Rows)
            {
                counter++;
                Console.WriteLine(counter + ". "+ row[0]);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Grabs data from a, specified, remote SQL source.
        /// </summary>
        /// <param name="statement">A String which represents the SQL statement.</param>
        /// <returns>DataTable</returns>
        static public DataTable GrabData(string statement)
        {
            //Setup:
            ///Creeër een plaats om de data van ons request op te slaan.
            DataTable dataStore = new DataTable();


            ///Creeër de connectie die gebruikt zal worden om met de database te communiceren. 
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F698CBK\\SQLEXPRESS,1433;" +
            //"server=(local);" +
            //"Database=project3;Persist Security Info=True;" +                                                         
            //"User ID=sa; Password=welkom01");


            //als usings toevoegen


            var ls = WebConfigurationManager.ConnectionStrings;
            Console.WriteLine(" COUNT: " + ls.Count + "\t" + ls[0]);

            var css = WebConfigurationManager.ConnectionStrings[0];
            using (SqlConnection connection = new SqlConnection(css.ConnectionString.ToString())) {
                //Creeër de SQL statement.
                SqlCommand sqlStatement = new SqlCommand(statement, connection);
                ///Creeër de adapter die de data van de database ophaalt.
                SqlDataAdapter dataGrabber = new SqlDataAdapter(sqlStatement);

                //Work:
                ///Open de connectie naar de database.
                connection.Open();
                ///Vul met de adapter de "dataStore".
                dataGrabber.Fill(dataStore);
                ///Sluit de connectie naar de database.
                connection.Close();
            }
                //Shutdown:
            ///Return de "dataStore".
            return dataStore;
        }
    }
}
