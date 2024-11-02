using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    public abstract class Sekil
    {
        public Rectangle Bounds { get; set; }

        public abstract void Paint(Graphics g);//kendini nasıl çizeceğini bilmiyor
    }

    public class Dortgen : Sekil
    {
        public override void Paint(Graphics g)
        {
            g.DrawRectangle(Pens.Black, Bounds);
        }
    }

    public class Cizgi : Sekil
    {
        public override void Paint(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(Bounds.X, Bounds.Y), new Point(Bounds.Right, Bounds.Bottom));
        }
    }
}
