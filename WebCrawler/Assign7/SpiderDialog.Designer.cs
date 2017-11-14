namespace Assign7
{
    partial class SpiderDialog
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
            this.lbSpiderName = new System.Windows.Forms.Label();
            this.lbStartingUrl = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.gbDataStructure = new System.Windows.Forms.GroupBox();
            this.rbQueue = new System.Windows.Forms.RadioButton();
            this.rbStack = new System.Windows.Forms.RadioButton();
            this.tbarSearchDepth = new System.Windows.Forms.TrackBar();
            this.gbDepth = new System.Windows.Forms.GroupBox();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.gbDataStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSearchDepth)).BeginInit();
            this.gbDepth.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSpiderName
            // 
            this.lbSpiderName.Font = new System.Drawing.Font("Moire", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpiderName.Location = new System.Drawing.Point(12, 11);
            this.lbSpiderName.Name = "lbSpiderName";
            this.lbSpiderName.Size = new System.Drawing.Size(123, 21);
            this.lbSpiderName.TabIndex = 0;
            this.lbSpiderName.Text = "Spider Name:";
            // 
            // lbStartingUrl
            // 
            this.lbStartingUrl.Font = new System.Drawing.Font("Moire", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartingUrl.Location = new System.Drawing.Point(12, 41);
            this.lbStartingUrl.Name = "lbStartingUrl";
            this.lbStartingUrl.Size = new System.Drawing.Size(123, 20);
            this.lbStartingUrl.TabIndex = 1;
            this.lbStartingUrl.Text = "Starting URL:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(141, 41);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(169, 20);
            this.tbUrl.TabIndex = 1;
            // 
            // gbDataStructure
            // 
            this.gbDataStructure.Controls.Add(this.rbQueue);
            this.gbDataStructure.Controls.Add(this.rbStack);
            this.gbDataStructure.Location = new System.Drawing.Point(15, 78);
            this.gbDataStructure.Name = "gbDataStructure";
            this.gbDataStructure.Size = new System.Drawing.Size(295, 81);
            this.gbDataStructure.TabIndex = 2;
            this.gbDataStructure.TabStop = false;
            this.gbDataStructure.Text = "Select Data Structure for Search";
            // 
            // rbQueue
            // 
            this.rbQueue.AutoSize = true;
            this.rbQueue.Location = new System.Drawing.Point(159, 37);
            this.rbQueue.Name = "rbQueue";
            this.rbQueue.Size = new System.Drawing.Size(119, 17);
            this.rbQueue.TabIndex = 1;
            this.rbQueue.Text = "Queue Breadth-First";
            this.rbQueue.UseVisualStyleBackColor = true;
            // 
            // rbStack
            // 
            this.rbStack.AutoSize = true;
            this.rbStack.Checked = true;
            this.rbStack.Location = new System.Drawing.Point(15, 37);
            this.rbStack.Name = "rbStack";
            this.rbStack.Size = new System.Drawing.Size(113, 17);
            this.rbStack.TabIndex = 0;
            this.rbStack.TabStop = true;
            this.rbStack.Text = "Stack - Depth-First";
            this.rbStack.UseVisualStyleBackColor = true;
            // 
            // tbarSearchDepth
            // 
            this.tbarSearchDepth.Location = new System.Drawing.Point(91, 34);
            this.tbarSearchDepth.Maximum = 40;
            this.tbarSearchDepth.Name = "tbarSearchDepth";
            this.tbarSearchDepth.Size = new System.Drawing.Size(187, 45);
            this.tbarSearchDepth.TabIndex = 1;
            this.tbarSearchDepth.Value = 10;
            this.tbarSearchDepth.Scroll += new System.EventHandler(this.tbSearchDepth_Scroll);
            // 
            // gbDepth
            // 
            this.gbDepth.Controls.Add(this.tbDepth);
            this.gbDepth.Controls.Add(this.tbarSearchDepth);
            this.gbDepth.Location = new System.Drawing.Point(15, 171);
            this.gbDepth.Name = "gbDepth";
            this.gbDepth.Size = new System.Drawing.Size(295, 88);
            this.gbDepth.TabIndex = 3;
            this.gbDepth.TabStop = false;
            this.gbDepth.Text = "Set Search Depth";
            // 
            // tbDepth
            // 
            this.tbDepth.Font = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepth.Location = new System.Drawing.Point(15, 34);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(55, 30);
            this.tbDepth.TabIndex = 0;
            this.tbDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDepth.TextChanged += new System.EventHandler(this.tbDepth_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(155, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(236, 269);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 5;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // SpiderDialog
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(323, 302);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.gbDepth);
            this.Controls.Add(this.gbDataStructure);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbStartingUrl);
            this.Controls.Add(this.lbSpiderName);
            this.Name = "SpiderDialog";
            this.Text = "New Spider Dialog";
            this.gbDataStructure.ResumeLayout(false);
            this.gbDataStructure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSearchDepth)).EndInit();
            this.gbDepth.ResumeLayout(false);
            this.gbDepth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSpiderName;
        private System.Windows.Forms.Label lbStartingUrl;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.GroupBox gbDataStructure;
        private System.Windows.Forms.TrackBar tbarSearchDepth;
        private System.Windows.Forms.GroupBox gbDepth;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.RadioButton rbQueue;
        private System.Windows.Forms.RadioButton rbStack;
        private System.Windows.Forms.TextBox tbDepth;
    }
}