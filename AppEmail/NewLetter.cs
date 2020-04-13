using MailKit.Net.Smtp;
using Microsoft.Win32;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppEmail
{
    public class NewLetter : INotifyPropertyChanged
    {
        string attachmentPath = string.Empty;

        string email_to;
        public string EMAIL_TO
        {
            get { return email_to; }
            set
            {
                email_to = value;
                OnPropertyChanged("EMAIL_TO");
            }
        }

        string subject;
        public string SUBJECT
        {
            get { return subject; }
            set
            {
                subject = value;
                OnPropertyChanged("SUBJECT");
            }
        }

        string bodyText;
        public string BodyText
        {
            get { return bodyText; }
            set
            {
                bodyText = value;
                OnPropertyChanged("BodyText");
            }
        }

        public AttachBtn ButtonAttach { get; set; }
        public DeleteBtn ButtonDel { get; set; }
        public SendBtn ButtonSend { get; set; }

        public SmtpClient smtp;
        public string thisEmail;
        public SendNewLetter window;

        public NewLetter(SmtpClient smtpClient, string _email, SendNewLetter _windows)
        {
            window = _windows;
            thisEmail = _email;
            ButtonAttach = new AttachBtn(this);
            ButtonDel = new DeleteBtn(this);
            ButtonSend = new SendBtn(this);
            smtp = smtpClient;
        }




        public void SendLetterClick()
        {
            if (email_to != "")
            {
                //SmtpClient client = new SmtpClient();
                //client.ConnectAsync("smtp.gmail.com", 587);
                //client.AuthenticateAsync("projectsprog1@gmail.com", "qqwwee11!!");

                MimeMessage mail = new MimeMessage();
                mail.From.Add(new MailboxAddress(thisEmail)); // sender
                mail.To.Add(new MailboxAddress(email_to));

                mail.Subject = subject;
                mail.Body = new TextPart("plain") { Text = bodyText };

                smtp.SendAsync(mail);                
                MessageBox.Show("Лист відправлений!");
                window.Close();
            }
            else
                MessageBox.Show("Поле отримувача є пустим!");

        }

        public void AtachClick()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            attachmentPath = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            //AttachFileTB.Text = openFileDialog.SafeFileName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
