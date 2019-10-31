using DynamicPivotList.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DynamicPivotList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> columnNames = new List<string>();
            columnNames.Add("Name");
            columnNames.Add("Code");

            List<string> pivotColumnNames = new List<string>();
            pivotColumnNames.Add("LocationId");

            DynamicPivotHelper<Product, StockLocation>.GetDynamicPivotList(new ProductRepository().GetAll(), new StockLocationRepository().GetAll(), columnNames, pivotColumnNames);
            new Program().GetAll();
            Console.ReadKey();
        }

        public List<object> GetAll()
        {
            List<object> listObj = new List<object>();

           



            // var fields = new List<D>() {
            //     new Field("EmployeeID", typeof(int)),
            //     new Field("EmployeeName", typeof(string)),
            //     new Field("Designation", typeof(string))
            // };

            // dynamic obj = new DynamicClass(fields);
            // //set
            // obj.EmployeeID = 123456;
            // obj.EmployeeName = "John";
            // obj.Designation = "Tech Lead";
            // listObj.Add(obj);

            //obj = new DynamicClass(fields);

            // //set
            // obj.EmployeeID = 123456;
            // obj.EmployeeName = "John";
            // obj.Designation = "Tech Lead";
            // listObj.Add(obj);

            // var ss = new Dictionary<string, string>();
            // ss.Add("1", "1");
            // var ss1 = new Dictionary<string, int>();
            // ss1.Add("1", 2);

            // List<dynamic> dynamics = new List<dynamic>();
            // dynamics.Add(ss);
            // dynamics.Add(ss1);

            // String json = JsonConvert.SerializeObject(listObj, new KeyValuePairConverter());
            return listObj;
        }
    }
}
