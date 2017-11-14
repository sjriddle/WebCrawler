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

namespace Assign7
{
    public interface IMessageObserver
    {
        /// <summary>
        /// Log a message to the MessageDisplayer
        /// </summary>
        /// <param name="message"></param>
        void Log(String message);
    }
}
