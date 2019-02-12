using System;
using System.ServiceModel;
using WCFPoc.Client.ConsoleApp.WebService;

namespace WCFPoc.Client.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService.WebServiceSoapClient teste = new WebService.WebServiceSoapClient();
            protocoloRecebimentoRecursoWS resultado = new protocoloRecebimentoRecursoWS();
            loteRecursoGlosaWS lote = new loteRecursoGlosaWS();
            lote.hashField = "envio";
            resultado = teste.tissRecursoGlosa_Operation(lote);
            Console.WriteLine(" res: " + resultado.hash);
            Console.ReadKey();
        }
    }
}
