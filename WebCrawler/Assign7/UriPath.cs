using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign7
{
    public class UriPath
    {
        public LinkedList<Uri> linkedList = new LinkedList<Uri>();

        /// <summary>
        /// Constructor that takes a starting Uri.
        /// </summary>
        /// <param name="uri"></param>
        public UriPath(Uri uri)
        {
            linkedList.AddFirst(uri);
        }

        /// <summary>
        /// Parameter-less constructor for the Copy method.
        /// </summary>
        public UriPath()
        {
        }

        /// <summary>
        /// Event that adds to the URI linked list
        /// </summary>
        /// <param name="uri"></param>
        public void Add(Uri uri)
        {
            if (!linkedList.Contains(uri))
                linkedList.AddLast(uri);
        }

        /// <summary>
        /// Returns the Uri at the ith position.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Uri Get(int i)
        {
            return linkedList.ElementAt(i);
        }

        /// <summary>
        /// Returns the number of Uris is the path.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return linkedList.Count;
        }

        /// <summary>
        /// Returns the last Uri in the path.
        /// </summary>
        /// <returns></returns>
        public Uri GetLast()
        {
            return linkedList.Last();
        }

        /// <summary>
        /// Copies the entire path.
        /// </summary>
        /// <returns></returns>
        public UriPath Copy()
        {
            UriPath cl = new UriPath();
            foreach (Uri u in linkedList) {
                cl.linkedList.AddLast(u);
            }            
            return cl;
        }
        
        /// <summary>
        /// Returns whether the URLList contains a given URL
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public Boolean Contains(Uri uri)
        {
            return linkedList.Contains(uri);
        }

    }
}
