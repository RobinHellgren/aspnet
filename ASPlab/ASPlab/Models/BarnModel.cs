using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlab.Models
{
    public class BarnModel
    {
        private string connectionString;

        public BarnModel()
        {
            connectionString = "Server=wwwlab.iit.his.se;Database=a17robhe_tomte;User InfoNisse;Password=123;Pooling=false;SslMode=none;convert zero datetime=True;";
            MySql.Data.MySqlClient.MySqlConnection dbCon = new MySql.Data.MySqlClient.MySqlConnection(connectionString);



        }
    }
}
