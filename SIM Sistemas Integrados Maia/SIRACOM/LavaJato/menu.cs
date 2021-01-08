using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LavaJato
{
    public class menu: ToolStrip
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            this.BackColor = System.Drawing.Color.SlateGray;
        }
    }
}
