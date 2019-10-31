using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DynamicPivotList.Helper
{
    public static class DynamicPivotHelper<TProduct, TStock> where TProduct: class where TStock: class  
    {
        public static List<object> GetDynamicPivotList(List<TProduct> products, List<TStock> stocks, List<string> columns, List<string> pivotColumns)
        {
            List<object> listObj = new List<object>();

            #region CreateClassField
            List<ClassFieldHelper> classFieldHelpers = new List<ClassFieldHelper>();
            foreach(string s in columns)
            {
                classFieldHelpers.Add(new ClassFieldHelper(s, GetType(Activator.CreateInstance(typeof(TProduct)), s)));
            }
            foreach (string s in pivotColumns)
            {
                classFieldHelpers.Add(new ClassFieldHelper(s, GetType(Activator.CreateInstance(typeof(TStock)), s)));
            }
            #endregion CreateClassField

            #region GenerateClass
            dynamic obj = new DynamicClass(classFieldHelpers);
            #endregion GenerateClass

           
     

            DynamicClass dynamicClassTest = obj as DynamicClass;
            foreach(var a in dynamicClassTest._fields)
            {
                a.Value = new KeyValuePair<Type, object>(GetType(Activator.CreateInstance(typeof(TProduct)), "Name"), "test"); ;
            }


            obj.GetType().GetProperty("Name").SetValue("ss", null);

       

            #region GenerateData
            foreach (TProduct p in products)
            {
                foreach(string s in columns)
                {
                    SetObjectProperty(s, p.GetType().GetProperty(s).GetValue(p), ref obj);

                    //obj.Name = p.GetType().GetProperty(s).GetValue(p);
                }
                //string aa = (string) p.GetType().GetProperty("Code").GetValue(p);
                //obj.Code = aa;

                listObj.Add(obj);
            }

            //obj.EmployeeID = 123456;
            //listObj.Add(obj);
            #endregion GenerateData

            return listObj;
        }

        private static Type GetType(object data, string columnName)
        {
            return data.GetType().GetProperty(columnName).PropertyType;
        }

        private static void SetObjectProperty(string propertyName, dynamic objValue, ref object objName)
        {
            //objName.GetType().GetProperty("Name").SetValue(objName, objValue);


            //PropertyInfo propertyInfo = objName.GetType().GetProperty(propertyName);
            //// make sure object has the property we are after
            //if (propertyInfo != null)
            //{
            //    propertyInfo.SetValue(objName, objValue, null);
            //}


        }
    }
}
