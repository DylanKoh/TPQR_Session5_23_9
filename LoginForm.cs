using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session5_23_9
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Ensure no empty field(s)!");
            }
            else
            {
                using (var context = new Session5Entities())
                {
                    var findUser = (from x in context.Users
                                    where x.userId == txtUserID.Text
                                    select x).FirstOrDefault();
                    if (findUser == null)
                    {
                        MessageBox.Show("User does not exist!");
                    }
                    else if (findUser.passwd != txtPassword.Text)
                    {
                        MessageBox.Show("Password incorrect!");
                    }
                    else
                    {
                        MessageBox.Show("Welcome!");
                        Hide();
                        (new AdminMain()).ShowDialog();
                        Close();
                    }
                }
            }
        }
    }
}
