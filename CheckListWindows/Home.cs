using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckListWindows
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            newLogin.Show();
        }
    }
}
