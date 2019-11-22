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
            this.startTimeComboBox = new System.Windows.Forms.ComboBox();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.coxswainLabel = new System.Windows.Forms.Label();
            this.boatTypeComboBox = new System.Windows.Forms.ComboBox();
            this.removeMemberButton = new System.Windows.Forms.Button();
            this.boatLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
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
            this.reservePanel.Controls.Add(this.startTimeComboBox);
            this.reservePanel.Controls.Add(this.startTimeLabel);
            this.reservePanel.Controls.Add(this.dateLabel);
            this.reservePanel.Controls.Add(this.datePicker);
            this.reservePanel.Controls.Add(this.coxswainLabel);
            this.reservePanel.Controls.Add(this.boatTypeComboBox);
            this.reservePanel.Controls.Add(this.removeMemberButton);
            this.reservePanel.Controls.Add(this.boatLabel);
            this.reservePanel.Controls.Add(this.teamLabel);
            this.reservePanel.Controls.Add(this.addMemberButton);
            this.reservePanel.Controls.Add(this.teamListBox);
            this.reservePanel.Location = new System.Drawing.Point(1, -3);
            this.reservePanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservePanel.Name = "reservePanel";
            this.reservePanel.Size = new System.Drawing.Size(491, 569);
            this.reservePanel.TabIndex = 1;
            // 
            // startTimeComboBox
            // 
            this.startTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeComboBox.FormattingEnabled = true;
            this.startTimeComboBox.Location = new System.Drawing.Point(364, 382);
            this.startTimeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.startTimeComboBox.Name = "startTimeComboBox";
            this.startTimeComboBox.Size = new System.Drawing.Size(110, 24);
            this.startTimeComboBox.TabIndex = 13;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(360, 362);
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
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(12, 313);
            this.datePicker.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.datePicker.MaxSelectionCount = 1;
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowToday = false;
            this.datePicker.ShowTodayCircle = false;
            this.datePicker.ShowWeekNumbers = true;
            this.datePicker.TabIndex = 8;
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
            // boatTypeComboBox
            // 
            this.boatTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boatTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boatTypeComboBox.FormattingEnabled = true;
            this.boatTypeComboBox.Location = new System.Drawing.Point(16, 207);
            this.boatTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.boatTypeComboBox.Name = "boatTypeComboBox";
            this.boatTypeComboBox.Size = new System.Drawing.Size(458, 24);
            this.boatTypeComboBox.TabIndex = 5;
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.Location = new System.Drawing.Point(185, 155);
            this.removeMemberButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(161, 28);
            this.removeMemberButton.TabIndex = 4;
            this.removeMemberButton.Text = "Team verwijderen";
            this.removeMemberButton.UseVisualStyleBackColor = true;
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
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(16, 155);
            this.addMemberButton.Margin = new System.Windows.Forms.Padding(4);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(161, 28);
            this.addMemberButton.TabIndex = 2;
            this.addMemberButton.Text = "Team toevoegen";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
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
        private System.Windows.Forms.MonthCalendar datePicker;
        private System.Windows.Forms.Label coxswainLabel;
        private System.Windows.Forms.ComboBox boatTypeComboBox;
        private System.Windows.Forms.Button removeMemberButton;
        private System.Windows.Forms.Label boatLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ListBox teamListBox;
    }
}