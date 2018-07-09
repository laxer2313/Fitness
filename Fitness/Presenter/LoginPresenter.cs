using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

using Fitness.View;
using Fitness.Modell;

namespace Fitness.Presenter
{
    class LoginPresenter
    {
        private readonly ILogin _loginView;
        private readonly User _userModel;

        public LoginPresenter(ILogin loginView, User userModel)
        {
            _loginView = loginView;
            _userModel = userModel;
        }

        public bool ValidateInputs()
        {
            // tutaj trzeba zrobic wszelka walidacje inputow w stylu
            // if _loginView.Email nie posida struktury ...@...
            // if _loginView.Email.length() == 0 itd itd

            if(_loginView.Email != "" && _loginView.Password != "")
            {
                try
                {
                    MailAddress mail = new MailAddress(_loginView.Email);
                }  
                catch
                {
                    return false;
                }
            } 
            
            return true;
        }
        public void Login()
        {
            // tutaj ma byc query ktory zapytuje baze danych czy istnieje taki user
            // jesli istnieje to CanLogin = true
            if (!ValidateInputs())
            {
                _loginView.CanLogin = false;
            }
            else
            {
                _loginView.CanLogin = _userModel.IsLoginValid(_loginView.Email, _loginView.Password);
            }
           
        }
    }
}
