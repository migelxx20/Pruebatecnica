//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppIndigo.ServiceReferenceRemison {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GeneraRemision", Namespace="http://schemas.datacontract.org/2004/07/Miguelwcf")]
    [System.SerializableAttribute()]
    public partial class GeneraRemision : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaDocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdAlamacenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdProveedorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TipooperaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaDocumento {
            get {
                return this.FechaDocumentoField;
            }
            set {
                if ((this.FechaDocumentoField.Equals(value) != true)) {
                    this.FechaDocumentoField = value;
                    this.RaisePropertyChanged("FechaDocumento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdAlamacen {
            get {
                return this.IdAlamacenField;
            }
            set {
                if ((this.IdAlamacenField.Equals(value) != true)) {
                    this.IdAlamacenField = value;
                    this.RaisePropertyChanged("IdAlamacen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdProveedor {
            get {
                return this.IdProveedorField;
            }
            set {
                if ((this.IdProveedorField.Equals(value) != true)) {
                    this.IdProveedorField = value;
                    this.RaisePropertyChanged("IdProveedor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Tipoopera {
            get {
                return this.TipooperaField;
            }
            set {
                if ((this.TipooperaField.Equals(value) != true)) {
                    this.TipooperaField = value;
                    this.RaisePropertyChanged("Tipoopera");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="getRemisiones", Namespace="http://schemas.datacontract.org/2004/07/Miguelwcf")]
    [System.SerializableAttribute()]
    public partial class getRemisiones : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.DataTable remisonesTabField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.DataTable remisonesTab {
            get {
                return this.remisonesTabField;
            }
            set {
                if ((object.ReferenceEquals(this.remisonesTabField, value) != true)) {
                    this.remisonesTabField = value;
                    this.RaisePropertyChanged("remisonesTab");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceRemison.IRemisionService")]
    public interface IRemisionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemisionService/GeneraRemision", ReplyAction="http://tempuri.org/IRemisionService/GeneraRemisionResponse")]
        string GeneraRemision(WebAppIndigo.ServiceReferenceRemison.GeneraRemision Remi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemisionService/GeneraRemision", ReplyAction="http://tempuri.org/IRemisionService/GeneraRemisionResponse")]
        System.Threading.Tasks.Task<string> GeneraRemisionAsync(WebAppIndigo.ServiceReferenceRemison.GeneraRemision Remi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemisionService/GetInforma", ReplyAction="http://tempuri.org/IRemisionService/GetInformaResponse")]
        WebAppIndigo.ServiceReferenceRemison.getRemisiones GetInforma();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemisionService/GetInforma", ReplyAction="http://tempuri.org/IRemisionService/GetInformaResponse")]
        System.Threading.Tasks.Task<WebAppIndigo.ServiceReferenceRemison.getRemisiones> GetInformaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRemisionServiceChannel : WebAppIndigo.ServiceReferenceRemison.IRemisionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RemisionServiceClient : System.ServiceModel.ClientBase<WebAppIndigo.ServiceReferenceRemison.IRemisionService>, WebAppIndigo.ServiceReferenceRemison.IRemisionService {
        
        public RemisionServiceClient() {
        }
        
        public RemisionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RemisionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemisionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemisionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GeneraRemision(WebAppIndigo.ServiceReferenceRemison.GeneraRemision Remi) {
            return base.Channel.GeneraRemision(Remi);
        }
        
        public System.Threading.Tasks.Task<string> GeneraRemisionAsync(WebAppIndigo.ServiceReferenceRemison.GeneraRemision Remi) {
            return base.Channel.GeneraRemisionAsync(Remi);
        }
        
        public WebAppIndigo.ServiceReferenceRemison.getRemisiones GetInforma() {
            return base.Channel.GetInforma();
        }
        
        public System.Threading.Tasks.Task<WebAppIndigo.ServiceReferenceRemison.getRemisiones> GetInformaAsync() {
            return base.Channel.GetInformaAsync();
        }
    }
}
