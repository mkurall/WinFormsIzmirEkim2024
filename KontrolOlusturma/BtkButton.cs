using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolOlusturma
{
    public class BtkButton : Button
    {
        public BtkButton()
        {
            BackColor = Color.BlueViolet;
            ForeColor = Color.White;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            BackColor = Color.Yellow;
            ForeColor = Color.Black;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BackColor = Color.BlueViolet;
            ForeColor = Color.White;
        }
    }
}
