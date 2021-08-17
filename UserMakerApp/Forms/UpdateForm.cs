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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (FieldValidator.areFielsStuffed(txtGetUserName.Text, txtGetNewPass.Text, txtGetRepeatNewPass.Text))
            {
                if (FieldValidator.isPassMatch(txtGetNewPass.Text, txtGetRepeatNewPass.Text))
                    UserManagement.UserManagement.UpdateUser(txtGetUserName.Text, txtGetNewPass.Text);
                else
                    MessageBox.Show("Passwords do not match");
            }
            else
                MessageBox.Show("Please Add Fields");
        }
    }
}
