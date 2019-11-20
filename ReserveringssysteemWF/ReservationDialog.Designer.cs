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
            this.teamLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.boatLabel = new System.Windows.Forms.Label();
            this.reservePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reserveButton
            // 
            this.reserveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reserveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.reserveButton.Location = new System.Drawing.Point(340, 331);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(75, 23);
            this.reserveButton.TabIndex = 0;
            this.reserveButton.Text = "Reserveren";
            this.reserveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(421, 331);
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
            this.reservePanel.Controls.Add(this.boatLabel);
            this.reservePanel.Controls.Add(this.teamLabel);
            this.reservePanel.Controls.Add(this.addMemberButton);
            this.reservePanel.Controls.Add(this.teamListBox);
            this.reservePanel.Location = new System.Drawing.Point(0, 0);
            this.reservePanel.Name = "reservePanel";
            this.reservePanel.Size = new System.Drawing.Size(508, 325);
            this.reservePanel.TabIndex = 0;
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
            this.addMemberButton.Size = new System.Drawing.Size(106, 23);
            this.addMemberButton.TabIndex = 2;
            this.addMemberButton.Text = "Teamlid toevoegen";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamListBox
            // 
            this.teamListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(12, 25);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(484, 95);
            this.teamListBox.TabIndex = 1;
            // 
            // boatLabel
            // 
            this.boatLabel.AutoSize = true;
            this.boatLabel.Location = new System.Drawing.Point(12, 152);
            this.boatLabel.Name = "boatLabel";
            this.boatLabel.Size = new System.Drawing.Size(29, 13);
            this.boatLabel.TabIndex = 3;
            this.boatLabel.Text = "Boot";
            // 
            // ReservationDialog
            // 
            this.AcceptButton = this.reserveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(508, 366);
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
    }
}