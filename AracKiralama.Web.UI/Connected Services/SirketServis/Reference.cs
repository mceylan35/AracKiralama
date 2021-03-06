﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracKiralama.Web.UI.SirketServis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SirketDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class SirketDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int SirketIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SirketAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SehirField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AracSayisiField;
        
        private System.Nullable<int> SirketPuaniField;
        
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
        public int SirketId {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string SirketAdi {
            get {
                return this.SirketAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.SirketAdiField, value) != true)) {
                    this.SirketAdiField = value;
                    this.RaisePropertyChanged("SirketAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sehir {
            get {
                return this.SehirField;
            }
            set {
                if ((object.ReferenceEquals(this.SehirField, value) != true)) {
                    this.SehirField = value;
                    this.RaisePropertyChanged("Sehir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Adres {
            get {
                return this.AdresField;
            }
            set {
                if ((object.ReferenceEquals(this.AdresField, value) != true)) {
                    this.AdresField = value;
                    this.RaisePropertyChanged("Adres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string AracSayisi {
            get {
                return this.AracSayisiField;
            }
            set {
                if ((object.ReferenceEquals(this.AracSayisiField, value) != true)) {
                    this.AracSayisiField = value;
                    this.RaisePropertyChanged("AracSayisi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<int> SirketPuani {
            get {
                return this.SirketPuaniField;
            }
            set {
                if ((this.SirketPuaniField.Equals(value) != true)) {
                    this.SirketPuaniField = value;
                    this.RaisePropertyChanged("SirketPuani");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SirketServis.SirketServisSoap")]
    public interface SirketServisSoap {
        
        // CODEGEN: Generating message contract since element name entity from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        AracKiralama.Web.UI.SirketServis.AddResponse Add(AracKiralama.Web.UI.SirketServis.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.SirketServis.AddResponse> AddAsync(AracKiralama.Web.UI.SirketServis.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
        
        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        AracKiralama.Web.UI.SirketServis.GetResponse Get(AracKiralama.Web.UI.SirketServis.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.SirketServis.GetResponse> GetAsync(AracKiralama.Web.UI.SirketServis.GetRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        AracKiralama.Web.UI.SirketServis.GetAllResponse GetAll(AracKiralama.Web.UI.SirketServis.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.SirketServis.GetAllResponse> GetAllAsync(AracKiralama.Web.UI.SirketServis.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        void Update(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateAsync(int id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.Web.UI.SirketServis.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(AracKiralama.Web.UI.SirketServis.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.Web.UI.SirketServis.SirketDTO entity;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(AracKiralama.Web.UI.SirketServis.SirketDTO entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.Web.UI.SirketServis.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(AracKiralama.Web.UI.SirketServis.AddResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.Web.UI.SirketServis.SirketDTO AddResult;
        
        public AddResponseBody() {
        }
        
        public AddResponseBody(AracKiralama.Web.UI.SirketServis.SirketDTO AddResult) {
            this.AddResult = AddResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.Web.UI.SirketServis.GetRequestBody Body;
        
        public GetRequest() {
        }
        
        public GetRequest(AracKiralama.Web.UI.SirketServis.GetRequestBody Body) {
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
        public AracKiralama.Web.UI.SirketServis.GetResponseBody Body;
        
        public GetResponse() {
        }
        
        public GetResponse(AracKiralama.Web.UI.SirketServis.GetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.Web.UI.SirketServis.SirketDTO GetResult;
        
        public GetResponseBody() {
        }
        
        public GetResponseBody(AracKiralama.Web.UI.SirketServis.SirketDTO GetResult) {
            this.GetResult = GetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.Web.UI.SirketServis.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(AracKiralama.Web.UI.SirketServis.GetAllRequestBody Body) {
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
        public AracKiralama.Web.UI.SirketServis.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(AracKiralama.Web.UI.SirketServis.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.Web.UI.SirketServis.SirketDTO[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(AracKiralama.Web.UI.SirketServis.SirketDTO[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SirketServisSoapChannel : AracKiralama.Web.UI.SirketServis.SirketServisSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SirketServisSoapClient : System.ServiceModel.ClientBase<AracKiralama.Web.UI.SirketServis.SirketServisSoap>, AracKiralama.Web.UI.SirketServis.SirketServisSoap {
        
        public SirketServisSoapClient() {
        }
        
        public SirketServisSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SirketServisSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SirketServisSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SirketServisSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.Web.UI.SirketServis.AddResponse AracKiralama.Web.UI.SirketServis.SirketServisSoap.Add(AracKiralama.Web.UI.SirketServis.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public AracKiralama.Web.UI.SirketServis.SirketDTO Add(AracKiralama.Web.UI.SirketServis.SirketDTO entity) {
            AracKiralama.Web.UI.SirketServis.AddRequest inValue = new AracKiralama.Web.UI.SirketServis.AddRequest();
            inValue.Body = new AracKiralama.Web.UI.SirketServis.AddRequestBody();
            inValue.Body.entity = entity;
            AracKiralama.Web.UI.SirketServis.AddResponse retVal = ((AracKiralama.Web.UI.SirketServis.SirketServisSoap)(this)).Add(inValue);
            return retVal.Body.AddResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.SirketServis.AddResponse> AracKiralama.Web.UI.SirketServis.SirketServisSoap.AddAsync(AracKiralama.Web.UI.SirketServis.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.Web.UI.SirketServis.AddResponse> AddAsync(AracKiralama.Web.UI.SirketServis.SirketDTO entity) {
            AracKiralama.Web.UI.SirketServis.AddRequest inValue = new AracKiralama.Web.UI.SirketServis.AddRequest();
            inValue.Body = new AracKiralama.Web.UI.SirketServis.AddRequestBody();
            inValue.Body.entity = entity;
            return ((AracKiralama.Web.UI.SirketServis.SirketServisSoap)(this)).AddAsync(inValue);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.Web.UI.SirketServis.GetResponse AracKiralama.Web.UI.SirketServis.SirketServisSoap.Get(AracKiralama.Web.UI.SirketServis.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public AracKiralama.Web.UI.SirketServis.SirketDTO Get(int id) {
            AracKiralama.Web.UI.SirketServis.GetRequest inValue = new AracKiralama.Web.UI.SirketServis.GetRequest();
            inValue.Body = new AracKiralama.Web.UI.SirketServis.GetRequestBody();
            inValue.Body.id = id;
            AracKiralama.Web.UI.SirketServis.GetResponse retVal = ((AracKiralama.Web.UI.SirketServis.SirketServisSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.SirketServis.GetResponse> AracKiralama.Web.UI.SirketServis.SirketServisSoap.GetAsync(AracKiralama.Web.UI.SirketServis.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.Web.UI.SirketServis.GetResponse> GetAsync(int id) {
            AracKiralama.Web.UI.SirketServis.GetRequest inValue = new AracKiralama.Web.UI.SirketServis.GetRequest();
            inValue.Body = new AracKiralama.Web.UI.SirketServis.GetRequestBody();
            inValue.Body.id = id;
            return ((AracKiralama.Web.UI.SirketServis.SirketServisSoap)(this)).GetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.Web.UI.SirketServis.GetAllResponse AracKiralama.Web.UI.SirketServis.SirketServisSoap.GetAll(AracKiralama.Web.UI.SirketServis.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public AracKiralama.Web.UI.SirketServis.SirketDTO[] GetAll() {
            AracKiralama.Web.UI.SirketServis.GetAllRequest inValue = new AracKiralama.Web.UI.SirketServis.GetAllRequest();
            inValue.Body = new AracKiralama.Web.UI.SirketServis.GetAllRequestBody();
            AracKiralama.Web.UI.SirketServis.GetAllResponse retVal = ((AracKiralama.Web.UI.SirketServis.SirketServisSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.Web.UI.SirketServis.GetAllResponse> AracKiralama.Web.UI.SirketServis.SirketServisSoap.GetAllAsync(AracKiralama.Web.UI.SirketServis.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.Web.UI.SirketServis.GetAllResponse> GetAllAsync() {
            AracKiralama.Web.UI.SirketServis.GetAllRequest inValue = new AracKiralama.Web.UI.SirketServis.GetAllRequest();
            inValue.Body = new AracKiralama.Web.UI.SirketServis.GetAllRequestBody();
            return ((AracKiralama.Web.UI.SirketServis.SirketServisSoap)(this)).GetAllAsync(inValue);
        }
        
        public void Update(int id) {
            base.Channel.Update(id);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(int id) {
            return base.Channel.UpdateAsync(id);
        }
    }
}
