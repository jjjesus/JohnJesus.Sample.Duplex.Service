using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.ServiceModel.Description;
using System.Text;
using JohnJesus.Sample.Duplex.Service;

namespace JohnJesus.Duplex.Service.Host
{
    public class DuplexCalculatorHost
    {
        // Host the service within this EXE console application.
        public static void Run()
        {
            // Create a ServiceHost for the CalculatorService type.
            string uri = "http://localhost:8000/JohnJesus.Sample.CalculatorDuplex/service";
            using (ServiceHost serviceHost = new ServiceHost(typeof(CalculatorDuplexService), new Uri(uri)))
            {
                // Check to see if the service host already has a ServiceMetadataBehavior
                ServiceMetadataBehavior smb = serviceHost.Description.Behaviors.Find<ServiceMetadataBehavior>();
                // If not, add one
                if (smb == null)
                    smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                serviceHost.Description.Behaviors.Add(smb);
                // Add MEX endpoint
                serviceHost.AddServiceEndpoint(
                  ServiceMetadataBehavior.MexContractName,
                  MetadataExchangeBindings.CreateMexHttpBinding(),
                  "mex"
                );
                // Add application endpoint
                serviceHost.AddServiceEndpoint(
                    typeof(ICalculatorDuplex),
                    new WSDualHttpBinding(WSDualHttpSecurityMode.None), 
                    "");

                // Open the ServiceHost to create listeners and start listening for messages.
                serviceHost.Open();

                // The service can now be accessed.
                Console.WriteLine("The service is ready at {0}", uri);
                Console.WriteLine("Metadata ready at {0}", uri + "/mex");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
