using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Samuel Riddle
/// INFO 2200
/// Assignment 7
/// 11/7/2017
/// </summary>
namespace Assign7
{
    public class UriQueue
    {
        // List that creates a queue
        List<UriPath> queue = new List<UriPath>();
        
        /// <summary>
        /// insert item into the Queue
        /// </summary>
        /// <returns></returns>
        public void Insert(UriPath path)
        {
            queue.Add(path);
        }

        /// <summary>
        /// Way to remove item from queue
        /// </summary>
        /// <returns></returns>
        public UriPath Remove()
        {
            // If queue is not empy, remove
            if (!IsEmpty())
            {
                UriPath p2 = queue[0];
                queue.RemoveAt(0);
                return p2;
            }
            // If we can't removre, return null
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the count of Urls in the queue.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return queue.Count;
        }

        /// <summary>
        /// Boolean to see if queue is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            // If count = 0, queue returns empty/false
            return queue.Count == 0;
        }
    }
}
