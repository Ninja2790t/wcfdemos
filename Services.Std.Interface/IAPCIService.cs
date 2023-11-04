using System;
using System.ServiceModel;

namespace Services.Std.Interface
{
    [ServiceContract]
    public interface IAPCIService
    {
        [OperationContract]
        string GetApciUpdates();
    }
}
