using Services.Std.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Impl
{
    public class ESWService : IESWService
    {
        public string GetSoftwareConfiguration()
        {
            return "ESW Service";
        }
    }
}
