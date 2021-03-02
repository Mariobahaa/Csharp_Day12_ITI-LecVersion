
namespace D12
{
    partial class frmNotepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotepad));
            this.txtUserInput = new System.Windows.Forms.RichTextBox();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenueItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenMenueItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveMenueItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdvancedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustDlgAdvancedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSave = new System.Windows.Forms.ToolStripMenuItem();
            this.CMClose = new System.Windows.Forms.ToolStripMenuItem();
            this.CMFont = new System.Windows.Forms.ToolStripMenuItem();
            this.CMColor = new System.Windows.Forms.ToolStripMenuItem();
            this.CMMyDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TBOpen = new System.Windows.Forms.ToolStripButton();
            this.TBSave = new System.Windows.Forms.ToolStripButton();
            this.TBClose = new System.Windows.Forms.ToolStripButton();
            this.TBFont = new System.Windows.Forms.ToolStripButton();
            this.TBColor = new System.Windows.Forms.ToolStripButton();
            this.TBMyDialog = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserInput
            // 
            this.txtUserInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserInput.Location = new System.Drawing.Point(0, 28);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(800, 422);
            this.txtUserInput.TabIndex = 0;
            this.txtUserInput.Text = "";
            this.txtUserInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserInput_MouseClick);
            this.txtUserInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUserInput_MouseDown);
            // 
            // dlgOpen
            // 
            this.dlgOpen.InitialDirectory = "D:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenueItem,
            this.EditMenuItem,
            this.AdvancedMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenueItem
            // 
            this.fileMenueItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenMenueItem,
            this.FileSaveMenueItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.fileMenueItem.Name = "fileMenueItem";
            this.fileMenueItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenueItem.Text = "File";
            // 
            // FileOpenMenueItem
            // 
            this.FileOpenMenueItem.Name = "FileOpenMenueItem";
            this.FileOpenMenueItem.Size = new System.Drawing.Size(175, 26);
            this.FileOpenMenueItem.Text = "Open";
            this.FileOpenMenueItem.Click += new System.EventHandler(this.FileOpenMenueItem_Click);
            // 
            // FileSaveMenueItem
            // 
            this.FileSaveMenueItem.Name = "FileSaveMenueItem";
            this.FileSaveMenueItem.Size = new System.Drawing.Size(175, 26);
            this.FileSaveMenueItem.Text = "Save";
            this.FileSaveMenueItem.Click += new System.EventHandler(this.FileSaveMenueItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 26);
            this.toolStripMenuItem1.Text = "-";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 26);
            this.toolStripMenuItem2.Text = "Close";
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditFontMenuItem,
            this.EditColorMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(49, 24);
            this.EditMenuItem.Text = "Edit";
            // 
            // EditFontMenuItem
            // 
            this.EditFontMenuItem.Name = "EditFontMenuItem";
            this.EditFontMenuItem.Size = new System.Drawing.Size(128, 26);
            this.EditFontMenuItem.Text = "Font";
            // 
            // EditColorMenuItem
            // 
            this.EditColorMenuItem.Name = "EditColorMenuItem";
            this.EditColorMenuItem.Size = new System.Drawing.Size(128, 26);
            this.EditColorMenuItem.Text = "Color";
            // 
            // AdvancedMenuItem
            // 
            this.AdvancedMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustDlgAdvancedMenuItem});
            this.AdvancedMenuItem.Name = "AdvancedMenuItem";
            this.AdvancedMenuItem.Size = new System.Drawing.Size(89, 24);
            this.AdvancedMenuItem.Text = "Advanced";
            // 
            // CustDlgAdvancedMenuItem
            // 
            this.CustDlgAdvancedMenuItem.Name = "CustDlgAdvancedMenuItem";
            this.CustDlgAdvancedMenuItem.Size = new System.Drawing.Size(161, 26);
            this.CustDlgAdvancedMenuItem.Text = "My Dialog";
            this.CustDlgAdvancedMenuItem.Click += new System.EventHandler(this.CustDlgAdvancedMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMOpen,
            this.CMSave,
            this.CMClose,
            this.CMFont,
            this.CMColor,
            this.CMMyDialog});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 148);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // CMOpen
            // 
            this.CMOpen.Name = "CMOpen";
            this.CMOpen.Size = new System.Drawing.Size(147, 24);
            this.CMOpen.Text = "Open";
            // 
            // CMSave
            // 
            this.CMSave.Name = "CMSave";
            this.CMSave.Size = new System.Drawing.Size(147, 24);
            this.CMSave.Text = "Save";
            // 
            // CMClose
            // 
            this.CMClose.Name = "CMClose";
            this.CMClose.Size = new System.Drawing.Size(147, 24);
            this.CMClose.Text = "Close";
            // 
            // CMFont
            // 
            this.CMFont.Name = "CMFont";
            this.CMFont.Size = new System.Drawing.Size(147, 24);
            this.CMFont.Text = "Font";
            // 
            // CMColor
            // 
            this.CMColor.Name = "CMColor";
            this.CMColor.Size = new System.Drawing.Size(147, 24);
            this.CMColor.Text = "Color";
            // 
            // CMMyDialog
            // 
            this.CMMyDialog.Name = "CMMyDialog";
            this.CMMyDialog.Size = new System.Drawing.Size(147, 24);
            this.CMMyDialog.Text = "My Dialog";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBOpen,
            this.TBSave,
            this.TBClose,
            this.TBFont,
            this.TBColor,
            this.TBMyDialog});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TBOpen
            // 
            this.TBOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TBOpen.Image = ((System.Drawing.Image)(resources.GetObject("TBOpen.Image")));
            this.TBOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBOpen.Name = "TBOpen";
            this.TBOpen.Size = new System.Drawing.Size(49, 24);
            this.TBOpen.Text = "Open";
            // 
            // TBSave
            // 
            this.TBSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TBSave.Image = ((System.Drawing.Image)(resources.GetObject("TBSave.Image")));
            this.TBSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBSave.Name = "TBSave";
            this.TBSave.Size = new System.Drawing.Size(44, 24);
            this.TBSave.Text = "Save";
            this.TBSave.ToolTipText = "Save";
            // 
            // TBClose
            // 
            this.TBClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TBClose.Image = ((System.Drawing.Image)(resources.GetObject("TBClose.Image")));
            this.TBClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBClose.Name = "TBClose";
            this.TBClose.Size = new System.Drawing.Size(49, 24);
            this.TBClose.Text = "Close";
            // 
            // TBFont
            // 
            this.TBFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TBFont.Image = ((System.Drawing.Image)(resources.GetObject("TBFont.Image")));
            this.TBFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBFont.Name = "TBFont";
            this.TBFont.Size = new System.Drawing.Size(42, 24);
            this.TBFont.Text = "Font";
            // 
            // TBColor
            // 
            this.TBColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TBColor.Image = ((System.Drawing.Image)(resources.GetObject("TBColor.Image")));
            this.TBColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(49, 24);
            this.TBColor.Text = "Color";
            this.TBColor.ToolTipText = "Color";
            // 
            // TBMyDialog
            // 
            this.TBMyDialog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TBMyDialog.Image = ((System.Drawing.Image)(resources.GetObject("TBMyDialog.Image")));
            this.TBMyDialog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBMyDialog.Name = "TBMyDialog";
            this.TBMyDialog.Size = new System.Drawing.Size(82, 24);
            this.TBMyDialog.Text = "My Dialog";
            // 
            // frmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNotepad";
            this.Text = "frmNotepad";
            this.Load += new System.EventHandler(this.frmNotepad_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmNotepad_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtUserInput;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenueItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenMenueItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveMenueItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem EditFontMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdvancedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustDlgAdvancedMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMOpen;
        private System.Windows.Forms.ToolStripMenuItem CMSave;
        private System.Windows.Forms.ToolStripMenuItem CMClose;
        private System.Windows.Forms.ToolStripMenuItem CMFont;
        private System.Windows.Forms.ToolStripMenuItem CMColor;
        private System.Windows.Forms.ToolStripMenuItem CMMyDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TBOpen;
        private System.Windows.Forms.ToolStripButton TBSave;
        private System.Windows.Forms.ToolStripButton TBClose;
        private System.Windows.Forms.ToolStripButton TBFont;
        private System.Windows.Forms.ToolStripButton TBColor;
        private System.Windows.Forms.ToolStripButton TBMyDialog;
    }
}