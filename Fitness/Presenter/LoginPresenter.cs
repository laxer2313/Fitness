using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return false;
        }
        public void Login()
        {
            // tutaj ma byc query ktory zapytuje baze danych czy istnieje taki user
            // jesli istnieje to CanLogin = true
            if (!ValidateInputs())
                _loginView.CanLogin = false;
            _loginView.CanLogin = _userModel.IsLoginValid(_loginView.Email, _loginView.Password);
        }
    }
}
