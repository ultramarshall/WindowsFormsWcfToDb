using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfToDb
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int TambahBiodata(Biodata p);

        [OperationContract]
        int EditBiodata(Biodata p);

        [OperationContract]
        int HapusBiodata(Biodata p);

        [OperationContract]
        Biodata GetBiodata(Biodata p);

        [OperationContract]
        List<Biodata> GetAllBiodata();
    }
}
