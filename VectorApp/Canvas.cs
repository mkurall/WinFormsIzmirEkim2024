using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    public class Canvas : Control
    {
        Point pt1 = new Point();//ilk tıklanan yer
        Point pt2 = new Point();//son bırakılan yer

        public Canvas() { }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, Width-1, Height-1));
            e.Graphics.DrawRectangle(Pens.Gray, new Rectangle(0, 0, Width - 1, Height - 1));
            ////

            e.Graphics.DrawRectangle(Pens.Black, Rectangle.FromLTRB(pt1.X, pt1.Y, pt2.X, pt2.Y));
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            pt1 = e.Location;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            pt2 = e.Location;

            Invalidate();
        }

    }
}
