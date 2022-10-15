using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PcsFileServer
{
    public partial class RecoverForm : MetroForm
    {
        //icqbqthqpmhvidqb ya pass

        public RecoverForm()
        {
            InitializeComponent();
            this.components.SetStyleDark(this);
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            try
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("pcsfileserver@yandex.ru", "Pcs_file_server");
                // кому отправляем
                MailAddress to = new MailAddress(MailTextBox.Text);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Тест";
                // текст письма
                m.Body = "<h2>Ваш код для восстановления пароля:</h2>";
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.yandex.com", 587);

                // логин и пароль
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("pcsfileserver@yandex.ru", "icqbqthqpmhvidqb");
                smtp.Send(m);
                //Console.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
