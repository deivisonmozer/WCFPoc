using System;
using System.ServiceModel;
using WCFPoc.Client.ConsoleApp.WebService;

namespace WCFPoc.Client.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region inicializa
            //var binding = new BasicHttpBinding();
            //var endpoint = new EndpointAddress(new Uri(string.Format("http://{0}:5050/Service.svc", Environment.MachineName)));
            //var channelFactory = new ChannelFactory<IService>(binding, endpoint);
            //var serviceClient = channelFactory.CreateChannel();
            //var result = serviceClient.GetData("hey");


            //localhost.Service service = new localhost.Service();
            //service.Url = @"http://localhost:50648/Service.svc";
            //var resulta = service.GetData(007, true);
            //Console.WriteLine("Valor digitado: " + resulta);
            //Console.ReadKey();

            //ServiceTest.ServiceTest teste = new ServiceTest.ServiceTest();
            //teste.Url = "http://localhost:50648/ServiceTest.svc";
            //var res = teste.tissRecursoGlosa_Operation("send");
            //Console.WriteLine("Valor digitado: " + res);
            //Console.ReadKey();

            //ServiceReference1.ServiceTestClient teste = new ServiceReference1.ServiceTestClient();
            #endregion

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
