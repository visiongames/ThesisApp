using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisManager
{
    public partial class MainAppForm : Form
    {
        public MainAppForm()
        {
            InitializeComponent();
        }

        private LoginForm loginForm;

        private void MainAppForm_Load(object sender, EventArgs e)
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
                loginForm.mainAppRef = this;
                loginForm.MdiParent = this;
                loginForm.FormClosed += new FormClosedEventHandler(loginForm_FormClosed);
                loginForm.Show();
            }
            else
            {
                loginForm.Activate();
            }
        }

        void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm = null;
        }

        public void OpenAddThesisForm()
        {
            RegisterThesisForm registerThesis = new RegisterThesisForm();
            loginForm.Close();
            
            registerThesis.MdiParent = this;
            registerThesis.StartPosition = this.StartPosition;
            registerThesis.Show();
        }
    }
}
