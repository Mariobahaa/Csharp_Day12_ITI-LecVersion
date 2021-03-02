using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D12
{
    public partial class frmDlg : Form
    {
        public frmDlg()
        {
            InitializeComponent();
        }

        public string CustText
        {
            get => txtCustText.Text;
            internal set => txtCustText.Text = value;
        }
       
    }
}
