using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Miguelwcf.conexion
{   
    public class Conexion
    {
        
        public SqlConnection conectarbd = new SqlConnection(WebConfigurationManager.ConnectionStrings["indigoEntities"].ConnectionString);

        public SqlConnection Abrir()
        {
            try
            {
                conectarbd.Open();
            }
            catch (Exception)
            {

                throw;
            }
            return conectarbd;
        }

        public void Cerrar()
        {
            try
            {
                conectarbd.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}