namespace Assign7
{
    partial class SpiderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msSpiderForm = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpider = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewSpider = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbortSpider = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveSpider = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSpiderForm = new System.Windows.Forms.ToolStrip();
            this.tslSpiderForm = new System.Windows.Forms.ToolStripLabel();
            this.tscbSpiderForm = new System.Windows.Forms.ToolStripComboBox();
            this.tsbNewSpider = new System.Windows.Forms.ToolStripButton();
            this.tsbAbortSpider = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveSpider = new System.Windows.Forms.ToolStripButton();
            this.lbSpiderStatus = new System.Windows.Forms.Label();
            this.tcMessages = new System.Windows.Forms.TabControl();
            this.msSpiderForm.SuspendLayout();
            this.tsSpiderForm.SuspendLayout();
            this.SuspendLayout();
            
            // msSpiderForm
            this.msSpiderForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiSpider,
            this.tsmiHelp});
            this.msSpiderForm.Location = new System.Drawing.Point(0, 0);
            this.msSpiderForm.Name = "msSpiderForm";
            this.msSpiderForm.Size = new System.Drawing.Size(565, 24);
            this.msSpiderForm.TabIndex = 0;
            this.msSpiderForm.Text = "menuStrip1";
            
            // tsmiFile
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            
            // tsmiExit
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.ExitMenuItem_Click);
            
            // tsmiSpider
            this.tsmiSpider.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewSpider,
            this.tsmiAbortSpider,
            this.tsmiRemoveSpider});
            this.tsmiSpider.Name = "tsmiSpider";
            this.tsmiSpider.Size = new System.Drawing.Size(52, 20);
            this.tsmiSpider.Text = "Spider";
            
            // tsmiNewSpider
            this.tsmiNewSpider.Name = "tsmiNewSpider";
            this.tsmiNewSpider.Size = new System.Drawing.Size(152, 22);
            this.tsmiNewSpider.Text = "New";
            this.tsmiNewSpider.Click += new System.EventHandler(this.NewSpiderMenuItem_Click);
 
            // tsmiAbortSpider
            this.tsmiAbortSpider.Enabled = false;
            this.tsmiAbortSpider.Name = "tsmiAbortSpider";
            this.tsmiAbortSpider.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbortSpider.Text = "Abort";
            this.tsmiAbortSpider.Click += new System.EventHandler(this.AbortMenuItem_Click);
            
            // tsmiRemoveSpider
            this.tsmiRemoveSpider.Enabled = false;
            this.tsmiRemoveSpider.Name = "tsmiRemoveSpider";
            this.tsmiRemoveSpider.Size = new System.Drawing.Size(152, 22);
            this.tsmiRemoveSpider.Text = "Clean away";
            this.tsmiRemoveSpider.Click += new System.EventHandler(this.RemoveMenuItem_Click);
            
            // tsmiHelp
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "Help";
            
            // tsmiAbout
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.AboutMenuItem_Click);
 
            // tsSpiderForm
            this.tsSpiderForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSpiderForm,
            this.tscbSpiderForm,
            this.tsbNewSpider,
            this.tsbAbortSpider,
            this.tsbRemoveSpider});
            this.tsSpiderForm.Location = new System.Drawing.Point(0, 24);
            this.tsSpiderForm.Name = "tsSpiderForm";
            this.tsSpiderForm.Size = new System.Drawing.Size(565, 25);
            this.tsSpiderForm.TabIndex = 1;
            this.tsSpiderForm.Text = "toolStrip1";
            
            // tslSpiderForm
            this.tslSpiderForm.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslSpiderForm.Name = "tslSpiderForm";
            this.tslSpiderForm.Size = new System.Drawing.Size(46, 22);
            this.tslSpiderForm.Text = "Spider:";
 
            // tscbSpiderForm
            this.tscbSpiderForm.DropDownWidth = 260;
            this.tscbSpiderForm.Name = "tscbSpiderForm";
            this.tscbSpiderForm.Size = new System.Drawing.Size(300, 25);
            this.tscbSpiderForm.SelectedIndexChanged += new System.EventHandler(this.cbSpiders_SelectedIndexChanged);
            
            // tsbNewSpider
            this.tsbNewSpider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewSpider.Image = global::Assign7.Properties.Resources.spider_new;
            this.tsbNewSpider.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewSpider.Name = "tsbNewSpider";
            this.tsbNewSpider.Size = new System.Drawing.Size(23, 22);
            this.tsbNewSpider.Text = "toolStripButton1";
            this.tsbNewSpider.ToolTipText = "New Spider";
            this.tsbNewSpider.Click += new System.EventHandler(this.NewSpiderMenuButton_Click);
 
            // tsbAbortSpider
            this.tsbAbortSpider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbortSpider.Enabled = false;
            this.tsbAbortSpider.Image = global::Assign7.Properties.Resources.spider_abort;
            this.tsbAbortSpider.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbortSpider.Name = "tsbAbortSpider";
            this.tsbAbortSpider.Size = new System.Drawing.Size(23, 22);
            this.tsbAbortSpider.Text = "toolStripButton2";
            this.tsbAbortSpider.ToolTipText = "Cancel Spider";
            this.tsbAbortSpider.Click += new System.EventHandler(this.AbortMenuButton_Click);
 
            // tsbRemoveSpider
            this.tsbRemoveSpider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveSpider.Enabled = false;
            this.tsbRemoveSpider.Image = global::Assign7.Properties.Resources.spider_clean;
            this.tsbRemoveSpider.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveSpider.Name = "tsbRemoveSpider";
            this.tsbRemoveSpider.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveSpider.Text = "toolStripButton3";
            this.tsbRemoveSpider.ToolTipText = "Remove Spider";
            this.tsbRemoveSpider.Click += new System.EventHandler(this.RemoveMenuButton_Click);

            // lbSpiderStatus 
            this.lbSpiderStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbSpiderStatus.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpiderStatus.Location = new System.Drawing.Point(4, 53);
            this.lbSpiderStatus.Name = "lbSpiderStatus";
            this.lbSpiderStatus.Size = new System.Drawing.Size(561, 28);
            this.lbSpiderStatus.TabIndex = 2;
            this.lbSpiderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // tcMessages
            this.tcMessages.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcMessages.ItemSize = new System.Drawing.Size(0, 1);
            this.tcMessages.Location = new System.Drawing.Point(4, 75);
            this.tcMessages.Name = "tcMessages";
            this.tcMessages.SelectedIndex = 0;
            this.tcMessages.Size = new System.Drawing.Size(561, 335);
            this.tcMessages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMessages.TabIndex = 3;
            
            // SpiderForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 414);
            this.Controls.Add(this.lbSpiderStatus);
            this.Controls.Add(this.tcMessages);
            this.Controls.Add(this.tsSpiderForm);
            this.Controls.Add(this.msSpiderForm);
            this.MainMenuStrip = this.msSpiderForm;
            this.Name = "SpiderForm";
            this.Text = "UVU INFO2200 - WebSpider";
            this.msSpiderForm.ResumeLayout(false);
            this.msSpiderForm.PerformLayout();
            this.tsSpiderForm.ResumeLayout(false);
            this.tsSpiderForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.MenuStrip msSpiderForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpider;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewSpider;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbortSpider;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveSpider;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStrip tsSpiderForm;
        private System.Windows.Forms.ToolStripLabel tslSpiderForm;
        private System.Windows.Forms.ToolStripComboBox tscbSpiderForm;
        private System.Windows.Forms.ToolStripButton tsbNewSpider;
        private System.Windows.Forms.ToolStripButton tsbAbortSpider;
        private System.Windows.Forms.ToolStripButton tsbRemoveSpider;
        private System.Windows.Forms.Label lbSpiderStatus;
        private System.Windows.Forms.TabControl tcMessages;
    }
}

