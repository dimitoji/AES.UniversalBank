//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VisualStudio.BizTalkProject.Generators generó automáticamente este código fuente, versión 4.0.30319.34014.
// 
namespace AES.UniversalBank.Messaging.BrokerProcess.LoanService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ILoanService", Namespace="http://tempuri.org/")]
    [Microsoft.XLANGs.BaseTypes.WebServiceUrlAttribute("http://localhost:29156/LoanService.svc")]
    public partial class LoanService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public LoanService() {
            string urlSetting = System.Configuration.ConfigurationManager.AppSettings["AES.UniversalBank.Messaging.BrokerProcess.LoanService.LoanService"];
            if ((urlSetting != null)) {
                this.Url = string.Concat(urlSetting, "");
            }
            else {
                this.Url = "http://localhost:29156/LoanService.svc";
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILoanService/GetCustomerLoans", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities")]
        public Loan[] GetCustomerLoans([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string customerId) {
            object[] results = this.Invoke("GetCustomerLoans", new object[] {
                        customerId});
            return ((Loan[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetCustomerLoans(string customerId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCustomerLoans", new object[] {
                        customerId}, callback, asyncState);
        }
        
        /// <remarks/>
        public Loan[] EndGetCustomerLoans(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Loan[])(results[0]));
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities")]
    public partial class Loan {
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string Id;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> NextPaymentValue;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public bool NextPaymentValueSpecified;
        
        /// <comentarios/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public int PaymentCount;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public bool PaymentCountSpecified;
        
        /// <comentarios/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public decimal PaymentValue;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public bool PaymentValueSpecified;
        
        /// <comentarios/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public int Payoff;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public bool PayoffSpecified;
        
        /// <comentarios/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public System.DateTime StartDate;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public bool StartDateSpecified;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> TotalPaymentValue;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public bool TotalPaymentValueSpecified;
    }
}