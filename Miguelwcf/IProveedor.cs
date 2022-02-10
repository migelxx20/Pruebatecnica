using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Miguelwcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProveedor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProveedor
    {
        [OperationContract]
        string Guardar(GuardaProve Prove);
        [OperationContract]
        getProveedores getInfo();
        [OperationContract]
        string Update(UpdateProve Prove);
        [OperationContract]
        string Delete(DeleteProveedor Prove);
        [OperationContract]
        getListProve getProveedores();

        [OperationContract]
        getListAlma getAlmacenes();


    }

    public class GuardaProve
    {
        string codigo = string.Empty;
        string nombre = string.Empty;
        string direccion = string.Empty;
        string telefono = string.Empty;

        [DataMember]
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        [DataMember]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
    public class getProveedores
    {
        [DataMember]
        public DataTable proveedorTab
        {
            get;
            set;
        }
    }
    public class UpdateProve
    {
        int id;
        string codigo = string.Empty;
        string nombre = string.Empty;
        string direccion = string.Empty;
        string telefono = string.Empty;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        [DataMember]
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        [DataMember]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }

    public class DeleteProveedor
    {
        int id;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }

        }
    }

    public class getListProve
    {
        [DataMember]
        public DataSet proveeTab
        {
            get;
            set;
        }
    }
    public class getListAlma
    {
        [DataMember]
        public DataSet almaTab
        {
            get;
            set;
        }
    }
}
