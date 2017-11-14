using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign7
{
    public class SpiderLogger : TextBox
    {
        public SpiderLogger()
        {
            this.Location = new System.Drawing.Point(0, 54);
            this.Multiline = true;
            this.Size = new System.Drawing.Size(428, 314);
        }

    }
}
