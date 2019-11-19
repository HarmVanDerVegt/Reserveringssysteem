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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.RemoveMemberButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coxswainComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.boatComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.startTimePicker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.durationComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.boatComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.coxswainComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RemoveMemberButton);
            this.panel1.Controls.Add(this.AddMemberButton);
            this.panel1.Controls.Add(this.teamListBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 385);
            this.panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(337, 391);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Annuleren";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // reserveButton
            // 
            this.reserveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reserveButton.Enabled = false;
            this.reserveButton.Location = new System.Drawing.Point(256, 391);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(75, 23);
            this.reserveButton.TabIndex = 2;
            this.reserveButton.Text = "Reserveren";
            this.reserveButton.UseVisualStyleBackColor = true;
            // 
            // teamListBox
            // 
            this.teamListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(12, 25);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(400, 95);
            this.teamListBox.TabIndex = 0;
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Location = new System.Drawing.Point(12, 126);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(99, 23);
            this.AddMemberButton.TabIndex = 1;
            this.AddMemberButton.Text = "Lid toevoegen";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // RemoveMemberButton
            // 
            this.RemoveMemberButton.Enabled = false;
            this.RemoveMemberButton.Location = new System.Drawing.Point(117, 126);
            this.RemoveMemberButton.Name = "RemoveMemberButton";
            this.RemoveMemberButton.Size = new System.Drawing.Size(99, 23);
            this.RemoveMemberButton.TabIndex = 2;
            this.RemoveMemberButton.Text = "Lid verwijderen";
            this.RemoveMemberButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teamleden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stuurman";
            // 
            // coxswainComboBox
            // 
            this.coxswainComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coxswainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coxswainComboBox.FormattingEnabled = true;
            this.coxswainComboBox.Items.AddRange(new object[] {
            "Geen stuurman"});
            this.coxswainComboBox.Location = new System.Drawing.Point(12, 168);
            this.coxswainComboBox.Name = "coxswainComboBox";
            this.coxswainComboBox.Size = new System.Drawing.Size(400, 21);
            this.coxswainComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum";
            // 
            // datePicker
            // 
            this.datePicker.Enabled = false;
            this.datePicker.Location = new System.Drawing.Point(9, 214);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowToday = false;
            this.datePicker.ShowWeekNumbers = true;
            this.datePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Boot";
            // 
            // boatComboBox
            // 
            this.boatComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boatComboBox.Enabled = false;
            this.boatComboBox.FormattingEnabled = true;
            this.boatComboBox.Location = new System.Drawing.Point(270, 214);
            this.boatComboBox.Name = "boatComboBox";
            this.boatComboBox.Size = new System.Drawing.Size(142, 21);
            this.boatComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Looptijd";
            // 
            // durationComboBox
            // 
            this.durationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationComboBox.Enabled = false;
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Location = new System.Drawing.Point(270, 254);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(142, 21);
            this.durationComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Starttijd";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimePicker.Enabled = false;
            this.startTimePicker.FormattingEnabled = true;
            this.startTimePicker.Location = new System.Drawing.Point(270, 294);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(142, 21);
            this.startTimePicker.TabIndex = 13;
            // 
            // ReservationDialog
            // 
            this.AcceptButton = this.reserveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(424, 426);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserveren";
            this.Load += new System.EventHandler(this.ReservationDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button RemoveMemberButton;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boatComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar datePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox coxswainComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox startTimePicker;
    }
}