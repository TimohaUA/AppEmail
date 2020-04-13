using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using MaterialDesignThemes.Wpf;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppEmail
{
    public class PostBox : INotifyPropertyChanged
    {

        List<MimeMessage> list_letters;
        public List<MimeMessage> List_Letters
        {
            get { return list_letters; }
            set
            {
                list_letters = value;
                OnPropertyChanged("List_Letters");
            }
        }

        List<MimeMessage> sended_list_letters;
        public List<MimeMessage> Sended_List_Letters
        {
            get { return sended_list_letters; }
            set
            {
                sended_list_letters = value;
                OnPropertyChanged("Sended_List_Letters");
            }
        }

        public ImapClient imap;
        public SmtpClient smtp;
        public string thisEmail;

        public ButtonSendNewLetter ButtonNewLetter { get; set; }

        SendNewLetter windowSendNewLetter;

        public PostBox(ImapClient _imap, SmtpClient _smtpClient, string _email)
        {
            imap = _imap;
            smtp = _smtpClient;
            thisEmail = _email;
            ButtonNewLetter = new ButtonSendNewLetter(this);
            list_letters = new List<MimeMessage>();
            sended_list_letters = new List<MimeMessage>();
            getLetters(imap);
            getSendedLetters(imap);
        }


        public void getLetters(ImapClient imap) //всі вхідні листи
        {
            try
            {
                IList<IMailFolder> folders = imap.GetFolders(imap.PersonalNamespaces.First());
                List<string> names = folders.Select(t => t.Name).ToList();
                folders[7].Open(MailKit.FolderAccess.ReadOnly);

                for (int i = folders[7].Count - 1; i > -1; i--)
                {
                    var message = folders[7].GetMessage(i);
                    list_letters.Add(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getSendedLetters(ImapClient imap) //всі надіслані листи
        {
            try
            {
                IList<IMailFolder> folders = imap.GetFolders(imap.PersonalNamespaces.First());
                List<string> names = folders.Select(t => t.Name).ToList();
                folders[5].Open(MailKit.FolderAccess.ReadOnly);

                for (int i = folders[5].Count - 1; i > -1; i--)
                {
                    var message = folders[5].GetMessage(i);
                    sended_list_letters.Add(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ButtonClickNewLetter()
        {

            try
            {
                windowSendNewLetter = new SendNewLetter(smtp, thisEmail);
                windowSendNewLetter.ShowDialog();

                //using (var client = new ImapClient())
                //{
                //    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                //    client.CheckCertificateRevocation = false;

                //    await client.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

                //    client.AuthenticationMechanisms.Remove("XOAUTH2");
                //    await client.AuthenticateAsync(email, pasword);

                //    if (client.IsAuthenticated)
                //    {

                //        SmtpClient smtpClient = new SmtpClient();
                //        await smtpClient.ConnectAsync("smtp.gmail.com", 587);
                //        await smtpClient.AuthenticateAsync(client, pasword);


                //        myMailBox = new MyMailBox(client);
                //        myMailBox.ShowDialog();
                //    }
                //    email = "";
                //    pasword = "";
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Вікно для нового повідомлення не відкрилось!");
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
