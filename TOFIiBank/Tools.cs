using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TOFIiBank.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TOFIiBank
{
    public static class Tools
    {

        public static void sendConfirmationCode(string emailTo, string body)
        {
            var mail  = Mail.CreateMail("TofiBank", "TofiBankk@gmail.com", emailTo, "Код подтверждения", body);
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

            if (Convert.ToInt32(exists)!=0)
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
            string checkEmail = "SELECT EXISTS(SELECT * FROM document WHERE ident_number = '" + documentNumber + "');";
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
            string checkEmail = "SELECT EXISTS(SELECT * FROM bancaccount WHERE account_number = '" + Convert.ToString(number) + "');";
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

        public static bool checkSessionExistence (int userID)
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

        public static void createSession(int userId)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string createSession = "Insert into sessions (userID) " + " values(" + userId + ");";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = createSession;
            int execute = cmd.ExecuteNonQuery();
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
        }

        public static void createSingleAccount(int userId, string currency, long number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string createSession = "Insert into bancaccount (userID, balance, started_at, expires_at, banc_account_type, currency, status, account_number) " + " values(" + userId + ", 0.0, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.AddYears(4).ToString("yyyy-MM-dd HH:mm:ss")
                + "','single', '" + currency + "','" + "online', '" + Convert.ToString(number) + "');";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = createSession;
            int execute = cmd.ExecuteNonQuery();
        }

        public static long LongRandom(long min, long max, Random rand)
        {
            long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
            result = (result << 32);
            result = result | (long)rand.Next((Int32)min, (Int32)max);
            return result;
        }

        public static List<BancAccount> getAllAccount(int userID)
        {
            List<BancAccount> accounts = new List<BancAccount>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string readAccounts = "SELECT * FROM bancAccount WHERE userID = " + userID + " and status ='online' and expires_at >= NOW()" + ";";
            cmd.CommandText = readAccounts;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        accounts.Add(new BancAccount(reader.GetInt32(0), reader.GetInt32(1), reader.GetFloat(3), reader.GetDateTime(5), reader.GetString(6), reader.GetString(8), reader.GetString(10)));
                    }
                }
            }
            conn.Close();
            return accounts;
        }

        public static void updateMoney(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT banc_accoutID FROM bancaccount WHERE account_number = " + number + ";";
            cmd.CommandText = checkID;
            int accountID = (int)cmd.ExecuteScalar();
            string updateAccount = "UPDATE bancaccount SET balance = balance + 100 where banc_accoutID = " + accountID + ";";
            cmd.CommandText = updateAccount;
            int execute = cmd.ExecuteNonQuery();
        }
        public static void blockAccount(string number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string checkID = "SELECT banc_accoutID FROM bancaccount WHERE account_number = " + number + ";";
            cmd.CommandText = checkID;
            int accountID = (int)cmd.ExecuteScalar();
            string updateAccount = "UPDATE bancaccount SET status = 'blocked' where banc_accoutID = " + accountID + ";";
            cmd.CommandText = updateAccount;
            int execute = cmd.ExecuteNonQuery();
        }
    }
}
