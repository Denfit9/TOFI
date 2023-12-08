using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOFIiBank.UserControls
{
    public partial class UC_PaymentsHistory : UserControl
    {
        private static UC_PaymentsHistory _instance;

        public static UC_PaymentsHistory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_PaymentsHistory();
                return _instance;
            }
        }
        public UC_PaymentsHistory()
        {
            InitializeComponent();
        }
    }
}
