/**
 * Created by Dan McDonald
 * Utah Valley University (UVU)
 * Assignment 7 - INFO 2200
 * July 15, 2013
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign7
{
    public partial class SpiderDialog : Form
    {
        string _startUrl;
        int _depth;
        string _spiderName;
        string _searchType;

        /// <summary>
        /// Returns the StartUrl
        /// </summary>
        public string StartUrl
        {
            get { return _startUrl; }
            set { _startUrl = value; }
        }

        /// <summary>
        /// Returns the SpiderName
        /// </summary>
        public string SpiderName
        {
            get { return _spiderName; }
            set { _spiderName = value; }
        }

        /// <summary>
        /// Returns the type of search to be performed.
        /// </summary>
        public string SearchType
        {
            get { return _searchType; }
            set { _searchType = value; }
        }

        /// <summary>
        /// Returns the requested depth of the search.
        /// </summary>
        public int Depth
        {
            get { return _depth; }
            set { _depth = value; }
        }
        
        /// <summary>
        /// The constructor for the SpiderDialog
        /// </summary>
        public SpiderDialog()
        {
            InitializeComponent();
            tbDepth.Text = tbarSearchDepth.Value.ToString();
        }

        /// <summary>
        /// The event listener for the okay button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOkay_Click(object sender, EventArgs e)
        {
            try
            {
                Depth = int.Parse(tbDepth.Text);
                StartUrl = tbUrl.Text;
                SpiderName = tbName.Text;
                if (rbQueue.Checked)
                {
                    SearchType = Spider.BFS;
                }
                else
                {
                    SearchType = Spider.DFS;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// The event listener for the Cancel button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// An event listener for the scroll control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSearchDepth_Scroll(object sender, EventArgs e)
        {
            tbDepth.Text = tbarSearchDepth.Value.ToString();
        }

        /// <summary>
        /// An event listener for the changing value of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDepth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbarSearchDepth.Value = int.Parse(tbDepth.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
