using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOFIiBank.Models
{
    public class Credit
    {
        public int creditID { get; set; }
        public int userID { get; set; }
        public int sum { get; set; }
        public DateTime startedAt { get; set; }
        public string status { get; set; }
        public string creditName { get; set; }
        public int finalSum { get; set; }
        public int months { get; set; }
        public int monthPayment { get; set; }

        public Credit(int creditID, int userID, int sum, DateTime startedAt, string status, string creditName, int finalSum, int months, int monthPayment)
        {
            string statusFixed = "";
            if (status == "opened")
            {
                statusFixed = "открыт";
            }
            else 
            { 
                statusFixed = "закрыт"; 
            }
            this.creditID = creditID;
            this.userID = userID;
            this.sum = sum;
            this.startedAt = startedAt;
            this.status = statusFixed;
            this.creditName = creditName;
            this.finalSum = finalSum;
            this.months = months;
            this.monthPayment = monthPayment;
        }
    }
}
