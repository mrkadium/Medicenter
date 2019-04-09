using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBManager.CLS
{
    public class DBConexion
    {
        protected MySqlConnection oConexion;
        String CadenaConexion = "Server=localhost;Port=3306;Database=sistema;Uid=root;Pwd=admin";

        protected Boolean Conectar()
        {
            Boolean conectado = false;
            try
            {
                oConexion = new MySqlConnection();
                oConexion.ConnectionString = CadenaConexion;
                oConexion.Open();
                conectado = true;
            }
            catch
            {
                conectado = false;
            }
            return conectado;
        }

        protected void Desconectar()
        {
            try
            {
                if(oConexion.State == System.Data.ConnectionState.Open)
                {
                    oConexion.Close();
                }
            }
            catch
            {

            }
        }
    }
}
