namespace AES.UniversalBank.Messaging.PaymentSchemas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.PaymentSchemas.PaymentRequest", typeof(global::AES.UniversalBank.Messaging.PaymentSchemas.PaymentRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest", typeof(global::AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest))]
    public sealed class RequestToAuthRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://www.universalbank.com/aes/payment/schemas"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:PaymentRequest"" />
  </xsl:template>
  <xsl:template match=""/ns0:PaymentRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;UB-Payments&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;UB-Secret&quot;)"" />
    <ns0:AuthPaymentRequest>
      <Id>
        <xsl:value-of select=""Id/text()"" />
      </Id>
      <PayeeReference>
        <xsl:value-of select=""PayeeReference/text()"" />
      </PayeeReference>
      <Amount>
        <xsl:value-of select=""Amount/text()"" />
      </Amount>
      <OriginName>
        <xsl:value-of select=""$var:v1"" />
      </OriginName>
      <OriginKey>
        <xsl:value-of select=""$var:v2"" />
      </OriginKey>
    </ns0:AuthPaymentRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AES.UniversalBank.Messaging.PaymentSchemas.PaymentRequest";
        
        private const global::AES.UniversalBank.Messaging.PaymentSchemas.PaymentRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest";
        
        private const global::AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"AES.UniversalBank.Messaging.PaymentSchemas.PaymentRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest";
                return _TrgSchemas;
            }
        }
    }
}
