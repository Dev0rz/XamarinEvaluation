using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;

namespace App.Mock.WebService
{
    public class MockService : IMockService
    {
        public List<Lot> GetLot(String lotNumber)
        {
            string File = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "MockDataLot.txt");
            string[] lines = System.IO.File.ReadAllLines(File);

            if (lines.Length <= 1)
            {
                throw new FaultException("Mock Data invalid.");
            }

            List<Lot> lots = new List<Lot>();
            foreach (var line in lines)
            {
                if(line.Equals(lines.First()))
                    continue;

                string[] elements = line.Split(';');

                // Check if line fits the specified format,
                // wrong lines are ignored
                if(elements.Length != 16)
                    continue;

                // Could crash on wrong Oper number
                Lot lot = new Lot()
                {
                    Oper = Convert.ToInt32(elements[0]),
                    Process_Nr = elements[1],
                    Process = elements[2],
                    Equipment = elements[3],
                    Specification = elements[4],
                    Oper_Desc = elements[5],
                    Hold_Category = elements[6],
                    Comment = elements[7],
                    Route = elements[8],
                    Planed_Hold = elements[9],
                    Hold_Name = elements[10],
                    Hold_Note = elements[11],
                    Hold_Reason = elements[12],
                    Hold_Release = elements[13],
                    Operator = elements[14],
                    Color = elements[15]
                };

                lots.Add(lot);
            }

            return lots;
        }

        public bool IsValidUser(String Username, String Password)
        {
            if (Username == "tc" && Password == "abc")
                return true;
            else
                return false;
        }
    }
}
