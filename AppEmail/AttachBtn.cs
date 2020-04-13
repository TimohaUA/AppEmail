using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppEmail
{
    public class AttachBtn : ICommand
    {
        public NewLetter newLetter { get; set; }

        public AttachBtn(NewLetter letter)
        {
            newLetter = letter;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            newLetter.AtachClick();
        }
    }
}
