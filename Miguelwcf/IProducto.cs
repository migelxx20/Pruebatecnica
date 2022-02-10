using Miguelwcf.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Miguelwcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProducto
    {

        [OperationContract]
        string Insert(InsertPro Pro);
        [OperationContract]
        getDatos getInfo();

        [OperationContract]
        string Update(UpdateProducto Producto);
        [OperationContract]
        string Delete(DeleteProducto Del);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class InsertPro
    {
        string codigo = string.Empty;
        string nombre = string.Empty;
        string descripcion = string.Empty;
        double precioventa = double.MaxValue;
        int stockminimo = int.MaxValue;
        int stockmaximo = int.MaxValue;


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
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        [DataMember]
        public double Precioventa
        {
            get { return precioventa; }
            set { precioventa = value; }
        }

        [DataMember]
        public int Stockminimo
        {
            get { return stockminimo; }
            set { stockminimo = value; }
        }
        [DataMember]
        public int Stockmaximo
        {
            get { return stockmaximo; }
            set { stockmaximo = value; }
        }
    }
    [DataContract]
    public class getDatos
    {
        [DataMember]
        public DataTable productoTab
        {
            get;
            set;
        }

    }
    public class UpdateProducto
    {
        int id;
        string codigo = string.Empty;
        string nombre = string.Empty;
        string descripcion = string.Empty;
        double precioventa = double.MaxValue;
        int stockminimo = int.MaxValue;
        int stockmaximo = int.MaxValue;

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
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        [DataMember]
        public double Precioventa
        {
            get { return precioventa; }
            set { precioventa = value; }
        }

        [DataMember]
        public int Stockminimo
        {
            get { return stockminimo; }
            set { stockminimo = value; }
        }
        [DataMember]
        public int Stockmaximo
        {
            get { return stockmaximo; }
            set { stockmaximo = value; }
        }

    }
    public class DeleteProducto
    {
        int id;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }

        }
    }

    }
