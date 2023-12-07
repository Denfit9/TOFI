namespace TOFIiBank
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.registerLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.documentComboBox = new System.Windows.Forms.ComboBox();
            this.registerAccountButton = new System.Windows.Forms.Button();
            this.documentLabel = new System.Windows.Forms.Label();
            this.documentErrorLabel = new System.Windows.Forms.Label();
            this.passwordRepeatError = new System.Windows.Forms.Label();
            this.passwordRepeatLabel = new System.Windows.Forms.Label();
            this.passwordRepeatTextBox = new System.Windows.Forms.TextBox();
            this.nameError = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameError = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicError = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.emailCodeError = new System.Windows.Forms.Label();
            this.emailCodeLabel = new System.Windows.Forms.Label();
            this.emailCodeTextBox = new System.Windows.Forms.TextBox();
            this.documentNumberError = new System.Windows.Forms.Label();
            this.documentNumberLabel = new System.Windows.Forms.Label();
            this.documentNumberTextBox = new System.Windows.Forms.TextBox();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.emailCodeLogin = new System.Windows.Forms.Label();
            this.emailCodeLoginTextBox = new System.Windows.Forms.TextBox();
            this.emailCodeLoginError = new System.Windows.Forms.Label();
            this.sendEmailLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(504, 12);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(603, 73);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Добро пожаловать на страницу входа.\r\nПожалуйста введите свои данные для входа или" +
    " нажмите на кнопку регистрации, \r\nчтобы создать новый аккаунт\r\n";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(610, 110);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(411, 30);
            this.emailTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(605, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Почта";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(605, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(610, 188);
            this.passwordTextBox.MaxLength = 100;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(411, 30);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(737, 516);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(166, 37);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(737, 604);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(166, 37);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(610, 143);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(11, 18);
            this.emailErrorLabel.TabIndex = 7;
            this.emailErrorLabel.Text = "l";
            this.emailErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(610, 221);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(11, 18);
            this.passwordErrorLabel.TabIndex = 8;
            this.passwordErrorLabel.Text = "l";
            this.passwordErrorLabel.Visible = false;
            // 
            // registerLabel
            // 
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.IsDerivedStyle = true;
            this.registerLabel.Location = new System.Drawing.Point(493, 9);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(603, 76);
            this.registerLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.registerLabel.StyleManager = null;
            this.registerLabel.TabIndex = 9;
            this.registerLabel.Text = "Страница регистрации\r\nПожалуйста введите все свои данные, чтобы зарегистрироватьс" +
    "я\r\n";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.registerLabel.ThemeAuthor = "Narwin";
            this.registerLabel.ThemeName = "MetroLite";
            this.registerLabel.Visible = false;
            // 
            // documentComboBox
            // 
            this.documentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentComboBox.FormattingEnabled = true;
            this.documentComboBox.Items.AddRange(new object[] {
            "Паспорт",
            "Вид на жительство"});
            this.documentComboBox.Location = new System.Drawing.Point(610, 350);
            this.documentComboBox.Name = "documentComboBox";
            this.documentComboBox.Size = new System.Drawing.Size(411, 33);
            this.documentComboBox.TabIndex = 10;
            this.documentComboBox.Visible = false;
            // 
            // registerAccountButton
            // 
            this.registerAccountButton.Location = new System.Drawing.Point(610, 799);
            this.registerAccountButton.Name = "registerAccountButton";
            this.registerAccountButton.Size = new System.Drawing.Size(166, 37);
            this.registerAccountButton.TabIndex = 11;
            this.registerAccountButton.Text = "Зарегистрироваться";
            this.registerAccountButton.UseVisualStyleBackColor = true;
            this.registerAccountButton.Visible = false;
            this.registerAccountButton.Click += new System.EventHandler(this.registerAccountButton_Click);
            // 
            // documentLabel
            // 
            this.documentLabel.AutoSize = true;
            this.documentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentLabel.Location = new System.Drawing.Point(611, 322);
            this.documentLabel.Name = "documentLabel";
            this.documentLabel.Size = new System.Drawing.Size(110, 25);
            this.documentLabel.TabIndex = 12;
            this.documentLabel.Text = "Документ";
            this.documentLabel.Visible = false;
            // 
            // documentErrorLabel
            // 
            this.documentErrorLabel.AutoSize = true;
            this.documentErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.documentErrorLabel.Location = new System.Drawing.Point(610, 384);
            this.documentErrorLabel.Name = "documentErrorLabel";
            this.documentErrorLabel.Size = new System.Drawing.Size(11, 18);
            this.documentErrorLabel.TabIndex = 13;
            this.documentErrorLabel.Text = "l";
            this.documentErrorLabel.Visible = false;
            this.documentErrorLabel.Click += new System.EventHandler(this.documentErrorLabel_Click);
            // 
            // passwordRepeatError
            // 
            this.passwordRepeatError.AutoSize = true;
            this.passwordRepeatError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRepeatError.ForeColor = System.Drawing.Color.Red;
            this.passwordRepeatError.Location = new System.Drawing.Point(610, 301);
            this.passwordRepeatError.Name = "passwordRepeatError";
            this.passwordRepeatError.Size = new System.Drawing.Size(11, 18);
            this.passwordRepeatError.TabIndex = 16;
            this.passwordRepeatError.Text = "l";
            this.passwordRepeatError.Visible = false;
            // 
            // passwordRepeatLabel
            // 
            this.passwordRepeatLabel.AutoSize = true;
            this.passwordRepeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRepeatLabel.Location = new System.Drawing.Point(605, 240);
            this.passwordRepeatLabel.Name = "passwordRepeatLabel";
            this.passwordRepeatLabel.Size = new System.Drawing.Size(185, 25);
            this.passwordRepeatLabel.TabIndex = 15;
            this.passwordRepeatLabel.Text = "Повторите пароль";
            this.passwordRepeatLabel.Visible = false;
            // 
            // passwordRepeatTextBox
            // 
            this.passwordRepeatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRepeatTextBox.Location = new System.Drawing.Point(610, 268);
            this.passwordRepeatTextBox.MaxLength = 100;
            this.passwordRepeatTextBox.Name = "passwordRepeatTextBox";
            this.passwordRepeatTextBox.PasswordChar = '*';
            this.passwordRepeatTextBox.Size = new System.Drawing.Size(411, 30);
            this.passwordRepeatTextBox.TabIndex = 14;
            this.passwordRepeatTextBox.Visible = false;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(613, 539);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(11, 18);
            this.nameError.TabIndex = 19;
            this.nameError.Text = "l";
            this.nameError.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(608, 478);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 25);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "Имя";
            this.nameLabel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(610, 506);
            this.nameTextBox.MaxLength = 100;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(411, 30);
            this.nameTextBox.TabIndex = 17;
            this.nameTextBox.Visible = false;
            // 
            // surnameError
            // 
            this.surnameError.AutoSize = true;
            this.surnameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameError.ForeColor = System.Drawing.Color.Red;
            this.surnameError.Location = new System.Drawing.Point(613, 619);
            this.surnameError.Name = "surnameError";
            this.surnameError.Size = new System.Drawing.Size(11, 18);
            this.surnameError.TabIndex = 23;
            this.surnameError.Text = "l";
            this.surnameError.Visible = false;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(614, 558);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(103, 25);
            this.surnameLabel.TabIndex = 22;
            this.surnameLabel.Text = "Фамилия";
            this.surnameLabel.Visible = false;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(610, 586);
            this.surnameTextBox.MaxLength = 100;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(411, 30);
            this.surnameTextBox.TabIndex = 21;
            this.surnameTextBox.Visible = false;
            // 
            // patronymicError
            // 
            this.patronymicError.AutoSize = true;
            this.patronymicError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicError.ForeColor = System.Drawing.Color.Red;
            this.patronymicError.Location = new System.Drawing.Point(613, 701);
            this.patronymicError.Name = "patronymicError";
            this.patronymicError.Size = new System.Drawing.Size(11, 18);
            this.patronymicError.TabIndex = 26;
            this.patronymicError.Text = "l";
            this.patronymicError.Visible = false;
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicLabel.Location = new System.Drawing.Point(611, 640);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(104, 25);
            this.patronymicLabel.TabIndex = 25;
            this.patronymicLabel.Text = "Отчество";
            this.patronymicLabel.Visible = false;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicTextBox.Location = new System.Drawing.Point(610, 668);
            this.patronymicTextBox.MaxLength = 100;
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(411, 30);
            this.patronymicTextBox.TabIndex = 24;
            this.patronymicTextBox.Visible = false;
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.FlatAppearance.BorderSize = 0;
            this.backToLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLoginButton.Image = global::TOFIiBank.Properties.Resources.backbutton11;
            this.backToLoginButton.Location = new System.Drawing.Point(12, 12);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(51, 56);
            this.backToLoginButton.TabIndex = 27;
            this.backToLoginButton.UseVisualStyleBackColor = true;
            this.backToLoginButton.Visible = false;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // emailCodeError
            // 
            this.emailCodeError.AutoSize = true;
            this.emailCodeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCodeError.ForeColor = System.Drawing.Color.Red;
            this.emailCodeError.Location = new System.Drawing.Point(613, 778);
            this.emailCodeError.Name = "emailCodeError";
            this.emailCodeError.Size = new System.Drawing.Size(11, 18);
            this.emailCodeError.TabIndex = 30;
            this.emailCodeError.Text = "l";
            this.emailCodeError.Visible = false;
            this.emailCodeError.Click += new System.EventHandler(this.label4_Click);
            // 
            // emailCodeLabel
            // 
            this.emailCodeLabel.AutoSize = true;
            this.emailCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCodeLabel.Location = new System.Drawing.Point(608, 719);
            this.emailCodeLabel.Name = "emailCodeLabel";
            this.emailCodeLabel.Size = new System.Drawing.Size(126, 25);
            this.emailCodeLabel.TabIndex = 29;
            this.emailCodeLabel.Text = "Код с почты";
            this.emailCodeLabel.Visible = false;
            this.emailCodeLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // emailCodeTextBox
            // 
            this.emailCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCodeTextBox.Location = new System.Drawing.Point(610, 745);
            this.emailCodeTextBox.MaxLength = 100;
            this.emailCodeTextBox.Name = "emailCodeTextBox";
            this.emailCodeTextBox.Size = new System.Drawing.Size(411, 30);
            this.emailCodeTextBox.TabIndex = 28;
            this.emailCodeTextBox.Visible = false;
            this.emailCodeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // documentNumberError
            // 
            this.documentNumberError.AutoSize = true;
            this.documentNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentNumberError.ForeColor = System.Drawing.Color.Red;
            this.documentNumberError.Location = new System.Drawing.Point(613, 460);
            this.documentNumberError.Name = "documentNumberError";
            this.documentNumberError.Size = new System.Drawing.Size(11, 18);
            this.documentNumberError.TabIndex = 33;
            this.documentNumberError.Text = "l";
            this.documentNumberError.Visible = false;
            // 
            // documentNumberLabel
            // 
            this.documentNumberLabel.AutoSize = true;
            this.documentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentNumberLabel.Location = new System.Drawing.Point(611, 402);
            this.documentNumberLabel.Name = "documentNumberLabel";
            this.documentNumberLabel.Size = new System.Drawing.Size(310, 25);
            this.documentNumberLabel.TabIndex = 32;
            this.documentNumberLabel.Text = "Номер документа (9 символов)";
            this.documentNumberLabel.Visible = false;
            // 
            // documentNumberTextBox
            // 
            this.documentNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentNumberTextBox.Location = new System.Drawing.Point(610, 430);
            this.documentNumberTextBox.MaxLength = 100;
            this.documentNumberTextBox.Name = "documentNumberTextBox";
            this.documentNumberTextBox.Size = new System.Drawing.Size(411, 30);
            this.documentNumberTextBox.TabIndex = 31;
            this.documentNumberTextBox.Visible = false;
            // 
            // sendMailButton
            // 
            this.sendMailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMailButton.Location = new System.Drawing.Point(825, 799);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(193, 37);
            this.sendMailButton.TabIndex = 34;
            this.sendMailButton.Text = "Отправить код";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Visible = false;
            this.sendMailButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailCodeLogin
            // 
            this.emailCodeLogin.AutoSize = true;
            this.emailCodeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCodeLogin.Location = new System.Drawing.Point(608, 239);
            this.emailCodeLogin.Name = "emailCodeLogin";
            this.emailCodeLogin.Size = new System.Drawing.Size(126, 25);
            this.emailCodeLogin.TabIndex = 35;
            this.emailCodeLogin.Text = "Код с почты";
            // 
            // emailCodeLoginTextBox
            // 
            this.emailCodeLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCodeLoginTextBox.Location = new System.Drawing.Point(610, 267);
            this.emailCodeLoginTextBox.MaxLength = 100;
            this.emailCodeLoginTextBox.Name = "emailCodeLoginTextBox";
            this.emailCodeLoginTextBox.Size = new System.Drawing.Size(411, 30);
            this.emailCodeLoginTextBox.TabIndex = 36;
            // 
            // emailCodeLoginError
            // 
            this.emailCodeLoginError.AutoSize = true;
            this.emailCodeLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCodeLoginError.ForeColor = System.Drawing.Color.Red;
            this.emailCodeLoginError.Location = new System.Drawing.Point(610, 301);
            this.emailCodeLoginError.Name = "emailCodeLoginError";
            this.emailCodeLoginError.Size = new System.Drawing.Size(11, 18);
            this.emailCodeLoginError.TabIndex = 37;
            this.emailCodeLoginError.Text = "l";
            this.emailCodeLoginError.Visible = false;
            // 
            // sendEmailLoginButton
            // 
            this.sendEmailLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendEmailLoginButton.Location = new System.Drawing.Point(737, 430);
            this.sendEmailLoginButton.Name = "sendEmailLoginButton";
            this.sendEmailLoginButton.Size = new System.Drawing.Size(166, 37);
            this.sendEmailLoginButton.TabIndex = 38;
            this.sendEmailLoginButton.Text = "Отправить код";
            this.sendEmailLoginButton.UseVisualStyleBackColor = true;
            this.sendEmailLoginButton.Click += new System.EventHandler(this.sendEmailLoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 930);
            this.Controls.Add(this.sendEmailLoginButton);
            this.Controls.Add(this.emailCodeLoginError);
            this.Controls.Add(this.emailCodeLoginTextBox);
            this.Controls.Add(this.emailCodeLogin);
            this.Controls.Add(this.sendMailButton);
            this.Controls.Add(this.documentNumberError);
            this.Controls.Add(this.documentNumberLabel);
            this.Controls.Add(this.documentNumberTextBox);
            this.Controls.Add(this.emailCodeError);
            this.Controls.Add(this.emailCodeLabel);
            this.Controls.Add(this.emailCodeTextBox);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.patronymicError);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.surnameError);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passwordRepeatError);
            this.Controls.Add(this.passwordRepeatLabel);
            this.Controls.Add(this.passwordRepeatTextBox);
            this.Controls.Add(this.documentErrorLabel);
            this.Controls.Add(this.documentLabel);
            this.Controls.Add(this.registerAccountButton);
            this.Controls.Add(this.documentComboBox);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.metroSetLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private MetroSet_UI.Controls.MetroSetLabel registerLabel;
        private System.Windows.Forms.ComboBox documentComboBox;
        private System.Windows.Forms.Button registerAccountButton;
        private System.Windows.Forms.Label documentLabel;
        private System.Windows.Forms.Label documentErrorLabel;
        private System.Windows.Forms.Label passwordRepeatError;
        private System.Windows.Forms.Label passwordRepeatLabel;
        private System.Windows.Forms.TextBox passwordRepeatTextBox;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label surnameError;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label patronymicError;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.Label emailCodeError;
        private System.Windows.Forms.Label emailCodeLabel;
        private System.Windows.Forms.TextBox emailCodeTextBox;
        private System.Windows.Forms.Label documentNumberError;
        private System.Windows.Forms.Label documentNumberLabel;
        private System.Windows.Forms.TextBox documentNumberTextBox;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.Label emailCodeLogin;
        private System.Windows.Forms.TextBox emailCodeLoginTextBox;
        private System.Windows.Forms.Label emailCodeLoginError;
        private System.Windows.Forms.Button sendEmailLoginButton;
    }
}

