using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TOFIiBank.Models;

namespace TOFIiBank.UserControls
{
    public partial class UC_Accounts : UserControl
    {
        private static UC_Accounts _instance;

        public static UC_Accounts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Accounts();
                return _instance;
            }
        }


        public UC_Accounts()
        {
            InitializeComponent();
            accountsTypeComboBox.SelectedIndex = 0;
            currencyComboBox.SelectedIndex = 0;
            confirmationComboBox.SelectedIndex = 0;
            List<BancAccount> accounts = Tools.getAllAccount(Program.userID);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "bancAccountType";
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].DataPropertyName = "accountNumber";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].DataPropertyName = "balance";
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].DataPropertyName = "currency";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].DataPropertyName = "expiresAt";
            dataGridView1.Columns[4].Width = 150;
            

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Пополнить";
            btn.Text = "+";
            btn.Name = "btn";
            btn.FlatStyle = FlatStyle.Flat;
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            dataGridView1.Columns[5].Width = 80;
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Заблокировать";
            btn2.Text = "-";
            btn2.Name = "btn2";
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn2);
            dataGridView1.Columns[6].Width = 90;
            dataGridView1.DataSource = accounts;
            

        }

        private void accountsTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountsTypeComboBox.SelectedIndex == 1)
            {
                secondOwnerLabel.Visible = true;
                secondOwnerTextBox.Visible = true;
                confirmationLabel.Visible = true;
                confirmationComboBox.Visible = true;
            }
            else
            {
                secondOwnerLabel.Visible = false;
                secondOwnerTextBox.Visible = false;
                confirmationLabel.Visible = false;
                confirmationComboBox.Visible = false;
            }
        }

        public void askMessageConfirm(string currency)
        {
            DialogResult result = MessageBox.Show(
                "Создать счёт?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                long number = 0;
                number = Tools.LongRandom(1000000000000000, 9999999999999999, new Random());
                while (Tools.checkAccountExistence(number))
                {
                    number = Tools.LongRandom(1000000000000000, 9999999999999999, new Random());
                }              
                Tools.createSingleAccount(Program.userID, currency, number);
                MessageBox.Show("Счёт создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.None);
                List<BancAccount> accounts = Tools.getAllAccount(Program.userID);
                dataGridView1.DataSource = accounts;
            }
            else if(result == DialogResult.No)
            {

            }
        }

        public void askBlockConfirm(string number)
        {
            DialogResult result = MessageBox.Show(
                "Заблокировать счёт?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Tools.blockAccount(number);
                MessageBox.Show("Счёт заблокирован");
                List<BancAccount> accounts = Tools.getAllAccount(Program.userID);
                dataGridView1.DataSource = accounts;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        public void showFailureMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            string failureMessage = "";
            bool error = false;
            if (accountsTypeComboBox.SelectedIndex == 0)
            {
                if (currencyComboBox.SelectedIndex >= 0)
                {
                    if (currencyComboBox.SelectedIndex == 0)
                    {
                        askMessageConfirm("BYN");
                    }
                    else if (currencyComboBox.SelectedIndex == 1)
                    {
                        askMessageConfirm("USD");
                    }
                    else if (currencyComboBox.SelectedIndex == 2)
                    {
                        askMessageConfirm("EUR");
                    }

                }
                else
                {
                    failureMessage += "Выберите валюту\n";
                    error = true;
                }
            }
            if (accountsTypeComboBox.SelectedIndex < 0)
            {
                failureMessage += "Выберите тип счёта\n";
                error = true;
            }
            if (currencyComboBox.SelectedIndex < 0)
            {
                failureMessage += "Выберите валюту\n";
                error = true;
            }
            if (accountsTypeComboBox.SelectedIndex == 1)
            {
                if (secondOwnerTextBox.Text == "")
                {
                    failureMessage += "Поле почты пусто\n";
                    error = true;
                }
                else if (!Regex.IsMatch(secondOwnerTextBox.Text, @"^[a-zA-Z0-9_.+-]+@gmail\.com$"))
                {
                    failureMessage += "Почта должна заканчиваться на @gmail.com\n";
                    error = true;
                }
                else if (!secondOwnerTextBox.Text.EndsWith("@gmail.com"))
                {
                    failureMessage += "Почта должна заканчиваться на @gmail.com\n";
                    error = true;
                }
                else
                {
                    if (!Tools.checkEmailExistence(secondOwnerTextBox.Text))
                    {
                        failureMessage += "Такого пользователя не существует\n";
                        error = true;
                    }
                    if (secondOwnerTextBox.Text == Program.userEmail)
                    {
                        failureMessage += "Нельзя быть двумя владельцами одновременно\n";
                        error = true;
                    }
                }
                if (confirmationComboBox.SelectedIndex < 0)
                {
                    failureMessage += "Выберите тип подтверждения\n";
                    error = true;
                }
                if (!error)
                {
                    //askMessageConfirm();
                }
            }


            if (error)
            {
                showFailureMessage(failureMessage);
                failureMessage = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string number = row.Cells[1].Value.ToString();
                Tools.updateMoney(number);
                MessageBox.Show("Средства добавлены");
                List<BancAccount> accounts = Tools.getAllAccount(Program.userID);
                dataGridView1.DataSource = accounts;
            }

            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string number = row.Cells[1].Value.ToString();
                askBlockConfirm(number);
            }
        }
    }
}
