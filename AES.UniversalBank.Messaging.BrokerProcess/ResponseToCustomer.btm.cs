namespace AES.UniversalBank.Messaging.BrokerProcess.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.BrokerProcess.CustomerService.Reference", typeof(global::AES.UniversalBank.Messaging.BrokerProcess.CustomerService.Reference))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.BrokerSchemas.Customer", typeof(global::AES.UniversalBank.Messaging.BrokerSchemas.Customer))]
    public sealed class ResponseToCustomer : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://schemas.datacontract.org/2004/07/AES.UniversalBankCRM"" xmlns:ns0=""http://www.universalbank.com/aes/broker/schemas"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Customer"" />
  </xsl:template>
  <xsl:template match=""/s0:Customer"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(s0:FirstName/text()) , &quot; &quot; , string(s0:LastName/text()))"" />
    <ns0:Customer>
      <Name>
        <xsl:value-of select=""$var:v1"" />
      </Name>
      <Email>
        <xsl:value-of select=""s0:Email/text()"" />
      </Email>
      <Address>
        <xsl:value-of select=""s0:Address/text()"" />
      </Address>
    </ns0:Customer>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AES.UniversalBank.Messaging.BrokerProcess.CustomerService.Reference";
        
        private const global::AES.UniversalBank.Messaging.BrokerProcess.CustomerService.Reference _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AES.UniversalBank.Messaging.BrokerSchemas.Customer";
        
        private const global::AES.UniversalBank.Messaging.BrokerSchemas.Customer _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"AES.UniversalBank.Messaging.BrokerProcess.CustomerService.Reference";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AES.UniversalBank.Messaging.BrokerSchemas.Customer";
                return _TrgSchemas;
            }
        }
    }
}
