﻿using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XDSDotNet
{
    [ServiceContract(Namespace = "urn:ihe:iti:xds-b:2007")]
    public interface ICrossGatewayQueryITI38
    {
        [OperationContract(Action = "urn:ihe:iti:2007:CrossGatewayQuery", ReplyAction = "urn:ihe:iti:2007:CrossGatewayQueryResponse")]
        Message CrossGatewayQuery(Message request);
    }
}
