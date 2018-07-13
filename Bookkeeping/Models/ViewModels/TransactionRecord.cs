using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookkeeping.Models.ViewModels
{
    public class TransactionRecord
    {
        public TransacionType Type { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Amount { get; set; }

         
    }

    public enum TransacionType
    {
        收入,
        支出
    }
}