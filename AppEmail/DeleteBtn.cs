using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppEmail
{
    public class DeleteBtn : ICommand
    {
        public NewLetter newLetter { get; set; }

        public DeleteBtn(NewLetter letter)
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
            //Clients.AutorizClient();
        }
    }
}
