using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webAppMiguel.ServiceReferenceProducto;

namespace webAppMiguel
{
    public partial class Homepages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Consultar()
        {
            using (ProductoClient client = new ProductoClient())
            {
                grilla.DataSource = client.Consultar();
                grilla.DataBind();  
            }

        }

        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}