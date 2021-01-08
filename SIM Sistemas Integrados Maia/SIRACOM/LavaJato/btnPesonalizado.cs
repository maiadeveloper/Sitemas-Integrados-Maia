using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LavaJato
{
    public class btnPesonalizado: Button
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = System.Drawing.Color.Beige;
        }

        protected override void OnLostFocus(EventArgs e)

        {
            base.OnLostFocus(e);
            this.BackColor = System.Drawing.Color.White;
        }
    }
}
