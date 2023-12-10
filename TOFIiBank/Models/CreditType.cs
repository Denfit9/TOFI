using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOFIiBank.Models
{
    public class CreditType
    {
        public int creditTypeID {  get; set; }
        public float percentage { get; set; }
        public int minSum { get; set; }
        public int maxSum { get; set; }
        public string creditName { get; set; }
        public int minMonths { get; set; }
        public int maxMonths { get; set; } 

        public CreditType(int creditTypeID, float percentage, int minSum, int maxSum, string creditName, int minMonths, int maxMonths)
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
