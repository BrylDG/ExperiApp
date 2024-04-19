using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperiApp
{
    public partial class LoginUserControl : UserControl
    {
        public event EventHandler SignUpButtonClicked, SignInButtonClicked;

        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignInButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
