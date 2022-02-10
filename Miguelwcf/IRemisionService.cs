using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Miguelwcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRemisionService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRemisionService
    {
        [OperationContract]
        String GeneraRemision(GeneraRemision Remi);
        [OperationContract]
        getRemisiones GetInforma();
    }
    public class GeneraRemision {
        int id = int.MinValue;
        string codigo = string.Empty;
        int idproveedor;
        int idalmacen;
        int estado;
        int tipoopera;
        DateTime fechadocumento = DateTime.Now;

        [DataMember]
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

  
        [DataMember]
        public int IdProveedor
        {
            get { return idproveedor; }
            set { idproveedor = value; }
        }

        [DataMember]
        public int IdAlamacen
        {
            get { return idalmacen; }
            set { idalmacen = value; }
        }

        [DataMember]
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        [DataMember]
        public DateTime FechaDocumento
        {
            get { return fechadocumento; }
            set { fechadocumento = value; }
        }

        [DataMember]
        public int Tipoopera
        {
            get { return tipoopera; }
            set { tipoopera = value; }
        }

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }

    public class getRemisiones
    {
        [DataMember]
        public DataTable remisonesTab
        {
            get;
            set;
        }
    }

}
