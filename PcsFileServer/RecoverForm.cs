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
        public static Dictionary<string, int> emailCodes = new Dictionary<string, int>();


        public RecoverForm()
        {
            InitializeComponent();
            this.components.SetStyleDark(this);
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            try
            {
                int emailCode = new Random().Next(1000,9999);
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("pcsfileserver@yandex.ru", "Pcs_file_server");
                // кому отправляем
                MailAddress to = new MailAddress(MailTextBox.Text);
                emailCodes.Add(MailTextBox.Text,emailCode);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "PcsFileServer";
                // текст письма
                m.Body = $"<img width='20%' height='20%' src='https://sun9-41.userapi.com/impg/jtmZmnRg-pQnNdjo8Ot-1zHKEpxpq7-whyToPg/lGmRpbKJThk.jpg?size=128x128&quality=96&sign=f28a7e82c51a8b7b4bd4ae5785e6013e&type=album'><h1>Ваш код для восстановления пароля: {emailCode}</h1>";
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.yandex.com", 587);

                // логин и пароль
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("pcsfileserver@yandex.ru", "icqbqthqpmhvidqb");
                smtp.Send(m);
                //Console.Read();
                CodeReviewForm codeReviewForm = new CodeReviewForm(MailTextBox.Text);
                MessageBox.Show("Код отправлен на указанную почту!");
                this.Hide();
                codeReviewForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
