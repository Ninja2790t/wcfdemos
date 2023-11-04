using Services.Std.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Impl
{
    public class ApciService : IAPCIService
    {
        public string GetApciUpdates()
        {
            return "APCI Services";
        }
    }
}
