using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Assign7
{
    public class Spider
    {
        public const string DFS = "STACK-DFS";
        public const string BFS = "QUEUE-DFS";
        private String _spiderName;
        private String _spiderType;
        private String _startUrl;
        private Boolean _complete;
        private int _maxDepth;
        private Boolean _stopMe;
        private List<SpiderMessenger> messengers;
        private WebBrowser webBrowser;
        private int visited;
        private UriStack stack;
        private UriQueue q;
        private UriPath path;
        private String nextUrl;

        /// <summary>
        /// Constructor called from the SpiderFrom that builds the Spider
        /// </summary>
        /// <param name="spidername"></param>
        /// <param name="starturl"></param>
        /// <param name="depth"></param>
        /// <param name="spidertype"></param>
        public Spider(string spidername, string starturl, int depth, string spidertype) {
            _spiderName = spidername;
            _spiderType = spidertype;
            _startUrl = starturl;
            _maxDepth = depth;
            Complete = false;
            messengers = new List<SpiderMessenger>();
            webBrowser = new WebBrowser();
            webBrowser.ScriptErrorsSuppressed = true;
            stack = new UriStack();
            q = new UriQueue();
            AddPage(new UriPath(new Uri(StartUrl)));
            visited = 0;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(GetHyperlinks);
        }

        /// <summary>
        /// Starts the processing of the spider.
        /// </summary>
        public void RunSpider() {
            nextUrl = "";
            if (!StorageEmpty(stack, q) && !StopMe) {
                path = GetPage();
                if (path == null) {
                    Complete = true;
                } else {
                    Uri next = path.GetLast();
                    Message();
                    nextUrl = next.ToString();
                    try {
                        webBrowser.Url = next;
                    } catch (Exception e) {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Checks whether there are any Uri in storage
        /// </summary>
        /// <param name="stack"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public Boolean StorageEmpty(UriStack stack, UriQueue q) {
            if (SpiderType == DFS) {
                return stack.IsEmpty();
            } else if (SpiderType == BFS) {
                return q.IsEmpty();
            } else {
                return false;
            }
        }

        /// <summary>
        /// Method that updates the GUI via the MesssageDisplayer interface.
        /// </summary>
        private void Message() {
            if (SpiderType == DFS) {
                this.Log("Current depth: " + path.Count() + "\tURLs visited: " + visited + "\tSize of URL storage: " + stack.Count() + "\n");
            } else if (SpiderType == BFS) {
                this.Log("Current depth: " + path.Count() + "\tURLs visited: " + visited + "\tSize of URL storage: " + q.Count() + "\n");
            }
        }

        /// <summary>
        /// Adds a page to the Uri storage.
        /// </summary>
        /// <param name="ul"></param>
        public void AddPage(UriPath ul) {
            if (SpiderType == DFS) {
                stack.Push(ul);
            } else if (SpiderType == BFS) {
                q.Insert(ul);
            }
        }

        /// <summary>
        /// Gets the next page from the Uri storage
        /// </summary>
        /// <returns></returns>
        public UriPath GetPage() {
            if (SpiderType == DFS) {
                return stack.Pop();
            } else {
                return q.Remove();
            }
        }


        /// <summary>
        /// Gets the hyperlinks off the page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetHyperlinks(object sender, WebBrowserDocumentCompletedEventArgs e) {
            visited++;
            String linkText;
            HtmlDocument document = webBrowser.Document;
            HtmlElementCollection linkCollection = document.Links;
            foreach (HtmlElement link in linkCollection) {
                if (StopMe) {
                    Complete = true;
                    break;
                }
                linkText = link.GetAttribute("href");
                if (linkText.EndsWith("html") || linkText.EndsWith("php") || linkText.EndsWith("htm") || linkText.EndsWith("jsp") || linkText.EndsWith("asp") || linkText.EndsWith("/") || linkText.EndsWith("com") || linkText.EndsWith("net") || linkText.EndsWith("org") || linkText.EndsWith("us") || linkText.EndsWith("uk")) {
                    if (!linkText.StartsWith("mailto")) {
                        if (path.Count() < MaxDepth) {
                            try {
                                Uri url = new Uri(linkText);
                                if (!path.Contains(url)) {
                                    UriPath newPath = path.Copy();
                                    newPath.Add(url);
                                    AddPage(newPath);
                                }
                            } catch (Exception except) {
                                Console.WriteLine(except.ToString());
                            }
                        }
                    }
                }
            }
            if (!Complete) {
                RunSpider();
            }
        }

        /// <summary>
        /// Returns the name of the Spider, used as the name for the tab on the GUI
        /// </summary>
        public String SpiderName {
            get { return _spiderName; }
            set { _spiderName = value; }
        }

        /// <summary>
        /// Returns the maximum requested depth
        /// </summary>
        public int MaxDepth {
            get { return _maxDepth; }
            set { _maxDepth = value; }
        }

        /// <summary>
        /// Returns whether the the spider should be stopped.
        /// </summary>
        public Boolean StopMe {
            get { return _stopMe; }
            set { _stopMe = value; }
        }

        /// <summary>
        /// Returns whether the Spider is complete.
        /// </summary>
        public Boolean Complete {
            get { return _complete; }
            set { _complete = value; }
        }

        /// <summary>
        /// Returns the search strategy of the spider.
        /// </summary>
        public String SpiderType {
            get { return _spiderType; }
            set { _spiderType = value; }
        }

        /// <summary>
        /// Returns the start Url string.
        /// </summary>
        public String StartUrl {
            get { return _startUrl; }
            set { _startUrl = value; }
        }


        /// <summary>
        /// Abort this spider following the current page parse
        /// </summary>
        public void Abort() {
            StopMe = true;
            Complete = true;
        }

        /// <summary>
        /// Relays log messages to those registered MessageDisplayers.
        /// </summary>
        /// <param name="message"></param>
        private void Log(String message) {
            for (int i = 0; i < messengers.Count; i++) {
                messengers[i].Log(message);
            }
        }


        /// <summary>
        /// Add messengers to be reported
        /// </summary>
        /// <param name="sm"></param>
        public SpiderMessenger CreateSpiderMessenger() {
            SpiderMessenger sm = new SpiderMessenger();
            messengers.Add(sm);
            sm.Log("Starting spider...\n");
            return sm;
        }

        /// <summary>
        /// Remove the SpiderMessenger
        /// </summary>
        /// <param name="sm"></param>
        public void RemoveSpiderMessenger(SpiderMessenger sm) {
            messengers.Remove(sm);
        }

        /// <summary>
        /// Return whether the spider is active.
        /// </summary>
        /// <returns></returns>
        public Boolean IsActive() {
            return !Complete;
        }

        /// <summary>
        /// Returns the status
        /// </summary>
        /// <returns></returns>
        public string GetStatus() {
            if (Complete) {
                return "inactive";
            } else {
                return "active";
            }
        }

        /// <summary>
        /// Overrides teh ToString method.
        /// </summary>
        /// <returns></returns>
        public override String ToString() {
            return SpiderName;
        }
    }
}
