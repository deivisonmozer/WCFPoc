using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

/// <summary>
/// Summary description for Tiss
/// </summary>
public class Tiss : ITissRecursoGlosaBinding
{
    public Tiss()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string GetString(int value)
    {
        return "valor digitado: " + value;
    }

    [return: XmlElement("protocoloRecebimentoRecursoWS", Namespace = "http://www.ans.gov.br/padroes/tiss/schemas")]
    public protocoloRecebimentoRecursoWS tissRecursoGlosa_Operation([XmlElement(Namespace = "http://www.ans.gov.br/padroes/tiss/schemas")] loteRecursoGlosaWS loteRecursoGlosaWS)
    {
        protocoloRecebimentoRecursoWS retorno = new protocoloRecebimentoRecursoWS();
        retorno.hash = "retornooo";

        return retorno;
    }
}