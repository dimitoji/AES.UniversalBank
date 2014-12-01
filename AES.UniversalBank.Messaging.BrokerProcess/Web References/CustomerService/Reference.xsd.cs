namespace AES.UniversalBank.Messaging.BrokerProcess.CustomerService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.datacontract.org/2004/07/AES.UniversalBankCRM",@"Customer")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Customer"})]
    public sealed class Reference : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/AES.UniversalBankCRM"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/AES.UniversalBankCRM"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Customer"" nillable=""true"" type=""tns:Customer"" />
  <xs:complexType name=""Customer"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Address"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Email"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""FirstName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Id"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""LastName"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public Reference() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Customer";
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
