using Miguelwcf.conexion;
using Miguelwcf.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Configuration;

namespace Miguelwcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProductoService : IProducto
    {
        public string Delete(DeleteProducto Del)
        {
            SqlConnection con = new Conexion().Abrir();
            string sms;
            SqlCommand cmd = new SqlCommand(" DELETE FROM producto WHERE  " +
            " id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Del.Id);


            int ok = cmd.ExecuteNonQuery();
            if (ok == 1)
            {
                sms = "Producto Eliminado Con Exito.";

            }
            else
            {
                sms = "Error al Eliminar.!";
            }
            con.Close();
            return sms;
        }

        public getDatos getInfo()
        {
            getDatos datos = new getDatos();
            SqlConnection con = new Conexion().Abrir();
            SqlCommand cmd = new SqlCommand("select * from producto", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("mytab");
            adapter.Fill(dt);
            datos.productoTab = dt;
            con.Close();
            return datos;
        }

        public string Insert(InsertPro Pro)
        {
            SqlConnection con = new Conexion().Abrir();
            //SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["indigoEntities"].ConnectionString);
            //con.Open();
            string sms;
            SqlCommand cmd = new SqlCommand(" INSERT INTO producto (Codigo,Nombre,Descripcion,PrecioVenta,StockMinimo,StockMaximo) " +
            " values (@Codigo,@Nombre,@Descripcion,@PrecioVenta,@StockMinimo,@StockMaximo)", con);
            cmd.Parameters.AddWithValue("@Codigo", Pro.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", Pro.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", Pro.Descripcion);
            cmd.Parameters.AddWithValue("@PrecioVenta", Pro.Precioventa);
            cmd.Parameters.AddWithValue("@StockMinimo", Pro.Stockminimo);
            cmd.Parameters.AddWithValue("@StockMaximo", Pro.Stockmaximo);

            int ok = cmd.ExecuteNonQuery();
            if (ok == 1)
            {
                sms = "Producto " + Pro.Nombre + " Insertado Con Exito.";

            }
            else
            {
                sms = "Error al crear producto " + Pro.Nombre + ".!";
            }
            con.Close();
            return sms;
        }

        public string Update(UpdateProducto Producto)
        {
            SqlConnection con = new Conexion().Abrir();

            string sms;
            SqlCommand cmd = new SqlCommand(" UPDATE  producto SET " +
            "  codigo=@Codigo,Nombre=@Nombre,Descripcion=@Descripcion,PrecioVenta=@PrecioVenta,StockMinimo=@StockMinimo,StockMaximo=@StockMaximo WHERE id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Producto.Id);
            cmd.Parameters.AddWithValue("@Codigo", Producto.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", Producto.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", Producto.Descripcion);
            cmd.Parameters.AddWithValue("@PrecioVenta", Producto.Precioventa);
            cmd.Parameters.AddWithValue("@StockMinimo", Producto.Stockminimo);
            cmd.Parameters.AddWithValue("@StockMaximo", Producto.Stockmaximo);

            int ok = cmd.ExecuteNonQuery();
            if (ok == 1)
            {
                sms = "Producto " + Producto.Nombre + " Modificado Con Exito.";

            }
            else
            {
                sms = "Error al Modificar producto " + Producto.Nombre + ".!";
            }
            con.Close();
            return sms;

        }

    }
}
