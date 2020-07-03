using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XDSDotNet
{
    [ServiceContract(Namespace = "urn:ihe:iti:xds-b:2007")]
    public interface IRegistryStoredQueryITI18
    {
        [OperationContract(Action = "urn:ihe:iti:2007:RegistryStoredQuery", ReplyAction = "urn:ihe:iti:2007:RegistryStoredQueryResponse")]
        Message RegistryStoredQuery(Message request);
    }
}

//TODO: Definer alle namespaces og actions som konstanter