namespace AES.UniversalBank.Messaging.BrokerProcess.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.BrokerProcess.PaymentService.Reference+ArrayOfPayment", typeof(global::AES.UniversalBank.Messaging.BrokerProcess.PaymentService.Reference.ArrayOfPayment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.BrokerSchemas.Payment", typeof(global::AES.UniversalBank.Messaging.BrokerSchemas.Payment))]
    public sealed class ResponseToPayments : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities"" xmlns:ns0=""http://www.universalbank.com/aes/broker/schemas"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ArrayOfPayment"" />
  </xsl:template>
  <xsl:template match=""/s0:ArrayOfPayment"">
    <ns0:PaymentList>
      <xsl:for-each select=""s0:Payment"">
        <ns0:Payment>
          <ns0:Id>
            <xsl:value-of select=""s0:Id/text()"" />
          </ns0:Id>
          <ns0:Description>
            <xsl:value-of select=""s0:Description/text()"" />
          </ns0:Description>
        </ns0:Payment>
      </xsl:for-each>
    </ns0:PaymentList>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AES.UniversalBank.Messaging.BrokerProcess.PaymentService.Reference+ArrayOfPayment";
        
        private const global::AES.UniversalBank.Messaging.BrokerProcess.PaymentService.Reference.ArrayOfPayment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AES.UniversalBank.Messaging.BrokerSchemas.Payment";
        
        private const global::AES.UniversalBank.Messaging.BrokerSchemas.Payment _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"AES.UniversalBank.Messaging.BrokerProcess.PaymentService.Reference+ArrayOfPayment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AES.UniversalBank.Messaging.BrokerSchemas.Payment";
                return _TrgSchemas;
            }
        }
    }
}
