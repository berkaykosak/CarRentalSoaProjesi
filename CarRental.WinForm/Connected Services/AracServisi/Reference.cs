﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental.WinForm.AracServisi {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Arac", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Arac : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int AracIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AracMarkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        private System.Nullable<int> EhliyetYasiField;
        
        private System.Nullable<int> MinYasSiniriField;
        
        private System.Nullable<int> GunlukSinirKMField;
        
        private System.Nullable<long> KendiAnlikKMField;
        
        private System.Nullable<bool> AirBagField;
        
        private System.Nullable<int> BagajHacmiField;
        
        private System.Nullable<int> KoltukSayisiField;
        
        private System.Nullable<decimal> GunlukKiralikFiyatField;
        
        private System.Nullable<int> SirketIDField;
        
        private System.Nullable<bool> RezerveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CarRental.WinForm.AracServisi.Sirket SirketField;
        
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
        public int AracID {
            get {
                return this.AracIDField;
            }
            set {
                if ((this.AracIDField.Equals(value) != true)) {
                    this.AracIDField = value;
                    this.RaisePropertyChanged("AracID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string AracMarka {
            get {
                return this.AracMarkaField;
            }
            set {
                if ((object.ReferenceEquals(this.AracMarkaField, value) != true)) {
                    this.AracMarkaField = value;
                    this.RaisePropertyChanged("AracMarka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<int> EhliyetYasi {
            get {
                return this.EhliyetYasiField;
            }
            set {
                if ((this.EhliyetYasiField.Equals(value) != true)) {
                    this.EhliyetYasiField = value;
                    this.RaisePropertyChanged("EhliyetYasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<int> MinYasSiniri {
            get {
                return this.MinYasSiniriField;
            }
            set {
                if ((this.MinYasSiniriField.Equals(value) != true)) {
                    this.MinYasSiniriField = value;
                    this.RaisePropertyChanged("MinYasSiniri");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<int> GunlukSinirKM {
            get {
                return this.GunlukSinirKMField;
            }
            set {
                if ((this.GunlukSinirKMField.Equals(value) != true)) {
                    this.GunlukSinirKMField = value;
                    this.RaisePropertyChanged("GunlukSinirKM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<long> KendiAnlikKM {
            get {
                return this.KendiAnlikKMField;
            }
            set {
                if ((this.KendiAnlikKMField.Equals(value) != true)) {
                    this.KendiAnlikKMField = value;
                    this.RaisePropertyChanged("KendiAnlikKM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<bool> AirBag {
            get {
                return this.AirBagField;
            }
            set {
                if ((this.AirBagField.Equals(value) != true)) {
                    this.AirBagField = value;
                    this.RaisePropertyChanged("AirBag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public System.Nullable<int> BagajHacmi {
            get {
                return this.BagajHacmiField;
            }
            set {
                if ((this.BagajHacmiField.Equals(value) != true)) {
                    this.BagajHacmiField = value;
                    this.RaisePropertyChanged("BagajHacmi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public System.Nullable<int> KoltukSayisi {
            get {
                return this.KoltukSayisiField;
            }
            set {
                if ((this.KoltukSayisiField.Equals(value) != true)) {
                    this.KoltukSayisiField = value;
                    this.RaisePropertyChanged("KoltukSayisi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public System.Nullable<decimal> GunlukKiralikFiyat {
            get {
                return this.GunlukKiralikFiyatField;
            }
            set {
                if ((this.GunlukKiralikFiyatField.Equals(value) != true)) {
                    this.GunlukKiralikFiyatField = value;
                    this.RaisePropertyChanged("GunlukKiralikFiyat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public System.Nullable<int> SirketID {
            get {
                return this.SirketIDField;
            }
            set {
                if ((this.SirketIDField.Equals(value) != true)) {
                    this.SirketIDField = value;
                    this.RaisePropertyChanged("SirketID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=12)]
        public System.Nullable<bool> Rezerve {
            get {
                return this.RezerveField;
            }
            set {
                if ((this.RezerveField.Equals(value) != true)) {
                    this.RezerveField = value;
                    this.RaisePropertyChanged("Rezerve");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public CarRental.WinForm.AracServisi.Sirket Sirket {
            get {
                return this.SirketField;
            }
            set {
                if ((object.ReferenceEquals(this.SirketField, value) != true)) {
                    this.SirketField = value;
                    this.RaisePropertyChanged("Sirket");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Sirket", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Sirket : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int SirketIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SirketAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SirketSehirField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SirketAdresField;
        
        private int SirketAracSayisiField;
        
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
        public int SirketID {
            get {
                return this.SirketIDField;
            }
            set {
                if ((this.SirketIDField.Equals(value) != true)) {
                    this.SirketIDField = value;
                    this.RaisePropertyChanged("SirketID");
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
        public string SirketSehir {
            get {
                return this.SirketSehirField;
            }
            set {
                if ((object.ReferenceEquals(this.SirketSehirField, value) != true)) {
                    this.SirketSehirField = value;
                    this.RaisePropertyChanged("SirketSehir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string SirketAdres {
            get {
                return this.SirketAdresField;
            }
            set {
                if ((object.ReferenceEquals(this.SirketAdresField, value) != true)) {
                    this.SirketAdresField = value;
                    this.RaisePropertyChanged("SirketAdres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int SirketAracSayisi {
            get {
                return this.SirketAracSayisiField;
            }
            set {
                if ((this.SirketAracSayisiField.Equals(value) != true)) {
                    this.SirketAracSayisiField = value;
                    this.RaisePropertyChanged("SirketAracSayisi");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AracServisi.AracSoap")]
    public interface AracSoap {
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        CarRental.WinForm.AracServisi.GetAllResponse GetAll(CarRental.WinForm.AracServisi.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<CarRental.WinForm.AracServisi.GetAllResponse> GetAllAsync(CarRental.WinForm.AracServisi.GetAllRequest request);
        
        // CODEGEN: Generating message contract since element name aracBilgi from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        CarRental.WinForm.AracServisi.UpdateResponse Update(CarRental.WinForm.AracServisi.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<CarRental.WinForm.AracServisi.UpdateResponse> UpdateAsync(CarRental.WinForm.AracServisi.UpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public CarRental.WinForm.AracServisi.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(CarRental.WinForm.AracServisi.GetAllRequestBody Body) {
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
        public CarRental.WinForm.AracServisi.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(CarRental.WinForm.AracServisi.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CarRental.WinForm.AracServisi.Arac[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(CarRental.WinForm.AracServisi.Arac[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public CarRental.WinForm.AracServisi.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(CarRental.WinForm.AracServisi.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CarRental.WinForm.AracServisi.Arac aracBilgi;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(CarRental.WinForm.AracServisi.Arac aracBilgi) {
            this.aracBilgi = aracBilgi;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public CarRental.WinForm.AracServisi.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(CarRental.WinForm.AracServisi.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool UpdateResult;
        
        public UpdateResponseBody() {
        }
        
        public UpdateResponseBody(bool UpdateResult) {
            this.UpdateResult = UpdateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AracSoapChannel : CarRental.WinForm.AracServisi.AracSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AracSoapClient : System.ServiceModel.ClientBase<CarRental.WinForm.AracServisi.AracSoap>, CarRental.WinForm.AracServisi.AracSoap {
        
        public AracSoapClient() {
        }
        
        public AracSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AracSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AracSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AracSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CarRental.WinForm.AracServisi.GetAllResponse CarRental.WinForm.AracServisi.AracSoap.GetAll(CarRental.WinForm.AracServisi.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public CarRental.WinForm.AracServisi.Arac[] GetAll() {
            CarRental.WinForm.AracServisi.GetAllRequest inValue = new CarRental.WinForm.AracServisi.GetAllRequest();
            inValue.Body = new CarRental.WinForm.AracServisi.GetAllRequestBody();
            CarRental.WinForm.AracServisi.GetAllResponse retVal = ((CarRental.WinForm.AracServisi.AracSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CarRental.WinForm.AracServisi.GetAllResponse> CarRental.WinForm.AracServisi.AracSoap.GetAllAsync(CarRental.WinForm.AracServisi.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<CarRental.WinForm.AracServisi.GetAllResponse> GetAllAsync() {
            CarRental.WinForm.AracServisi.GetAllRequest inValue = new CarRental.WinForm.AracServisi.GetAllRequest();
            inValue.Body = new CarRental.WinForm.AracServisi.GetAllRequestBody();
            return ((CarRental.WinForm.AracServisi.AracSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CarRental.WinForm.AracServisi.UpdateResponse CarRental.WinForm.AracServisi.AracSoap.Update(CarRental.WinForm.AracServisi.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public bool Update(CarRental.WinForm.AracServisi.Arac aracBilgi) {
            CarRental.WinForm.AracServisi.UpdateRequest inValue = new CarRental.WinForm.AracServisi.UpdateRequest();
            inValue.Body = new CarRental.WinForm.AracServisi.UpdateRequestBody();
            inValue.Body.aracBilgi = aracBilgi;
            CarRental.WinForm.AracServisi.UpdateResponse retVal = ((CarRental.WinForm.AracServisi.AracSoap)(this)).Update(inValue);
            return retVal.Body.UpdateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CarRental.WinForm.AracServisi.UpdateResponse> CarRental.WinForm.AracServisi.AracSoap.UpdateAsync(CarRental.WinForm.AracServisi.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<CarRental.WinForm.AracServisi.UpdateResponse> UpdateAsync(CarRental.WinForm.AracServisi.Arac aracBilgi) {
            CarRental.WinForm.AracServisi.UpdateRequest inValue = new CarRental.WinForm.AracServisi.UpdateRequest();
            inValue.Body = new CarRental.WinForm.AracServisi.UpdateRequestBody();
            inValue.Body.aracBilgi = aracBilgi;
            return ((CarRental.WinForm.AracServisi.AracSoap)(this)).UpdateAsync(inValue);
        }
    }
}
