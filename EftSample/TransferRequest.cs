using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EftSample
{
    public class TransferRequest
    {
        public decimal Amount { get; set; }
        public string SenderIban { get; set; }
        public string ReceiveIban { get; set; }

        public TransferRequest()
        {

        }

        public TransferRequest(decimal amount, string senderIban, string receiveIban)
        {
            Amount = amount;
            SenderIban = senderIban;
            ReceiveIban = receiveIban;
        } 
    }
}
