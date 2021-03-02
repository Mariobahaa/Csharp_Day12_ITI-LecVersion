using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D12
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();

           // OpenToolStripBtn.Click += (sender, e) => fileMenueItem.PerformClick();
        }

        private void FileOpenMenueItem_Click(object sender, EventArgs e)
        {
            if ( dlgOpen.ShowDialog() == DialogResult.OK)
                txtUserInput.LoadFile(dlgOpen.FileName , (RichTextBoxStreamType)(dlgOpen.FilterIndex-1));
        }

        private void frmNotepad_Load(object sender, EventArgs e)
        {
            dlgOpen.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            dlgSave.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";

            EditColorMenuItem.Click += EditColorMenuItem_Click;
            EditFontMenuItem.Click += EditFontMenuItem_Click;

            CMOpen.Click += FileOpenMenueItem_Click;
            CMClose.Click += CloseWin;
            CMSave.Click += FileSaveMenueItem_Click;
            CMFont.Click += EditFontMenuItem_Click;
            CMColor.Click += EditColorMenuItem_Click;
            CMMyDialog.Click += CustDlgAdvancedMenuItem_Click;


            TBOpen.Click += FileOpenMenueItem_Click;
            TBClose.Click += CloseWin;
            TBSave.Click += FileSaveMenueItem_Click;
            TBFont.Click += EditFontMenuItem_Click;
            TBColor.Click += EditColorMenuItem_Click;
            TBMyDialog.Click += CustDlgAdvancedMenuItem_Click;

        }
        private void CloseWin(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFontMenuItem_Click(object sender, EventArgs e)
        {
            if (txtUserInput.SelectedText?.Length > 0)
                dlgFont.Font = txtUserInput.SelectionFont;

            if (dlgFont.ShowDialog() == DialogResult.OK)
                txtUserInput.SelectionFont = dlgFont.Font;
        }

        private void EditColorMenuItem_Click(object sender, EventArgs e)
        {
            if (txtUserInput.SelectedText?.Length > 0)
                dlgColor.Color = txtUserInput.SelectionColor;

            if (dlgColor.ShowDialog() == DialogResult.OK)
                txtUserInput.SelectionColor = dlgColor.Color;
        }

        private void FileSaveMenueItem_Click(object sender, EventArgs e)
        {
            if ( dlgSave.ShowDialog() == DialogResult.OK)
            {
                switch ( dlgSave.FilterIndex)
                {
                    case 1:
                        txtUserInput.SaveFile(dlgSave.FileName , RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        txtUserInput.SaveFile(dlgSave.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
            }
        }

        frmDlg CustDlg = new frmDlg();

        private void CustDlgAdvancedMenuItem_Click(object sender, EventArgs e)
        {
            CustDlg.CustText = "Type Here";
            if (CustDlg.ShowDialog() == DialogResult.OK)
                txtUserInput.AppendText(CustDlg.CustText);
        }

        private void txtUserInput_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void frmNotepad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show();
        }

        private void txtUserInput_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show();

        }
    }
}
