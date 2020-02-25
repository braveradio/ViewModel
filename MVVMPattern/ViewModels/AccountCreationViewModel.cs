using MVVMPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMPattern.ViewModels
{
    public class AccountCreationViewModel
    {
        public AccountModel NewAccount { get; set; }
        public string Message { get; set; } = "Fuck You!";

        public AccountCreationViewModel()
        {
            NewAccount = new AccountModel();

        }

        private RelayCommand simpleCommand;
        public RelayCommand SimpleCommand
        {
            get 
            {
                return simpleCommand ?? (simpleCommand = new RelayCommand(obj => MessageBox.Show(Message))); 
            }
        }


        private void DoSimpleCommand()
        {
            MessageBox.Show("Fuck you!");
        }



        public void ValidatePassword()
        {
            NewAccount.ValidatePassword();
        }
    }
}
