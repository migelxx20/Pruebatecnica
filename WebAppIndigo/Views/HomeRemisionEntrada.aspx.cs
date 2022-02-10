using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppIndigo.ServiceReferenceProveedor;
using WebAppIndigo.ServiceReferenceRemison;

namespace WebAppIndigo.Views
{
    public partial class HomeRemisionEntrada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            recargarProveedor();
            recargarAlmacen();


        }
         ProveedorClient Client = new ProveedorClient();
         RemisionServiceClient Remi = new RemisionServiceClient();

        protected void Button1_Click(object sender, EventArgs e)
        {

            Ejecuta(1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            recargar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Ejecuta(2);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Ejecuta(3);
        }

        protected void TextBox1_SelectionChanged(object sender, EventArgs e)
        {
            fecha.Text = TextBox1.SelectedDate.ToShortDateString();
        }
        public void recargarProveedor()
        {
            getListProve g = new getListProve();
            g = Client.getProveedores();
            DataSet dt = new DataSet();
            dt = g.proveeTab;
            Listaprove.DataSource = dt;
            Listaprove.DataValueField = "id";
            Listaprove.DataTextField = "nombre";
            Listaprove.DataBind();
            Listaprove.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
            
        }
        public void recargarAlmacen()
        {
            getListAlma g = new getListAlma();
            g = Client.getAlmacenes();
            DataSet dt = new DataSet();
            dt = g.almaTab;
            ListaAlamce.DataSource = dt;
            this.ListaAlamce.DataValueField = "id";
            this.ListaAlamce.DataTextField = "nombre";
            ListaAlamce.DataBind();
            this.ListaAlamce.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }

        public void recargar()
        {
            getRemisiones g = new getRemisiones();
            g = Remi.GetInforma();
            DataTable dt = new DataTable();
            dt = g.remisonesTab;
            grilla.DataSource = dt;
            grilla.DataBind();
        }

        public void Ejecuta(int TipoOpera)
        {

            GeneraRemision remision = new GeneraRemision();
            remision.Codigo = cod.Text;
            remision.FechaDocumento = DateTime.Parse(fecha.Text);
            remision.IdProveedor = int.Parse(Request.Form[Listaprove.UniqueID]);
            remision.IdAlamacen = int.Parse(Request.Form[ListaAlamce.UniqueID]);
            remision.Tipoopera = TipoOpera;
            remision.Id = int.Parse(idremi.Text);
            if (TipoOpera==1)
            {
                remision.Estado = 1;
            }else if (TipoOpera == 2)
            {
                remision.Estado = 2;
            }
            else if(TipoOpera== 5)
            {
                remision.Estado = 2;
            }else if(TipoOpera == 4)
            {
                remision.Estado = 3;
            }
            


            string resul = Remi.GeneraRemision(remision);
            msj.Text = resul.ToString();
            recargar();
        }

        protected void grilla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Ejecuta(5);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Ejecuta(4);
        }
    }
}