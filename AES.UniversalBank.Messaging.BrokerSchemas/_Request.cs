namespace AES.UniversalBank.Messaging.BrokerSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.universalbank.com/aes/broker/schemas",@"AccountInfoRequest")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AccountInfoRequest"})]
    public sealed class AccountInfoRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.universalbank.com/aes/broker/schemas"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://www.universalbank.com/aes/broker/schemas"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo root_reference=""AccountInfoRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AccountInfoRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerId"" type=""xs:string"" />
        <xs:element name=""Type"" type=""RequestType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RequestType"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:enumeration value=""Account"" />
        <xs:enumeration value=""Customer"" />
        <xs:enumeration value=""Loan"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:simpleType name=""RequestType"">
    <xs:restriction base=""xs:token"" />
  </xs:simpleType>
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
