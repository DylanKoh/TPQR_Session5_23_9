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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new LoginForm()).ShowDialog();
            Close();
        }

        private void btnAssignSeating_Click(object sender, EventArgs e)
        {
            Hide();
            (new AssignSeating()).ShowDialog();
            Close();
        }

        private void btnEnterMarks_Click(object sender, EventArgs e)
        {
            Hide();
            (new EnterMarks()).ShowDialog();
            Close();
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            Hide();
            (new ViewResults()).ShowDialog();
            Close();
        }
    }
}
