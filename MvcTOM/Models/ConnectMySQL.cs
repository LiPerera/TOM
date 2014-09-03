using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace MvcTOM.Models
{
    public class ConnectMySQL
    {
        public MySqlConnection TomCon;
        public MySqlCommand TomCommand;
        public MySqlDataAdapter TomDta;

        public void Connection()
        {
            TomCon = new MySqlConnection();
            TomCon.ConnectionString = "server=192.168.0.113; database=tom_tst; Uid=tom_usr; pwd=hola123;";

            TomCommand = new MySqlCommand();
            TomCommand.Connection = TomCon;
            TomDta = new MySqlDataAdapter();
            TomDta.SelectCommand = TomCommand;

        }

    }
}