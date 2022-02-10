using Miguelwcf.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Miguelwcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RemisionService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RemisionService.svc o RemisionService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RemisionService : IRemisionService
    {
        public string GeneraRemision(GeneraRemision Remi)
        {
            SqlDataReader reader;
            SqlConnection con = new Conexion().Abrir();
            string sms="ok";
            SqlCommand cmd = new SqlCommand("Sp_Admintra_remisiones " , con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", Remi.Codigo);
            cmd.Parameters.AddWithValue("@Id", Remi.Id);
            cmd.Parameters.AddWithValue("@IdProveedor", Remi.IdProveedor);
            cmd.Parameters.AddWithValue("@IdAlmacen", Remi.IdAlamacen);
            cmd.Parameters.AddWithValue("@Estado", Remi.Estado);
            cmd.Parameters.AddWithValue("@FechaDocumento", Remi.FechaDocumento);
            cmd.Parameters.AddWithValue("@TipoOpera", Remi.Tipoopera);

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sms = reader["STATUS"].ToString();
            }
            
            con.Close();
            return sms;
        }

        public getRemisiones GetInforma()
        {
            getRemisiones datos = new getRemisiones();
            SqlConnection con = new Conexion().Abrir();
            SqlCommand cmd = new SqlCommand("select * from RemisionEntrada", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("mytab");
            adapter.Fill(dt);
            datos.remisonesTab = dt;
            con.Close();
            return datos;
        }
    }
}
