using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TOFIiBank.Models
{
    public class Notification
    {
        public int notificationID { get; set; }
        public string description { get; set; }
        public int secondUserID { get; set; }
        public int bancAccountID { get; set; }
        public string bancAccountNumber { get; set; }

        public Notification(int notificationID, string description, int secondUserID, int bancAccountID, string bancAccountNumber)
        {
            string descriptionFixed = "";
            if (description == "USD" || description == "BYN" || description == "EUR")
            {
                string approvalType = Tools.getAccountApproval(bancAccountID);
                if (approvalType == "nothing")
                {
                    approvalType = "без подтверждения";
                }
                else if (approvalType == "password")
                {
                    approvalType = "по паролю";
                }
                else if (approvalType == "notification")
                {
                    approvalType = "по уведомлению";
                }
                descriptionFixed = "Пользователь " + Tools.getUserEmail(secondUserID) + " хочет создать с вами совместный счёт с валютой " + description + " и типом подтверждения операций " + approvalType + ". Ваше мнение?";
            }
            else if (description == "block")
            {
                descriptionFixed = "Пользователь " + Tools.getUserEmail(secondUserID) + " хочет заблокировать совместный счёт под номером: " + bancAccountNumber +  ". Ваше мнение?";
            }
            else if (description.StartsWith("send"))
            {
                string pattern = @"\((.*?)\)";

                Match match = Regex.Match(description, pattern);

                string extra = "";

                if (match.Success)
                {
                    extra = match.Groups[1].Value;
                }
                descriptionFixed = "Пользователь " + Tools.getUserEmail(secondUserID) + " хочет перевести: "  + Tools.getTransactionBal(extra) + " со счёта " + bancAccountNumber + ". Ваше мнение?";
            }
            this.notificationID = notificationID;
            this.description = descriptionFixed;
            this.secondUserID = secondUserID;
            this.bancAccountID = bancAccountID;
            this.bancAccountNumber = bancAccountNumber;
        }
    }
}
