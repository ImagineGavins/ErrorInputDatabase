namespace Schillinger_Quest4_ErrorInputDatabase
{
    partial class BugForm
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FounderTextBox = new System.Windows.Forms.TextBox();
            this.ErrorStatusDropDown = new System.Windows.Forms.ComboBox();
            this.LineNumberTextBox = new System.Windows.Forms.TextBox();
            this.TypeOfErrorDropDown = new System.Windows.Forms.ComboBox();
            this.ErrorDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.FounderLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LineNumberLabel = new System.Windows.Forms.Label();
            this.TypeOfErrorLabel = new System.Windows.Forms.Label();
            this.ErrorDescriptionLabel = new System.Windows.Forms.Label();
            this.ErrorBox = new System.Windows.Forms.ListBox();
            this.editReplayBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.playReplayBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(49, 281);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 28);
            this.SubmitButton.TabIndex = 21;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FounderTextBox
            // 
            this.FounderTextBox.Location = new System.Drawing.Point(211, 238);
            this.FounderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FounderTextBox.Name = "FounderTextBox";
            this.FounderTextBox.Size = new System.Drawing.Size(132, 22);
            this.FounderTextBox.TabIndex = 20;
            // 
            // ErrorStatusDropDown
            // 
            this.ErrorStatusDropDown.FormattingEnabled = true;
            this.ErrorStatusDropDown.Items.AddRange(new object[] {
            "Not Fixed",
            "In Progress",
            "Fixed"});
            this.ErrorStatusDropDown.Location = new System.Drawing.Point(211, 202);
            this.ErrorStatusDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrorStatusDropDown.Name = "ErrorStatusDropDown";
            this.ErrorStatusDropDown.Size = new System.Drawing.Size(194, 24);
            this.ErrorStatusDropDown.TabIndex = 19;
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.Location = new System.Drawing.Point(211, 162);
            this.LineNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.LineNumberTextBox.TabIndex = 18;
            // 
            // TypeOfErrorDropDown
            // 
            this.TypeOfErrorDropDown.FormattingEnabled = true;
            this.TypeOfErrorDropDown.Items.AddRange(new object[] {
            "Logic Error"});
            this.TypeOfErrorDropDown.Location = new System.Drawing.Point(211, 119);
            this.TypeOfErrorDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TypeOfErrorDropDown.Name = "TypeOfErrorDropDown";
            this.TypeOfErrorDropDown.Size = new System.Drawing.Size(194, 24);
            this.TypeOfErrorDropDown.TabIndex = 17;
            // 
            // ErrorDescriptionTextBox
            // 
            this.ErrorDescriptionTextBox.Location = new System.Drawing.Point(211, 27);
            this.ErrorDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrorDescriptionTextBox.Multiline = true;
            this.ErrorDescriptionTextBox.Name = "ErrorDescriptionTextBox";
            this.ErrorDescriptionTextBox.Size = new System.Drawing.Size(386, 74);
            this.ErrorDescriptionTextBox.TabIndex = 16;
            // 
            // FounderLabel
            // 
            this.FounderLabel.AutoSize = true;
            this.FounderLabel.Location = new System.Drawing.Point(45, 242);
            this.FounderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FounderLabel.Name = "FounderLabel";
            this.FounderLabel.Size = new System.Drawing.Size(65, 17);
            this.FounderLabel.TabIndex = 15;
            this.FounderLabel.Text = "Founder:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(45, 206);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 17);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "Status:";
            // 
            // LineNumberLabel
            // 
            this.LineNumberLabel.AutoSize = true;
            this.LineNumberLabel.Location = new System.Drawing.Point(45, 166);
            this.LineNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LineNumberLabel.Name = "LineNumberLabel";
            this.LineNumberLabel.Size = new System.Drawing.Size(93, 17);
            this.LineNumberLabel.TabIndex = 13;
            this.LineNumberLabel.Text = "Line Number:";
            // 
            // TypeOfErrorLabel
            // 
            this.TypeOfErrorLabel.AutoSize = true;
            this.TypeOfErrorLabel.Location = new System.Drawing.Point(45, 123);
            this.TypeOfErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeOfErrorLabel.Name = "TypeOfErrorLabel";
            this.TypeOfErrorLabel.Size = new System.Drawing.Size(96, 17);
            this.TypeOfErrorLabel.TabIndex = 12;
            this.TypeOfErrorLabel.Text = "Type of Error:";
            // 
            // ErrorDescriptionLabel
            // 
            this.ErrorDescriptionLabel.AutoSize = true;
            this.ErrorDescriptionLabel.Location = new System.Drawing.Point(45, 30);
            this.ErrorDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorDescriptionLabel.Name = "ErrorDescriptionLabel";
            this.ErrorDescriptionLabel.Size = new System.Drawing.Size(119, 17);
            this.ErrorDescriptionLabel.TabIndex = 11;
            this.ErrorDescriptionLabel.Text = "Error Description:";
            // 
            // ErrorBox
            // 
            this.ErrorBox.FormattingEnabled = true;
            this.ErrorBox.ItemHeight = 16;
            this.ErrorBox.Location = new System.Drawing.Point(461, 122);
            this.ErrorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(262, 180);
            this.ErrorBox.TabIndex = 22;
            this.ErrorBox.SelectedIndexChanged += new System.EventHandler(this.ErrorBox_SelectedIndexChanged);
            // 
            // editReplayBtn
            // 
            this.editReplayBtn.Location = new System.Drawing.Point(332, 281);
            this.editReplayBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editReplayBtn.Name = "editReplayBtn";
            this.editReplayBtn.Size = new System.Drawing.Size(100, 28);
            this.editReplayBtn.TabIndex = 23;
            this.editReplayBtn.Text = "Edit Replay";
            this.editReplayBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(-1, -2);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 28);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // playReplayBtn
            // 
            this.playReplayBtn.Location = new System.Drawing.Point(200, 281);
            this.playReplayBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playReplayBtn.Name = "playReplayBtn";
            this.playReplayBtn.Size = new System.Drawing.Size(100, 28);
            this.playReplayBtn.TabIndex = 25;
            this.playReplayBtn.Text = "Play Replay";
            this.playReplayBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 26;
            // 
            // BugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 336);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.playReplayBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.editReplayBtn);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.FounderTextBox);
            this.Controls.Add(this.ErrorStatusDropDown);
            this.Controls.Add(this.LineNumberTextBox);
            this.Controls.Add(this.TypeOfErrorDropDown);
            this.Controls.Add(this.ErrorDescriptionTextBox);
            this.Controls.Add(this.FounderLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.LineNumberLabel);
            this.Controls.Add(this.TypeOfErrorLabel);
            this.Controls.Add(this.ErrorDescriptionLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BugForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.BugForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox FounderTextBox;
        private System.Windows.Forms.ComboBox ErrorStatusDropDown;
        private System.Windows.Forms.TextBox LineNumberTextBox;
        private System.Windows.Forms.ComboBox TypeOfErrorDropDown;
        private System.Windows.Forms.TextBox ErrorDescriptionTextBox;
        private System.Windows.Forms.Label FounderLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label LineNumberLabel;
        private System.Windows.Forms.Label TypeOfErrorLabel;
        private System.Windows.Forms.Label ErrorDescriptionLabel;
        private System.Windows.Forms.ListBox ErrorBox;
        private System.Windows.Forms.Button editReplayBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button playReplayBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}