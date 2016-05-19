using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TestProjectsWord
{
    class DatabaseAccess
    {
        public string myConnString;
        public MySqlConnection conn;
       public DatabaseAccess()
        {
            myConnString = "SERVER=oldbrainbox;Port=3306;Database=dataTransfers;uid=root;Password=Raven47946$;";
            conn = new MySqlConnection(myConnString);
        }

        public void Add(TransferInfo T)
        {
            
            String ComputerName = System.Environment.MachineName;
            DateTime date = DateTime.Today;
            String CurrentDate = date.ToString("yyyy-MM-dd");
            conn.Open();

            String InsertDT = "INSERT INTO transferinformation VALUES ('" + T.EmployeeID + "','" + T.FirstName + "','" + T.LastName + "','" + T.PhoneNumber + "','" + T.OldComputer + "','" + ComputerName + "','" + T.VPN + "','" + CurrentDate + "',NULL,NULL);";
            MySqlCommand InsertSQL = new MySqlCommand(InsertDT, conn);
            InsertSQL.ExecuteNonQuery();
        }
    }
}
