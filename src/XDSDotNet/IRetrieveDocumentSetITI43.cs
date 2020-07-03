using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XDSDotNet
{
    [ServiceContract(Namespace = "urn:ihe:iti:xds-b:2007")]
    public interface IRetrieveDocumentSetITI43
    {
        [OperationContract(Action = "urn:ihe:iti:2007:RetrieveDocumentSet", ReplyAction = "urn:ihe:iti:2007:RetrieveDocumentSetResponse")]
        Message RetrieveDocumentSet(Message request);
    }

}