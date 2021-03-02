using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           // this.BackColor = Color.DarkSlateBlue;
            InitializeComponent();

            //ResizeBegin += (sender, e) => this.Opacity = 0.5;
        }
        ///Child Subsc. to Base event
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            this.Opacity = 1;
        }

        private void ChangeOpacity(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        //private void Form1_ResizeBegin(object sender, EventArgs e)
        //{
        //    this.Opacity = 0.5;
        //}
    }
}
