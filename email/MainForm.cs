using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Net.Pop3;
using MimeKit;

namespace EmailClientWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Предзаполнение SMTP и POP3 серверов для популярных почтовиков
            txtSmtp.Text = "smtp.yandex.ru";
            txtSmtpPort.Text = "587";
            txtPop.Text = "pop.yandex.ru";
            txtPopPort.Text = "995";
        }

        // Отправка письма по SMTP
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(txtEmail.Text));
                message.To.Add(MailboxAddress.Parse(txtTo.Text));
                message.Subject = txtSubject.Text;
                message.Body = new TextPart("plain") { Text = txtBody.Text };

                using (var client = new SmtpClient())
                {
                    client.Connect(txtSmtp.Text, int.Parse(txtSmtpPort.Text), true);
                    client.Authenticate(txtEmail.Text, txtPassword.Text);
                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Письмо отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отправке: " + ex.Message);
            }
        }

        // Получение писем через POP3
        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                lstEmails.Items.Clear();
                using (var client = new Pop3Client())
                {
                    client.Connect(txtPop.Text, int.Parse(txtPopPort.Text), true);
                    client.Authenticate(txtEmail.Text, txtPassword.Text);

                    // Получаем количество писем
                    int emailCount = client.Count;

                    // Определяем сколько писем нужно получить (максимум последние 10)
                    int startIndex = Math.Max(0, emailCount - 10);

                    // Цикл с конца для получения последних 10 писем
                    for (int i = startIndex; i < emailCount; i++)
                    {
                        var message = client.GetMessage(i);
                        lstEmails.Items.Add($"{message.Date:dd.MM.yyyy HH:mm} - {message.Subject}");
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении: " + ex.Message);
            }
        }
    }
}
