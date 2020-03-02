using System;
using System.Collections.Generic;
using System.Text;

namespace Validations.Utils.Results
{
    public class Result<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; }
    }
}
