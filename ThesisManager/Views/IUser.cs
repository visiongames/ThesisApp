using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisManager.Views
{
    public interface IUser
    {
        string UserNameText { get; set; }
        string PasswordText { get; set; }
    }
}
