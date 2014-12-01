namespace AES.UniversalBank.Messaging.BrokerProcess.PaymentService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ArrayOfPayment", @"Payment"})]
    public sealed class Reference : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ArrayOfPayment"" nillable=""true"" type=""tns:ArrayOfPayment"" />
  <xs:complexType name=""ArrayOfPayment"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Payment"" nillable=""true"" type=""tns:Payment"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""Payment"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Description"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Id"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Payment"" nillable=""true"" type=""tns:Payment"" />
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
                _RootElements[0] = "ArrayOfPayment";
                _RootElements[1] = "Payment";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities",@"ArrayOfPayment")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfPayment"})]
        public sealed class ArrayOfPayment : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfPayment() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfPayment";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities",@"Payment")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Payment"})]
        public sealed class Payment : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Payment() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Payment";
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
