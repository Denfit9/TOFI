using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TOFIiBank.Models;

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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "notificationID";
            dataGridView1.Columns[1].DataPropertyName = "description";
            dataGridView1.Columns[2].DataPropertyName = "bancAccountNumber";
            dataGridView1.Columns[0].Width = 35;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Одобрить";
            btn.Text = "✓";
            btn.Name = "btn";
            btn.FlatStyle = FlatStyle.Flat;
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 70;
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Отклонить";
            btn2.Text = "X";
            btn2.Name = "btn2";
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn2);
            dataGridView1.Columns[4].Width = 70;
            List<Notification> notificaitions = Tools.getAllNotifications(Program.userID);
            dataGridView1.DataSource = notificaitions;
            // dataGridView1.DataSource = accounts;
        }

        public void askMessageConfirmJoint(string number, string id)
        {
            DialogResult result = MessageBox.Show(
                "Одобрить операцию?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {

                Tools.confirmJointAccount(number,id);
                MessageBox.Show("Операция одобрена", "Одобрено", MessageBoxButtons.OK, MessageBoxIcon.None);
                List<Notification> notificaitions = Tools.getAllNotifications(Program.userID);
                dataGridView1.DataSource = notificaitions;
            }
            else if (result == DialogResult.No)
            {

            }
        }
        public void askMessageConfirmJointBlock(string number, string id)
        {
            DialogResult result = MessageBox.Show(
                "Одобрить операцию?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {

                Tools.confirmJointAccountBlocking(number, id);
                MessageBox.Show("Операция одобрена", "Одобрено", MessageBoxButtons.OK, MessageBoxIcon.None);
                List<Notification> notificaitions = Tools.getAllNotifications(Program.userID);
                dataGridView1.DataSource = notificaitions;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        public void askMessageConfirmJointSend(string number, string id)
        {
            DialogResult result = MessageBox.Show(
                "Одобрить операцию?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {

                Tools.proceedMoneyTransferSuccess(Convert.ToString(Tools.getTransactionIDFromNotificationNumber(Convert.ToString(id))), id);
                MessageBox.Show("Операция одобрена", "Одобрено", MessageBoxButtons.OK, MessageBoxIcon.None);
                List<Notification> notificaitions = Tools.getAllNotifications(Program.userID);
                dataGridView1.DataSource = notificaitions;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        public void askMessageRejectJoint(string number, string id)
        {
            DialogResult result = MessageBox.Show(
                "Отклонить операцию?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {

                Tools.rejectJointAccount(number, id);
                MessageBox.Show("Операция отклонена", "отклонено", MessageBoxButtons.OK, MessageBoxIcon.None);
                List<Notification> notificaitions = Tools.getAllNotifications(Program.userID);
                dataGridView1.DataSource = notificaitions;
            }
            else if (result == DialogResult.No)
            {

            }
        }
        public void askMessageRejectJointBlock(string number, string id)
        {
            DialogResult result = MessageBox.Show(
                "Отклонить операцию?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {

                Tools.rejectJointAccountBlocking(number, id);
                MessageBox.Show("Операция отклонена", "отклонено", MessageBoxButtons.OK, MessageBoxIcon.None);
                List<Notification> notificaitions = Tools.getAllNotifications(Program.userID);
                dataGridView1.DataSource = notificaitions;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string number = row.Cells[2].Value.ToString();
                string id = row.Cells[0].Value.ToString();
                string desc = row.Cells[1].Value.ToString();
                if (desc.Contains("создать"))
                {
                    askMessageConfirmJoint(number, id);
                }
                else if (desc.Contains("заблокировать"))
                {
                    askMessageConfirmJointBlock(number, id);
                }
                else if (desc.Contains("перевести"))
                {
                    askMessageConfirmJointSend(number, id);
                }
            }
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string number = row.Cells[2].Value.ToString();
                string id = row.Cells[0].Value.ToString();
                string desc = row.Cells[1].Value.ToString();
                if (desc.Contains("создать"))
                {
                    askMessageRejectJoint(number, id);
                }
                else if (desc.Contains("заблокировать"))
                {
                    askMessageRejectJointBlock(number, id);
                }
                else if (desc.Contains("перевести"))
                {
                    Tools.proceedMoneyTransferReject(Convert.ToString(Tools.getTransactionIDFromNotificationNumber(Convert.ToString(id))), id);
                }
                    
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            List<Notification> notificaitions = Tools.getAllNotifications(Program.userID);
            dataGridView1.DataSource = notificaitions;
        }
    }
}
