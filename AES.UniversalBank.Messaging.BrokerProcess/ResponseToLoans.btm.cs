namespace AES.UniversalBank.Messaging.BrokerProcess.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.BrokerProcess.LoanService.Reference+ArrayOfLoan", typeof(global::AES.UniversalBank.Messaging.BrokerProcess.LoanService.Reference.ArrayOfLoan))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.BrokerSchemas.Loan", typeof(global::AES.UniversalBank.Messaging.BrokerSchemas.Loan))]
    public sealed class ResponseToLoans : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.datacontract.org/2004/07/AES.UniversalBank.Common.Entities"" xmlns:ns0=""http://www.universalbank.com/aes/broker/schemas"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ArrayOfLoan"" />
  </xsl:template>
  <xsl:template match=""/s0:ArrayOfLoan"">
    <ns0:LoanList>
      <xsl:for-each select=""s0:Loan"">
        <ns0:Loan>
          <ns0:Id>
            <xsl:value-of select=""s0:Id/text()"" />
          </ns0:Id>
          <xsl:if test=""s0:StartDate"">
            <ns0:StartDate>
              <xsl:value-of select=""s0:StartDate/text()"" />
            </ns0:StartDate>
          </xsl:if>
          <xsl:if test=""s0:Payoff"">
            <ns0:Payoff>
              <xsl:value-of select=""s0:Payoff/text()"" />
            </ns0:Payoff>
          </xsl:if>
          <xsl:if test=""s0:PaymentCount"">
            <ns0:PaymentCount>
              <xsl:value-of select=""s0:PaymentCount/text()"" />
            </ns0:PaymentCount>
          </xsl:if>
          <xsl:if test=""s0:PaymentValue"">
            <ns0:PaymentValue>
              <xsl:value-of select=""s0:PaymentValue/text()"" />
            </ns0:PaymentValue>
          </xsl:if>
          <xsl:if test=""s0:NextPaymentValue"">
            <xsl:variable name=""var:v1"" select=""string(s0:NextPaymentValue/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v1)='true'"">
              <ns0:NextPaymentValue>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns0:NextPaymentValue>
            </xsl:if>
            <xsl:if test=""string($var:v1)='false'"">
              <ns0:NextPaymentValue>
                <xsl:value-of select=""s0:NextPaymentValue/text()"" />
              </ns0:NextPaymentValue>
            </xsl:if>
          </xsl:if>
          <xsl:if test=""s0:TotalPaymentValue"">
            <xsl:variable name=""var:v2"" select=""string(s0:TotalPaymentValue/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v2)='true'"">
              <ns0:TotalPaymentValue>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns0:TotalPaymentValue>
            </xsl:if>
            <xsl:if test=""string($var:v2)='false'"">
              <ns0:TotalPaymentValue>
                <xsl:value-of select=""s0:TotalPaymentValue/text()"" />
              </ns0:TotalPaymentValue>
            </xsl:if>
          </xsl:if>
        </ns0:Loan>
      </xsl:for-each>
    </ns0:LoanList>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AES.UniversalBank.Messaging.BrokerProcess.LoanService.Reference+ArrayOfLoan";
        
        private const global::AES.UniversalBank.Messaging.BrokerProcess.LoanService.Reference.ArrayOfLoan _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AES.UniversalBank.Messaging.BrokerSchemas.Loan";
        
        private const global::AES.UniversalBank.Messaging.BrokerSchemas.Loan _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"AES.UniversalBank.Messaging.BrokerProcess.LoanService.Reference+ArrayOfLoan";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AES.UniversalBank.Messaging.BrokerSchemas.Loan";
                return _TrgSchemas;
            }
        }
    }
}
