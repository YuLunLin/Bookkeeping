using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookkeeping.Models.ViewModels
{
    public class TransactionRecord
    {

        [Display(Name = "類別")]
        public TransacionType Type { get; set; }

        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime TransactionDate { get; set; }

        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Amount { get; set; }

         
    }

    public enum TransacionType
    {
        收入,
        支出
    }
}