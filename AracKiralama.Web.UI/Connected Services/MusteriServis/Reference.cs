﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracKiralama.Web.UI.MusteriServis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MusteriDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class MusteriDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int MusteriIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SoyadiField;
        
        private System.Nullable<System.DateTime> DogumTarihiField;
        
        private System.Nullable<System.DateTime> EhliyetAlimTarihiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SifreField;
        
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
        public int MusteriId {
            get {
                return this.MusteriIdField;
            }
            set {
                if ((this.MusteriIdField.Equals(value) != true)) {
                    this.MusteriIdField = value;
                    this.RaisePropertyChanged("MusteriId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Adi {
            get {
                return this.AdiField;
            }
            set {
                if ((object.ReferenceEquals(this.AdiField, value) != true)) {
                    this.AdiField = value;
                    this.RaisePropertyChanged("Adi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Soyadi {
            get {
                return this.SoyadiField;
            }
            set {
                if ((object.ReferenceEquals(this.SoyadiField, value) != true)) {
                    this.SoyadiField = value;
                    this.RaisePropertyChanged("Soyadi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MusteriServis.MusteriServisSoap")]
    public interface MusteriServisSoap {
        
        // CODEGEN: Generating message contract since element name entity from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        AracKiralama.Web.UI.MusteriServis.AddResponse Add(AracKiralama.Web.UI.MusteriServis.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.AddResponse> AddAsync(AracKiralama.Web.UI.MusteriServis.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
        
        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        AracKiralama.Web.UI.MusteriServis.GetResponse Get(AracKiralama.Web.UI.MusteriServis.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.GetResponse> GetAsync(AracKiralama.Web.UI.MusteriServis.GetRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        AracKiralama.Web.UI.MusteriServis.GetAllResponse GetAll(AracKiralama.Web.UI.MusteriServis.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.GetAllResponse> GetAllAsync(AracKiralama.Web.UI.MusteriServis.GetAllRequest request);
        
        // CODEGEN: Generating message contract since element name entity from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        AracKiralama.Web.UI.MusteriServis.UpdateResponse Update(AracKiralama.Web.UI.MusteriServis.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.UpdateResponse> UpdateAsync(AracKiralama.Web.UI.MusteriServis.UpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.Web.UI.MusteriServis.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(AracKiralama.Web.UI.MusteriServis.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.Web.UI.MusteriServis.MusteriDTO entity;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(AracKiralama.Web.UI.MusteriServis.MusteriDTO entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.Web.UI.MusteriServis.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(AracKiralama.Web.UI.MusteriServis.AddResponseBody Body) {
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
        public AracKiralama.Web.UI.MusteriServis.GetRequestBody Body;
        
        public GetRequest() {
        }
        
        public GetRequest(AracKiralama.Web.UI.MusteriServis.GetRequestBody Body) {
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
        public AracKiralama.Web.UI.MusteriServis.GetResponseBody Body;
        
        public GetResponse() {
        }
        
        public GetResponse(AracKiralama.Web.UI.MusteriServis.GetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.Web.UI.MusteriServis.MusteriDTO GetResult;
        
        public GetResponseBody() {
        }
        
        public GetResponseBody(AracKiralama.Web.UI.MusteriServis.MusteriDTO GetResult) {
            this.GetResult = GetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.Web.UI.MusteriServis.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(AracKiralama.Web.UI.MusteriServis.GetAllRequestBody Body) {
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
        public AracKiralama.Web.UI.MusteriServis.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(AracKiralama.Web.UI.MusteriServis.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.Web.UI.MusteriServis.MusteriDTO[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(AracKiralama.Web.UI.MusteriServis.MusteriDTO[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.Web.UI.MusteriServis.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(AracKiralama.Web.UI.MusteriServis.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.Web.UI.MusteriServis.MusteriDTO entity;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(AracKiralama.Web.UI.MusteriServis.MusteriDTO entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.Web.UI.MusteriServis.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(AracKiralama.Web.UI.MusteriServis.UpdateResponseBody Body) {
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
    public interface MusteriServisSoapChannel : AracKiralama.Web.UI.MusteriServis.MusteriServisSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MusteriServisSoapClient : System.ServiceModel.ClientBase<AracKiralama.Web.UI.MusteriServis.MusteriServisSoap>, AracKiralama.Web.UI.MusteriServis.MusteriServisSoap {
        
        public MusteriServisSoapClient() {
        }
        
        public MusteriServisSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MusteriServisSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusteriServisSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusteriServisSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.Web.UI.MusteriServis.AddResponse AracKiralama.Web.UI.MusteriServis.MusteriServisSoap.Add(AracKiralama.Web.UI.MusteriServis.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public void Add(AracKiralama.Web.UI.MusteriServis.MusteriDTO entity) {
            AracKiralama.Web.UI.MusteriServis.AddRequest inValue = new AracKiralama.Web.UI.MusteriServis.AddRequest();
            inValue.Body = new AracKiralama.Web.UI.MusteriServis.AddRequestBody();
            inValue.Body.entity = entity;
            AracKiralama.Web.UI.MusteriServis.AddResponse retVal = ((AracKiralama.Web.UI.MusteriServis.MusteriServisSoap)(this)).Add(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.AddResponse> AracKiralama.Web.UI.MusteriServis.MusteriServisSoap.AddAsync(AracKiralama.Web.UI.MusteriServis.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.AddResponse> AddAsync(AracKiralama.Web.UI.MusteriServis.MusteriDTO entity) {
            AracKiralama.Web.UI.MusteriServis.AddRequest inValue = new AracKiralama.Web.UI.MusteriServis.AddRequest();
            inValue.Body = new AracKiralama.Web.UI.MusteriServis.AddRequestBody();
            inValue.Body.entity = entity;
            return ((AracKiralama.Web.UI.MusteriServis.MusteriServisSoap)(this)).AddAsync(inValue);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.Web.UI.MusteriServis.GetResponse AracKiralama.Web.UI.MusteriServis.MusteriServisSoap.Get(AracKiralama.Web.UI.MusteriServis.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public AracKiralama.Web.UI.MusteriServis.MusteriDTO Get(int id) {
            AracKiralama.Web.UI.MusteriServis.GetRequest inValue = new AracKiralama.Web.UI.MusteriServis.GetRequest();
            inValue.Body = new AracKiralama.Web.UI.MusteriServis.GetRequestBody();
            inValue.Body.id = id;
            AracKiralama.Web.UI.MusteriServis.GetResponse retVal = ((AracKiralama.Web.UI.MusteriServis.MusteriServisSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.GetResponse> AracKiralama.Web.UI.MusteriServis.MusteriServisSoap.GetAsync(AracKiralama.Web.UI.MusteriServis.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.GetResponse> GetAsync(int id) {
            AracKiralama.Web.UI.MusteriServis.GetRequest inValue = new AracKiralama.Web.UI.MusteriServis.GetRequest();
            inValue.Body = new AracKiralama.Web.UI.MusteriServis.GetRequestBody();
            inValue.Body.id = id;
            return ((AracKiralama.Web.UI.MusteriServis.MusteriServisSoap)(this)).GetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.Web.UI.MusteriServis.GetAllResponse AracKiralama.Web.UI.MusteriServis.MusteriServisSoap.GetAll(AracKiralama.Web.UI.MusteriServis.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public AracKiralama.Web.UI.MusteriServis.MusteriDTO[] GetAll() {
            AracKiralama.Web.UI.MusteriServis.GetAllRequest inValue = new AracKiralama.Web.UI.MusteriServis.GetAllRequest();
            inValue.Body = new AracKiralama.Web.UI.MusteriServis.GetAllRequestBody();
            AracKiralama.Web.UI.MusteriServis.GetAllResponse retVal = ((AracKiralama.Web.UI.MusteriServis.MusteriServisSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.GetAllResponse> AracKiralama.Web.UI.MusteriServis.MusteriServisSoap.GetAllAsync(AracKiralama.Web.UI.MusteriServis.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.GetAllResponse> GetAllAsync() {
            AracKiralama.Web.UI.MusteriServis.GetAllRequest inValue = new AracKiralama.Web.UI.MusteriServis.GetAllRequest();
            inValue.Body = new AracKiralama.Web.UI.MusteriServis.GetAllRequestBody();
            return ((AracKiralama.Web.UI.MusteriServis.MusteriServisSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.Web.UI.MusteriServis.UpdateResponse AracKiralama.Web.UI.MusteriServis.MusteriServisSoap.Update(AracKiralama.Web.UI.MusteriServis.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public void Update(AracKiralama.Web.UI.MusteriServis.MusteriDTO entity) {
            AracKiralama.Web.UI.MusteriServis.UpdateRequest inValue = new AracKiralama.Web.UI.MusteriServis.UpdateRequest();
            inValue.Body = new AracKiralama.Web.UI.MusteriServis.UpdateRequestBody();
            inValue.Body.entity = entity;
            AracKiralama.Web.UI.MusteriServis.UpdateResponse retVal = ((AracKiralama.Web.UI.MusteriServis.MusteriServisSoap)(this)).Update(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.UpdateResponse> AracKiralama.Web.UI.MusteriServis.MusteriServisSoap.UpdateAsync(AracKiralama.Web.UI.MusteriServis.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.Web.UI.MusteriServis.UpdateResponse> UpdateAsync(AracKiralama.Web.UI.MusteriServis.MusteriDTO entity) {
            AracKiralama.Web.UI.MusteriServis.UpdateRequest inValue = new AracKiralama.Web.UI.MusteriServis.UpdateRequest();
            inValue.Body = new AracKiralama.Web.UI.MusteriServis.UpdateRequestBody();
            inValue.Body.entity = entity;
            return ((AracKiralama.Web.UI.MusteriServis.MusteriServisSoap)(this)).UpdateAsync(inValue);
        }
    }
}