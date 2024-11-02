using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    public class Sekil
    {
        public Sekil()
        {
            
        }
        public Rectangle Bounds { get; set; }
        public Color CizgiRengi { get; set; }
        public Color DolguRengi { get; set; }
        public int CizgiKalinligi { get; set; }
        public virtual void Paint(Graphics g) { }//kendini nasıl çizeceğini bilmiyor
    }

    public class Dortgen : Sekil
    {
        public Dortgen()
        {
            
        }
        public override void Paint(Graphics g)
        {
            
            g.DrawRectangle(new Pen(CizgiRengi, CizgiKalinligi), Bounds);
        }
    }

    public class Cizgi : Sekil
    {
        public Cizgi()
        {
            
        }
        public override void Paint(Graphics g)
        {
            g.DrawLine(new Pen(CizgiRengi, CizgiKalinligi), new Point(Bounds.X, Bounds.Y), new Point(Bounds.Right, Bounds.Bottom));
        }
    }
}
