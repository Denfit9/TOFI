using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOFIiBank.Models
{
    public class CreditType
    {
        int creditTypeID {  get; set; }
        int percentage { get; set; }
        int minSum { get; set; }
        int maxSum { get; set; }
        string creditName { get; set; }
        int minMonths { get; set; }
        int maxMonths { get; set; } 

        public CreditType(int creditTypeID, int percentage, int minSum, int maxSum, string creditName, int minMonths, int maxMonths)
        {
            this.creditTypeID = creditTypeID;
            this.percentage = percentage;
            this.minSum = minSum;
            this.maxSum = maxSum;
            this.creditName = creditName;
            this.minMonths = minMonths;
            this.maxMonths = maxMonths;
        }
    }
}
