﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backbone.Utilities.Results
{
    public class DataResult<T> :Result, IDataResult<T>// Class constructor'unda ilk olarak Result classından alınan bilgiler kullanıldıgı için ilk implementasyon class tarafından gerçekleştirilmelidir
    {
        public DataResult(T data, bool success, string message):base(success,message)
        {
            Data = data;
        }

        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
    
}
