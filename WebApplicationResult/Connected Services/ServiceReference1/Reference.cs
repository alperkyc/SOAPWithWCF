﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationResult.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Yillar", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceResults")]
    [System.SerializableAttribute()]
    public partial class Yillar : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplicationResult.ServiceReference1.Sonuclar[] SonuclarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string yilAdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int yilIdField;
        
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
        public WebApplicationResult.ServiceReference1.Sonuclar[] Sonuclar {
            get {
                return this.SonuclarField;
            }
            set {
                if ((object.ReferenceEquals(this.SonuclarField, value) != true)) {
                    this.SonuclarField = value;
                    this.RaisePropertyChanged("Sonuclar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string yilAd {
            get {
                return this.yilAdField;
            }
            set {
                if ((object.ReferenceEquals(this.yilAdField, value) != true)) {
                    this.yilAdField = value;
                    this.RaisePropertyChanged("yilAd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int yilId {
            get {
                return this.yilIdField;
            }
            set {
                if ((this.yilIdField.Equals(value) != true)) {
                    this.yilIdField = value;
                    this.RaisePropertyChanged("yilId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Sonuclar", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceResults")]
    [System.SerializableAttribute()]
    public partial class Sonuclar : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplicationResult.ServiceReference1.Ogrenciler OgrencilerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplicationResult.ServiceReference1.Turler TurlerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplicationResult.ServiceReference1.Yillar YillarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ogrenciIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> sonucField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int sonucIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> turIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> yilIdField;
        
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
        public WebApplicationResult.ServiceReference1.Ogrenciler Ogrenciler {
            get {
                return this.OgrencilerField;
            }
            set {
                if ((object.ReferenceEquals(this.OgrencilerField, value) != true)) {
                    this.OgrencilerField = value;
                    this.RaisePropertyChanged("Ogrenciler");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplicationResult.ServiceReference1.Turler Turler {
            get {
                return this.TurlerField;
            }
            set {
                if ((object.ReferenceEquals(this.TurlerField, value) != true)) {
                    this.TurlerField = value;
                    this.RaisePropertyChanged("Turler");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplicationResult.ServiceReference1.Yillar Yillar {
            get {
                return this.YillarField;
            }
            set {
                if ((object.ReferenceEquals(this.YillarField, value) != true)) {
                    this.YillarField = value;
                    this.RaisePropertyChanged("Yillar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ogrenciId {
            get {
                return this.ogrenciIdField;
            }
            set {
                if ((this.ogrenciIdField.Equals(value) != true)) {
                    this.ogrenciIdField = value;
                    this.RaisePropertyChanged("ogrenciId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> sonuc {
            get {
                return this.sonucField;
            }
            set {
                if ((this.sonucField.Equals(value) != true)) {
                    this.sonucField = value;
                    this.RaisePropertyChanged("sonuc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sonucId {
            get {
                return this.sonucIdField;
            }
            set {
                if ((this.sonucIdField.Equals(value) != true)) {
                    this.sonucIdField = value;
                    this.RaisePropertyChanged("sonucId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> turId {
            get {
                return this.turIdField;
            }
            set {
                if ((this.turIdField.Equals(value) != true)) {
                    this.turIdField = value;
                    this.RaisePropertyChanged("turId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> yilId {
            get {
                return this.yilIdField;
            }
            set {
                if ((this.yilIdField.Equals(value) != true)) {
                    this.yilIdField = value;
                    this.RaisePropertyChanged("yilId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ogrenciler", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceResults")]
    [System.SerializableAttribute()]
    public partial class Ogrenciler : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplicationResult.ServiceReference1.Sonuclar[] SonuclarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ogrenciAdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ogrenciIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> ogrenciTCKNField;
        
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
        public WebApplicationResult.ServiceReference1.Sonuclar[] Sonuclar {
            get {
                return this.SonuclarField;
            }
            set {
                if ((object.ReferenceEquals(this.SonuclarField, value) != true)) {
                    this.SonuclarField = value;
                    this.RaisePropertyChanged("Sonuclar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ogrenciAd {
            get {
                return this.ogrenciAdField;
            }
            set {
                if ((object.ReferenceEquals(this.ogrenciAdField, value) != true)) {
                    this.ogrenciAdField = value;
                    this.RaisePropertyChanged("ogrenciAd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ogrenciId {
            get {
                return this.ogrenciIdField;
            }
            set {
                if ((this.ogrenciIdField.Equals(value) != true)) {
                    this.ogrenciIdField = value;
                    this.RaisePropertyChanged("ogrenciId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> ogrenciTCKN {
            get {
                return this.ogrenciTCKNField;
            }
            set {
                if ((this.ogrenciTCKNField.Equals(value) != true)) {
                    this.ogrenciTCKNField = value;
                    this.RaisePropertyChanged("ogrenciTCKN");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Turler", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceResults")]
    [System.SerializableAttribute()]
    public partial class Turler : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplicationResult.ServiceReference1.Sonuclar[] SonuclarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string turAdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int turIdField;
        
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
        public WebApplicationResult.ServiceReference1.Sonuclar[] Sonuclar {
            get {
                return this.SonuclarField;
            }
            set {
                if ((object.ReferenceEquals(this.SonuclarField, value) != true)) {
                    this.SonuclarField = value;
                    this.RaisePropertyChanged("Sonuclar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string turAd {
            get {
                return this.turAdField;
            }
            set {
                if ((object.ReferenceEquals(this.turAdField, value) != true)) {
                    this.turAdField = value;
                    this.RaisePropertyChanged("turAd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int turId {
            get {
                return this.turIdField;
            }
            set {
                if ((this.turIdField.Equals(value) != true)) {
                    this.turIdField = value;
                    this.RaisePropertyChanged("turId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getYears", ReplyAction="http://tempuri.org/IService1/getYearsResponse")]
        WebApplicationResult.ServiceReference1.Yillar[] getYears();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getYears", ReplyAction="http://tempuri.org/IService1/getYearsResponse")]
        System.Threading.Tasks.Task<WebApplicationResult.ServiceReference1.Yillar[]> getYearsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getTypes", ReplyAction="http://tempuri.org/IService1/getTypesResponse")]
        WebApplicationResult.ServiceReference1.Turler[] getTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getTypes", ReplyAction="http://tempuri.org/IService1/getTypesResponse")]
        System.Threading.Tasks.Task<WebApplicationResult.ServiceReference1.Turler[]> getTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getStudents", ReplyAction="http://tempuri.org/IService1/getStudentsResponse")]
        WebApplicationResult.ServiceReference1.Ogrenciler[] getStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getStudents", ReplyAction="http://tempuri.org/IService1/getStudentsResponse")]
        System.Threading.Tasks.Task<WebApplicationResult.ServiceReference1.Ogrenciler[]> getStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getResult", ReplyAction="http://tempuri.org/IService1/getResultResponse")]
        WebApplicationResult.ServiceReference1.Sonuclar getResult(int studentId, int typeId, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getResult", ReplyAction="http://tempuri.org/IService1/getResultResponse")]
        System.Threading.Tasks.Task<WebApplicationResult.ServiceReference1.Sonuclar> getResultAsync(int studentId, int typeId, int year);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplicationResult.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplicationResult.ServiceReference1.IService1>, WebApplicationResult.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplicationResult.ServiceReference1.Yillar[] getYears() {
            return base.Channel.getYears();
        }
        
        public System.Threading.Tasks.Task<WebApplicationResult.ServiceReference1.Yillar[]> getYearsAsync() {
            return base.Channel.getYearsAsync();
        }
        
        public WebApplicationResult.ServiceReference1.Turler[] getTypes() {
            return base.Channel.getTypes();
        }
        
        public System.Threading.Tasks.Task<WebApplicationResult.ServiceReference1.Turler[]> getTypesAsync() {
            return base.Channel.getTypesAsync();
        }
        
        public WebApplicationResult.ServiceReference1.Ogrenciler[] getStudents() {
            return base.Channel.getStudents();
        }
        
        public System.Threading.Tasks.Task<WebApplicationResult.ServiceReference1.Ogrenciler[]> getStudentsAsync() {
            return base.Channel.getStudentsAsync();
        }
        
        public WebApplicationResult.ServiceReference1.Sonuclar getResult(int studentId, int typeId, int year) {
            return base.Channel.getResult(studentId, typeId, year);
        }
        
        public System.Threading.Tasks.Task<WebApplicationResult.ServiceReference1.Sonuclar> getResultAsync(int studentId, int typeId, int year) {
            return base.Channel.getResultAsync(studentId, typeId, year);
        }
    }
}
