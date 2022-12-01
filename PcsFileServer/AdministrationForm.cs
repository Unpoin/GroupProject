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
using MetroFramework;
using MetroFramework.Forms;

namespace PcsFileServer
{
    public partial class AdministrationForm:MetroForm 
    {
        public AdministrationForm()
        {
            InitializeComponent();
            this.components.SetStyleDark(this);
        }

        private void AboutTile_Click(object sender, EventArgs e)
        {
            InformationForm info = new InformationForm();
            info.ShowDialog();
        }

        private void GuideTile_Click(object sender, EventArgs e)
        {
            //guideform
        }
        private void SendNotification(string email, string login)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("pcsfileserver@yandex.ru", "Pcs_file_server");
            // кому отправляем
            MailAddress to = new MailAddress(email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "PcsFileServer";
            // текст письма
            m.Body = $"<h1>Уведомление</h1><br>Ваш аккаунт: {login} был удален! Для получения подробной информации обращайтесь к администратору.";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.com", 587);

            // логин и пароль
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("pcsfileserver@yandex.ru", "icqbqthqpmhvidqb");
            smtp.Send(m);
        }
        private void RefreshData()
        {
            ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
            var data = context.ftpuser
                    .Select(u => new
                    {
                        u.userid,
                        u.passwd,
                        u.name,
                        u.email,
                        u.role,
                        u.phone
                    });
            UsersDataGrid.DataSource = data.ToList();
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            // 124; 65; 153
            UsersDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 65, 153);
            RefreshPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RefreshPictureBox.Image = Properties.Resources.refresh;
            RefreshData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить пользователя(ей)?", "Подветверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
                    string loginGridItem;
                    ftpuser user = new ftpuser();
                    for (int rows = 0; rows < UsersDataGrid.SelectedRows.Count; rows++)
                    {
                        loginGridItem = UsersDataGrid.SelectedRows[rows].Cells[0].Value.ToString();
                        user = context.ftpuser.Where(u => u.userid == loginGridItem).FirstOrDefault();
                        context.ftpuser.Remove(user);
                        SendNotification(user.email, user.userid);
                        user = null;
                    }
                    context.SaveChanges();
                    MessageBox.Show("Пользователь(и) успешно удален!");
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void RedactButton_Click(object sender, EventArgs e)
        {
            var lgn = UsersDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
            var redactedUser = context.ftpuser.Where(u => u.userid == lgn).FirstOrDefault();
            NameTextBox.Text = redactedUser.name;
            LoginTextBox.Text = redactedUser.userid;
            PasswordTextBox.Text = redactedUser.passwd;
            EmailTextBox.Text = redactedUser.email;
            PhoneTextBox.Text = redactedUser.phone;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите добавить пользователя(ей)?", "Подветверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
                    ftpuser newUser = new ftpuser()
                    {
                        name = NameTextBox.Text,
                        userid = LoginTextBox.Text,
                        passwd = PasswordTextBox.Text,
                        email = EmailTextBox.Text,
                        role = "user",
                        phone = PhoneTextBox.Text,
                        homedir = $"/srv/{LoginTextBox.Text}"
                    };
                    context.ftpuser.Add(newUser);
                    context.SaveChanges();
                    MessageBox.Show("Пользователь успешно добавлен!");
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
                var data = context.ftpuser
                    .Select(u => new
                    {
                        u.userid,
                        u.passwd,
                        u.name,
                        u.email,
                        u.role,
                        u.phone
                    }).Where(n => n.userid.Contains(SearchTextBox.Text)).ToList();
                UsersDataGrid.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshPictureBox_Click(object sender, EventArgs e)
        {
            RefreshData();
            SearchTextBox.Text = "";
        }

        private void UsersDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.FromArgb(124, 65, 153);
        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Подветверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
                    var redactedUser = context.ftpuser.Where(u => u.userid == LoginTextBox.Text).FirstOrDefault();
                    redactedUser.name = NameTextBox.Text;
                    redactedUser.userid = LoginTextBox.Text;
                    redactedUser.passwd = PasswordTextBox.Text;
                    redactedUser.email = EmailTextBox.Text;
                    redactedUser.phone = PhoneTextBox.Text;
                    context.SaveChanges();
                    MessageBox.Show("Пользователь успешно изменен!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неккоректные данные, попробуйте снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
