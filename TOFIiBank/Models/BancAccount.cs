using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TOFIiBank.Models
{
    public class BancAccount
    {
        public int bancAccountID { get; set; }
        public int userID { get; set; }
        public float balance { get; set; }
        public DateTime expiresAt { get; set; }
        public string bancAccountType { get; set; }
        public string currency { get; set; }
        public string accountNumber { get; set; }

        public BancAccount(int bancAccountID, int userID, float balance, DateTime expiresAt, string bancAccountType, string currency, string accountNumber) 
        {
            string dateTimeNormal = expiresAt.ToString("dd-MM-yyyy");
            this.bancAccountID = bancAccountID;
            this.userID = userID;
            this.balance = balance;
            this.expiresAt = Convert.ToDateTime(dateTimeNormal);
            this.bancAccountType = bancAccountType == "single" ? "Одиночный" : "Двойной";
            this.currency = currency;
            this.accountNumber = accountNumber;
        }
    }
}
