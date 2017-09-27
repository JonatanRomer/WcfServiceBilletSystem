using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceBilletSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBillet" in both code and config file together.
    [ServiceContract]
    public interface IBillet
    {

        [OperationContract]
        int BilPris();

        [OperationContract]
        int BilPrisMedBizz();

        [OperationContract]
        int BilprisØresund();

        [OperationContract]
        int BilprisØresundBizz();

        [OperationContract]
        int MCPris();

        [OperationContract]
        int MCØresund();

        [OperationContract]
        int MCØresundBizz();

        [OperationContract]
        int MCPrisØresundBizz();

        [OperationContract]
        int MCBizz();

    }

}
