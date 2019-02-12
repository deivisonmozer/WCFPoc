using System.Web.Services;
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
    [WebMethod]
    public string GetString(string value)
    {
        return "valor digitado: " + value;
    }
}
