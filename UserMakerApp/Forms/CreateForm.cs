using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMakerApp.Utilities;

namespace UserMakerApp.Forms
{
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (FieldValidator.areFielsStuffed(txtGetNewUserName.Text, txtGetNewPass.Text,txtGetRepeatNewPass.Text))
            {
                if (FieldValidator.isPassMatch(txtGetNewPass.Text, txtGetRepeatNewPass.Text))
                    UserManagement.UserManagement.MakeUser(txtGetNewUserName.Text, txtGetNewPass.Text);
                else
                    MessageBox.Show("Passwords do not match");
            }
            else
                MessageBox.Show("Please Add Fields");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
