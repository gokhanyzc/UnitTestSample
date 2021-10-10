using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EftSample.Test
{
    [TestClass]
    public class TransferMoneyUnitTest
    {

        [TestMethod]
        public void TransferMoney_With_Zero_Amount_Then_Transfer_Failed_Test()
        {
            var expected = new TransferResponse
            {
                IsSuccess = false,
                Message = "Amount must be greater Then 1"
            };

            var transfer = new Transfer();

            var transferRequest = new TransferRequest
            {
                Amount = 0,
                ReceiveIban = "TR806541651616516416541",
                SenderIban = "TR1321649846846541"
            };

            var actual = transfer.TransferMoney(transferRequest);

            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);
            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void TransferMoney_With_Empty_Sender_IBAN_Then_Transfer_Failed_Test()
        {
            var expected = new TransferResponse
            {
                IsSuccess = false,
                Message = "Sender Account IBAN must not be null or empty."
            };

            var transfer = new Transfer();

            var transferRequest = new TransferRequest
            {
                Amount = 60,
                SenderIban = string.Empty,
                ReceiveIban = "TR13216498468465416"
            };

            var actual = transfer.TransferMoney(transferRequest);

            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);
            Assert.AreEqual(expected.Message, actual.Message);
        }


        [TestMethod]
        public void TransferMoney_With_Empty_Receiver_IBAN_Then_Transfer_Failed_Test()
        {
            var expected = new TransferResponse
            {
                IsSuccess = false,
                Message = "Receiver Account IBAN must not be null or empty."
            };

            var transfer = new Transfer();

            var transferRequest = new TransferRequest
            {
                Amount = 60,
                SenderIban = "TR806541651616516416541",
                ReceiveIban =  string.Empty
            };

            var actual = transfer.TransferMoney(transferRequest);

            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);
            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void TransferMoney_With_Correct_Request_Parameter_Then_Transfer_OK_Test()
        {
            var expected = new TransferResponse
            {
                IsSuccess = true,
                Message = "Transfer operation is successful."
            };

            var transfer = new Transfer();

            var transferRequest = new TransferRequest
            {
                Amount = 60,
                ReceiveIban = "TR806541651616516416541",
                SenderIban = "TR13216498468465416"
            };

            var actual = transfer.TransferMoney(transferRequest);

            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);
            Assert.AreEqual(expected.Message, actual.Message);
        }

 
    }
}
