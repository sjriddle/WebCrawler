using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Assign7
{
    public partial class SpiderForm : Form
    {
        private const String NO_SPIDER_MSG = "No spiders...";
        private Spider spidie;
        private List<Thread> threadCollection = new List<Thread>();

        /// <summary>
        ///  SpiderForm constructor
        /// </summary>
        public SpiderForm()
        {
            InitializeComponent();
            lbSpiderStatus.Text = NO_SPIDER_MSG;

        }

        /// <summary>
        /// Launches the SpiderDialog to collect the information. 
        /// If the Dialog is confirmed, a Spider is created and started.
        /// </summary>
        private void NewSpiderDialog()
        {
            SpiderDialog spiderDialog = new SpiderDialog();
            spiderDialog.ShowDialog();

            if (spiderDialog.DialogResult == DialogResult.OK) {
                spidie = new Spider(spiderDialog.SpiderName, spiderDialog.StartUrl, spiderDialog.Depth, spiderDialog.SearchType);
                SpiderMessenger sm = spidie.CreateSpiderMessenger();
                tscbSpiderForm.Items.Add(spidie);
                TabPage tabPage = new TabPage();                
                tabPage.Name = spiderDialog.SpiderName;
                tcMessages.Controls.Add(tabPage);
                SelectSpiderToView(spidie);
                //sm.Log("Starting spider...\n");
                //Thread thread = new Thread(spidie.RunSpider);
                //thread.Start();
                //threadCollection.Add(thread);
                spidie.RunSpider();
                Application.DoEvents();
                tabPage.Controls.Add(sm);
            }
        }

        /// <summary>
        /// Stops a running Spider.
        /// </summary>
        private void AbortSpider()
        {
            Spider spider = (Spider)tscbSpiderForm.SelectedItem;
            spider.Abort();
        }

        /// <summary>
        /// Removes a completed or stopped Spider.
        /// </summary>
        private void RemoveSpider()
        {
            Spider spider = (Spider)tscbSpiderForm.SelectedItem;
            tscbSpiderForm.Items.Remove(spider);
            tscbSpiderForm.Text = "";
            if (tscbSpiderForm.Items.Count == 0)
            {
                lbSpiderStatus.Text = NO_SPIDER_MSG;
                tcMessages.Controls.RemoveAt(tcMessages.SelectedIndex);
                tsbAbortSpider.Enabled = false;
                tsbRemoveSpider.Enabled = false;
                tsmiAbortSpider.Enabled = false;
                tsmiRemoveSpider.Enabled = false;
                Application.DoEvents();
            }
        }
        
        /// <summary>
        /// Process selection of GUI from pulldown, or a change initiated By the GUI itself (e.g. one spiderMenu is removed so the next on the listBox gets shown
        /// </summary>
        /// <param name="spider"></param>
        private void SelectSpiderToView(Spider spider)
        {
            tscbSpiderForm.SelectedItem = spider;
            String label = "Name: "+spider.SpiderName+" Type: "+spider.SpiderType+" URL: " + spider.StartUrl+ " Depth: " + spider.MaxDepth + " (" + spider.GetStatus() + ")";
            lbSpiderStatus.Text = label;
            tcMessages.SelectTab(spider.SpiderName);
            tsbAbortSpider.Enabled = spider.IsActive();
            tsbRemoveSpider.Enabled = !spider.IsActive();
            tsmiAbortSpider.Enabled = spider.IsActive();
            tsmiRemoveSpider.Enabled = !spider.IsActive();
        }

        /// <summary>
        /// Method from the SpiderObserver that changes the Spider being watched.
        /// </summary>
        /// <param name="spider"></param>
        public void SpiderChanged(Spider spider)
        {
            Spider spidie = (Spider)tscbSpiderForm.SelectedItem;
            SelectSpiderToView(spidie);
        }

        /// <summary>
        /// Event listener for the About form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            SpiderAbout about = new SpiderAbout();
            about.ShowDialog();
        }

        /// <summary>
        /// Event listener for the exit menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Menu listener for creating a new Spider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewSpiderMenuItem_Click(object sender, EventArgs e)
        {
            NewSpiderDialog();
        }

        /// <summary>
        /// Menu button listener for creating a new Spider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewSpiderMenuButton_Click(object sender, EventArgs e)
        {
            NewSpiderDialog();
        }

        /// <summary>
        /// Menu listener for aborting a spider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AbortMenuItem_Click(object sender, EventArgs e)
        {
            AbortSpider();
        }

        /// <summary>
        /// Menu button listener for aborting a spider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AbortMenuButton_Click(object sender, EventArgs e)
        {
            AbortSpider();
        }

        /// <summary>
        /// Menu button listener for removing a spider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveMenuButton_Click(object sender, EventArgs e)
        {
            RemoveSpider();
        }

        /// <summary>
        /// Menu listener for removing a spider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSpider();
        }

        /// <summary>
        /// Listener on the combo box that acts when the selected index changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSpiders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Spider spider = (Spider)tscbSpiderForm.SelectedItem;
            if (spider != null) {
                SelectSpiderToView(spider);
            }
        }
    }
}
