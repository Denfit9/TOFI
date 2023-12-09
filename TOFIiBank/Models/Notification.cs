using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            this.notificationID = notificationID;
            this.description = descriptionFixed;
            this.secondUserID = secondUserID;
            this.bancAccountID = bancAccountID;
            this.bancAccountNumber = bancAccountNumber;
        }
    }
}
