using Services.Std.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Impl
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ApciService : IAPCIService
    {
        public string GetApciUpdates()
        {
            //Thread.Sleep(10000); // To test sendTimeout binding config
            //throw new Exception("You cannot run this service."); // To test [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
            return "APCI Services";
        }
    }
}
