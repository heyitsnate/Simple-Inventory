using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhistlingPalms
{
    class TransactionDetails
    {
        public int TransactionDetailID { get; set; }
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public int WareHouseID { get; set; }
        public decimal ProductCost { get; set; }
        public decimal TransactQuantity { get; set; }
        public decimal TransactCost { get; set; }
        public decimal OldQuantity { get; set; }
        public decimal NewQuantity { get; set; }
        public decimal TotalCost { get; set; }

        public TransactionDetails()
        {
            TransactionDetailID = 0;
            TransactionID = 0;
            ProductID = 0;
            WareHouseID = 0;
            ProductCost = 0;
            TransactQuantity = 0;
            TransactCost = 0;
            OldQuantity = 0;
            NewQuantity = 0;
            TotalCost = 0;
        }
    }
}
