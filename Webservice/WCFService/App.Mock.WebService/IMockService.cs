using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace App.Mock.WebService
{
    [ServiceContract]
    public interface IMockService
    {
        [OperationContract]
        List<RouteOperation> GetRouteOperations(String lotNumber);

        [OperationContract]
        bool IsValidUser(String Username, String Password);

        [OperationContract]
        List<KeyValuePair<int, String>> EDC_GetParameters(String lotNumber);

        [OperationContract]
        List<KeyValuePair<int, String>> EDC_GetValues(String lotNumber);
    }

    //Oper;Process Nr;Process;Equipment;Specification;Oper. Desc.;Hold Category;Comment;Route;Planed Hold;Hold Name;Hold Note;Hold Reason;Hold Release;Operator;Color
    [DataContract]
    public class RouteOperation
    {
        [DataMember]
        public String Type { get; set; }

        [DataMember]
        public String Product_Type { get; set; }

        [DataMember]
        public String Product { get; set; }

        [DataMember]
        public String Plant { get; set; }

        [DataMember]
        public String Manufacturing_Line { get; set; }

        [DataMember]
        public String Production_Level { get; set; }

        [DataMember]
        public String Route { get; set; }

        [DataMember]
        public String Version { get; set; }

        [DataMember]
        public String Op_Seq { get; set; }

        [DataMember]
        public String Op { get; set; }

        [DataMember]
        public String Position { get; set; }

        [DataMember]
        public String CT_Plan { get; set; }

        [DataMember]
        public String CT_Q { get; set; }

        [DataMember]
        public String RPT { get; set; }

        [DataMember]
        public String Color { get; set; }
    }
}
