/**
 * Created by Dan McDonald
 * Utah Valley University (UVU)
 * Assignment 7 - INFO 2200
 * July 15, 2013
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign7
{
    public class SpiderMessenger: TextBox, IMessageObserver
    {
        /// <summary>
        /// Constructor for SpiderMessenger, a TextBox with a Log method added to it.
        /// </summary>
        public SpiderMessenger()
        {
            this.Location = new System.Drawing.Point(3, 3);
            this.Multiline = true;
            this.Size = new System.Drawing.Size(550, 320);
            this.ScrollBars = ScrollBars.Vertical;
        }

        public void Log(String message)
        {
            this.AppendText(message);
        }
    }
}
