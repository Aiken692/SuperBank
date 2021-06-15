using System;
namespace MySuperBank
{
    public class Transaction
    {
        public decimal Amount { get;  }
        public DateTime Date { get; }
        public string Notes { get;  }

        // Constuctor for the bank transactions.
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
