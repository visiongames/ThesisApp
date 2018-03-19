using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ThesisManager.Domain;
using ThesisManager.Views;
using ThesisManager.Models;

namespace ThesisManager.Presenters
{
    public class UserPresenter
    {
        IUser userView;
        private LoginForm viewRef;
        private DbHandler dbHandler;
        public UserPresenter(IUser view, LoginForm _viewRef)
        {
            userView = view;
            viewRef = _viewRef;

        }

        public void CheckLogin()
        {
            UserModel user = new UserModel();
            user.UserName = userView.UserNameText;
            user.Password = userView.PasswordText;
            
            dbHandler =  new DbHandler();
            if (dbHandler.CheckUserData(user.UserName, user.Password) == true)
            {
                viewRef.debugLabelValue.Text = "Zalogowano";
            }
            else
            {
                viewRef.debugLabelValue.Text = "Błedne dane";
            }
            

        }

        
    }
}
