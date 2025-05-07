namespace EmailClientWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.txtPopPort = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.lstEmails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // Email
            this.txtEmail.Location = new System.Drawing.Point(12, 12);
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.PlaceholderText = "Ваш email";

            // Password
            this.txtPassword.Location = new System.Drawing.Point(320, 12);
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Пароль";

            // To
            this.txtTo.Location = new System.Drawing.Point(12, 45);
            this.txtTo.Size = new System.Drawing.Size(300, 23);
            this.txtTo.PlaceholderText = "Кому";

            // Subject
            this.txtSubject.Location = new System.Drawing.Point(320, 45);
            this.txtSubject.Size = new System.Drawing.Size(200, 23);
            this.txtSubject.PlaceholderText = "Тема";

            // Body
            this.txtBody.Location = new System.Drawing.Point(12, 75);
            this.txtBody.Multiline = true;
            this.txtBody.Size = new System.Drawing.Size(508, 100);
            this.txtBody.PlaceholderText = "Текст письма";

            // SMTP
            this.txtSmtp.Location = new System.Drawing.Point(12, 185);
            this.txtSmtp.Size = new System.Drawing.Size(200, 23);
            this.txtSmtp.PlaceholderText = "SMTP сервер";

            // SMTP Port
            this.txtSmtpPort.Location = new System.Drawing.Point(220, 185);
            this.txtSmtpPort.Size = new System.Drawing.Size(50, 23);
            this.txtSmtpPort.PlaceholderText = "Порт";

            // POP3
            this.txtPop.Location = new System.Drawing.Point(12, 215);
            this.txtPop.Size = new System.Drawing.Size(200, 23);
            this.txtPop.PlaceholderText = "POP3 сервер";

            // POP3 Port
            this.txtPopPort.Location = new System.Drawing.Point(220, 215);
            this.txtPopPort.Size = new System.Drawing.Size(50, 23);
            this.txtPopPort.PlaceholderText = "Порт";

            // Send Button
            this.btnSend.Location = new System.Drawing.Point(320, 185);
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.Text = "Отправить";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // Receive Button
            this.btnReceive.Location = new System.Drawing.Point(428, 185);
            this.btnReceive.Size = new System.Drawing.Size(100, 23);
            this.btnReceive.Text = "Получить";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);

            // Email List
            this.lstEmails.Location = new System.Drawing.Point(12, 250);
            this.lstEmails.Size = new System.Drawing.Size(508, 150);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 420);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSmtp);
            this.Controls.Add(this.txtSmtpPort);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.txtPopPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lstEmails);
            this.Name = "MainForm";
            this.Text = "Почтовый клиент";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.TextBox txtPopPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.ListBox lstEmails;
    }
}
