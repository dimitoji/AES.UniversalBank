namespace AES.UniversalBank.Messaging.BrokerSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.universalbank.com/aes/broker/schemas",@"Loan")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Loan"})]
    public sealed class Loan : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.universalbank.com/aes/broker/schemas"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://www.universalbank.com/aes/broker/schemas"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Loan"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Id"" type=""xs:string"" />
        <xs:element name=""StartDate"" type=""xs:dateTime"" />
        <xs:element name=""Payoff"" type=""xs:int"" />
        <xs:element name=""PaymentCount"" type=""xs:int"" />
        <xs:element name=""PaymentValue"" type=""xs:decimal"" />
        <xs:element name=""NextPaymentValue"" nillable=""true"" type=""xs:decimal"" />
        <xs:element name=""TotalPaymentValue"" nillable=""true"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Loan() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Loan";
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
