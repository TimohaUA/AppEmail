using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
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
    public class Autorization : INotifyPropertyChanged
    {


        string email;
        public string EMAIL
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("EMAIL");
            }
        }

        string pasword;
        public string PASSWORD
        {
            get { return pasword; }
            set
            {
                pasword = value;
                OnPropertyChanged("PASSWORD");
            }
        }

        private MainWindow autorizationWindow = null;
        public MainWindow AutorizationWindow
        {
            get => autorizationWindow;
            set => autorizationWindow = value;
        }

        public ButtonAutoriz ButtonAutoriz { get; set; }

        MyMailBox myMailBox;

        public Autorization()
        {
            ButtonAutoriz = new ButtonAutoriz(this);
        }




        public async void AutorizClient()
        {
            if (email != "" && pasword != "")
            {
                try
                {
                    using (var client = new ImapClient())
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                        client.CheckCertificateRevocation = false;

                        await client.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

                        client.AuthenticationMechanisms.Remove("XOAUTH2");
                        await client.AuthenticateAsync(email, pasword);

                        if (client.IsAuthenticated)
                        {

                            SmtpClient smtpClient = new SmtpClient();
                            await smtpClient.ConnectAsync("smtp.gmail.com", 587);
                            await smtpClient.AuthenticateAsync(email, pasword);

                            
                            myMailBox = new MyMailBox(client, smtpClient, email);
                            myMailBox.ShowDialog();
                        }
                        email = "";
                        pasword = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Логін або пароль введено невірно!");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
