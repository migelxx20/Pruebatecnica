using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppIndigo.ServiceReferenceProducto;

namespace WebAppIndigo
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ProductoClient Client = new ProductoClient(); 
        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertPro insertPro = new InsertPro();

            insertPro.Codigo = cod.Text;
            insertPro.Nombre = nom.Text;
            insertPro.Descripcion = des.Text;
            insertPro.Precioventa = double.Parse(pre.Text);
            insertPro.Stockminimo = int.Parse(stockmin.Text);
            insertPro.Stockmaximo = int.Parse(stockmax.Text);

            string resul = Client.Insert(insertPro);
            msj.Text = resul.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            recargar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            UpdateProducto updateProducto = new UpdateProducto();

            updateProducto.Codigo = cod.Text;
            updateProducto.Nombre= nom.Text;
            updateProducto.Descripcion= des.Text;
            updateProducto.Precioventa= double.Parse(pre.Text);
            updateProducto.Stockminimo= int.Parse(stockmin.Text);
            updateProducto.Stockmaximo= int.Parse(stockmax.Text);   
            updateProducto.Id=  int.Parse(idpro.Text);

            string result = Client.Update(updateProducto);
            msj.Text = result.ToString();
            recargar();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DeleteProducto deleteProducto = new DeleteProducto();
            deleteProducto.Id = int.Parse(idpro.Text);
            string result = Client.Delete(deleteProducto);
            msj.Text = result.ToString();
            recargar();
        }
        public void recargar()
        {
            getDatos g = new getDatos();
            g = Client.getInfo();
            DataTable dt = new DataTable();
            dt = g.productoTab;
            grilla.DataSource = dt;
            grilla.DataBind();
        }
    }
}