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
    public partial class UC_Settings : UserControl
    {
        private static UC_Settings _instance;

        public static UC_Settings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Settings();
                return _instance;
            }
        }
        public UC_Settings()
        {
            InitializeComponent();
        }
    }
}
