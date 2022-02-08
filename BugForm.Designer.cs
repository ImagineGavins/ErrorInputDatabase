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
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(55, 351);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(112, 35);
            this.SubmitButton.TabIndex = 21;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // FounderTextBox
            // 
            this.FounderTextBox.Location = new System.Drawing.Point(237, 298);
            this.FounderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FounderTextBox.Name = "FounderTextBox";
            this.FounderTextBox.Size = new System.Drawing.Size(148, 26);
            this.FounderTextBox.TabIndex = 20;
            // 
            // ErrorStatusDropDown
            // 
            this.ErrorStatusDropDown.FormattingEnabled = true;
            this.ErrorStatusDropDown.Items.AddRange(new object[] {
            "Not Fixed",
            "In Progress",
            "Fixed"});
            this.ErrorStatusDropDown.Location = new System.Drawing.Point(237, 252);
            this.ErrorStatusDropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ErrorStatusDropDown.Name = "ErrorStatusDropDown";
            this.ErrorStatusDropDown.Size = new System.Drawing.Size(218, 28);
            this.ErrorStatusDropDown.TabIndex = 19;
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.Location = new System.Drawing.Point(237, 203);
            this.LineNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.LineNumberTextBox.TabIndex = 18;
            // 
            // TypeOfErrorDropDown
            // 
            this.TypeOfErrorDropDown.FormattingEnabled = true;
            this.TypeOfErrorDropDown.Items.AddRange(new object[] {
            "Logic Error"});
            this.TypeOfErrorDropDown.Location = new System.Drawing.Point(237, 149);
            this.TypeOfErrorDropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeOfErrorDropDown.Name = "TypeOfErrorDropDown";
            this.TypeOfErrorDropDown.Size = new System.Drawing.Size(218, 28);
            this.TypeOfErrorDropDown.TabIndex = 17;
            // 
            // ErrorDescriptionTextBox
            // 
            this.ErrorDescriptionTextBox.Location = new System.Drawing.Point(237, 34);
            this.ErrorDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ErrorDescriptionTextBox.Multiline = true;
            this.ErrorDescriptionTextBox.Name = "ErrorDescriptionTextBox";
            this.ErrorDescriptionTextBox.Size = new System.Drawing.Size(434, 92);
            this.ErrorDescriptionTextBox.TabIndex = 16;
            // 
            // FounderLabel
            // 
            this.FounderLabel.AutoSize = true;
            this.FounderLabel.Location = new System.Drawing.Point(51, 303);
            this.FounderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FounderLabel.Name = "FounderLabel";
            this.FounderLabel.Size = new System.Drawing.Size(73, 20);
            this.FounderLabel.TabIndex = 15;
            this.FounderLabel.Text = "Founder:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(51, 257);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(60, 20);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "Status:";
            // 
            // LineNumberLabel
            // 
            this.LineNumberLabel.AutoSize = true;
            this.LineNumberLabel.Location = new System.Drawing.Point(51, 208);
            this.LineNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LineNumberLabel.Name = "LineNumberLabel";
            this.LineNumberLabel.Size = new System.Drawing.Size(103, 20);
            this.LineNumberLabel.TabIndex = 13;
            this.LineNumberLabel.Text = "Line Number:";
            // 
            // TypeOfErrorLabel
            // 
            this.TypeOfErrorLabel.AutoSize = true;
            this.TypeOfErrorLabel.Location = new System.Drawing.Point(51, 154);
            this.TypeOfErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeOfErrorLabel.Name = "TypeOfErrorLabel";
            this.TypeOfErrorLabel.Size = new System.Drawing.Size(104, 20);
            this.TypeOfErrorLabel.TabIndex = 12;
            this.TypeOfErrorLabel.Text = "Type of Error:";
            // 
            // ErrorDescriptionLabel
            // 
            this.ErrorDescriptionLabel.AutoSize = true;
            this.ErrorDescriptionLabel.Location = new System.Drawing.Point(51, 37);
            this.ErrorDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorDescriptionLabel.Name = "ErrorDescriptionLabel";
            this.ErrorDescriptionLabel.Size = new System.Drawing.Size(132, 20);
            this.ErrorDescriptionLabel.TabIndex = 11;
            this.ErrorDescriptionLabel.Text = "Error Description:";
            // 
            // ErrorBox
            // 
            this.ErrorBox.FormattingEnabled = true;
            this.ErrorBox.ItemHeight = 20;
            this.ErrorBox.Location = new System.Drawing.Point(519, 152);
            this.ErrorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(294, 224);
            this.ErrorBox.TabIndex = 22;
            // 
            // editReplayBtn
            // 
            this.editReplayBtn.Location = new System.Drawing.Point(374, 351);
            this.editReplayBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editReplayBtn.Name = "editReplayBtn";
            this.editReplayBtn.Size = new System.Drawing.Size(112, 35);
            this.editReplayBtn.TabIndex = 23;
            this.editReplayBtn.Text = "Edit Replay";
            this.editReplayBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(-1, -3);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(112, 35);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // playReplayBtn
            // 
            this.playReplayBtn.Location = new System.Drawing.Point(225, 351);
            this.playReplayBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playReplayBtn.Name = "playReplayBtn";
            this.playReplayBtn.Size = new System.Drawing.Size(112, 35);
            this.playReplayBtn.TabIndex = 25;
            this.playReplayBtn.Text = "Play Replay";
            this.playReplayBtn.UseVisualStyleBackColor = true;
            // 
            // BugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 420);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BugForm";
            this.Text = "Form2";
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
    }
}