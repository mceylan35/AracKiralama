﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracKiralama.WinFormUI.KullaniciSoapServis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KullaniciDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class KullaniciDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int KullaniciIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SoyadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        private System.Nullable<System.DateTime> EhliyetAlimTarihiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SifreField;
        
        private System.Nullable<System.DateTime> DogumTarihiField;
        
        private System.Nullable<int> RoleIdField;
        
        private System.Nullable<int> SirketIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int KullaniciId {
            get {
                return this.KullaniciIdField;
            }
            set {
                if ((this.KullaniciIdField.Equals(value) != true)) {
                    this.KullaniciIdField = value;
                    this.RaisePropertyChanged("KullaniciId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Ad {
            get {
                return this.AdField;
            }
            set {
                if ((object.ReferenceEquals(this.AdField, value) != true)) {
                    this.AdField = value;
                    this.RaisePropertyChanged("Ad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Soyad {
            get {
                return this.SoyadField;
            }
            set {
                if ((object.ReferenceEquals(this.SoyadField, value) != true)) {
                    this.SoyadField = value;
                    this.RaisePropertyChanged("Soyad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<System.DateTime> EhliyetAlimTarihi {
            get {
                return this.EhliyetAlimTarihiField;
            }
            set {
                if ((this.EhliyetAlimTarihiField.Equals(value) != true)) {
                    this.EhliyetAlimTarihiField = value;
                    this.RaisePropertyChanged("EhliyetAlimTarihi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Sifre {
            get {
                return this.SifreField;
            }
            set {
                if ((object.ReferenceEquals(this.SifreField, value) != true)) {
                    this.SifreField = value;
                    this.RaisePropertyChanged("Sifre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<System.DateTime> DogumTarihi {
            get {
                return this.DogumTarihiField;
            }
            set {
                if ((this.DogumTarihiField.Equals(value) != true)) {
                    this.DogumTarihiField = value;
                    this.RaisePropertyChanged("DogumTarihi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<int> RoleId {
            get {
                return this.RoleIdField;
            }
            set {
                if ((this.RoleIdField.Equals(value) != true)) {
                    this.RoleIdField = value;
                    this.RaisePropertyChanged("RoleId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public System.Nullable<int> SirketId {
            get {
                return this.SirketIdField;
            }
            set {
                if ((this.SirketIdField.Equals(value) != true)) {
                    this.SirketIdField = value;
                    this.RaisePropertyChanged("SirketId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KullaniciSoapServis.KullaniciServisSoap")]
    public interface KullaniciServisSoap {
        
        // CODEGEN: Generating message contract since element name entity from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        AracKiralama.WinFormUI.KullaniciSoapServis.AddResponse Add(AracKiralama.WinFormUI.KullaniciSoapServis.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.AddResponse> AddAsync(AracKiralama.WinFormUI.KullaniciSoapServis.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
        
        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        AracKiralama.WinFormUI.KullaniciSoapServis.GetResponse Get(AracKiralama.WinFormUI.KullaniciSoapServis.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.GetResponse> GetAsync(AracKiralama.WinFormUI.KullaniciSoapServis.GetRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        AracKiralama.WinFormUI.KullaniciSoapServis.GetAllResponse GetAll(AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.GetAllResponse> GetAllAsync(AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequest request);
        
        // CODEGEN: Generating message contract since element name eposta from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KullaniciGiris", ReplyAction="*")]
        AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisResponse KullaniciGiris(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KullaniciGiris", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisResponse> KullaniciGirisAsync(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequest request);
        
        // CODEGEN: Generating message contract since element name entity from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        AracKiralama.WinFormUI.KullaniciSoapServis.UpdateResponse Update(AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.UpdateResponse> UpdateAsync(AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(AracKiralama.WinFormUI.KullaniciSoapServis.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO entity;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(AracKiralama.WinFormUI.KullaniciSoapServis.AddResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddResponseBody {
        
        public AddResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.GetRequestBody Body;
        
        public GetRequest() {
        }
        
        public GetRequest(AracKiralama.WinFormUI.KullaniciSoapServis.GetRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetRequestBody() {
        }
        
        public GetRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.GetResponseBody Body;
        
        public GetResponse() {
        }
        
        public GetResponse(AracKiralama.WinFormUI.KullaniciSoapServis.GetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO GetResult;
        
        public GetResponseBody() {
        }
        
        public GetResponseBody(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO GetResult) {
            this.GetResult = GetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody {
        
        public GetAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(AracKiralama.WinFormUI.KullaniciSoapServis.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KullaniciGirisRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="KullaniciGiris", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequestBody Body;
        
        public KullaniciGirisRequest() {
        }
        
        public KullaniciGirisRequest(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class KullaniciGirisRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string eposta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sifre;
        
        public KullaniciGirisRequestBody() {
        }
        
        public KullaniciGirisRequestBody(string eposta, string sifre) {
            this.eposta = eposta;
            this.sifre = sifre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KullaniciGirisResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="KullaniciGirisResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisResponseBody Body;
        
        public KullaniciGirisResponse() {
        }
        
        public KullaniciGirisResponse(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class KullaniciGirisResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO KullaniciGirisResult;
        
        public KullaniciGirisResponseBody() {
        }
        
        public KullaniciGirisResponseBody(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO KullaniciGirisResult) {
            this.KullaniciGirisResult = KullaniciGirisResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO entity;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WinFormUI.KullaniciSoapServis.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(AracKiralama.WinFormUI.KullaniciSoapServis.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateResponseBody {
        
        public UpdateResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface KullaniciServisSoapChannel : AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KullaniciServisSoapClient : System.ServiceModel.ClientBase<AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap>, AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap {
        
        public KullaniciServisSoapClient() {
        }
        
        public KullaniciServisSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KullaniciServisSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KullaniciServisSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KullaniciServisSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.WinFormUI.KullaniciSoapServis.AddResponse AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.Add(AracKiralama.WinFormUI.KullaniciSoapServis.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public void Add(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO entity) {
            AracKiralama.WinFormUI.KullaniciSoapServis.AddRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.AddRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.AddRequestBody();
            inValue.Body.entity = entity;
            AracKiralama.WinFormUI.KullaniciSoapServis.AddResponse retVal = ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).Add(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.AddResponse> AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.AddAsync(AracKiralama.WinFormUI.KullaniciSoapServis.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.AddResponse> AddAsync(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO entity) {
            AracKiralama.WinFormUI.KullaniciSoapServis.AddRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.AddRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.AddRequestBody();
            inValue.Body.entity = entity;
            return ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).AddAsync(inValue);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.WinFormUI.KullaniciSoapServis.GetResponse AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.Get(AracKiralama.WinFormUI.KullaniciSoapServis.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO Get(int id) {
            AracKiralama.WinFormUI.KullaniciSoapServis.GetRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.GetRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.GetRequestBody();
            inValue.Body.id = id;
            AracKiralama.WinFormUI.KullaniciSoapServis.GetResponse retVal = ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.GetResponse> AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.GetAsync(AracKiralama.WinFormUI.KullaniciSoapServis.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.GetResponse> GetAsync(int id) {
            AracKiralama.WinFormUI.KullaniciSoapServis.GetRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.GetRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.GetRequestBody();
            inValue.Body.id = id;
            return ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).GetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.WinFormUI.KullaniciSoapServis.GetAllResponse AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.GetAll(AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO[] GetAll() {
            AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequestBody();
            AracKiralama.WinFormUI.KullaniciSoapServis.GetAllResponse retVal = ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.GetAllResponse> AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.GetAllAsync(AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.GetAllResponse> GetAllAsync() {
            AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.GetAllRequestBody();
            return ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisResponse AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.KullaniciGiris(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequest request) {
            return base.Channel.KullaniciGiris(request);
        }
        
        public AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO KullaniciGiris(string eposta, string sifre) {
            AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequestBody();
            inValue.Body.eposta = eposta;
            inValue.Body.sifre = sifre;
            AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisResponse retVal = ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).KullaniciGiris(inValue);
            return retVal.Body.KullaniciGirisResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisResponse> AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.KullaniciGirisAsync(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequest request) {
            return base.Channel.KullaniciGirisAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisResponse> KullaniciGirisAsync(string eposta, string sifre) {
            AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciGirisRequestBody();
            inValue.Body.eposta = eposta;
            inValue.Body.sifre = sifre;
            return ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).KullaniciGirisAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.WinFormUI.KullaniciSoapServis.UpdateResponse AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.Update(AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public void Update(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO entity) {
            AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequestBody();
            inValue.Body.entity = entity;
            AracKiralama.WinFormUI.KullaniciSoapServis.UpdateResponse retVal = ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).Update(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.UpdateResponse> AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap.UpdateAsync(AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.WinFormUI.KullaniciSoapServis.UpdateResponse> UpdateAsync(AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciDTO entity) {
            AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequest inValue = new AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequest();
            inValue.Body = new AracKiralama.WinFormUI.KullaniciSoapServis.UpdateRequestBody();
            inValue.Body.entity = entity;
            return ((AracKiralama.WinFormUI.KullaniciSoapServis.KullaniciServisSoap)(this)).UpdateAsync(inValue);
        }
    }
}
