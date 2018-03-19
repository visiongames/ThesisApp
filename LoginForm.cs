using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisManager.Views;
using ThesisManager.Presenters;


namespace ThesisManager
{
    public partial class LoginForm : Form, IUser
    {
        private UserPresenter userPresenter;
        public MainAppForm mainAppRef;
        public LoginForm()
        {
            InitializeComponent();
        }

        public string UserNameText
        {
            get
            {
                return txtUserName.Text;
            }
            set
            {
                txtUserName.Text = value;
            }
        }

        public string PasswordText
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }

        public void DebugLog(string _debug)
        {
            debugLabelValue.Text = _debug;
        }

        
        private void ThesisView_Load(object sender, EventArgs e)
        {
            userPresenter = new UserPresenter(this,this);
            
        }

        private void CheckLogin_Click(object sender, EventArgs e)
        {
            
            userPresenter.CheckLogin();
            //this.Hide();
            //RegisterThesisForm registerForm = new RegisterThesisForm();
            //registerForm.Show();
            //DebugLog(txtUserName.Text);
            
        }

        private void btThesisAdd_Click(object sender, EventArgs e)
        {
            mainAppRef.OpenAddThesisForm();
            //mainAppFormRef.ShowTherisRegisterForm();
            //mainAppFormRef.mainAppPanel.Controls.Clear();
            //RegisterThesisForm registerForm = new RegisterThesisForm();
            //registerForm.TopLevel = false;
            //registerForm.Dock = mainAppFormRef.mainAppPanel.Dock;
            //mainAppFormRef.mainAppPanel.Controls.Add(registerForm);
            //registerForm.Show();

            //mainAppPanel.Controls.Clear();
            //LoginForm loginForm = new LoginForm();
            //loginForm.TopLevel = false;
            //loginForm.Dock = mainAppPanel.Dock;
            //mainAppPanel.Controls.Add(loginForm);
            //loginForm.Show();
            //loginForm.mainAppFormRef = this;
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}
