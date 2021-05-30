using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NFS.Properties;
using NLog;

namespace NFS
{
    class Email
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string AdminEmail = $"{Settings.Default.email}";
        private static string AdminEmailPass = $"{Settings.Default.emailPass}";
        private MailAddress from = new MailAddress(AdminEmail, "NFS");
        public void SendResetPassEmail(string userEmail, int restoreCode)
        {
            try
            { 
                //кому отправляем
                MailAddress to = new MailAddress(userEmail);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Password reset";
                // текст письма
                m.Body = "This is new your password to login in NFS:\n "+ restoreCode;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential(AdminEmail, AdminEmailPass);
                smtp.EnableSsl = true;
                smtp.Send(m);
                MessageBox.Show("Email has been send!");
            }
            catch (Exception e)
            {
                logger.Fatal($"Error email send: {e};");
            }
        }
        public bool IsValidEmail(string email)
        {
            const string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
