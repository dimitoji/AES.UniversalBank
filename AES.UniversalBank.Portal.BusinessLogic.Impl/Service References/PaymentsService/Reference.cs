﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AES.UniversalBank.Portal.BusinessLogic.Impl.PaymentsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.universalbank.com/aes/services", ConfigurationName="PaymentsService.IPaymentsService")]
    public interface IPaymentsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.universalbank.com/aes/services/IPaymentsService/GetCustomerPayments", ReplyAction="http://www.universalbank.com/aes/services/IPaymentsService/GetCustomerPaymentsRes" +
            "ponse")]
        System.Collections.Generic.List<AES.UniversalBank.Common.Entities.Payment> GetCustomerPayments(string customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.universalbank.com/aes/services/IPaymentsService/GetCustomerPayments", ReplyAction="http://www.universalbank.com/aes/services/IPaymentsService/GetCustomerPaymentsRes" +
            "ponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AES.UniversalBank.Common.Entities.Payment>> GetCustomerPaymentsAsync(string customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.universalbank.com/aes/services/IPaymentsService/GetPayment", ReplyAction="http://www.universalbank.com/aes/services/IPaymentsService/GetPaymentResponse")]
        AES.UniversalBank.Common.Entities.Payment GetPayment(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.universalbank.com/aes/services/IPaymentsService/GetPayment", ReplyAction="http://www.universalbank.com/aes/services/IPaymentsService/GetPaymentResponse")]
        System.Threading.Tasks.Task<AES.UniversalBank.Common.Entities.Payment> GetPaymentAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.universalbank.com/aes/services/IPaymentsService/SavePayment", ReplyAction="http://www.universalbank.com/aes/services/IPaymentsService/SavePaymentResponse")]
        void SavePayment(AES.UniversalBank.Common.Entities.Payment payment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.universalbank.com/aes/services/IPaymentsService/SavePayment", ReplyAction="http://www.universalbank.com/aes/services/IPaymentsService/SavePaymentResponse")]
        System.Threading.Tasks.Task SavePaymentAsync(AES.UniversalBank.Common.Entities.Payment payment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.universalbank.com/aes/services/IPaymentsService/GetPaymentRecords", ReplyAction="http://www.universalbank.com/aes/services/IPaymentsService/GetPaymentRecordsRespo" +
            "nse")]
        System.Collections.Generic.List<AES.UniversalBank.Common.Entities.PaymentRecord> GetPaymentRecords(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.universalbank.com/aes/services/IPaymentsService/GetPaymentRecords", ReplyAction="http://www.universalbank.com/aes/services/IPaymentsService/GetPaymentRecordsRespo" +
            "nse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AES.UniversalBank.Common.Entities.PaymentRecord>> GetPaymentRecordsAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaymentsServiceChannel : AES.UniversalBank.Portal.BusinessLogic.Impl.PaymentsService.IPaymentsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentsServiceClient : System.ServiceModel.ClientBase<AES.UniversalBank.Portal.BusinessLogic.Impl.PaymentsService.IPaymentsService>, AES.UniversalBank.Portal.BusinessLogic.Impl.PaymentsService.IPaymentsService {
        
        public PaymentsServiceClient() {
        }
        
        public PaymentsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaymentsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<AES.UniversalBank.Common.Entities.Payment> GetCustomerPayments(string customerId) {
            return base.Channel.GetCustomerPayments(customerId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AES.UniversalBank.Common.Entities.Payment>> GetCustomerPaymentsAsync(string customerId) {
            return base.Channel.GetCustomerPaymentsAsync(customerId);
        }
        
        public AES.UniversalBank.Common.Entities.Payment GetPayment(string id) {
            return base.Channel.GetPayment(id);
        }
        
        public System.Threading.Tasks.Task<AES.UniversalBank.Common.Entities.Payment> GetPaymentAsync(string id) {
            return base.Channel.GetPaymentAsync(id);
        }
        
        public void SavePayment(AES.UniversalBank.Common.Entities.Payment payment) {
            base.Channel.SavePayment(payment);
        }
        
        public System.Threading.Tasks.Task SavePaymentAsync(AES.UniversalBank.Common.Entities.Payment payment) {
            return base.Channel.SavePaymentAsync(payment);
        }
        
        public System.Collections.Generic.List<AES.UniversalBank.Common.Entities.PaymentRecord> GetPaymentRecords(string id) {
            return base.Channel.GetPaymentRecords(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AES.UniversalBank.Common.Entities.PaymentRecord>> GetPaymentRecordsAsync(string id) {
            return base.Channel.GetPaymentRecordsAsync(id);
        }
    }
}
