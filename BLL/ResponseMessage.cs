using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ResponseMessage<T> where T:class
    {
        public bool IsSuccess { get; set; }
        public int EffectedRow { get; set; }
        public T ResultTable { get; set; }
        public string Message { get; set; }

        public ResponseMessage()
        {
            IsSuccess = true;
            EffectedRow = 0;
            ResultTable = null;
            Message = string.Empty;
        }

    }
}
