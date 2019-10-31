using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicPivotList.Helper
{
    public class ClassFieldHelper
    {
        public ClassFieldHelper(string name, Type type)
        {
            this.FieldName = name;
            this.FieldType = type;
        }

        public string FieldName;

        public Type FieldType;
    }
}
