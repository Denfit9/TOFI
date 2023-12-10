using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOFIiBank.Models;

namespace TOFIiBank.UserControls
{
    public partial class UC_Credist : UserControl
    {
        private static UC_Credist _instance;

        public static UC_Credist Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Credist();
                return _instance;
            }
        }
        public UC_Credist()
        {
            InitializeComponent();
            List<CreditType> accounts = Tools.getAllCreditTypes();
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
