using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBA_Central.CustomControls
{
    public partial class ScrollingText : Label
    {
        private int poz, vit;

        public ScrollingText()
        {
            InitializeComponent();

            AutoSize = true;
            UseCompatibleTextRendering = true;
            this.BackColor = Color.Transparent;
            timer1.Start();
        }

        public int Seteaza_Viteza { get { return vit; } set { vit = value; Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform((float)poz, 0);

            base.OnPaint(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(poz < -Width) poz = this.Parent.Width;

            poz -= vit;
            Invalidate();
        }
    }
}
