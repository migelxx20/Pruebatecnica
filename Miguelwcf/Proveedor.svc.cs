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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Proveedor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Proveedor.svc o Proveedor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Proveedor : IProveedor
    {
        public string Delete(DeleteProveedor Prove)
        {
            SqlConnection con = new Conexion().Abrir();
            string sms;
            SqlCommand cmd = new SqlCommand(" DELETE FROM proveedor WHERE  " +
            " id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Prove.Id);


            int ok = cmd.ExecuteNonQuery();
            if (ok == 1)
            {
                sms = "Proveedor Eliminado Con Exito.";

            }
            else
            {
                sms = "Error al Eliminar.!";
            }
            con.Close();
            return sms;
        }

        public getListAlma getAlmacenes()
        {
            getListAlma datos = new getListAlma();
            SqlConnection con = new Conexion().Abrir();
            SqlCommand cmd = new SqlCommand("select id,Nombre from almacen", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            datos.almaTab = dt;
            con.Close();
            return datos;
        }

        public getProveedores getInfo()
        {
            getProveedores datos = new getProveedores();
            SqlConnection con = new Conexion().Abrir();
            SqlCommand cmd = new SqlCommand("exec Sp_datos_proveedor", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("mytab");
            adapter.Fill(dt);
            datos.proveedorTab = dt;
            con.Close();
            return datos;
        }

        public getListProve getProveedores()
        {
            getListProve datos = new getListProve();
            SqlConnection con = new Conexion().Abrir();
            SqlCommand cmd = new SqlCommand("select id,Nombre from proveedor", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            datos.proveeTab = dt;
            con.Close();
            return datos;
        }

        public string Guardar(GuardaProve Prove)
        {
            SqlConnection con = new Conexion().Abrir();
            string sms;
            SqlCommand cmd = new SqlCommand(" INSERT INTO proveedor (Codigo,Nombre,Direccion,Telefono) " +
            " values (@Codigo,@Nombre,@Direccion,@Telefono)", con);
            cmd.Parameters.AddWithValue("@Codigo", Prove.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", Prove.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", Prove.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", Prove.Telefono);

            int ok = cmd.ExecuteNonQuery();
            if (ok == 1)
            {
                sms = "Producto " + Prove.Nombre + " Insertado Con Exito.";

            }
            else
            {
                sms = "Error al crear producto " + Prove.Nombre + ".!";
            }
            con.Close();
            return sms;
        }

        public string Update(UpdateProve Prove)
        {
            SqlConnection con = new Conexion().Abrir();

            string sms;
            SqlCommand cmd = new SqlCommand(" UPDATE  proveedor SET " +
            "  codigo=@Codigo,Nombre=@Nombre,Direccion=@Direccion,Telefono=@Telefono WHERE id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Prove.Id);
            cmd.Parameters.AddWithValue("@Codigo", Prove.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", Prove.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", Prove.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", Prove.Telefono);

            int ok = cmd.ExecuteNonQuery();
            if (ok == 1)
            {
                sms = "Producto " + Prove.Nombre + " Modificado Con Exito.";

            }
            else
            {
                sms = "Error al Modificar producto " + Prove.Nombre + ".!";
            }
            con.Close();
            return sms;
        }
    }
}
