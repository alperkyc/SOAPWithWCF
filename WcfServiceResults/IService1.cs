using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceResults.Models;

namespace WcfServiceResults
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Yillar> getYears();

        [OperationContract]
        List<Turler> getTypes();

        [OperationContract]
        List<Ogrenciler> getStudents();

        [OperationContract]
        int? getResult(int studentId, int typeId, int yearId);

        [OperationContract]
        List<Test> getTestList();



    }

}
