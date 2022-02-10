using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppIndigo.ServiceReferenceProveedor;

namespace WebAppIndigo
{
    public partial class HomeProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ProveedorClient Client = new ProveedorClient();
        protected void Button2_Click(object sender, EventArgs e)
        {
            recargar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            UpdateProve updateProve = new UpdateProve();    
            updateProve.Codigo = cod.Text;
            updateProve.Nombre = nom.Text;
            updateProve.Direccion = des.Text;
            updateProve.Telefono = pre.Text;
            updateProve.Id = int.Parse(idpro.Text);

            string result = Client.Update(updateProve);
            msj.Text = result.ToString();
            recargar();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DeleteProveedor deleteProveedor = new DeleteProveedor();

            deleteProveedor.Id = int.Parse(idpro.Text);
            string result = Client.Delete(deleteProveedor);
            msj.Text = result.ToString();
            recargar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GuardaProve insertProveedor = new GuardaProve();    
            insertProveedor.Codigo = cod.Text;
            insertProveedor.Nombre = nom.Text;
            insertProveedor.Direccion = des.Text;
            insertProveedor.Telefono = pre.Text;


            string resul = Client.Guardar(insertProveedor);
            msj.Text = resul.ToString();
        }

        public void recargar()
        {
            getProveedores g = new getProveedores();
            g = Client.getInfo();
            DataTable dt = new DataTable();
            dt = g.proveedorTab;
            grilla.DataSource = dt;
            grilla.DataBind();
        }
    }
}