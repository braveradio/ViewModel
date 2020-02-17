using MVVMPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.ViewModels
{
    public class AccountCreationViewModel
    {
        public AccountModel NewAccount { get; set; }

        public AccountCreationViewModel()
        {
            NewAccount = new AccountModel();
        }

        public void ValidatePassword()
        {
            NewAccount.ValidatePassword();
        }
    }
}
