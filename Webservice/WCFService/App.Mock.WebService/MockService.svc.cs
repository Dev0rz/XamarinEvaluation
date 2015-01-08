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
        public List<RouteOperation> GetRouteOperations(String lotNumber)
        {
            string File = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "MockDataLot.txt");
            string[] lines = System.IO.File.ReadAllLines(File);

            if (lines.Length <= 1)
            {
                throw new FaultException("Mock Data invalid.");
            }

            List<RouteOperation> lots = new List<RouteOperation>();
            foreach (var line in lines)
            {
                if (line.Equals(lines.First()))
                    continue;

                string[] elements = line.Split(';');

                // Check if line fits the specified format,
                // wrong lines are ignored
                if (elements.Length != 16)
                    continue;

                // Could crash on wrong Oper number
                RouteOperation routeOperation = new RouteOperation()
                {
                    Type = elements[0],
                    Product_Type = elements[1],
                    Product = elements[2],
                    Plant = elements[3],
                    Manufacturing_Line = elements[4],
                    Production_Level = elements[5],
                    Route = elements[6],
                    Version = elements[7],
                    Op_Seq = elements[8],
                    Op = elements[9],
                    Position = elements[10],
                    CT_Plan = elements[11],
                    CT_Q = elements[12],
                    RPT = elements[13],
                    Color = elements[14],
                };

                lots.Add(routeOperation);
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

        public List<KeyValuePair<int, String>> EDC_GetParameters(String lotNumber)
        {
            string File = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "MockDataEDC.txt");
            string[] lines = System.IO.File.ReadAllLines(File);

            List<KeyValuePair<int, String>> data = new List<KeyValuePair<int, String>>();

            foreach (var line in lines)
            {
                String[] items = line.Split('@');

                // Continue if line isn't the right lotnumber
                if (lotNumber != items[0])
                    continue;

                // Get column names
                String[] columnNames = items[1].Split(';');
                int i = 0;
                foreach (var column in columnNames)
                {
                    KeyValuePair<int, String> pair = new KeyValuePair<int, string>(i, column);
                    data.Add(pair);
                    i++;
                }
            }

            return data;
        }

        public List<KeyValuePair<int, String>> EDC_GetValues(String lotNumber)
        {
            string File = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "MockDataEDC.txt");
            string[] lines = System.IO.File.ReadAllLines(File);

            List<KeyValuePair<int, String>> data = new List<KeyValuePair<int, String>>();

            foreach (var line in lines)
            {
                String[] items = line.Split('@');

                // Continue if line isn't the right lotnumber
                if (lotNumber != items[0])
                    continue;

                // Get column values
                String[] columnValues = items[2].Split(';');
                int i = 0;
                foreach (var value in columnValues)
                {
                    KeyValuePair<int, String> pair = new KeyValuePair<int, string>(i, value);
                    data.Add(pair);
                    i++;
                }
            }

            return data;
        }
    }
}
