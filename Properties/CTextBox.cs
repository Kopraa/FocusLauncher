using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusLauncher.Properties
{
    public partial class CTextBox : UserControl
    {
        private Color borderColor = Color.Orange;
        private int borderSize = 2;
        private bool underlinedStyles = false;

        public CTextBox()
        {
            InitializeComponent();
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public bool UnderlinedStyles
        {
            get
            {
                return underlinedStyles;
            }
            set
            {
                underlinedStyles = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using Pen penBorder = new(borderColor, borderSize);
            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            if (underlinedStyles)
                graph.DrawLine(penBorder, 0, Height - 1, Width - 1, Height - 1);
        }
    }
}
