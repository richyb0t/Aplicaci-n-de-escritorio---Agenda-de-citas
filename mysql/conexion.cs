using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto.mysql
{
    class conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=LocalHost;database=hospital;Uid=root;pwd=1234");
            conexion.Open();
            return conexion;
        }
    }
}
