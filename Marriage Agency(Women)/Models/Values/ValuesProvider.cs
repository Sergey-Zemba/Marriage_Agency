using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values
{
    public class ValuesProvider
    {
        private IDictionary<int, ViewValue> _dictionary;
        private IValuesInitializer _initializer;
        public ValuesProvider(IValuesInitializer initializer)
        {
            _initializer = initializer;
            _initializer.Init(out _dictionary);
        }

        public IDictionary<int, ViewValue> Dictionary
        {
            get { return _dictionary; }
        } 
    }
}