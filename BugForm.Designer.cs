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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFounder = new System.Windows.Forms.TextBox();
            this.dropErrorStatus = new System.Windows.Forms.ComboBox();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.dropErrorType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.FounderLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LineNumberLabel = new System.Windows.Forms.Label();
            this.TypeOfErrorLabel = new System.Windows.Forms.Label();
            this.ErrorDescriptionLabel = new System.Windows.Forms.Label();
            this.errorList = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtErrorReplay = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(387, 353);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtFounder
            // 
            this.txtFounder.Location = new System.Drawing.Point(158, 311);
            this.txtFounder.Name = "txtFounder";
            this.txtFounder.Size = new System.Drawing.Size(100, 20);
            this.txtFounder.TabIndex = 20;
            // 
            // dropErrorStatus
            // 
            this.dropErrorStatus.FormattingEnabled = true;
            this.dropErrorStatus.Items.AddRange(new object[] {
            "Not Fixed",
            "In Progress",
            "Fixed"});
            this.dropErrorStatus.Location = new System.Drawing.Point(158, 270);
            this.dropErrorStatus.Name = "dropErrorStatus";
            this.dropErrorStatus.Size = new System.Drawing.Size(146, 21);
            this.dropErrorStatus.TabIndex = 19;
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(158, 229);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(100, 20);
            this.txtLineNumber.TabIndex = 18;
            // 
            // dropErrorType
            // 
            this.dropErrorType.FormattingEnabled = true;
            this.dropErrorType.Items.AddRange(new object[] {
            "Logic Error"});
            this.dropErrorType.Location = new System.Drawing.Point(158, 186);
            this.dropErrorType.Name = "dropErrorType";
            this.dropErrorType.Size = new System.Drawing.Size(146, 21);
            this.dropErrorType.TabIndex = 17;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(158, 97);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(212, 61);
            this.txtDescription.TabIndex = 16;
            // 
            // FounderLabel
            // 
            this.FounderLabel.AutoSize = true;
            this.FounderLabel.Location = new System.Drawing.Point(34, 315);
            this.FounderLabel.Name = "FounderLabel";
            this.FounderLabel.Size = new System.Drawing.Size(49, 13);
            this.FounderLabel.TabIndex = 15;
            this.FounderLabel.Text = "Founder:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(34, 273);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "Status:";
            // 
            // LineNumberLabel
            // 
            this.LineNumberLabel.AutoSize = true;
            this.LineNumberLabel.Location = new System.Drawing.Point(34, 232);
            this.LineNumberLabel.Name = "LineNumberLabel";
            this.LineNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.LineNumberLabel.TabIndex = 13;
            this.LineNumberLabel.Text = "Line Number:";
            // 
            // TypeOfErrorLabel
            // 
            this.TypeOfErrorLabel.AutoSize = true;
            this.TypeOfErrorLabel.Location = new System.Drawing.Point(34, 189);
            this.TypeOfErrorLabel.Name = "TypeOfErrorLabel";
            this.TypeOfErrorLabel.Size = new System.Drawing.Size(71, 13);
            this.TypeOfErrorLabel.TabIndex = 12;
            this.TypeOfErrorLabel.Text = "Type of Error:";
            // 
            // ErrorDescriptionLabel
            // 
            this.ErrorDescriptionLabel.AutoSize = true;
            this.ErrorDescriptionLabel.Location = new System.Drawing.Point(34, 99);
            this.ErrorDescriptionLabel.Name = "ErrorDescriptionLabel";
            this.ErrorDescriptionLabel.Size = new System.Drawing.Size(88, 13);
            this.ErrorDescriptionLabel.TabIndex = 11;
            this.ErrorDescriptionLabel.Text = "Error Description:";
            // 
            // errorList
            // 
            this.errorList.FormattingEnabled = true;
            this.errorList.Location = new System.Drawing.Point(387, 97);
            this.errorList.Name = "errorList";
            this.errorList.Size = new System.Drawing.Size(198, 238);
            this.errorList.TabIndex = 22;
            this.errorList.SelectedIndexChanged += new System.EventHandler(this.ErrorBox_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(131, 405);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit Replay";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(-1, -2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(212, 405);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 25;
            this.btnPlay.Text = "Play Replay";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 20);
            this.txtID.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Error ID#:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Insert Error Replay:";
            // 
            // txtErrorReplay
            // 
            this.txtErrorReplay.Location = new System.Drawing.Point(158, 350);
            this.txtErrorReplay.Name = "txtErrorReplay";
            this.txtErrorReplay.Size = new System.Drawing.Size(100, 20);
            this.txtErrorReplay.TabIndex = 29;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(510, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(168, 376);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 23);
            this.btnInsert.TabIndex = 31;
            this.btnInsert.Text = "Insert Replay";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // BugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 452);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtErrorReplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.errorList);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFounder);
            this.Controls.Add(this.dropErrorStatus);
            this.Controls.Add(this.txtLineNumber);
            this.Controls.Add(this.dropErrorType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.FounderLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.LineNumberLabel);
            this.Controls.Add(this.TypeOfErrorLabel);
            this.Controls.Add(this.ErrorDescriptionLabel);
            this.Name = "BugForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.BugForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtFounder;
        private System.Windows.Forms.ComboBox dropErrorStatus;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.ComboBox dropErrorType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label FounderLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label LineNumberLabel;
        private System.Windows.Forms.Label TypeOfErrorLabel;
        private System.Windows.Forms.Label ErrorDescriptionLabel;
        private System.Windows.Forms.ListBox errorList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtErrorReplay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}