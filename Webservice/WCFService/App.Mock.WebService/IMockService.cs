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
        List<Lot> GetLot(String lotNumber);

        [OperationContract]
        bool IsValidUser(String Username, String Password);
    }

    //Oper;Process Nr;Process;Equipment;Specification;Oper. Desc.;Hold Category;Comment;Route;Planed Hold;Hold Name;Hold Note;Hold Reason;Hold Release;Operator;Color
    [DataContract]
    public class Lot
    {
        [DataMember]
        public int Oper { get; set; }

        [DataMember]
        public String Process { get; set; }

        [DataMember]
        public String Process_Nr { get; set; }

        [DataMember]
        public String Equipment { get; set; }

        [DataMember]
        public String Specification { get; set; }

        [DataMember]
        public String Oper_Desc { get; set; }

        [DataMember]
        public String Hold_Category { get; set; }

        [DataMember]
        public String Comment { get; set; }

        [DataMember]
        public String Route { get; set; }

        [DataMember]
        public String Planed_Hold { get; set; }

        [DataMember]
        public String Hold_Name { get; set; }

        [DataMember]
        public String Hold_Note { get; set; }

        [DataMember]
        public String Hold_Reason { get; set; }

        [DataMember]
        public String Hold_Release { get; set; }

        [DataMember]
        public String Operator { get; set; }

        [DataMember]
        public String Color { get; set; }
    }
}
