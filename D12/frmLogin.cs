using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D12
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            btnClose.Click += (sender, e) => this.Close();

            this.FormClosing += FrmLogin_FormClosing;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure you want to exit?(Y|N)",
                 "Warnning",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2
                 ) == DialogResult.No)
                e.Cancel = true;
        }

        frmHomePage frm = new frmHomePage();

        private void btnOk_Click(object sender, EventArgs e)
        {
           // if ((txtUserName.Text == "ABC") && (txtUserPassword.Text == "123"))
            {
                this.Hide();
                frm.ShowDialog();
                //this.Text = "Test";
                this.Visible = true;
            }
        }
    }
}
