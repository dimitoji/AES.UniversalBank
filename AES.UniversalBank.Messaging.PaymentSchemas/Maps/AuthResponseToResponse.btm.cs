namespace AES.UniversalBank.Messaging.PaymentSchemas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentResponse", typeof(global::AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.PaymentSchemas.PaymentResponse", typeof(global::AES.UniversalBank.Messaging.PaymentSchemas.PaymentResponse))]
    public sealed class AuthResponseToResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://www.universalbank.com/aes/payment/schemas"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:AuthPaymentResponse"" />
  </xsl:template>
  <xsl:template match=""/ns0:AuthPaymentResponse"">
    <ns0:PaymentResponse>
      <Id>
        <xsl:value-of select=""Id/text()"" />
      </Id>
      <Success>
        <xsl:value-of select=""Success/text()"" />
      </Success>
      <Message>
        <xsl:value-of select=""Message/text()"" />
      </Message>
    </ns0:PaymentResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentResponse";
        
        private const global::AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AES.UniversalBank.Messaging.PaymentSchemas.PaymentResponse";
        
        private const global::AES.UniversalBank.Messaging.PaymentSchemas.PaymentResponse _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AES.UniversalBank.Messaging.PaymentSchemas.PaymentResponse";
                return _TrgSchemas;
            }
        }
    }
}
