namespace AES.UniversalBank.Messaging.PaymentSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.universalbank.com/aes/payment/schemas",@"PaymentRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Id", XPath = @"/*[local-name()='PaymentRequest' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Id' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::AES.UniversalBank.Messaging.PaymentSchemas.PaymentSetId), XPath = @"/*[local-name()='PaymentRequest' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Id' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::AES.UniversalBank.Messaging.PaymentSchemas.PaymentType), XPath = @"/*[local-name()='PaymentRequest' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='PayeeType' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PayeeType", XPath = @"/*[local-name()='PaymentRequest' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='PayeeType' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PaymentRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.PaymentSchemas.PropertySchema", typeof(global::AES.UniversalBank.Messaging.PaymentSchemas.PropertySchema))]
    public sealed class PaymentRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.universalbank.com/aes/payment/schemas"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://www.universalbank.com/aes/payment/properties"" targetNamespace=""http://www.universalbank.com/aes/payment/schemas"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://www.universalbank.com/aes/payment/properties"" location=""AES.UniversalBank.Messaging.PaymentSchemas.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""PaymentRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PaymentRequest' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Id' and namespace-uri()='']"" />
          <b:property name=""ns0:PaymentSetId"" xpath=""/*[local-name()='PaymentRequest' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Id' and namespace-uri()='']"" />
          <b:property name=""ns0:PaymentType"" xpath=""/*[local-name()='PaymentRequest' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='PayeeType' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PaymentRequest' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='PayeeType' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Id"" type=""xs:string"" />
        <xs:element name=""ProcessDate"" type=""xs:string"" />
        <xs:element name=""PayeeType"" type=""xs:string"" />
        <xs:element name=""PayeeReference"" type=""xs:string"" />
        <xs:element name=""Amount"" type=""xs:decimal"" />
        <xs:element name=""Status"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PaymentRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PaymentRequest";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
