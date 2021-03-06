//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumeWcf.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/LastProject")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsumeWcf.ServiceReference1.Order[] OrdersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YTDOrdersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YTDSalesField;
        
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
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerName {
            get {
                return this.CustomerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerNameField, value) != true)) {
                    this.CustomerNameField = value;
                    this.RaisePropertyChanged("CustomerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsumeWcf.ServiceReference1.Order[] Orders {
            get {
                return this.OrdersField;
            }
            set {
                if ((object.ReferenceEquals(this.OrdersField, value) != true)) {
                    this.OrdersField = value;
                    this.RaisePropertyChanged("Orders");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int YTDOrders {
            get {
                return this.YTDOrdersField;
            }
            set {
                if ((this.YTDOrdersField.Equals(value) != true)) {
                    this.YTDOrdersField = value;
                    this.RaisePropertyChanged("YTDOrders");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int YTDSales {
            get {
                return this.YTDSalesField;
            }
            set {
                if ((this.YTDSalesField.Equals(value) != true)) {
                    this.YTDSalesField = value;
                    this.RaisePropertyChanged("YTDSales");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/LastProject")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsumeWcf.ServiceReference1.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FilledDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime OrderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
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
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsumeWcf.ServiceReference1.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FilledDate {
            get {
                return this.FilledDateField;
            }
            set {
                if ((this.FilledDateField.Equals(value) != true)) {
                    this.FilledDateField = value;
                    this.RaisePropertyChanged("FilledDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderID {
            get {
                return this.OrderIDField;
            }
            set {
                if ((this.OrderIDField.Equals(value) != true)) {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCustomer", ReplyAction="http://tempuri.org/IService1/AddCustomerResponse")]
        void AddCustomer(string customerName, int YTDOrders, int YTDSales);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCustomer", ReplyAction="http://tempuri.org/IService1/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(string customerName, int YTDOrders, int YTDSales);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCustomer", ReplyAction="http://tempuri.org/IService1/UpdateCustomerResponse")]
        void UpdateCustomer(int customerId, string customerName, int YTDOrders, int YTDSales);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCustomer", ReplyAction="http://tempuri.org/IService1/UpdateCustomerResponse")]
        System.Threading.Tasks.Task UpdateCustomerAsync(int customerId, string customerName, int YTDOrders, int YTDSales);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCustomer", ReplyAction="http://tempuri.org/IService1/DeleteCustomerResponse")]
        void DeleteCustomer(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCustomer", ReplyAction="http://tempuri.org/IService1/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomerById", ReplyAction="http://tempuri.org/IService1/GetCustomerByIdResponse")]
        ConsumeWcf.ServiceReference1.Customer GetCustomerById(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomerById", ReplyAction="http://tempuri.org/IService1/GetCustomerByIdResponse")]
        System.Threading.Tasks.Task<ConsumeWcf.ServiceReference1.Customer> GetCustomerByIdAsync(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        ConsumeWcf.ServiceReference1.Customer[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        System.Threading.Tasks.Task<ConsumeWcf.ServiceReference1.Customer[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddOrder", ReplyAction="http://tempuri.org/IService1/AddOrderResponse")]
        void AddOrder(int customerId, System.DateTime orderDate, System.DateTime filledDate, string status, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddOrder", ReplyAction="http://tempuri.org/IService1/AddOrderResponse")]
        System.Threading.Tasks.Task AddOrderAsync(int customerId, System.DateTime orderDate, System.DateTime filledDate, string status, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateOrder", ReplyAction="http://tempuri.org/IService1/UpdateOrderResponse")]
        void UpdateOrder(int orderId, int customerId, System.DateTime orderDate, System.DateTime filledDate, string status, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateOrder", ReplyAction="http://tempuri.org/IService1/UpdateOrderResponse")]
        System.Threading.Tasks.Task UpdateOrderAsync(int orderId, int customerId, System.DateTime orderDate, System.DateTime filledDate, string status, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrder", ReplyAction="http://tempuri.org/IService1/DeleteOrderResponse")]
        void DeleteOrder(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrder", ReplyAction="http://tempuri.org/IService1/DeleteOrderResponse")]
        System.Threading.Tasks.Task DeleteOrderAsync(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrderById", ReplyAction="http://tempuri.org/IService1/GetOrderByIdResponse")]
        ConsumeWcf.ServiceReference1.Order GetOrderById(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrderById", ReplyAction="http://tempuri.org/IService1/GetOrderByIdResponse")]
        System.Threading.Tasks.Task<ConsumeWcf.ServiceReference1.Order> GetOrderByIdAsync(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrders", ReplyAction="http://tempuri.org/IService1/GetOrdersResponse")]
        ConsumeWcf.ServiceReference1.Order[] GetOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrders", ReplyAction="http://tempuri.org/IService1/GetOrdersResponse")]
        System.Threading.Tasks.Task<ConsumeWcf.ServiceReference1.Order[]> GetOrdersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsumeWcf.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsumeWcf.ServiceReference1.IService1>, ConsumeWcf.ServiceReference1.IService1 {
        
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
        
        public void AddCustomer(string customerName, int YTDOrders, int YTDSales) {
            base.Channel.AddCustomer(customerName, YTDOrders, YTDSales);
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(string customerName, int YTDOrders, int YTDSales) {
            return base.Channel.AddCustomerAsync(customerName, YTDOrders, YTDSales);
        }
        
        public void UpdateCustomer(int customerId, string customerName, int YTDOrders, int YTDSales) {
            base.Channel.UpdateCustomer(customerId, customerName, YTDOrders, YTDSales);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerAsync(int customerId, string customerName, int YTDOrders, int YTDSales) {
            return base.Channel.UpdateCustomerAsync(customerId, customerName, YTDOrders, YTDSales);
        }
        
        public void DeleteCustomer(int customerId) {
            base.Channel.DeleteCustomer(customerId);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(int customerId) {
            return base.Channel.DeleteCustomerAsync(customerId);
        }
        
        public ConsumeWcf.ServiceReference1.Customer GetCustomerById(int customerId) {
            return base.Channel.GetCustomerById(customerId);
        }
        
        public System.Threading.Tasks.Task<ConsumeWcf.ServiceReference1.Customer> GetCustomerByIdAsync(int customerId) {
            return base.Channel.GetCustomerByIdAsync(customerId);
        }
        
        public ConsumeWcf.ServiceReference1.Customer[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<ConsumeWcf.ServiceReference1.Customer[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public void AddOrder(int customerId, System.DateTime orderDate, System.DateTime filledDate, string status, int amount) {
            base.Channel.AddOrder(customerId, orderDate, filledDate, status, amount);
        }
        
        public System.Threading.Tasks.Task AddOrderAsync(int customerId, System.DateTime orderDate, System.DateTime filledDate, string status, int amount) {
            return base.Channel.AddOrderAsync(customerId, orderDate, filledDate, status, amount);
        }
        
        public void UpdateOrder(int orderId, int customerId, System.DateTime orderDate, System.DateTime filledDate, string status, int amount) {
            base.Channel.UpdateOrder(orderId, customerId, orderDate, filledDate, status, amount);
        }
        
        public System.Threading.Tasks.Task UpdateOrderAsync(int orderId, int customerId, System.DateTime orderDate, System.DateTime filledDate, string status, int amount) {
            return base.Channel.UpdateOrderAsync(orderId, customerId, orderDate, filledDate, status, amount);
        }
        
        public void DeleteOrder(int orderId) {
            base.Channel.DeleteOrder(orderId);
        }
        
        public System.Threading.Tasks.Task DeleteOrderAsync(int orderId) {
            return base.Channel.DeleteOrderAsync(orderId);
        }
        
        public ConsumeWcf.ServiceReference1.Order GetOrderById(int orderId) {
            return base.Channel.GetOrderById(orderId);
        }
        
        public System.Threading.Tasks.Task<ConsumeWcf.ServiceReference1.Order> GetOrderByIdAsync(int orderId) {
            return base.Channel.GetOrderByIdAsync(orderId);
        }
        
        public ConsumeWcf.ServiceReference1.Order[] GetOrders() {
            return base.Channel.GetOrders();
        }
        
        public System.Threading.Tasks.Task<ConsumeWcf.ServiceReference1.Order[]> GetOrdersAsync() {
            return base.Channel.GetOrdersAsync();
        }
    }
}
