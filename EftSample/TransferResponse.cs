using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EftSample
{
    public class TransferResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public TransferResponse()
        {

        }

        public TransferResponse(bool isSuccess , string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
      
    }
}
