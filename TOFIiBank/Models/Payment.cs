using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOFIiBank.Models
{
    public class Payment
    {
        public int transactionID { get; set; }
        public float summ { get; set; }
        public string date { get; set; }
        public int bancAccountID { get; set; }
        public int bancAccountIDReceiver { get; set; }
        public string bancAccountNumber { get; set; }
        public string bancAccountReceiverNumber { get; set; }
        public string transactionMessage { get; set;}
        public string transactionStatus { get; set;}
        public string transactionType {  get; set;}

        public Payment(int transactionID, float summ, DateTime date, int bancAccountID, int bancAccountIDReceiver, string transactionMessage, string transactionStatus, string transactionType)
        {
            string fixedDate = date.ToString("G");
            string transactionMessageFixed = "";
            string transactionStatusFixed = "";
            string transactionTypeFixed = "";
            bancAccountNumber = Tools.getAccountNumber(bancAccountID);
            bancAccountReceiverNumber = Tools.getAccountNumber(bancAccountIDReceiver);
            if (transactionMessage == "added by system")
            {
                transactionMessageFixed = "Пополнение системой";
                bancAccountNumber = "";
            }
            else if(transactionMessage == "credit")
            {
                transactionMessageFixed = "Пополнение от кредита";
                bancAccountNumber = "";
            }
            else if (transactionMessage == "credit pay")
            {
                transactionMessageFixed = "Оплата за кредит";
                bancAccountReceiverNumber = "";
            }
            if (transactionStatus == "completed")
            {
                transactionStatusFixed = "Проведена";
            }
            if(transactionType == "added")
            {
                transactionTypeFixed = "Пополнение";
            }
            else if(transactionType == "transfered")
            {
                transactionTypeFixed = "Перевод";
                summ *= -1;
            }
            this.transactionID = transactionID;
            this.summ = summ;
            this.date = fixedDate;
            this.bancAccountID = bancAccountID;
            this.bancAccountIDReceiver = bancAccountIDReceiver;
            this.transactionMessage = transactionMessageFixed;
            this.transactionStatus = transactionStatusFixed;
            this.transactionType = transactionTypeFixed;
            
        }
    }
}
