using Bookkeeping.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookkeeping.Controllers
{
    public class TransactionsController : Controller
    {
        // GET: Transactions
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ShowTransactionRecord()
        {
            var Record = new List<TransactionRecord>
            {
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,11),Amount=3500},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,12),Amount=250},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,13),Amount=1200},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,14),Amount=30},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,15),Amount=20},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,11),Amount=350},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,12),Amount=25},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,13),Amount=120},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,14),Amount=3},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,15),Amount=20},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,11),Amount=3500},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,12),Amount=250},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,13),Amount=1200},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,14),Amount=30},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,15),Amount=20},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,11),Amount=350},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,12),Amount=25},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,13),Amount=120},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,14),Amount=3},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,15),Amount=20},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,11),Amount=3500},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,12),Amount=250},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,13),Amount=1200},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,14),Amount=30},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,15),Amount=20},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,11),Amount=350},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,12),Amount=25},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,13),Amount=120},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,14),Amount=3},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,15),Amount=20},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,11),Amount=3500},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,12),Amount=250},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,13),Amount=1200},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,14),Amount=30},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,15),Amount=20},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,11),Amount=350},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,12),Amount=25},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,13),Amount=120},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,14),Amount=3},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,15),Amount=20},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,11),Amount=3500},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,12),Amount=250},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,13),Amount=1200},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,7,14),Amount=30},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,7,15),Amount=20},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,11),Amount=350},
                new TransactionRecord{ Type=TransacionType.收入,TransactionDate = new DateTime(2018,6,12),Amount=25},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,13),Amount=120},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,14),Amount=3},
                new TransactionRecord{ Type=TransacionType.支出,TransactionDate = new DateTime(2018,6,15),Amount=20},


            };
            return View(Record);
        }
    }
}