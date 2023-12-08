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
    public partial class UC_Payments : UserControl
    {

        private static UC_Payments _instance;

        public static UC_Payments Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Payments();
                return _instance;
            }
        }
        public UC_Payments()
        {
            InitializeComponent();
        }
    }
}
