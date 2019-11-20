namespace ReserveringssysteemWF
{
    partial class MemberPicker
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.pickButton = new System.Windows.Forms.Button();
            this.pickPanel = new System.Windows.Forms.Panel();
            this.membersLabel = new System.Windows.Forms.Label();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.pickPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(213, 190);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Annuleren";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // pickButton
            // 
            this.pickButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pickButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pickButton.Location = new System.Drawing.Point(132, 190);
            this.pickButton.Name = "pickButton";
            this.pickButton.Size = new System.Drawing.Size(75, 23);
            this.pickButton.TabIndex = 2;
            this.pickButton.Text = "Kiezen";
            this.pickButton.UseVisualStyleBackColor = true;
            // 
            // pickPanel
            // 
            this.pickPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickPanel.BackColor = System.Drawing.SystemColors.Window;
            this.pickPanel.Controls.Add(this.filterTextBox);
            this.pickPanel.Controls.Add(this.filterLabel);
            this.pickPanel.Controls.Add(this.memberListBox);
            this.pickPanel.Controls.Add(this.membersLabel);
            this.pickPanel.Location = new System.Drawing.Point(0, 0);
            this.pickPanel.Name = "pickPanel";
            this.pickPanel.Size = new System.Drawing.Size(300, 184);
            this.pickPanel.TabIndex = 0;
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Location = new System.Drawing.Point(12, 9);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(125, 13);
            this.membersLabel.TabIndex = 0;
            this.membersLabel.Text = "Leden van de vereniging";
            // 
            // memberListBox
            // 
            this.memberListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.Location = new System.Drawing.Point(12, 25);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.Size = new System.Drawing.Size(276, 108);
            this.memberListBox.TabIndex = 1;
            // 
            // filterLabel
            // 
            this.filterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(12, 145);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(29, 13);
            this.filterLabel.TabIndex = 2;
            this.filterLabel.Text = "Filter";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTextBox.Location = new System.Drawing.Point(12, 161);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(276, 20);
            this.filterTextBox.TabIndex = 3;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // MemberPicker
            // 
            this.AcceptButton = this.pickButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(300, 225);
            this.Controls.Add(this.pickPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pickButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberPicker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lid kiezen";
            this.Load += new System.EventHandler(this.MemberPicker_Load);
            this.pickPanel.ResumeLayout(false);
            this.pickPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button pickButton;
        private System.Windows.Forms.Panel pickPanel;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ListBox memberListBox;
    }
}