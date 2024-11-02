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
        bool isDouseDown = false;
        List<Sekil> sekilList = new List<Sekil>();

        Dortgen dortgen = new Dortgen();
        Cizgi cizgi = new Cizgi();

        public enum SekilTurleri { Pointer = 0, Dortgen = 1, Cizgi = 2};
        public SekilTurleri SekilTuru { get; set; }

        public Canvas() {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, Width-1, Height-1));
            e.Graphics.DrawRectangle(Pens.Gray, new Rectangle(0, 0, Width - 1, Height - 1));
            ////
            //Eski çizimleri çizdir
            foreach (var sekil in sekilList)
            {
                sekil.Paint(e.Graphics);//benim grafik alanıma kendini çiz
            }
            ///
            if (isDouseDown)
            {
                if(SekilTuru == SekilTurleri.Dortgen)
                {
          
                    dortgen.Bounds = Rectangle.FromLTRB( 
                        
                        Math.Min(pt1.X, pt2.X), Math.Min(pt1.Y, pt2.Y), Math.Max(pt1.X, pt2.X), Math.Max(pt1.Y, pt2.Y));
   


                    dortgen.Paint(e.Graphics);
                }
                else if(SekilTuru == SekilTurleri.Cizgi)
                {
                    cizgi.Bounds = Rectangle.FromLTRB(pt1.X, pt1.Y, pt2.X, pt2.Y);
                    cizgi.Paint(e.Graphics);
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            pt1 = e.Location;
            isDouseDown = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            pt2 = e.Location;
            Sekil sekil = null;

            if (SekilTuru == SekilTurleri.Dortgen)
                sekil = new Dortgen()
                {
                    Bounds = Rectangle.FromLTRB(

                        Math.Min(pt1.X, pt2.X), Math.Min(pt1.Y, pt2.Y),
                        Math.Max(pt1.X, pt2.X), Math.Max(pt1.Y, pt2.Y))
                };

            else if (SekilTuru == SekilTurleri.Cizgi)
                sekil = new Cizgi() { Bounds = Rectangle.FromLTRB(pt1.X, pt1.Y, pt2.X, pt2.Y) };


            sekilList.Add(sekil);

            Invalidate();
            isDouseDown = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            pt2 = e.Location;
            Invalidate();
        }
    }
}
