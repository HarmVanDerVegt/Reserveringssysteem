namespace ReserveringssysteemWF
{
    partial class MatchCreatorDialog
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
            this.reservePanel = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.endTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.startTimeComboBox = new System.Windows.Forms.ComboBox();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePickerMatch = new System.Windows.Forms.MonthCalendar();
            this.coxswainLabel = new System.Windows.Forms.Label();
            this.boatTypeList = new System.Windows.Forms.ComboBox();
            this.removeTeamButton = new System.Windows.Forms.Button();
            this.boatLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.reservePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservePanel
            // 
            this.reservePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservePanel.BackColor = System.Drawing.SystemColors.Window;
            this.reservePanel.Controls.Add(this.Cancel);
            this.reservePanel.Controls.Add(this.Create);
            this.reservePanel.Controls.Add(this.label2);
            this.reservePanel.Controls.Add(this.endTimeComboBox);
            this.reservePanel.Controls.Add(this.label1);
            this.reservePanel.Controls.Add(this.DistanceTextBox);
            this.reservePanel.Controls.Add(this.startTimeComboBox);
            this.reservePanel.Controls.Add(this.startTimeLabel);
            this.reservePanel.Controls.Add(this.dateLabel);
            this.reservePanel.Controls.Add(this.datePickerMatch);
            this.reservePanel.Controls.Add(this.coxswainLabel);
            this.reservePanel.Controls.Add(this.boatTypeList);
            this.reservePanel.Controls.Add(this.removeTeamButton);
            this.reservePanel.Controls.Add(this.boatLabel);
            this.reservePanel.Controls.Add(this.teamLabel);
            this.reservePanel.Controls.Add(this.addTeamButton);
            this.reservePanel.Controls.Add(this.teamListBox);
            this.reservePanel.Location = new System.Drawing.Point(1, -3);
            this.reservePanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservePanel.Name = "reservePanel";
            this.reservePanel.Size = new System.Drawing.Size(491, 569);
            this.reservePanel.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(409, 495);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Annuleer";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Create.Location = new System.Drawing.Point(327, 496);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 18;
            this.Create.Text = "Maak";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Eindtijd";
            // 
            // endTimeComboBox
            // 
            this.endTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endTimeComboBox.FormattingEnabled = true;
            this.endTimeComboBox.Location = new System.Drawing.Point(350, 409);
            this.endTimeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.endTimeComboBox.Name = "endTimeComboBox";
            this.endTimeComboBox.Size = new System.Drawing.Size(110, 24);
            this.endTimeComboBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "meter";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Location = new System.Drawing.Point(19, 257);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.DistanceTextBox.TabIndex = 14;
            this.DistanceTextBox.TextChanged += new System.EventHandler(this.DistanceTextBox_TextChanged);
            // 
            // startTimeComboBox
            // 
            this.startTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeComboBox.FormattingEnabled = true;
            this.startTimeComboBox.Location = new System.Drawing.Point(351, 348);
            this.startTimeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.startTimeComboBox.Name = "startTimeComboBox";
            this.startTimeComboBox.Size = new System.Drawing.Size(110, 24);
            this.startTimeComboBox.TabIndex = 13;
            this.startTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.StartTimeComboBox_SelectedIndexChanged);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(347, 328);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(56, 17);
            this.startTimeLabel.TabIndex = 12;
            this.startTimeLabel.Text = "Starttijd";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(16, 286);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(49, 17);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Datum";
            // 
            // datePickerMatch
            // 
            this.datePickerMatch.Location = new System.Drawing.Point(12, 313);
            this.datePickerMatch.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.datePickerMatch.MaxSelectionCount = 1;
            this.datePickerMatch.Name = "datePickerMatch";
            this.datePickerMatch.ShowToday = false;
            this.datePickerMatch.ShowTodayCircle = false;
            this.datePickerMatch.ShowWeekNumbers = true;
            this.datePickerMatch.TabIndex = 8;
            this.datePickerMatch.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DatePicker_DateChanged);
            // 
            // coxswainLabel
            // 
            this.coxswainLabel.AutoSize = true;
            this.coxswainLabel.Location = new System.Drawing.Point(16, 236);
            this.coxswainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coxswainLabel.Name = "coxswainLabel";
            this.coxswainLabel.Size = new System.Drawing.Size(56, 17);
            this.coxswainLabel.TabIndex = 6;
            this.coxswainLabel.Text = "Afstand";
            // 
            // boatTypeList
            // 
            this.boatTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boatTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boatTypeList.FormattingEnabled = true;
            this.boatTypeList.Location = new System.Drawing.Point(16, 207);
            this.boatTypeList.Margin = new System.Windows.Forms.Padding(4);
            this.boatTypeList.Name = "boatTypeList";
            this.boatTypeList.Size = new System.Drawing.Size(458, 24);
            this.boatTypeList.TabIndex = 5;
            // 
            // removeTeamButton
            // 
            this.removeTeamButton.Location = new System.Drawing.Point(185, 155);
            this.removeTeamButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeTeamButton.Name = "removeTeamButton";
            this.removeTeamButton.Size = new System.Drawing.Size(161, 28);
            this.removeTeamButton.TabIndex = 4;
            this.removeTeamButton.Text = "Team verwijderen";
            this.removeTeamButton.UseVisualStyleBackColor = true;
            this.removeTeamButton.Click += new System.EventHandler(this.RemoveMemberButton_Click);
            // 
            // boatLabel
            // 
            this.boatLabel.AutoSize = true;
            this.boatLabel.Location = new System.Drawing.Point(16, 187);
            this.boatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boatLabel.Name = "boatLabel";
            this.boatLabel.Size = new System.Drawing.Size(64, 17);
            this.boatLabel.TabIndex = 3;
            this.boatLabel.Text = "Boottype";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(16, 11);
            this.teamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(51, 17);
            this.teamLabel.TabIndex = 0;
            this.teamLabel.Text = "Teams";
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(16, 155);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(161, 28);
            this.addTeamButton.TabIndex = 2;
            this.addTeamButton.Text = "Team toevoegen";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // teamListBox
            // 
            this.teamListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.ItemHeight = 16;
            this.teamListBox.Location = new System.Drawing.Point(16, 31);
            this.teamListBox.Margin = new System.Windows.Forms.Padding(4);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(458, 116);
            this.teamListBox.TabIndex = 1;
            // 
            // MatchCreatorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 533);
            this.Controls.Add(this.reservePanel);
            this.Name = "MatchCreatorDialog";
            this.Text = "MatchCreatorDialog";
            this.Load += new System.EventHandler(this.MatchCreatorDialog_Load);
            this.reservePanel.ResumeLayout(false);
            this.reservePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reservePanel;
        private System.Windows.Forms.ComboBox startTimeComboBox;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MonthCalendar datePickerMatch;
        private System.Windows.Forms.Label coxswainLabel;
        private System.Windows.Forms.ComboBox boatTypeList;
        private System.Windows.Forms.Button removeTeamButton;
        private System.Windows.Forms.Label boatLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox endTimeComboBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Create;
    }
}