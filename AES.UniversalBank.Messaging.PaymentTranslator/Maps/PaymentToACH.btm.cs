namespace AES.UniversalBank.Messaging.PaymentTranslator.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest", typeof(global::AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AES.UniversalBank.Messaging.PaymentTranslator.ACHPayment", typeof(global::AES.UniversalBank.Messaging.PaymentTranslator.ACHPayment))]
    public sealed class PaymentToACH : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.universalbank.com/aes/payment/schemas"" xmlns:ns0=""http://www.universalbank.com/aes/payment/mapping"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AuthPaymentRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:AuthPaymentRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDate()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;21&quot;)"" />
    <xsl:variable name=""var:v6"" select=""count(/s0:AuthPaymentRequest)"" />
    <ns0:ACH>
      <FileHeader>
        <Type>
          <xsl:text>1</xsl:text>
        </Type>
        <Date>
          <xsl:value-of select=""$var:v1"" />
        </Date>
        <Id>
          <xsl:value-of select=""Id/text()"" />
        </Id>
      </FileHeader>
      <BatchHeader>
        <Type>
          <xsl:text>5</xsl:text>
        </Type>
        <Company>
          <xsl:value-of select=""OriginName/text()"" />
        </Company>
      </BatchHeader>
      <EntryDetail>
        <Type>
          <xsl:text>6</xsl:text>
        </Type>
        <TrxCode>
          <xsl:value-of select=""$var:v2"" />
        </TrxCode>
        <Reference>
          <xsl:value-of select=""PayeeReference/text()"" />
        </Reference>
        <Amount>
          <xsl:value-of select=""Amount/text()"" />
        </Amount>
      </EntryDetail>
      <BatchControl>
        <Type>
          <xsl:text>8</xsl:text>
        </Type>
        <xsl:variable name=""var:v3"" select=""userCSharp:InitCumulativeSum(0)"" />
        <xsl:for-each select=""/s0:AuthPaymentRequest"">
          <xsl:variable name=""var:v4"" select=""userCSharp:AddToCumulativeSum(0,string(Amount/text()),&quot;1000&quot;)"" />
        </xsl:for-each>
        <xsl:variable name=""var:v5"" select=""userCSharp:GetCumulativeSum(0)"" />
        <TotalAmount>
          <xsl:value-of select=""$var:v5"" />
        </TotalAmount>
      </BatchControl>
      <FileControl>
        <Type>
          <xsl:text>9</xsl:text>
        </Type>
        <BatchCount>
          <xsl:value-of select=""$var:v6"" />
        </BatchCount>
      </FileControl>
    </ns0:ACH>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string StringConcat(string param0)
{
   return param0;
}


public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest";
        
        private const global::AES.UniversalBank.Messaging.PaymentSchemas.AuthPaymentRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AES.UniversalBank.Messaging.PaymentTranslator.ACHPayment";
        
        private const global::AES.UniversalBank.Messaging.PaymentTranslator.ACHPayment _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"AES.UniversalBank.Messaging.PaymentTranslator.ACHPayment";
                return _TrgSchemas;
            }
        }
    }
}
