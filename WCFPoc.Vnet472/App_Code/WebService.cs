using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

[WebService(Namespace = "http://tempuri.org/")]
public class WebService : ITissRecursoGlosaBinding
{
    [WebMethod]
    [return: XmlElement("protocoloRecebimentoRecursoWS", Namespace = "http://www.ans.gov.br/padroes/tiss/schemas")]
    public protocoloRecebimentoRecursoWS tissRecursoGlosa_Operation([XmlElement(Namespace = "http://www.ans.gov.br/padroes/tiss/schemas")] loteRecursoGlosaWS loteRecursoGlosaWS)
    {
        protocoloRecebimentoRecursoWS retorno = new protocoloRecebimentoRecursoWS();
        retorno.hash = loteRecursoGlosaWS.hashField + " - ok";
        return retorno;
    }
}
