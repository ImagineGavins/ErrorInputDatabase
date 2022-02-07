namespace Schillinger_Quest4_ErrorInputDatabase
{
    partial class Form1
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
            this.ErrorDescriptionLabel = new System.Windows.Forms.Label();
            this.TypeOfErrorLabel = new System.Windows.Forms.Label();
            this.LineNumberLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.FounderLabel = new System.Windows.Forms.Label();
            this.ErrorDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TypeOfErrorDropDown = new System.Windows.Forms.ComboBox();
            this.LineNumberTextBox = new System.Windows.Forms.TextBox();
            this.ErrorStatusDropDown = new System.Windows.Forms.ComboBox();
            this.FounderTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorDescriptionLabel
            // 
            this.ErrorDescriptionLabel.AutoSize = true;
            this.ErrorDescriptionLabel.Location = new System.Drawing.Point(24, 34);
            this.ErrorDescriptionLabel.Name = "ErrorDescriptionLabel";
            this.ErrorDescriptionLabel.Size = new System.Drawing.Size(88, 13);
            this.ErrorDescriptionLabel.TabIndex = 0;
            this.ErrorDescriptionLabel.Text = "Error Description:";
            // 
            // TypeOfErrorLabel
            // 
            this.TypeOfErrorLabel.AutoSize = true;
            this.TypeOfErrorLabel.Location = new System.Drawing.Point(24, 110);
            this.TypeOfErrorLabel.Name = "TypeOfErrorLabel";
            this.TypeOfErrorLabel.Size = new System.Drawing.Size(71, 13);
            this.TypeOfErrorLabel.TabIndex = 1;
            this.TypeOfErrorLabel.Text = "Type of Error:";
            // 
            // LineNumberLabel
            // 
            this.LineNumberLabel.AutoSize = true;
            this.LineNumberLabel.Location = new System.Drawing.Point(24, 145);
            this.LineNumberLabel.Name = "LineNumberLabel";
            this.LineNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.LineNumberLabel.TabIndex = 2;
            this.LineNumberLabel.Text = "Line Number:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(24, 177);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status:";
            // 
            // FounderLabel
            // 
            this.FounderLabel.AutoSize = true;
            this.FounderLabel.Location = new System.Drawing.Point(24, 207);
            this.FounderLabel.Name = "FounderLabel";
            this.FounderLabel.Size = new System.Drawing.Size(49, 13);
            this.FounderLabel.TabIndex = 4;
            this.FounderLabel.Text = "Founder:";
            // 
            // ErrorDescriptionTextBox
            // 
            this.ErrorDescriptionTextBox.Location = new System.Drawing.Point(148, 32);
            this.ErrorDescriptionTextBox.Multiline = true;
            this.ErrorDescriptionTextBox.Name = "ErrorDescriptionTextBox";
            this.ErrorDescriptionTextBox.Size = new System.Drawing.Size(291, 61);
            this.ErrorDescriptionTextBox.TabIndex = 5;
            // 
            // TypeOfErrorDropDown
            // 
            this.TypeOfErrorDropDown.FormattingEnabled = true;
            this.TypeOfErrorDropDown.Items.AddRange(new object[] {
            "Logic Error"});
            this.TypeOfErrorDropDown.Location = new System.Drawing.Point(148, 107);
            this.TypeOfErrorDropDown.Name = "TypeOfErrorDropDown";
            this.TypeOfErrorDropDown.Size = new System.Drawing.Size(147, 21);
            this.TypeOfErrorDropDown.TabIndex = 6;
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.Location = new System.Drawing.Point(148, 142);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.LineNumberTextBox.TabIndex = 7;
            // 
            // ErrorStatusDropDown
            // 
            this.ErrorStatusDropDown.FormattingEnabled = true;
            this.ErrorStatusDropDown.Items.AddRange(new object[] {
            "Not Fixed",
            "In Progress",
            "Fixed"});
            this.ErrorStatusDropDown.Location = new System.Drawing.Point(148, 174);
            this.ErrorStatusDropDown.Name = "ErrorStatusDropDown";
            this.ErrorStatusDropDown.Size = new System.Drawing.Size(147, 21);
            this.ErrorStatusDropDown.TabIndex = 8;
            // 
            // FounderTextBox
            // 
            this.FounderTextBox.Location = new System.Drawing.Point(148, 204);
            this.FounderTextBox.Name = "FounderTextBox";
            this.FounderTextBox.Size = new System.Drawing.Size(100, 20);
            this.FounderTextBox.TabIndex = 9;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(202, 238);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 273);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorDescriptionLabel;
        private System.Windows.Forms.Label TypeOfErrorLabel;
        private System.Windows.Forms.Label LineNumberLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label FounderLabel;
        private System.Windows.Forms.TextBox ErrorDescriptionTextBox;
        private System.Windows.Forms.ComboBox TypeOfErrorDropDown;
        private System.Windows.Forms.TextBox LineNumberTextBox;
        private System.Windows.Forms.ComboBox ErrorStatusDropDown;
        private System.Windows.Forms.TextBox FounderTextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}

