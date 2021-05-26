using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace NFS
{
    class Email
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private const string AdminEmail = "qazwsxedcrffv.11@gmail.com";
        private const string AdminEmailPass = "Qazwsxedcrfvtgbyhnujmikolp12";
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
    }
}
