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
    /// Логика взаимодействия для SendNewLetter.xaml
    /// </summary>
    public partial class SendNewLetter : Window
    {
        NewLetter newLetter;

        public SendNewLetter(SmtpClient smtpClient, string _email)
        {
            InitializeComponent();
            newLetter = new NewLetter(smtpClient, _email, this);
            grid_newLetter.DataContext = newLetter;
        }
    }
}
