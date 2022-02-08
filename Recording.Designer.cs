
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(77, 153);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(139, 63);
            this.recordBtn.TabIndex = 0;
            this.recordBtn.Text = "Record";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // stopRecordingBtn
            // 
            this.stopRecordingBtn.Location = new System.Drawing.Point(77, 222);
            this.stopRecordingBtn.Name = "stopRecordingBtn";
            this.stopRecordingBtn.Size = new System.Drawing.Size(139, 63);
            this.stopRecordingBtn.TabIndex = 1;
            this.stopRecordingBtn.Text = "Stop Recording";
            this.stopRecordingBtn.UseVisualStyleBackColor = true;
            this.stopRecordingBtn.Click += new System.EventHandler(this.stopRecordingBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(472, 153);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(139, 63);
            this.reportBtn.TabIndex = 2;
            this.reportBtn.Text = "Report Bug";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Bug";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Recording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.stopRecordingBtn);
            this.Controls.Add(this.recordBtn);
            this.Name = "Recording";
            this.Text = "Recording";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button stopRecordingBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button button2;
    }
}