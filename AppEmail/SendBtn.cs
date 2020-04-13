using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppEmail
{
    public class SendBtn : ICommand
    {
        public NewLetter Letter { get; set; }

        public SendBtn(NewLetter letter)
        {
            Letter = letter;
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
            Letter.SendLetterClick();
        }
    }
}
