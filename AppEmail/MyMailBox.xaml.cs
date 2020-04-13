using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppEmail
{
    /// <summary>
    /// Логика взаимодействия для MyMailBox.xaml
    /// </summary>
    public partial class MyMailBox : Window
    {
        PostBox myPostBox;

        public MyMailBox(ImapClient _imap, SmtpClient _smtpClient, string _email)
        {
            InitializeComponent();
            myPostBox = new PostBox(_imap, _smtpClient, _email);
            grid_MyMailBox.DataContext = myPostBox;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sp_c.Visibility = Visibility.Visible;
            sp_n.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sp_c.Visibility = Visibility.Collapsed;
            sp_n.Visibility = Visibility.Visible;
        }
    }
}
