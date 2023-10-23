﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeNamesClientSide.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/DataModels")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Player_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Player_Id {
            get {
                return this.Player_IdField;
            }
            set {
                if ((this.Player_IdField.Equals(value) != true)) {
                    this.Player_IdField = value;
                    this.RaisePropertyChanged("Player_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPlayerManager")]
    public interface IPlayerManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/AddUserAccountToDatabase", ReplyAction="http://tempuri.org/IPlayerManager/AddUserAccountToDatabaseResponse")]
        void AddUserAccountToDatabase(string nickname, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/AddUserAccountToDatabase", ReplyAction="http://tempuri.org/IPlayerManager/AddUserAccountToDatabaseResponse")]
        System.Threading.Tasks.Task AddUserAccountToDatabaseAsync(string nickname, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/Login", ReplyAction="http://tempuri.org/IPlayerManager/LoginResponse")]
        CodeNamesClientSide.ServiceReference1.Player Login(string nickname, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/Login", ReplyAction="http://tempuri.org/IPlayerManager/LoginResponse")]
        System.Threading.Tasks.Task<CodeNamesClientSide.ServiceReference1.Player> LoginAsync(string nickname, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/ShowUsersAccounts", ReplyAction="http://tempuri.org/IPlayerManager/ShowUsersAccountsResponse")]
        void ShowUsersAccounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/ShowUsersAccounts", ReplyAction="http://tempuri.org/IPlayerManager/ShowUsersAccountsResponse")]
        System.Threading.Tasks.Task ShowUsersAccountsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPlayerManagerChannel : CodeNamesClientSide.ServiceReference1.IPlayerManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PlayerManagerClient : System.ServiceModel.ClientBase<CodeNamesClientSide.ServiceReference1.IPlayerManager>, CodeNamesClientSide.ServiceReference1.IPlayerManager {
        
        public PlayerManagerClient() {
        }
        
        public PlayerManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PlayerManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddUserAccountToDatabase(string nickname, string email, string password) {
            base.Channel.AddUserAccountToDatabase(nickname, email, password);
        }
        
        public System.Threading.Tasks.Task AddUserAccountToDatabaseAsync(string nickname, string email, string password) {
            return base.Channel.AddUserAccountToDatabaseAsync(nickname, email, password);
        }
        
        public CodeNamesClientSide.ServiceReference1.Player Login(string nickname, string password) {
            return base.Channel.Login(nickname, password);
        }
        
        public System.Threading.Tasks.Task<CodeNamesClientSide.ServiceReference1.Player> LoginAsync(string nickname, string password) {
            return base.Channel.LoginAsync(nickname, password);
        }
        
        public void ShowUsersAccounts() {
            base.Channel.ShowUsersAccounts();
        }
        
        public System.Threading.Tasks.Task ShowUsersAccountsAsync() {
            return base.Channel.ShowUsersAccountsAsync();
        }
    }
}