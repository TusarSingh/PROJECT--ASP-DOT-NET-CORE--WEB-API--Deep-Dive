using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radhey.Model.CommonModel
{
    public class ResponseComModel
    {

#nullable disable
        public int  StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public bool IsSuccess { get; set; }

    }

    public class ResponseComModel<T> : ResponseComModel
    {
        public object Data { get; set; }
        public T ValidationError { get; set; }

    }

}
