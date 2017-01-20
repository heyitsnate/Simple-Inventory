using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhistlingPalms
{
    class Transaction
    {
        public int TransactionID { get; set; }
        public string TransactionDetails { get; set; }
        public DateTime TransactionDate { get; set; }
        public clsTransactionType objTransactionType { get; set; }
        public string Remarks { get; set; }
        public string OrderNo { get; set; }
        public int ClientID { get; set; }
        public List<TransactionDetails> objTransactionDetails { get; set; }

        public Transaction()
        {
            TransactionID = 0;
            TransactionDetails = "";
            TransactionDate = DateTime.MinValue;
            objTransactionType = new clsTransactionType();
            Remarks = "";
            OrderNo = "";
            ClientID = 0;
            objTransactionDetails = new List<TransactionDetails>();
        }
    }
}
