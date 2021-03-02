using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D12
{
    public partial class frmGDI : Form
    {
        public frmGDI()
        {
            InitializeComponent();

            //this.ResizeRedraw = true; ///Raise Paint event whenever Resize

            this.Resize += (sender, e) => Invalidate();

            this.MouseClick += FrmGDI_MouseClick;

        }
        List<Point> pLst = new List<Point>();
        private void FrmGDI_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics G = this.CreateGraphics();

            if ( e.Button == MouseButtons.Left)
            {
                G.FillEllipse(Brushes.YellowGreen , e.X - 15, e.Y - 15, 30, 30);
                G.DrawEllipse(Pens.DarkGoldenrod, e.X-15, e.Y-15, 30, 30);
                pLst.Add(e.Location);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Font MyFont = new Font(this.Font.FontFamily, 18);
            string Msg = "Hello GDI+";
            var TextSize = e.Graphics.MeasureString(Msg, MyFont);
            SolidBrush MyBrush = new SolidBrush(Color.FromArgb(this.Width%255, this.Height%255, (Width + Height)%255));

            e.Graphics.DrawString(Msg,
                //this.Font, 
                MyFont,
                MyBrush,
                //Brushes.DarkTurquoise, 
                (ClientSize.Width - TextSize.Width)/2 ,
                (ClientSize.Height - TextSize.Height )/ 2
                //100, 100
                );

            foreach (var item in pLst)
            {
                e.Graphics.FillEllipse(Brushes.YellowGreen, item.X - 15, item.Y - 15, 30, 30);
                e.Graphics.DrawEllipse(Pens.DarkGoldenrod, item.X - 15, item.Y - 15, 30, 30);
            }

        }

        
    }
}
