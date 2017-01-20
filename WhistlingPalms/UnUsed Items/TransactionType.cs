using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhistlingPalms
{
    class clsTransactionType
    {
        public int TransactionTypeID { get; set; }
        public string TransactionType { get; set; }
        public string ActionType { get; set; }
        public bool HasClientOrderInformation { get; set; }

        public clsTransactionType()
        {
            TransactionTypeID = 0;
            TransactionType = "";
            ActionType = "";
            HasClientOrderInformation = false;
        }
    }
}
