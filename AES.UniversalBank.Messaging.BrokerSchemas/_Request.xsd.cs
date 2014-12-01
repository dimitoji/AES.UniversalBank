namespace AES.UniversalBank.Messaging.BrokerSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.universalbank.com/aes/broker/schemas",@"AccountInfoRequest")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::AES.UniversalBank.Messaging.BrokerSchemas.Properties.RequestType), XPath = @"/*[local-name()='AccountInfoRequest' and namespace-uri()='http://www.universalbank.com/aes/broker/schemas']/*[local-name()='Type' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "CustomerId", XPath = @"/*[local-name()='AccountInfoRequest' and namespace-uri()='http://www.universalbank.com/aes/broker/schemas']/*[local-name()='CustomerId' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AccountInfoRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.BrokerSchemas.Properties.PropertySchema", typeof(global::AES.UniversalBank.Messaging.BrokerSchemas.Properties.PropertySchema))]
    public sealed class AccountInfoRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.universalbank.com/aes/broker/schemas"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://www.universalbank.com/aes/broker/properties"" targetNamespace=""http://www.universalbank.com/aes/broker/schemas"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo root_reference=""AccountInfoRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://www.universalbank.com/aes/broker/properties"" location=""AES.UniversalBank.Messaging.BrokerSchemas.Properties.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AccountInfoRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:RequestType"" xpath=""/*[local-name()='AccountInfoRequest' and namespace-uri()='http://www.universalbank.com/aes/broker/schemas']/*[local-name()='Type' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AccountInfoRequest' and namespace-uri()='http://www.universalbank.com/aes/broker/schemas']/*[local-name()='CustomerId' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerId"" type=""xs:string"" />
        <xs:element name=""Type"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AccountInfoRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AccountInfoRequest";
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
