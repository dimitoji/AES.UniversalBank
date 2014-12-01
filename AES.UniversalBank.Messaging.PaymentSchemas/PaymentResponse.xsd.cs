namespace AES.UniversalBank.Messaging.PaymentSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.universalbank.com/aes/payment/schemas",@"PaymentResponse")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Id", XPath = @"/*[local-name()='PaymentResponse' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Id' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "Success", XPath = @"/*[local-name()='PaymentResponse' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Success' and namespace-uri()='']", XsdType = @"boolean")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Message", XPath = @"/*[local-name()='PaymentResponse' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Message' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PaymentResponse"})]
    public sealed class PaymentResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.universalbank.com/aes/payment/schemas"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://www.universalbank.com/aes/payment/schemas"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PaymentResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PaymentResponse' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Id' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PaymentResponse' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Success' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PaymentResponse' and namespace-uri()='http://www.universalbank.com/aes/payment/schemas']/*[local-name()='Message' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Id"" type=""xs:string"" />
        <xs:element name=""Success"" type=""xs:boolean"" />
        <xs:element name=""Message"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PaymentResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PaymentResponse";
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
