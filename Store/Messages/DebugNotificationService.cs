using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using Store.domain;
namespace Store.Messages
{
    public class DebugNotificationService : INotificationService
    {
        public void SendConfirmationCode(string cellPhone, int code)
        {
            Debug.WriteLine("Cell phone: {0}, code: {1:0000}.", cellPhone, code);
        }
        public void StartProcess(Order order)
        {
            MailAddress from = new MailAddress("test", "серГЕЙ");
            // кому отправляем
            MailAddress to = new MailAddress("test");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Заказ #" + order.Id;
            // текст письма
            m.Body = $"Ваш заказ в сборке Количество товара {order.Items.Count}+на сумму {order.TotalPrice}";

            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("test", "test");
            
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
        
    }
}