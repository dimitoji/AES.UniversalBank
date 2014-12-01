namespace AES.UniversalBank.Messaging.PaymentTranslator.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest", typeof(global::AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.PaymentTranslator.EPayment", typeof(global::AES.UniversalBank.Messaging.PaymentTranslator.EPayment))]
    public sealed class PaymentToEPayment : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://www.universalbank.com/aes/payment/schemas"" xmlns:ns0=""http://www.universalbank.com/aes/payment/mapping"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AuthPaymentRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:AuthPaymentRequest"">
    <ns0:EPayment>
      <Header>
        <Id>
          <xsl:value-of select=""Id/text()"" />
        </Id>
        <Origin>
          <xsl:value-of select=""OriginName/text()"" />
        </Origin>
      </Header>
      <Payment>
        <Reference>
          <xsl:value-of select=""PayeeReference/text()"" />
        </Reference>
        <Amount>
          <xsl:value-of select=""Amount/text()"" />
        </Amount>
      </Payment>
    </ns0:EPayment>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest";
        
        private const global::AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AES.UniversalBank.Messaging.PaymentTranslator.EPayment";
        
        private const global::AES.UniversalBank.Messaging.PaymentTranslator.EPayment _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AES.UniversalBank.Messaging.PaymentTranslator.EPayment";
                return _TrgSchemas;
            }
        }
    }
}
