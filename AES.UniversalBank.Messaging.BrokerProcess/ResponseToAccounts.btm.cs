namespace AES.UniversalBank.Messaging.BrokerProcess.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.BrokerProcess.AccountService.Reference+ArrayOfAccount", typeof(global::AES.UniversalBank.Messaging.BrokerProcess.AccountService.Reference.ArrayOfAccount))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.BrokerSchemas.Account", typeof(global::AES.UniversalBank.Messaging.BrokerSchemas.Account))]
    public sealed class ResponseToAccounts : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities"" xmlns:ns0=""http://www.universalbank.com/aes/broker/schemas"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ArrayOfAccount"" />
  </xsl:template>
  <xsl:template match=""/s0:ArrayOfAccount"">
    <ns0:AccountList>
      <xsl:for-each select=""s0:Account"">
        <ns0:Account>
          <ns0:Id>
            <xsl:value-of select=""s0:Id/text()"" />
          </ns0:Id>
          <ns0:Type>
            <xsl:value-of select=""s0:Type/text()"" />
          </ns0:Type>
          <xsl:if test=""s0:BalanceValue"">
            <xsl:variable name=""var:v1"" select=""string(s0:BalanceValue/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v1)='true'"">
              <ns0:BalanceValue>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns0:BalanceValue>
            </xsl:if>
            <xsl:if test=""string($var:v1)='false'"">
              <ns0:BalanceValue>
                <xsl:value-of select=""s0:BalanceValue/text()"" />
              </ns0:BalanceValue>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""s0:BalanceDate"">
            <xsl:variable name=""var:v2"" select=""string(s0:BalanceDate/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v2)='true'"">
              <ns0:BalanceDate>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns0:BalanceDate>
            </xsl:if>
            <xsl:if test=""string($var:v2)='false'"">
              <ns0:BalanceDate>
                <xsl:value-of select=""s0:BalanceDate/text()"" />
              </ns0:BalanceDate>
            </xsl:if>
          </xsl:if>
        </ns0:Account>
      </xsl:for-each>
    </ns0:AccountList>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AES.UniversalBank.Messaging.BrokerProcess.AccountService.Reference+ArrayOfAccount";
        
        private const global::AES.UniversalBank.Messaging.BrokerProcess.AccountService.Reference.ArrayOfAccount _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AES.UniversalBank.Messaging.BrokerSchemas.Account";
        
        private const global::AES.UniversalBank.Messaging.BrokerSchemas.Account _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"AES.UniversalBank.Messaging.BrokerProcess.AccountService.Reference+ArrayOfAccount";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AES.UniversalBank.Messaging.BrokerSchemas.Account";
                return _TrgSchemas;
            }
        }
    }
}
