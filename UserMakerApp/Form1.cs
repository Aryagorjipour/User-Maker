using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMakerApp.Forms;

namespace UserMakerApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form form = new frmCreate();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form form = new frmUpdate();
            form.ShowDialog();
        }
    }
}
