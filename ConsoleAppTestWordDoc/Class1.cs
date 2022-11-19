using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;

namespace ConsoleAppTestWordDoc
{
    internal class Class1
    {
        private string? _valueEnum;
        private System.Type _typeEnum;
        public Class1() 
        {
            _valueEnum= null;
        }
        public System.Enum GetEnum()
        {
            object result;
            Enum.TryParse(_typeEnum, _valueEnum, out result);
            return result == null ? TypeValues.None : result as Enum;
        }
        public void SetEnum(System.Enum value)
        {
            _valueEnum = value.ToString();
            _typeEnum= value.GetType();
        }
        public System.Type GetTypeEnum() { return _typeEnum; }
    }
}
