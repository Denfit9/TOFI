using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOFIiBank
{
    public static class Tools
    {

        public static void sendConfirmationCode(string emailTo, string body)
        {
            var mail  = Mail.CreateMail("TofiBank", "TofiBankk@gmail.com", emailTo, "Код подтверждения", body);
            Mail.SendMail("smtp.gmail.com", 587, "TofiBankk@gmail.com", "uqfnlmylqpffivpl", mail);
        }
    }
}
