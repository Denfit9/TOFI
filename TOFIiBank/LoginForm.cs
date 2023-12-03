using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI;

namespace TOFIiBank
{
    public partial class Login : Form
    {
        int state = 0;


        public Login()
        {

            InitializeComponent();
            if(state != 0)
            {
                loginButton.Visible = false;
                registerLabel.Visible = true;
                registerButton.Visible = false;
                registerAccountButton.Visible = true;
                documentLabel.Visible = true;
                documentComboBox.Visible = true;
                passwordRepeatLabel.Visible = true;
                passwordRepeatTextBox.Visible = true;
                nameLabel.Visible = true;
                nameTextBox.Visible = true;
                surnameLabel.Visible = true;
                surnameTextBox.Visible = true;
                patronymicLabel.Visible = true;
                patronymicTextBox.Visible = true;
                backToLoginButton.Visible = true;
                documentNumberLabel.Visible = true;
                documentNumberTextBox.Visible = true;
            }
            else 
            {
                loginButton.Visible = true;
                registerLabel.Visible = false;
                registerButton.Visible = true;
                registerAccountButton.Visible = false;
                documentLabel.Visible = false;
                documentComboBox.Visible = false;
                passwordRepeatLabel.Visible = false;
                passwordRepeatTextBox.Visible = false;
                nameLabel.Visible = false;
                nameTextBox.Visible = false;
                surnameLabel.Visible = false;
                surnameTextBox.Visible = false;
                patronymicLabel.Visible = false;
                patronymicTextBox.Visible = false;
                backToLoginButton.Visible = false;
                emailCodeLabel.Visible = false;
                emailCodeTextBox.Visible = false;
                documentNumberLabel.Visible = false;
                documentNumberTextBox.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckSimilarPasswords(ref bool error)
        {
            if (passwordTextBox.Text != passwordRepeatTextBox.Text)
            {
                passwordErrorLabel.Text = "Пароли не совпадают";
                passwordErrorLabel.Visible = true;
                passwordRepeatError.Text = "Пароли не совпадают";
                passwordRepeatError.Visible = true;
                error = true;
            }
            else
            {
                passwordErrorLabel.Visible = false;
                passwordRepeatError.Visible = false;
                error = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if(emailTextBox.Text=="") 
            {
                emailErrorLabel.Text = "Empty email error";
                emailErrorLabel.Visible = true;
            }
            if(passwordTextBox.Text=="") 
            {
                passwordErrorLabel.Text = "Wrong password";
                passwordErrorLabel.Visible = true;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            state = 1;
            loginButton.Visible = false;
            registerLabel.Visible = true;
            registerButton.Visible = false;
            registerAccountButton.Visible = true;
            documentLabel.Visible = true;
            documentComboBox.Visible = true;
            passwordRepeatLabel.Visible = true;
            passwordRepeatTextBox.Visible = true;   
            nameLabel.Visible = true;   
            nameTextBox.Visible = true; 
            surnameLabel.Visible = true;
            surnameTextBox.Visible = true;
            patronymicLabel.Visible = true;
            patronymicTextBox.Visible = true;
            backToLoginButton.Visible = true;
            documentNumberLabel.Visible = true;
            documentNumberTextBox.Visible = true;
            // RegisterForm registerForm = new RegisterForm();
            //registerForm.Show();
            //Close();
        }

        private void registerAccountButton_Click(object sender, EventArgs e)
        {
            string pattern = @"^[A-Z]{2}\d{7}$";

            bool error = false;
            string document = "";

            if (documentNumberTextBox.Text.Length < 9)
            {
                documentNumberError.Text = "Номер документа состоит из девяти символов";
                documentNumberError.Visible = true;
                error = true;
            }
            else if(!Regex.IsMatch(documentNumberTextBox.Text, pattern))
            {
                documentNumberError.Text = "Документ не валиден";
                documentNumberError.Visible = true;
                error = true;
            }
            else
            {
                documentNumberError.Visible = false;
                error = false;
            }

            if (emailTextBox.Text == "")
            {
                emailErrorLabel.Text = "Пустое поле почты";
                emailErrorLabel.Visible = true;
                error = true;
            }
            else if (!emailTextBox.Text.EndsWith("@gmail.com"))
            {
                emailErrorLabel.Text = "почта должна заканчиваться на @gmail.com";
                emailErrorLabel.Visible = true;
                error = true;
            }
            else
            {
                emailErrorLabel.Visible = false;
                error = false;
            }
            if (passwordTextBox.Text == "")
            {
                passwordErrorLabel.Text = "Пустое поле пароля";
                passwordErrorLabel.Visible = true;
                error = true;
            }
            else if (passwordTextBox.Text.Length <= 9)
            {
                passwordErrorLabel.Text = "Пароль должен быть длиннее 9 символов";
                passwordErrorLabel.Visible = true;
                error = true;
            }
            else if (!Regex.IsMatch(passwordTextBox.Text, @"^[a-zA-Z0-9]+$"))
            {
                passwordErrorLabel.Text = "Пароль должен содержать только английские символы";
                passwordErrorLabel.Visible = true;
                error = true;
            }
            else
            {
                CheckSimilarPasswords(ref error);
            }
            if (passwordRepeatTextBox.Text == "")
            {
                passwordRepeatError.Text = "Пустое поле пароля";
                passwordRepeatError.Visible = true;
                error = true;
            }
            else if (passwordRepeatTextBox.Text.Length <= 9)
            {
                passwordRepeatError.Text = "Пароль должен быть длиннее 9 символов";
                passwordRepeatError.Visible = true;
                error = true;
            }
            else if (!Regex.IsMatch(passwordRepeatTextBox.Text, @"^[a-zA-Z0-9]+$"))
            {
                passwordRepeatError.Text = "Пароль должен содержать только английские символы";
                passwordRepeatError.Visible = true;
                error = true;
            }
            else
            {
                CheckSimilarPasswords(ref error);
            }
            if (documentComboBox.SelectedIndex !=-1)
            {
                documentErrorLabel.Visible = false; 
                error = false;
                if(documentComboBox.SelectedIndex == 0)
                {
                    document = "Passport";
                }
                else
                {
                    document = "Resident card";
                }
            }
            else 
            { 
                documentErrorLabel.Visible = true;
                documentErrorLabel.Text = "Выберите тип документа";
                error = true; 
            }
            if (nameTextBox.Text.Length < 2)
            {
                nameError.Text = "Поле имени не должно быть пустым или меньше двух символов";
                nameError.Visible = true;
                error = true;
            }
            else if(!Regex.IsMatch(nameTextBox.Text, @"^[a-zA-Z]+$"))
            {
                nameError.Text = "Пожалуйста пишите имя латиницей как в паспорте";
                nameError.Visible = true;
                error = true;
            }
            else
            {
                nameError.Visible = false;
                error = false;
            }

            if (surnameTextBox.Text.Length < 2)
            {
                surnameError.Text = "Поле фамилии не должно быть пустым или меньше двух символов";
                surnameError.Visible = true;
                error = true;
            }
            else if (!Regex.IsMatch(surnameTextBox.Text, @"^[a-zA-Z]+$"))
            {
                surnameError.Text = "Пожалуйста пишите фимилию латиницей как в паспорте";
                surnameError.Visible = true;
                error = true;
            }
            else
            {
                surnameError.Visible = false;
                error = false;
            }

            if (patronymicTextBox.Text.Length < 2)
            {
                patronymicError.Text = "Поле отчества не должно быть пустым или меньше двух символов";
                patronymicError.Visible = true;
                error = true;
            }
            else if (!Regex.IsMatch(patronymicTextBox.Text, @"^[a-zA-Z]+$"))
            {
                patronymicError.Text = "Пожалуйста пишите отчество латиницей как в паспорте";
                patronymicError.Visible = true;
                error = true;
            }
            else
            {
                patronymicError.Visible = false;
                error = false;
            }

            if (!error)
            {
                emailCodeLabel.Visible = true;
                emailCodeTextBox.Visible = true;
            }
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            state = 0;
            loginButton.Visible = true;
            registerLabel.Visible = false;
            registerButton.Visible = true;
            registerAccountButton.Visible = false;
            documentLabel.Visible = false;
            documentComboBox.Visible = false;
            passwordRepeatLabel.Visible = false;
            passwordRepeatTextBox.Visible = false;
            documentNumberLabel.Visible = false;
            documentNumberTextBox.Visible = false;
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            surnameLabel.Visible = false;
            surnameTextBox.Visible = false;
            patronymicLabel.Visible = false;
            patronymicTextBox.Visible = false;
            backToLoginButton.Visible = false;
            emailCodeLabel.Visible = false;
            emailCodeTextBox.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
