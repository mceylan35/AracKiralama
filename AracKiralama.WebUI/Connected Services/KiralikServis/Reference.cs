﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracKiralama.WebUI.KiralikServis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KiralikDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class KiralikDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int KiralikIdField;
        
        private System.Nullable<int> AracIdField;
        
        private System.Nullable<System.DateTime> Alis_TarihiField;
        
        private System.Nullable<System.DateTime> Veris_TarihiField;
        
        private System.Nullable<long> VerilisKmField;
        
        private System.Nullable<decimal> AlinanUcretField;
        
        private System.Nullable<bool> IadeField;
        
        private System.Nullable<bool> DurumField;
        
        private System.Nullable<int> MusteriIdField;
        
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
        public int KiralikId {
            get {
                return this.KiralikIdField;
            }
            set {
                if ((this.KiralikIdField.Equals(value) != true)) {
                    this.KiralikIdField = value;
                    this.RaisePropertyChanged("KiralikId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public System.Nullable<int> AracId {
            get {
                return this.AracIdField;
            }
            set {
                if ((this.AracIdField.Equals(value) != true)) {
                    this.AracIdField = value;
                    this.RaisePropertyChanged("AracId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<System.DateTime> Alis_Tarihi {
            get {
                return this.Alis_TarihiField;
            }
            set {
                if ((this.Alis_TarihiField.Equals(value) != true)) {
                    this.Alis_TarihiField = value;
                    this.RaisePropertyChanged("Alis_Tarihi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<System.DateTime> Veris_Tarihi {
            get {
                return this.Veris_TarihiField;
            }
            set {
                if ((this.Veris_TarihiField.Equals(value) != true)) {
                    this.Veris_TarihiField = value;
                    this.RaisePropertyChanged("Veris_Tarihi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<long> VerilisKm {
            get {
                return this.VerilisKmField;
            }
            set {
                if ((this.VerilisKmField.Equals(value) != true)) {
                    this.VerilisKmField = value;
                    this.RaisePropertyChanged("VerilisKm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<decimal> AlinanUcret {
            get {
                return this.AlinanUcretField;
            }
            set {
                if ((this.AlinanUcretField.Equals(value) != true)) {
                    this.AlinanUcretField = value;
                    this.RaisePropertyChanged("AlinanUcret");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<bool> Iade {
            get {
                return this.IadeField;
            }
            set {
                if ((this.IadeField.Equals(value) != true)) {
                    this.IadeField = value;
                    this.RaisePropertyChanged("Iade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<bool> Durum {
            get {
                return this.DurumField;
            }
            set {
                if ((this.DurumField.Equals(value) != true)) {
                    this.DurumField = value;
                    this.RaisePropertyChanged("Durum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public System.Nullable<int> MusteriId {
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KiralikServis.KiralikServiceSoap")]
    public interface KiralikServiceSoap {
        
        // CODEGEN: Generating message contract since element name entity from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        AracKiralama.WebUI.KiralikServis.AddResponse Add(AracKiralama.WebUI.KiralikServis.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.AddResponse> AddAsync(AracKiralama.WebUI.KiralikServis.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
        
        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        AracKiralama.WebUI.KiralikServis.GetResponse Get(AracKiralama.WebUI.KiralikServis.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.GetResponse> GetAsync(AracKiralama.WebUI.KiralikServis.GetRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        AracKiralama.WebUI.KiralikServis.GetAllResponse GetAll(AracKiralama.WebUI.KiralikServis.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.GetAllResponse> GetAllAsync(AracKiralama.WebUI.KiralikServis.GetAllRequest request);
        
        // CODEGEN: Generating message contract since element name entity from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        AracKiralama.WebUI.KiralikServis.UpdateResponse Update(AracKiralama.WebUI.KiralikServis.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.UpdateResponse> UpdateAsync(AracKiralama.WebUI.KiralikServis.UpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WebUI.KiralikServis.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(AracKiralama.WebUI.KiralikServis.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.WebUI.KiralikServis.KiralikDTO entity;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(AracKiralama.WebUI.KiralikServis.KiralikDTO entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WebUI.KiralikServis.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(AracKiralama.WebUI.KiralikServis.AddResponseBody Body) {
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
        public AracKiralama.WebUI.KiralikServis.GetRequestBody Body;
        
        public GetRequest() {
        }
        
        public GetRequest(AracKiralama.WebUI.KiralikServis.GetRequestBody Body) {
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
        public AracKiralama.WebUI.KiralikServis.GetResponseBody Body;
        
        public GetResponse() {
        }
        
        public GetResponse(AracKiralama.WebUI.KiralikServis.GetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.WebUI.KiralikServis.KiralikDTO GetResult;
        
        public GetResponseBody() {
        }
        
        public GetResponseBody(AracKiralama.WebUI.KiralikServis.KiralikDTO GetResult) {
            this.GetResult = GetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WebUI.KiralikServis.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(AracKiralama.WebUI.KiralikServis.GetAllRequestBody Body) {
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
        public AracKiralama.WebUI.KiralikServis.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(AracKiralama.WebUI.KiralikServis.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.WebUI.KiralikServis.KiralikDTO[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(AracKiralama.WebUI.KiralikServis.KiralikDTO[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WebUI.KiralikServis.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(AracKiralama.WebUI.KiralikServis.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AracKiralama.WebUI.KiralikServis.KiralikDTO entity;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(AracKiralama.WebUI.KiralikServis.KiralikDTO entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public AracKiralama.WebUI.KiralikServis.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(AracKiralama.WebUI.KiralikServis.UpdateResponseBody Body) {
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
    public interface KiralikServiceSoapChannel : AracKiralama.WebUI.KiralikServis.KiralikServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KiralikServiceSoapClient : System.ServiceModel.ClientBase<AracKiralama.WebUI.KiralikServis.KiralikServiceSoap>, AracKiralama.WebUI.KiralikServis.KiralikServiceSoap {
        
        public KiralikServiceSoapClient() {
        }
        
        public KiralikServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KiralikServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KiralikServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KiralikServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.WebUI.KiralikServis.AddResponse AracKiralama.WebUI.KiralikServis.KiralikServiceSoap.Add(AracKiralama.WebUI.KiralikServis.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public void Add(AracKiralama.WebUI.KiralikServis.KiralikDTO entity) {
            AracKiralama.WebUI.KiralikServis.AddRequest inValue = new AracKiralama.WebUI.KiralikServis.AddRequest();
            inValue.Body = new AracKiralama.WebUI.KiralikServis.AddRequestBody();
            inValue.Body.entity = entity;
            AracKiralama.WebUI.KiralikServis.AddResponse retVal = ((AracKiralama.WebUI.KiralikServis.KiralikServiceSoap)(this)).Add(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.AddResponse> AracKiralama.WebUI.KiralikServis.KiralikServiceSoap.AddAsync(AracKiralama.WebUI.KiralikServis.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.AddResponse> AddAsync(AracKiralama.WebUI.KiralikServis.KiralikDTO entity) {
            AracKiralama.WebUI.KiralikServis.AddRequest inValue = new AracKiralama.WebUI.KiralikServis.AddRequest();
            inValue.Body = new AracKiralama.WebUI.KiralikServis.AddRequestBody();
            inValue.Body.entity = entity;
            return ((AracKiralama.WebUI.KiralikServis.KiralikServiceSoap)(this)).AddAsync(inValue);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.WebUI.KiralikServis.GetResponse AracKiralama.WebUI.KiralikServis.KiralikServiceSoap.Get(AracKiralama.WebUI.KiralikServis.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public AracKiralama.WebUI.KiralikServis.KiralikDTO Get(int id) {
            AracKiralama.WebUI.KiralikServis.GetRequest inValue = new AracKiralama.WebUI.KiralikServis.GetRequest();
            inValue.Body = new AracKiralama.WebUI.KiralikServis.GetRequestBody();
            inValue.Body.id = id;
            AracKiralama.WebUI.KiralikServis.GetResponse retVal = ((AracKiralama.WebUI.KiralikServis.KiralikServiceSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.GetResponse> AracKiralama.WebUI.KiralikServis.KiralikServiceSoap.GetAsync(AracKiralama.WebUI.KiralikServis.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.GetResponse> GetAsync(int id) {
            AracKiralama.WebUI.KiralikServis.GetRequest inValue = new AracKiralama.WebUI.KiralikServis.GetRequest();
            inValue.Body = new AracKiralama.WebUI.KiralikServis.GetRequestBody();
            inValue.Body.id = id;
            return ((AracKiralama.WebUI.KiralikServis.KiralikServiceSoap)(this)).GetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.WebUI.KiralikServis.GetAllResponse AracKiralama.WebUI.KiralikServis.KiralikServiceSoap.GetAll(AracKiralama.WebUI.KiralikServis.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public AracKiralama.WebUI.KiralikServis.KiralikDTO[] GetAll() {
            AracKiralama.WebUI.KiralikServis.GetAllRequest inValue = new AracKiralama.WebUI.KiralikServis.GetAllRequest();
            inValue.Body = new AracKiralama.WebUI.KiralikServis.GetAllRequestBody();
            AracKiralama.WebUI.KiralikServis.GetAllResponse retVal = ((AracKiralama.WebUI.KiralikServis.KiralikServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.GetAllResponse> AracKiralama.WebUI.KiralikServis.KiralikServiceSoap.GetAllAsync(AracKiralama.WebUI.KiralikServis.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.GetAllResponse> GetAllAsync() {
            AracKiralama.WebUI.KiralikServis.GetAllRequest inValue = new AracKiralama.WebUI.KiralikServis.GetAllRequest();
            inValue.Body = new AracKiralama.WebUI.KiralikServis.GetAllRequestBody();
            return ((AracKiralama.WebUI.KiralikServis.KiralikServiceSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AracKiralama.WebUI.KiralikServis.UpdateResponse AracKiralama.WebUI.KiralikServis.KiralikServiceSoap.Update(AracKiralama.WebUI.KiralikServis.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public void Update(AracKiralama.WebUI.KiralikServis.KiralikDTO entity) {
            AracKiralama.WebUI.KiralikServis.UpdateRequest inValue = new AracKiralama.WebUI.KiralikServis.UpdateRequest();
            inValue.Body = new AracKiralama.WebUI.KiralikServis.UpdateRequestBody();
            inValue.Body.entity = entity;
            AracKiralama.WebUI.KiralikServis.UpdateResponse retVal = ((AracKiralama.WebUI.KiralikServis.KiralikServiceSoap)(this)).Update(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.UpdateResponse> AracKiralama.WebUI.KiralikServis.KiralikServiceSoap.UpdateAsync(AracKiralama.WebUI.KiralikServis.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<AracKiralama.WebUI.KiralikServis.UpdateResponse> UpdateAsync(AracKiralama.WebUI.KiralikServis.KiralikDTO entity) {
            AracKiralama.WebUI.KiralikServis.UpdateRequest inValue = new AracKiralama.WebUI.KiralikServis.UpdateRequest();
            inValue.Body = new AracKiralama.WebUI.KiralikServis.UpdateRequestBody();
            inValue.Body.entity = entity;
            return ((AracKiralama.WebUI.KiralikServis.KiralikServiceSoap)(this)).UpdateAsync(inValue);
        }
    }
}