using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Gradient
{
    class PanelGradient : Panel
    {
        public Color CorCima {get; set;}
        public Color CorBaixo { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush Degrade = new LinearGradientBrush(this.ClientRectangle, CorCima,CorBaixo, 90f);
            Graphics Graf = e.Graphics;
            Graf.FillRectangle(Degrade, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
