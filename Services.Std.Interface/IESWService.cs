using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace Services.Std.Interface
{
    [ServiceContract]
    public interface IESWService
    {
        [OperationContract]
        string GetSoftwareConfiguration();
    }
}
