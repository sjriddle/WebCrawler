using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign7
{
    public class UriStack
    {
        // Creating the List of UriPath called stack
        List<UriPath> stack = new List<UriPath>();

        /// <summary>
        /// Click event to push to the UriPath
        /// </summary>
        /// <param name="path"></param>
        public void Push(UriPath path)
        {
            stack.Insert(0, path);
        }

        /// <summary>
        /// Click event to pop off the UriPath
        /// </summary>
        /// <returns></returns>
        public UriPath Pop()
        {
            // If Stack is not empy, pop
            if (!IsEmpty()) {
                UriPath p1 = stack[0];
                stack.RemoveAt(0);
                return p1;
            } else {
                return null;
            }
        }

        /// <summary>
        /// Returns the count of Urls in the stack.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return stack.Count;
        }

        /// <summary>
        /// Boolean to see if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            // If count = 0, stack returns empty/false
            return stack.Count == 0;
        }

    }
}
