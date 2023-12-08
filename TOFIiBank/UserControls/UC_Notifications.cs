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


    public partial class UC_Notifications : UserControl
    {

        private static UC_Notifications _instance;

        public static UC_Notifications Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Notifications();
                return _instance;
            }
        }
        public UC_Notifications()
        {
            InitializeComponent();
        }
    }
}
