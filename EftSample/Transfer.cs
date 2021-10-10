using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EftSample
{
    public class Transfer
    {
        public TransferResponse TransferMoney(TransferRequest request)
        {
            var response = new TransferResponse();

            if(request.Amount < 1)
            {
                response.IsSuccess = false;
                response.Message = "Amount must be greater  than 1";
                return response;
            }

            if (string.IsNullOrEmpty(request.SenderIban))
            {
                response.IsSuccess = false;
                response.Message = "Sender Account IBAN must not be null or empty.";
            }

            if (string.IsNullOrEmpty(request.ReceiveIban))
            {
                response.IsSuccess = false;
                response.Message = "Receive Account IBAN must not be null or empty.";

            }

            response.IsSuccess = true; // deneme
            response.Message = "Transfer operation is successfull.";

            return response;

        }
    }
}
