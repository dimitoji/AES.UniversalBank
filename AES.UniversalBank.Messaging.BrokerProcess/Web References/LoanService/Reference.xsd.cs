namespace AES.UniversalBank.Messaging.BrokerProcess.LoanService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ArrayOfLoan", @"Loan"})]
    public sealed class Reference : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ArrayOfLoan"" nillable=""true"" type=""tns:ArrayOfLoan"" />
  <xs:complexType name=""ArrayOfLoan"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Loan"" nillable=""true"" type=""tns:Loan"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""Loan"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Id"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""NextPaymentValue"" nillable=""true"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PaymentCount"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PaymentValue"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Payoff"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""StartDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TotalPaymentValue"" nillable=""true"" type=""xs:decimal"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Loan"" nillable=""true"" type=""tns:Loan"" />
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
                string[] _RootElements = new string [2];
                _RootElements[0] = "ArrayOfLoan";
                _RootElements[1] = "Loan";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities",@"ArrayOfLoan")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfLoan"})]
        public sealed class ArrayOfLoan : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfLoan() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfLoan";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities",@"Loan")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Loan"})]
        public sealed class Loan : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
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
}
