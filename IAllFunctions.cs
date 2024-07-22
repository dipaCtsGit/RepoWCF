using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Test
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAllFunctions" in both code and config file together.
    [ServiceContract]
    public interface IAllFunctions
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string fn_GetRemainder(float x, float y);

        [OperationContract]
        string fn_GetPrime(int x);
    }
}
