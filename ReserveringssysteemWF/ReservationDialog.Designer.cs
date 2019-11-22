namespace ReserveringssysteemWF
{
    partial class ReservationDialog
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
            this.reserveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.reservePanel = new System.Windows.Forms.Panel();
            this.startTimeComboBox = new System.Windows.Forms.ComboBox();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.coxswainComboBox = new System.Windows.Forms.ComboBox();
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
            // reserveButton
            // 
            this.reserveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reserveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.reserveButton.Location = new System.Drawing.Point(250, 425);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(75, 23);
            this.reserveButton.TabIndex = 0;
            this.reserveButton.Text = "Reserveren";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(331, 425);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Annuleren";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // reservePanel
            // 
            this.reservePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservePanel.BackColor = System.Drawing.SystemColors.Window;
            this.reservePanel.Controls.Add(this.startTimeComboBox);
            this.reservePanel.Controls.Add(this.startTimeLabel);
            this.reservePanel.Controls.Add(this.durationComboBox);
            this.reservePanel.Controls.Add(this.durationLabel);
            this.reservePanel.Controls.Add(this.dateLabel);
            this.reservePanel.Controls.Add(this.datePicker);
            this.reservePanel.Controls.Add(this.coxswainComboBox);
            this.reservePanel.Controls.Add(this.coxswainLabel);
            this.reservePanel.Controls.Add(this.boatTypeComboBox);
            this.reservePanel.Controls.Add(this.removeMemberButton);
            this.reservePanel.Controls.Add(this.boatLabel);
            this.reservePanel.Controls.Add(this.teamLabel);
            this.reservePanel.Controls.Add(this.addMemberButton);
            this.reservePanel.Controls.Add(this.teamListBox);
            this.reservePanel.Location = new System.Drawing.Point(0, 0);
            this.reservePanel.Name = "reservePanel";
            this.reservePanel.Size = new System.Drawing.Size(418, 419);
            this.reservePanel.TabIndex = 0;
            // 
            // startTimeComboBox
            // 
            this.startTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeComboBox.FormattingEnabled = true;
            this.startTimeComboBox.Location = new System.Drawing.Point(273, 310);
            this.startTimeComboBox.Name = "startTimeComboBox";
            this.startTimeComboBox.Size = new System.Drawing.Size(133, 21);
            this.startTimeComboBox.TabIndex = 13;
            this.startTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.startTimeComboBox_SelectedIndexChanged);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(270, 294);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(42, 13);
            this.startTimeLabel.TabIndex = 12;
            this.startTimeLabel.Text = "Starttijd";
            // 
            // durationComboBox
            // 
            this.durationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Location = new System.Drawing.Point(273, 270);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(133, 21);
            this.durationComboBox.TabIndex = 11;
            this.durationComboBox.SelectedIndexChanged += new System.EventHandler(this.durationComboBox_SelectedIndexChanged);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(270, 254);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(44, 13);
            this.durationLabel.TabIndex = 10;
            this.durationLabel.Text = "Looptijd";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 232);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 13);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Datum";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(9, 254);
            this.datePicker.MaxSelectionCount = 1;
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowToday = false;
            this.datePicker.ShowTodayCircle = false;
            this.datePicker.ShowWeekNumbers = true;
            this.datePicker.TabIndex = 8;
            this.datePicker.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.datePicker_DateChanged);
            // 
            // coxswainComboBox
            // 
            this.coxswainComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coxswainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coxswainComboBox.FormattingEnabled = true;
            this.coxswainComboBox.Location = new System.Drawing.Point(12, 208);
            this.coxswainComboBox.Name = "coxswainComboBox";
            this.coxswainComboBox.Size = new System.Drawing.Size(394, 21);
            this.coxswainComboBox.TabIndex = 7;
            // 
            // coxswainLabel
            // 
            this.coxswainLabel.AutoSize = true;
            this.coxswainLabel.Location = new System.Drawing.Point(12, 192);
            this.coxswainLabel.Name = "coxswainLabel";
            this.coxswainLabel.Size = new System.Drawing.Size(52, 13);
            this.coxswainLabel.TabIndex = 6;
            this.coxswainLabel.Text = "Stuurman";
            // 
            // boatTypeComboBox
            // 
            this.boatTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boatTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boatTypeComboBox.FormattingEnabled = true;
            this.boatTypeComboBox.Location = new System.Drawing.Point(12, 168);
            this.boatTypeComboBox.Name = "boatTypeComboBox";
            this.boatTypeComboBox.Size = new System.Drawing.Size(394, 21);
            this.boatTypeComboBox.TabIndex = 5;
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.Location = new System.Drawing.Point(139, 126);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(121, 23);
            this.removeMemberButton.TabIndex = 4;
            this.removeMemberButton.Text = "Teamlid verwijderen";
            this.removeMemberButton.UseVisualStyleBackColor = true;
            this.removeMemberButton.Click += new System.EventHandler(this.removeMemberButton_Click);
            // 
            // boatLabel
            // 
            this.boatLabel.AutoSize = true;
            this.boatLabel.Location = new System.Drawing.Point(12, 152);
            this.boatLabel.Name = "boatLabel";
            this.boatLabel.Size = new System.Drawing.Size(49, 13);
            this.boatLabel.TabIndex = 3;
            this.boatLabel.Text = "Boottype";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(12, 9);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(60, 13);
            this.teamLabel.TabIndex = 0;
            this.teamLabel.Text = "Teamleden";
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(12, 126);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(121, 23);
            this.addMemberButton.TabIndex = 2;
            this.addMemberButton.Text = "Teamlid toevoegen";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // teamListBox
            // 
            this.teamListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(12, 25);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(394, 95);
            this.teamListBox.TabIndex = 1;
            // 
            // ReservationDialog
            // 
            this.AcceptButton = this.reserveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(418, 460);
            this.Controls.Add(this.reservePanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.reserveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserveren";
            this.Load += new System.EventHandler(this.ReservationDialog_Load);
            this.reservePanel.ResumeLayout(false);
            this.reservePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel reservePanel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Label boatLabel;
        private System.Windows.Forms.Button removeMemberButton;
        private System.Windows.Forms.ComboBox boatTypeComboBox;
        private System.Windows.Forms.ComboBox coxswainComboBox;
        private System.Windows.Forms.Label coxswainLabel;
        private System.Windows.Forms.MonthCalendar datePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.ComboBox startTimeComboBox;
        private System.Windows.Forms.Label startTimeLabel;
    }
}