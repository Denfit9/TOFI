﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Text.RegularExpressions;
using TOFIiBank.Models;

namespace TOFIiBank
{
    public static class Tools
    {

        public static void sendConfirmationCode(string emailTo, string body)
        {
            var mail = Mail.CreateMail("TofiBank", "TofiBankk@gmail.com", emailTo, "Код подтверждения", body);
            Mail.SendMail("smtp.gmail.com", 587, "TofiBankk@gmail.com", "uqfnlmylqpffivpl", mail);
        }

        public static bool checkEmailExistence(string email)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT EXISTS(SELECT * FROM user WHERE email = '" + email + "');";
            cmd.CommandText = checkEmail;
            object exists = cmd.ExecuteScalar();
            conn.Close();

            if (Convert.ToInt32(exists) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool checkDocumentExistence(string documentNumber)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT EXISTS(SELECT * FROM Document WHERE ident_number = '" + documentNumber + "');";
            cmd.CommandText = checkEmail;
            object exists = cmd.ExecuteScalar();
            conn.Close();

            if (Convert.ToInt32(exists) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkUserExistence(string email, string password)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT EXISTS(SELECT * FROM user WHERE email = '" + email + "' and password ='" + password + "');";
            cmd.CommandText = checkEmail;
            object exists = cmd.ExecuteScalar();
            conn.Close();

            if (Convert.ToInt32(exists) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkAccountExistence(long number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT EXISTS(SELECT * FROM bancAccount WHERE account_number = '" + Convert.ToString(number) + "');";
            cmd.CommandText = checkEmail;
            object exists = cmd.ExecuteScalar();
            conn.Close();

            if (Convert.ToInt32(exists) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkAccountExistenceS(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT EXISTS(SELECT * FROM bancAccount WHERE account_number = '" + number + "');";
            cmd.CommandText = checkEmail;
            object exists = cmd.ExecuteScalar();
            conn.Close();

            if (Convert.ToInt32(exists) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkAccountExistenceSOnline(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT EXISTS(SELECT * FROM bancAccount WHERE account_number = '" + number + "' and NOT status = 'online');";
            cmd.CommandText = checkEmail;
            object exists = cmd.ExecuteScalar();
            conn.Close();

            if (Convert.ToInt32(exists) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkSessionExistence(int userID)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkSession = "SELECT EXISTS(SELECT * FROM sessions WHERE userID = " + userID + ");";
            cmd.CommandText = checkSession;
            object exists = cmd.ExecuteScalar();
            conn.Close();

            if (Convert.ToInt32(exists) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int getUserID(string email, string password)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT userID FROM user WHERE email = '" + email + "' and password ='" + password + "';";
            cmd.CommandText = checkEmail;
            int userID = (int)cmd.ExecuteScalar();
            conn.Close();

            return userID;
        }

        public static int getUserID(string email)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT userID FROM user WHERE email = '" + email + "';";
            cmd.CommandText = checkEmail;
            int userID = (int)cmd.ExecuteScalar();
            conn.Close();

            return userID;
        }

        public static string getUserEmail(int userID)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT email FROM user WHERE userID =" + userID + ";";
            cmd.CommandText = checkEmail;
            string userEmail = (string)cmd.ExecuteScalar();
            conn.Close();

            return userEmail;
        }

        public static string getUserPassword(int userID)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT password FROM user WHERE userID =" + userID + ";";
            cmd.CommandText = checkEmail;
            string userEmail = (string)cmd.ExecuteScalar();
            conn.Close();

            return userEmail;
        }

        public static int getAccountID(long number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT banc_accoutID FROM bancAccount WHERE account_number = '" + number + "';";
            cmd.CommandText = checkEmail;
            int accountID = (int)cmd.ExecuteScalar();
            conn.Close();

            return accountID;
        }



        public static int getAccountIDS(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT banc_accoutID FROM bancAccount WHERE account_number = '" + number + "';";
            cmd.CommandText = checkEmail;
            int accountID = (int)cmd.ExecuteScalar();
            conn.Close();

            return accountID;
        }

        public static int getAccountBalance(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT balance FROM bancAccount WHERE account_number = '" + number + "';";
            cmd.CommandText = checkEmail;
            int accountID = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return accountID;
        }

        public static int getAccountFirstOwnerS(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT userID FROM bancAccount WHERE account_number = '" + number + "';";
            cmd.CommandText = checkEmail;
            int accountID = (int)cmd.ExecuteScalar();
            conn.Close();

            return accountID;
        }

        public static int openCreditsCount(int userID)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT COUNT(*) FROM credit WHERE userID = " + userID + " and status = 'opened';";
            cmd.CommandText = checkEmail;
            int accountID = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return accountID;
        }

        public static string getAccountNumber(int accountID)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkNumber = "SELECT account_number FROM bancAccount WHERE banc_accoutID = '" + accountID + "';";
            cmd.CommandText = checkNumber;
            string accountNumber = (string)cmd.ExecuteScalar();
            conn.Close();

            return accountNumber;
        }

        public static string getAccountApproval(int accountID)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkEmail = "SELECT approval_type FROM bancAccount WHERE banc_accoutID = '" + accountID + "';";
            cmd.CommandText = checkEmail;
            string accountApproval = (string)cmd.ExecuteScalar();
            conn.Close();

            return accountApproval;
        }

        public static void createSession(int userId)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string createSession = "Insert into sessions (userID) " + " values(" + userId + ");";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = createSession;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void deleteSession(int userId)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT sessionID FROM sessions WHERE userID = " + userId + ";";
            cmd.CommandText = checkID;
            int sessionID = (int)cmd.ExecuteScalar();
            string createSession = "Delete from sessions where sessionID = " + sessionID + ";";
            cmd.CommandText = createSession;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void createTransactionSys(float sum, string transactionType, int bancAccoutId, int receiverId, string transactionMessage, string transactionStatus)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            DateTime datetime = DateTime.Now;
            string createTransaction = "Insert into transaction (summ, date, transaction_type,banc_accountID, banc_accountID_receiver, transaction_message, transaction_status) " + " values(" + sum + ",'" + datetime.ToString("yyyy-MM-dd H:mm:ss") + "','" + transactionType + "', " + bancAccoutId + " , " + receiverId + ", '" + transactionMessage + "', '" + transactionStatus + "');";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = createTransaction;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static void createTransaction(string sum, string transactionType, int bancAccoutId, int receiverId, string transactionMessage, string transactionStatus)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            DateTime datetime = DateTime.Now;
            string createTransaction = "Insert into transaction (summ, date, transaction_type,banc_accountID, banc_accountID_receiver, transaction_message, transaction_status) " + " values(" + sum + ",'" + datetime.ToString("yyyy-MM-dd H:mm:ss") + "','" + transactionType + "', " + bancAccoutId + " , " + receiverId + ", '" + transactionMessage + "', '" + transactionStatus + "');";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = createTransaction;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void createTransactionById(string sum, string transactionType, int bancAccoutId, int receiverId, string transactionMessage, string transactionStatus)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            DateTime datetime = DateTime.Now;
            string createTransaction = "Insert into transaction (transactionID, summ, date, transaction_type,banc_accountID, banc_accountID_receiver, transaction_message, transaction_status) " + " values(" + getMaxTransactionID()  + ", " + sum + ",'" + datetime.ToString("yyyy-MM-dd H:mm:ss") + "','" + transactionType + "', " + bancAccoutId + " , " + receiverId + ", '" + transactionMessage + "', '" + transactionStatus + "');";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = createTransaction;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void openCredit(int userID, string receiverAccID, int sum, int final_sum, int months, int monthPayment, string creditName)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            DateTime datetime = DateTime.Now;
            string openCredit = "Insert into credit(userID,sum,started_at, status, credit_name, final_sum, months, month_payment) values(" + userID + ", " + sum + ", '" + datetime.ToString("yyyy-MM-dd H:mm:ss") + "', 'opened', '" + creditName + "', " + final_sum + ", " + months + "," + monthPayment + ");";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = openCredit;
            int execute = cmd.ExecuteNonQuery();
            createTransactionSys(sum, "added", Convert.ToInt32(receiverAccID), Convert.ToInt32(receiverAccID), "credit", "completed");
            string updateAccount = "UPDATE bancAccount SET balance = balance + " + sum + " WHERE banc_accoutID = " + receiverAccID + ";";
            cmd.CommandText = updateAccount;
            int execute3 = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void createSingleAccount(int userId, string currency, long number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string createSession = "Insert into bancAccount (userID, balance, started_at, expires_at, banc_account_type, currency, status, account_number) " + " values(" + userId + ", 0.0, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.AddYears(4).ToString("yyyy-MM-dd HH:mm:ss")
                + "','single', '" + currency + "','" + "online', '" + Convert.ToString(number) + "');";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = createSession;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void createJointAccount(int userId, string currency, long number, string approvalType, string secondOwnerEmail)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string createSession = "Insert into bancAccount (userID, balance, started_at, expires_at, banc_account_type, currency, status, account_number, possible_userID, approval_type) " + " values(" + userId + ", 0.0, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.AddYears(4).ToString("yyyy-MM-dd HH:mm:ss")
                + "','joint', '" + currency + "','" + "waiting', '" + Convert.ToString(number) + "'," + getUserID(secondOwnerEmail) + ",'" + approvalType + "');";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = createSession;
            int execute = cmd.ExecuteNonQuery();

            string createNotification = "Insert into notification (description, status, bancaccountID, userID, second_userID) " + " values('" + currency + "', 'waiting', " + getAccountID(number) + ", " + getUserID(secondOwnerEmail) + "," + userId + ");";
            cmd.CommandText = createNotification;
            int execute2 = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void confirmJointAccount(string accountNumber, string id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            int accountId = getAccountIDS(accountNumber);
            string createJointAcc = "Update bancAccount set status ='online' where banc_accoutID = " + accountId + ";";
            cmd.CommandText = createJointAcc;
            int execute = cmd.ExecuteNonQuery();
            deleteNotification(id);

            conn.Close();
        }
        public static void confirmJointAccountBlocking(string accountNumber, string id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            int accountId = getAccountIDS(accountNumber);
            string createJointAcc = "Update bancAccount set status ='blocked' where banc_accoutID = " + accountId + ";";
            cmd.CommandText = createJointAcc;
            int execute = cmd.ExecuteNonQuery();
            deleteNotification(id);

            conn.Close();
        }
        public static void rejectJointAccountBlocking(string accountNumber, string id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            deleteNotification(id);
            conn.Close();
        }
        public static void rejectJointAccount(string accountNumber, string id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            int accountId = getAccountIDS(accountNumber);
            string createJointAcc = "Update bancAccount set status ='blocked' where banc_accoutID = " + accountId + ";";
            cmd.CommandText = createJointAcc;
            int execute = cmd.ExecuteNonQuery();
            deleteNotification(id);
            conn.Close();
        }

        public static long LongRandom(long min, long max, Random rand)
        {
            long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
            result = (result << 32);
            result = result | (long)rand.Next((Int32)min, (Int32)max);
            return result;
        }

        public static List<BancAccount> getAllAccountForCredit(int userID)
        {
            List<BancAccount> accounts = new List<BancAccount>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM bancAccount WHERE userID = " + userID + " and status ='online' and banc_account_type ='single' and currency = 'BYN' and expires_at >= NOW()" + ";";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        accounts.Add(new BancAccount(reader.GetInt32(0), reader.GetInt32(1), reader.GetFloat(5), reader.GetDateTime(9), reader.GetString(3), reader.GetString(7), reader.GetString(4), ""));
                    }
                }
            }
            conn.Close();
            return accounts;
        }



            public static List<BancAccount> getAllAccount(int userID)
        {
            List<BancAccount> accounts = new List<BancAccount>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM bancAccount WHERE userID = " + userID + " and status ='online' and banc_account_type ='single' and expires_at >= NOW()" + ";";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        accounts.Add(new BancAccount(reader.GetInt32(0), reader.GetInt32(1), reader.GetFloat(5), reader.GetDateTime(9), reader.GetString(3), reader.GetString(7), reader.GetString(4), ""));
                    }
                }
            }
            string readAccounts2 = "SELECT * FROM bancAccount WHERE userID = " + userID + " and status ='online' and banc_account_type ='joint' and expires_at >= NOW()" + ";";
            cmd.CommandText = readAccounts2;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        accounts.Add(new BancAccount(reader.GetInt32(0), reader.GetInt32(1), reader.GetFloat(5), reader.GetDateTime(9), reader.GetString(3), reader.GetString(7), reader.GetString(4), getUserEmail(reader.GetInt32(2))));
                    }
                }
            }
            string readAccountsJoint = "SELECT * FROM bancAccount WHERE possible_userID = " + userID + " and status ='online' and expires_at >= NOW()" + ";";
            cmd.CommandText = readAccountsJoint;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        accounts.Add(new BancAccount(reader.GetInt32(0), reader.GetInt32(1), reader.GetFloat(5), reader.GetDateTime(9), reader.GetString(3), reader.GetString(7), reader.GetString(4), getUserEmail(reader.GetInt32(2))));
                    }
                }
            }
            conn.Close();
            return accounts;
        }

        public static List<BancAccount> getOneAccount(string accountNumber)
        {
            List<BancAccount> accounts = new List<BancAccount>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM bancAccount WHERE account_number = " + accountNumber + " and status ='online' and banc_account_type ='single' and expires_at >= NOW()" + ";";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        accounts.Add(new BancAccount(reader.GetInt32(0), reader.GetInt32(1), reader.GetFloat(5), reader.GetDateTime(9), reader.GetString(3), reader.GetString(7), reader.GetString(4), ""));
                    }
                }
            }
            conn.Close();
            return accounts;
        }
        public static List<BancAccount> getOneAccountJoint(string accountNumber)
        {
            List<BancAccount> accounts = new List<BancAccount>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM bancAccount WHERE account_number = " + accountNumber + " and status ='online' and banc_account_type = 'joint' and expires_at >= NOW()" + ";";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        accounts.Add(new BancAccount(reader.GetInt32(0), reader.GetInt32(1), reader.GetFloat(5), reader.GetDateTime(9), reader.GetString(3), reader.GetString(7), reader.GetString(4), Convert.ToString(reader.GetInt32(2))));
                    }
                }
            }
            conn.Close();
            return accounts;
        }

        public static List<Notification> getAllNotifications(int userID)
        {
            List<Notification> notifications = new List<Notification>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM notification WHERE userID = " + userID + " and status ='waiting';";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        notifications.Add(new Notification(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(4), reader.GetInt32(3), getAccountNumber(reader.GetInt32(3))));
                    }
                }
            }
            conn.Close();
            return notifications;
        }

        public static List<Payment> getAllPayments(int userID)
        {
            List<Payment> payments = new List<Payment>();
            List<BancAccount> accounts = getAllAccount(userID);
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM transaction;";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        if (accounts.Exists(s => s.bancAccountID == reader.GetInt32(4)) || accounts.Exists(s => s.bancAccountID.Equals(reader.GetInt32(5))))
                        {
                            payments.Add(new Payment(reader.GetInt32(0), reader.GetFloat(1), reader.GetDateTime(2), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7), reader.GetString(3)));
                        }

                    }
                }
            }
            conn.Close();
            return payments;
        }

        public static List<Credit> getAllCredits(int userID)
        {
            List<Credit> credits = new List<Credit>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM credit where userId = " + userID+ ";";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        
                            credits.Add(new Credit(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9)));
                        

                    }
                }
            }
            conn.Close();
            return credits;
        }

        public static List<Credit> getOneCredit(int creditID)
        {
            List<Credit> credits = new List<Credit>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM credit where creditId = " + creditID + ";";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        credits.Add(new Credit(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9)));


                    }
                }
            }
            conn.Close();
            return credits;
        }

        public static List<CreditType> getAllCreditTypes()
        {
            List<CreditType> credits = new List<CreditType>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM creditType;";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        credits.Add(new CreditType(reader.GetInt32(0), reader.GetFloat(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6)));
                    }
                }
            }
            conn.Close();
            return credits;
        }

        public static List<CreditType> getOneCreditTypes(int creditID)
        {
            List<CreditType> credits = new List<CreditType>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM creditType where credit_TypeID = "  + creditID +  ";";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        credits.Add(new CreditType(reader.GetInt32(0), reader.GetFloat(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6)));
                    }
                }
            }
            conn.Close();
            return credits;
        }

        public static void updateMoney(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT banc_accoutID FROM bancAccount WHERE account_number = " + number + ";";
            cmd.CommandText = checkID;
            int accountID = (int)cmd.ExecuteScalar();
            string updateAccount = "UPDATE bancAccount SET balance = balance + 100 where banc_accoutID = " + accountID + ";";
            cmd.CommandText = updateAccount;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static double getTransactionBal(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT summ FROM transaction WHERE transactionID = " + number + ";";
            cmd.CommandText = checkID;
            string accountID = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return Convert.ToDouble(accountID);
        }

        public static int getMaxTransactionID()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT MAX(transactionID) from transaction ;";
            cmd.CommandText = checkID;
            int accountID = (int)cmd.ExecuteScalar();
            conn.Close();
            return accountID;
        }

        public static int getTransactionIDFromNotificationNumber(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT description from notification ;";
            cmd.CommandText = checkID;
            string accountID = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            string pattern = @"\((.*?)\)";

            Match match = Regex.Match(accountID, pattern);

            string extra = "";

            if (match.Success)
            {
                extra = match.Groups[1].Value;
            }
            return Convert.ToInt32(extra);
        }

        public static void updateMoneyTransfer(string number, string numberSender, string sum)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT banc_accoutID FROM bancAccount WHERE account_number = " + number + ";";
            cmd.CommandText = checkID;
            int accountID = (int)cmd.ExecuteScalar();
            string updateAccount = "UPDATE bancAccount SET balance = balance + " + sum + " WHERE banc_accoutID = " + accountID + ";";
            cmd.CommandText = updateAccount;
            int execute = cmd.ExecuteNonQuery();
            string checkID2 = "SELECT banc_accoutID FROM bancAccount WHERE account_number = " + numberSender + ";";
            cmd.CommandText = checkID2;
            int accountID2 = (int)cmd.ExecuteScalar();
            string updateAccount2 = "UPDATE bancAccount SET balance = balance - " + sum + " where banc_accoutID = " + accountID2 + ";";
            cmd.CommandText = updateAccount2;
            int execute2 = cmd.ExecuteNonQuery();
            createTransaction(sum, "added", accountID2, accountID, "", "completed");
            createTransaction(sum, "transfered", accountID2, accountID, "", "completed");
            conn.Close();
        }

        public static void proceedMoneyTransferSuccess(string operationNumber, string notificationNumber)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string senderID = "SELECT banc_accountID FROM transaction WHERE transactionID = " + operationNumber + ";";
            cmd.CommandText = senderID;
            int senderIDD = (int)cmd.ExecuteScalar();

            string receiverID = "SELECT banc_accountID_receiver FROM transaction WHERE transactionID = " + operationNumber + ";";
            cmd.CommandText = senderID;
            int receiverIDD = (int)cmd.ExecuteScalar();

            string sum = "SELECT summ FROM transaction WHERE transactionID = " + operationNumber + ";";
            cmd.CommandText = senderID;
            string summ = Convert.ToString(cmd.ExecuteScalar());
            double finalSumm = Convert.ToDouble(summ);

            string updateAccount = "UPDATE bancAccount SET balance = balance + " + finalSumm + " WHERE banc_accoutID = " + receiverIDD + ";";
            cmd.CommandText = updateAccount;
            int execute = cmd.ExecuteNonQuery();

            string updateAccount2 = "UPDATE transaction SET transaction_status = 'completed'  where transactionID = " + operationNumber + ";";
            cmd.CommandText = updateAccount2;
            int execute2 = cmd.ExecuteNonQuery();

            deleteNotification(notificationNumber);
            conn.Close();
        }

        public static void proceedMoneyTransferReject(string operationNumber, string notificationNumber)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string senderID = "SELECT banc_accountID FROM transaction WHERE transactionID = " + operationNumber + ";";
            cmd.CommandText = senderID;
            int senderIDD = (int)cmd.ExecuteScalar();

            string receiverID = "SELECT banc_accountID_receiver FROM transaction WHERE transactionID = " + operationNumber + ";";
            cmd.CommandText = senderID;
            int receiverIDD = (int)cmd.ExecuteScalar();

            string sum = "SELECT summ FROM transaction WHERE transactionID = " + operationNumber + ";";
            cmd.CommandText = senderID;
            string summ = Convert.ToString(cmd.ExecuteScalar());
            double finalSumm = Convert.ToDouble(summ);

            string updateAccount = "UPDATE bancAccount SET balance = balance + " + finalSumm + " WHERE banc_accoutID = " + senderIDD + ";";
            cmd.CommandText = updateAccount;
            int execute = cmd.ExecuteNonQuery();

            string updateAccount2 = "UPDATE transaction SET transaction_status = 'completed'  where transactionID = " + operationNumber + ";";
            cmd.CommandText = updateAccount2;
            int execute2 = cmd.ExecuteNonQuery();

            deleteNotification(notificationNumber);
            conn.Close();
        }

        public static void updateMoneyTransferRequest(string number, string numberSender, string sum, int secondOwnerID, int firstOwner)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT banc_accoutID FROM bancAccount WHERE account_number = " + number + ";";
            cmd.CommandText = checkID;
            int accountID = (int)cmd.ExecuteScalar();
            string checkID2 = "SELECT banc_accoutID FROM bancAccount WHERE account_number = " + numberSender + ";";
            cmd.CommandText = checkID2;
            int accountID2 = (int)cmd.ExecuteScalar();
            string updateAccount2 = "UPDATE bancAccount SET balance = balance - " + sum + " where banc_accoutID = " + accountID2 + ";";
            cmd.CommandText = updateAccount2;
            int execute2 = cmd.ExecuteNonQuery();
            createTransaction(sum, "added", accountID2, accountID, "", "waiting");
            //createTransaction(sum, "transfered", accountID2, accountID, "", "waiting");
            string createNotification = "Insert into notification (description, status, bancaccountID, userID, second_userID) " + " values('" + "send("  + getMaxTransactionID()  + ")" + "', 'waiting', " + getAccountIDS(number) + ", " + secondOwnerID + "," + firstOwner + ");";
            cmd.CommandText = createNotification;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }
            public static void updateMoneyTransferDifferentValues(string number, string numberSender, string sum, string sumSender)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT banc_accoutID FROM bancAccount WHERE account_number = " + number + ";";
            cmd.CommandText = checkID;
            int accountID = (int)cmd.ExecuteScalar();
            string updateAccount = "UPDATE bancAccount SET balance = balance + " + sumSender + " WHERE banc_accoutID = " + accountID + ";";
            cmd.CommandText = updateAccount;
            int execute = cmd.ExecuteNonQuery();
            string checkID2 = "SELECT banc_accoutID FROM bancAccount WHERE account_number = " + numberSender + ";";
            cmd.CommandText = checkID2;
            int accountID2 = (int)cmd.ExecuteScalar();
            string updateAccount2 = "UPDATE bancAccount SET balance = balance - " + sum + " where banc_accoutID = " + accountID2 + ";";
            cmd.CommandText = updateAccount2;
            int execute2 = cmd.ExecuteNonQuery();
            createTransaction(sumSender, "added", accountID2, accountID, "", "completed");
            createTransaction(sum, "transfered", accountID2, accountID, "", "completed");
            conn.Close();
        }

        public static void PayForCredit(string numberSender, int sum, int creditNumber)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT banc_accoutID FROM bancAccount WHERE account_number = " + numberSender + ";";
            cmd.CommandText = checkID;
            int accountID = (int)cmd.ExecuteScalar();
            string checkCreditBalance = "SELECT Final_sum FROM credit WHERE creditID = " + creditNumber + ";";
            cmd.CommandText = checkCreditBalance;
            int balance = Convert.ToInt32(cmd.ExecuteScalar());
            if(balance == sum)
            {
                string updateAccount2 = "UPDATE credit SET final_sum = final_sum - " + sum + " and status = 'closed' where creditID = " + creditNumber + ";";
                cmd.CommandText = updateAccount2;
                int execute2 = cmd.ExecuteNonQuery();
            }
            else
            {
                string updateAccount2 = "UPDATE credit SET final_sum = final_sum - " + sum + " where creditID = " + creditNumber + ";";
                cmd.CommandText = updateAccount2;
                int execute2 = cmd.ExecuteNonQuery();
            }
            string updateAccount3 = "UPDATE bancAccount SET balance = balance - " + sum + " where banc_accoutID = " + accountID + ";";
            cmd.CommandText = updateAccount3;
            int execute3 = cmd.ExecuteNonQuery();

            createTransaction(Convert.ToString(sum), "transfered", accountID, accountID, "credit pay", "completed");

            conn.Close();
        }

        public static void blockAccount(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT banc_accoutID FROM bancAccount WHERE account_number = " + number + ";";
            cmd.CommandText = checkID;
            int accountID = (int)cmd.ExecuteScalar();
            string updateAccount = "UPDATE bancaccount SET status = 'blocked' where banc_accoutID = " + accountID + ";";
            cmd.CommandText = updateAccount;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void blockJointAccount(string number, string secondOwnerEmail, int userId)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            int receiver = 0;
            if (getUserID(secondOwnerEmail) == userId)
            {
                receiver = getAccountFirstOwnerS(number);
            }
            else
            {
                receiver = getUserID(secondOwnerEmail);
            }
            string createNotification = "Insert into notification (description, status, bancaccountID, userID, second_userID) " + " values('" + "block" + "', 'waiting', " + getAccountIDS(number) + ", " + receiver + "," + userId + ");";
            cmd.CommandText = createNotification;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void deleteNotification(string id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "delete from notification where notificationID =" + id + ";";
            cmd.CommandText = checkID;
            int execute = cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
