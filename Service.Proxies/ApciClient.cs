using Services.Std.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service.Proxies
{
    public class ApciClient : ClientBase<IAPCIService>, IAPCIService
    {
        public string GetApciUpdates()
        {
            return Channel.GetApciUpdates();
        }
    }
}
