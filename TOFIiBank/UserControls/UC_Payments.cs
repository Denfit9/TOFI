using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using TOFIiBank.Models;

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
            List<BancAccount> accounts = Tools.getAllAccount(Program.userID);
            foreach (BancAccount account in accounts)
            {
                comboBox1.Items.Add(account.accountNumber);
            }
            secondOwnerPasswordTextBox.PasswordChar = '*';

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BancAccount> accounts = Tools.getAllAccount(Program.userID);
            string currency = "";
            float sum = 0;
            string type = "";
            string approval = "";

            foreach (BancAccount account in accounts)
            {
                if (account.accountNumber == comboBox1.SelectedItem.ToString())
                {

                    currency = account.currency;
                    sum = account.balance;
                    type = account.bancAccountType.ToString();
                    if (type == "Двойной")
                    {
                        approval = Tools.getAccountApproval(Tools.getAccountIDS(comboBox1.SelectedItem.ToString()));
                    }

                }
            }
            if (approval == "password")
            {
                secondOwnerPassword.Visible = true;
                secondOwnerPasswordTextBox.Visible = true;
            }
            else
            {
                secondOwnerPassword.Visible = false;
                secondOwnerPasswordTextBox.Visible = false;

            }
            accountCurrency.Text = currency;
            sumLabel.Text = sum.ToString();
            accountType.Text = type;
        }

        private double getCoursesEUR()
        {
            string url = "https://open.er-api.com/v6/latest";

            double eurRate = 0;

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                // Десериализация JSON в объект
                dynamic data = JsonConvert.DeserializeObject(json);

                // Получение курсов валют
                eurRate = data.rates.EUR;

            }
            return eurRate;
        }

        private double getCoursesBYN()
        {
            string url = "https://open.er-api.com/v6/latest";

            double bynRate = 0;

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                // Десериализация JSON в объект
                dynamic data = JsonConvert.DeserializeObject(json);

                // Получение курсов валют
                bynRate = data.rates.BYN;
            }
            return bynRate;
        }

        public void showFailureMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        public void askTransferConfirmSingle(string summ)
        {
            DialogResult result = MessageBox.Show(
                "Подтвердить перевод на сумму " + summ + " на счёт " + textBox1.Text.ToString() + " ?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                int sel = comboBox1.SelectedIndex;
                Tools.updateMoneyTransfer(textBox1.Text.ToString(), comboBox1.Items[sel].ToString(), Convert.ToString(summ).Replace(',', '.'));
                MessageBox.Show("Перевод совершён");
                textBox1.Text = "";
                sumTextBox.Text = "";
                comboBox1.SelectedIndex = 0;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        public void askTransferConfirmJointPassword(string summ, int secondOwnerID)
        {
            DialogResult result = MessageBox.Show(
                "Подтвердить перевод на сумму " + summ + " на счёт " + textBox1.Text.ToString() + " ?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                int sel = comboBox1.SelectedIndex;
                Tools.updateMoneyTransfer(textBox1.Text.ToString(), comboBox1.Items[sel].ToString(), Convert.ToString(summ).Replace(',', '.'));
                MessageBox.Show("Перевод совершён");
                textBox1.Text = "";
                sumTextBox.Text = "";
                comboBox1.SelectedIndex = 0;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        public void askTransferConfirmJointNotification(string summ, int secondOwnerID)
        {
            DialogResult result = MessageBox.Show(
                "Подтвердить перевод на сумму " + summ + " на счёт " + textBox1.Text.ToString() + " ?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                int sel = comboBox1.SelectedIndex;
                Tools.updateMoneyTransferRequest(textBox1.Text.ToString(), comboBox1.Items[sel].ToString(), Convert.ToString(summ).Replace(',', '.'), secondOwnerID, Program.userID);
                MessageBox.Show("Запрос на перевод отправлен второму владельцу счёта");
                textBox1.Text = "";
                sumTextBox.Text = "";
                comboBox1.SelectedIndex = 0;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        public void askTransferConfirmSingleCurrencies(string summ, string summSended)
        {
            DialogResult result = MessageBox.Show(
                "Подтвердить перевод на сумму " + summ + " на счёт " + textBox1.Text.ToString() + " и с комиссией за конвертацию в 5%, где конечная сумма составит " + (Convert.ToDouble(summ) + Convert.ToDouble(summ) * 0.05) + "?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                int sel = comboBox1.SelectedIndex;
                Tools.updateMoneyTransferDifferentValues(textBox1.Text.ToString(), comboBox1.Items[sel].ToString(), Convert.ToString((Convert.ToDouble(summ) + Convert.ToDouble(summ) * 0.05)).Replace(',', '.'), summSended.Replace(',', '.'));
                MessageBox.Show("Перевод совершён");
                textBox1.Text = "";
                sumTextBox.Text = "";
                comboBox1.SelectedIndex = 0;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            int error = 0;
            float summ = 0;
            int sel = comboBox1.SelectedIndex;

            if (textBox1.Text == "")
            {
                errorMessage += "Выберите получателя\n";
                error++;
            }
            else if (!Tools.checkAccountExistenceS(textBox1.Text.ToString()) || Tools.checkAccountExistenceSOnline(textBox1.Text.ToString()))
            {
                errorMessage += "Счёта получателя не существует\n";
                error++;
            }
            else if (comboBox1.Items[sel].ToString() == textBox1.Text.ToString())
            {
                errorMessage += "Перевод должен производиться на другой счёт\n";
                error++;
            }

            if (!float.TryParse(sumTextBox.Text.Replace('.', ','), out summ))
            {
                errorMessage += "Введите сумму корректно\n";
                error++;
            }

            if (comboBox1.SelectedIndex < 0)
            {
                errorMessage += "Выберите счёт\n";
                error++;
            }

            if (comboBox1.SelectedIndex >= 0)
            {
                if (Convert.ToDouble(summ) > Convert.ToDouble(sumLabel.Text.ToString()))
                {
                    errorMessage += "Недостаточно средств\n";
                    error++;
                }
            }
            if (secondOwnerPassword.Visible == true)
            {
                int secondOwnerID = 0;
                string str = comboBox1.Items[sel].ToString();
                List<BancAccount> accountSender3 = Tools.getOneAccountJoint(comboBox1.Items[sel].ToString());

                if (Program.userID != Convert.ToInt32(accountSender3[0].secondOwnerId))
                {
                    secondOwnerID = Convert.ToInt32(accountSender3[0].secondOwnerId);
                }
                else
                {
                    secondOwnerID = Convert.ToInt32(accountSender3[0].userID);
                }
                if (secondOwnerPasswordTextBox.Text.ToString() != Tools.getUserPassword(secondOwnerID))
                {
                    errorMessage += "Неправильный пароль второго владельца\n";
                    error++;
                }
            }

            if (error > 0)
            {
                showFailureMessage(errorMessage);
            }
            else
            {
                List<BancAccount> account = Tools.getOneAccount(textBox1.Text.ToString());
                if (account.Count == 0)
                {
                    account = Tools.getOneAccountJoint(textBox1.Text.ToString());
                }
                List<BancAccount> accountSender = Tools.getOneAccount(comboBox1.Items[sel].ToString());
                
                List<BancAccount> accountReceiver = Tools.getOneAccount(textBox1.Text.ToString());
                if (accountReceiver.Count == 0)
                {
                    accountReceiver = Tools.getOneAccountJoint(textBox1.Text.ToString());
                }
                if (accountType.Text.ToString() == "Одиночный")
                {
                    if (account[0].currency == accountCurrency.Text.ToString())
                    {
                        askTransferConfirmSingle(Convert.ToString(summ));
                        //Tools.updateMoneyTransfer(textBox1.Text.ToString(), comboBox1.Items[sel].ToString(), Convert.ToString(summ).Replace(',', '.'));
                    }
                    else if (accountCurrency.Text.ToString() == "USD")
                    {
                        if (account[0].currency == "BYN")
                        {
                            double sumInByn = Math.Round(Convert.ToDouble(summ) * getCoursesBYN(), 3);
                            if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                            {
                                MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                            }
                            else
                            {
                                askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInByn));
                            }

                        }
                        else if (account[0].currency == "EUR")
                        {
                            double sumInEUR = Math.Round(Convert.ToDouble(summ) * getCoursesEUR(), 3);
                            if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                            {
                                MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                            }
                            else
                            {
                                askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInEUR));
                            }
                        }

                    }
                    else if (accountCurrency.Text.ToString() == "BYN")
                    {
                        if (account[0].currency == "USD")
                        {
                            double sumInUSD = Math.Round(Convert.ToDouble(summ) * 1 / getCoursesBYN(), 3);
                            if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                            {
                                MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                            }
                            else
                            {
                                askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInUSD));
                            }

                        }
                        else if (account[0].currency == "EUR")
                        {
                            double sumInEUR = Math.Round(Convert.ToDouble(summ) * (1 / getCoursesBYN() / getCoursesEUR()), 3);
                            if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                            {
                                MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                            }
                            else
                            {
                                askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInEUR));
                            }
                        }
                    }
                    else if (accountCurrency.Text.ToString() == "EUR")
                    {
                        if (account[0].currency == "USD")
                        {
                            double sumInUSD = Math.Round(Convert.ToDouble(summ) * 1 / getCoursesEUR(), 3);
                            if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                            {
                                MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                            }
                            else
                            {
                                askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInUSD));
                            }

                        }
                        else if (account[0].currency == "BYN")
                        {
                            double sumInEUR = Math.Round(Convert.ToDouble(summ) * ((1 / getCoursesEUR()) / (1 / getCoursesBYN())), 3);
                            if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                            {
                                MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                            }
                            else
                            {
                                askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInEUR));
                            }
                        }
                    }
                }

                if (accountType.Text.ToString() == "Двойной")
                {
                    List<BancAccount> accountSender2 = Tools.getOneAccountJoint(comboBox1.Items[sel].ToString());
                    List<BancAccount> accountSender3 = Tools.getOneAccountJoint(comboBox1.Items[sel].ToString());
                    if (Tools.getAccountApproval(Convert.ToInt32(accountSender3[0].bancAccountID)) == "nothing")
                    {
                        if (accountReceiver[0].currency == accountCurrency.Text.ToString())
                        {
                            askTransferConfirmSingle(Convert.ToString(summ));
                            //Tools.updateMoneyTransfer(textBox1.Text.ToString(), comboBox1.Items[sel].ToString(), Convert.ToString(summ).Replace(',', '.'));
                        }
                        else if (accountCurrency.Text.ToString() == "USD")
                        {
                            if (accountReceiver[0].currency == "BYN")
                            {
                                double sumInByn = Math.Round(Convert.ToDouble(summ) * getCoursesBYN(), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInByn));
                                }

                            }
                            else if (accountReceiver[0].currency == "EUR")
                            {
                                double sumInEUR = Math.Round(Convert.ToDouble(summ) * getCoursesEUR(), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInEUR));
                                }
                            }

                        }
                        else if (accountCurrency.Text.ToString() == "BYN")
                        {
                            if (accountReceiver[0].currency == "USD")
                            {
                                double sumInUSD = Math.Round(Convert.ToDouble(summ) * 1 / getCoursesBYN(), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInUSD));
                                }

                            }
                            else if (accountReceiver[0].currency == "EUR")
                            {
                                double sumInEUR = Math.Round(Convert.ToDouble(summ) * (1 / getCoursesBYN() / getCoursesEUR()), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInEUR));
                                }
                            }
                        }
                        else if (accountCurrency.Text.ToString() == "EUR")
                        {
                            if (accountReceiver[0].currency == "USD")
                            {
                                double sumInUSD = Math.Round(Convert.ToDouble(summ) * 1 / getCoursesEUR(), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInUSD));
                                }

                            }
                            else if (accountReceiver[0].currency == "BYN")
                            {
                                double sumInEUR = Math.Round(Convert.ToDouble(summ) * ((1 / getCoursesEUR()) / (1 / getCoursesBYN())), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInEUR));
                                }
                            }
                        }
                    }
                    else if (Tools.getAccountApproval(Convert.ToInt32(accountSender3[0].bancAccountID)) == "password")
                    {
                        int secondOwnerID = 0;

                        if (Program.userID != Convert.ToInt32(accountSender2[0].secondOwnerId))
                        {
                            secondOwnerID = Convert.ToInt32(accountSender2[0].secondOwnerId);
                        }
                        else
                        {
                            secondOwnerID = Convert.ToInt32(accountSender2[0].userID);
                        }

                        if (accountReceiver[0].currency == accountCurrency.Text.ToString())
                        {
                            askTransferConfirmSingle(Convert.ToString(summ));
                            //Tools.updateMoneyTransfer(textBox1.Text.ToString(), comboBox1.Items[sel].ToString(), Convert.ToString(summ).Replace(',', '.'));
                        }
                        else if (accountCurrency.Text.ToString() == "USD")
                        {
                            if (accountReceiver[0].currency == "BYN")
                            {
                                double sumInByn = Math.Round(Convert.ToDouble(summ) * getCoursesBYN(), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInByn));
                                }

                            }
                            else if (accountReceiver[0].currency == "EUR")
                            {
                                double sumInEUR = Math.Round(Convert.ToDouble(summ) * getCoursesEUR(), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInEUR));
                                }
                            }

                        }
                        else if (accountCurrency.Text.ToString() == "BYN")
                        {
                            if (accountReceiver[0].currency == "USD")
                            {
                                double sumInUSD = Math.Round(Convert.ToDouble(summ) * 1 / getCoursesBYN(), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInUSD));
                                }

                            }
                            else if (accountReceiver[0].currency == "EUR")
                            {
                                double sumInEUR = Math.Round(Convert.ToDouble(summ) * (1 / getCoursesBYN() / getCoursesEUR()), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInEUR));
                                }
                            }
                        }
                        else if (accountCurrency.Text.ToString() == "EUR")
                        {
                            if (accountReceiver[0].currency == "USD")
                            {
                                double sumInUSD = Math.Round(Convert.ToDouble(summ) * 1 / getCoursesEUR(), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInUSD));
                                }

                            }
                            else if (accountReceiver[0].currency == "BYN")
                            {
                                double sumInEUR = Math.Round(Convert.ToDouble(summ) * ((1 / getCoursesEUR()) / (1 / getCoursesBYN())), 3);
                                if (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05) > Convert.ToDouble(sumLabel.Text.ToString()))
                                {
                                    MessageBox.Show("Недостаточно средств для покрытия комиссии (5%) в " + (Convert.ToDouble(summ) + (Convert.ToDouble(summ) * 0.05)));
                                }
                                else
                                {
                                    askTransferConfirmSingleCurrencies(Convert.ToString(summ), Convert.ToString(sumInEUR));
                                }
                            }
                        }
                    }
                    else if (Tools.getAccountApproval(Convert.ToInt32(accountSender3[0].bancAccountID)) == "notification")
                    {
                        int secondOwnerID = 0;

                        if (Program.userID != Convert.ToInt32(accountSender2[0].secondOwnerId))
                        {
                            secondOwnerID = Convert.ToInt32(accountSender2[0].secondOwnerId);
                        }
                        else
                        {
                            secondOwnerID = Convert.ToInt32(accountSender2[0].userID);
                        }
                        if (accountReceiver[0].currency == accountCurrency.Text.ToString())
                        {
                            askTransferConfirmJointNotification(Convert.ToString(summ), secondOwnerID);
                            
                        }
                        else
                        {
                            MessageBox.Show("Для данного счёта операции в разных валютах недоступны");
                        }

                    }
                }

            }
        }
    }
}
