using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Serialization;

[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
[System.Web.Services.WebServiceBindingAttribute(Name = "tissRecursoGlosa_Binding", Namespace = "http://www.ans.gov.br/tiss/ws/tipos/tissrecursoglosa/v30303")]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SignatureType))]
public class ServiceTest : ITissRecursoGlosaBinding
{
    [return: XmlElement("protocoloRecebimentoRecursoWS", Namespace = "http://www.ans.gov.br/padroes/tiss/schemas")]
    public protocoloRecebimentoRecursoWS tissRecursoGlosa_Operation([XmlElement(Namespace = "http://www.ans.gov.br/padroes/tiss/schemas")] loteRecursoGlosaWS loteRecursoGlosaWS)
    {
        throw new NotImplementedException();
    }
}
