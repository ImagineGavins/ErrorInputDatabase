
namespace Schillinger_Quest4_ErrorInputDatabase
{
    partial class Recording
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
            this.recordBtn = new System.Windows.Forms.Button();
            this.stopRecordingBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.viewBugBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(51, 99);
            this.recordBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(93, 41);
            this.recordBtn.TabIndex = 0;
            this.recordBtn.Text = "Record";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // stopRecordingBtn
            // 
            this.stopRecordingBtn.Location = new System.Drawing.Point(51, 144);
            this.stopRecordingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopRecordingBtn.Name = "stopRecordingBtn";
            this.stopRecordingBtn.Size = new System.Drawing.Size(93, 41);
            this.stopRecordingBtn.TabIndex = 1;
            this.stopRecordingBtn.Text = "Stop Recording";
            this.stopRecordingBtn.UseVisualStyleBackColor = true;
            this.stopRecordingBtn.Click += new System.EventHandler(this.stopRecordingBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Enabled = false;
            this.reportBtn.Location = new System.Drawing.Point(315, 99);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(93, 41);
            this.reportBtn.TabIndex = 2;
            this.reportBtn.Text = "Report Bug";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // viewBugBtn
            // 
            this.viewBugBtn.Location = new System.Drawing.Point(315, 144);
            this.viewBugBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewBugBtn.Name = "viewBugBtn";
            this.viewBugBtn.Size = new System.Drawing.Size(93, 41);
            this.viewBugBtn.TabIndex = 3;
            this.viewBugBtn.Text = "View Bug";
            this.viewBugBtn.UseVisualStyleBackColor = true;
            this.viewBugBtn.Click += new System.EventHandler(this.viewBugBtn_Click);
            // 
            // Recording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.viewBugBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.stopRecordingBtn);
            this.Controls.Add(this.recordBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Recording";
            this.Text = "Recording";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button stopRecordingBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button viewBugBtn;
    }
}