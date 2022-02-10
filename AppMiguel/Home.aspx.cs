using AppMiguel.ConsultarProductoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppMiguel
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Consultar()
        {
            using (ProductoClient cliente = new ProductoClient())
            {

                grilla.DataSource = cliente.Consultar();
                grilla.DataBind();

            }
        }
        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}