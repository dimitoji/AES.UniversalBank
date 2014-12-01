namespace AES.UniversalBank.Messaging.BrokerProcess.AccountService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ArrayOfAccount", @"ArrayOfAccountTransaction", @"Account", @"AccountTransaction"})]
    public sealed class Reference : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ArrayOfAccount"" nillable=""true"" type=""tns:ArrayOfAccount"" />
  <xs:complexType name=""ArrayOfAccount"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Account"" nillable=""true"" type=""tns:Account"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""Account"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BalanceDate"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BalanceValue"" nillable=""true"" type=""xs:decimal"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Id"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Type"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAccountTransaction"" nillable=""true"" type=""tns:ArrayOfAccountTransaction"" />
  <xs:complexType name=""ArrayOfAccountTransaction"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AccountTransaction"" nillable=""true"" type=""tns:AccountTransaction"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AccountTransaction"" />
  <xs:element name=""Account"" nillable=""true"" type=""tns:Account"" />
  <xs:element name=""AccountTransaction"" nillable=""true"" type=""tns:AccountTransaction"" />
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
                string[] _RootElements = new string [4];
                _RootElements[0] = "ArrayOfAccount";
                _RootElements[1] = "ArrayOfAccountTransaction";
                _RootElements[2] = "Account";
                _RootElements[3] = "AccountTransaction";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities",@"ArrayOfAccount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAccount"})]
        public sealed class ArrayOfAccount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAccount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAccount";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities",@"ArrayOfAccountTransaction")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAccountTransaction"})]
        public sealed class ArrayOfAccountTransaction : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAccountTransaction() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAccountTransaction";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities",@"Account")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Account"})]
        public sealed class Account : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Account() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Account";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities",@"AccountTransaction")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountTransaction"})]
        public sealed class AccountTransaction : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountTransaction() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountTransaction";
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
