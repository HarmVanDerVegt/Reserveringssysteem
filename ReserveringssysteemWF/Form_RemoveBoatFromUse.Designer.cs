﻿namespace ReserveringssysteemWF
{
    partial class Form_RemoveBoatFromUse
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
            this.Datagrid_RemoveBoatFromUse1 = new System.Windows.Forms.DataGridView();
            this.Datagrid_RemoveBoatFromUse2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_RemoveBoatFromUse = new System.Windows.Forms.Button();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.Name_RemoveBoatFromUseTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_RemoveBoatFromUseTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_BrokenBoats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_BrokenBoats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_RemoveBoatFromUse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_RemoveBoatFromUse2)).BeginInit();
            this.SuspendLayout();
            // 
            // Datagrid_RemoveBoatFromUse1
            // 
            this.Datagrid_RemoveBoatFromUse1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datagrid_RemoveBoatFromUse1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_RemoveBoatFromUse1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_RemoveBoatFromUseTab,
            this.Status_RemoveBoatFromUseTab});
            this.Datagrid_RemoveBoatFromUse1.Location = new System.Drawing.Point(1, 28);
            this.Datagrid_RemoveBoatFromUse1.Name = "Datagrid_RemoveBoatFromUse1";
            this.Datagrid_RemoveBoatFromUse1.RowHeadersVisible = false;
            this.Datagrid_RemoveBoatFromUse1.RowHeadersWidth = 51;
            this.Datagrid_RemoveBoatFromUse1.RowTemplate.Height = 24;
            this.Datagrid_RemoveBoatFromUse1.Size = new System.Drawing.Size(431, 150);
            this.Datagrid_RemoveBoatFromUse1.TabIndex = 0;
            // 
            // Datagrid_RemoveBoatFromUse2
            // 
            this.Datagrid_RemoveBoatFromUse2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_RemoveBoatFromUse2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_BrokenBoats,
            this.Status_BrokenBoats});
            this.Datagrid_RemoveBoatFromUse2.Location = new System.Drawing.Point(1, 208);
            this.Datagrid_RemoveBoatFromUse2.Name = "Datagrid_RemoveBoatFromUse2";
            this.Datagrid_RemoveBoatFromUse2.RowHeadersVisible = false;
            this.Datagrid_RemoveBoatFromUse2.RowHeadersWidth = 51;
            this.Datagrid_RemoveBoatFromUse2.RowTemplate.Height = 24;
            this.Datagrid_RemoveBoatFromUse2.Size = new System.Drawing.Size(431, 150);
            this.Datagrid_RemoveBoatFromUse2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Boten in onderhoud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kapotte boten";
            // 
            // Bt_RemoveBoatFromUse
            // 
            this.Bt_RemoveBoatFromUse.Location = new System.Drawing.Point(30, 391);
            this.Bt_RemoveBoatFromUse.Name = "Bt_RemoveBoatFromUse";
            this.Bt_RemoveBoatFromUse.Size = new System.Drawing.Size(135, 35);
            this.Bt_RemoveBoatFromUse.TabIndex = 4;
            this.Bt_RemoveBoatFromUse.Text = "Uit vaart nemen";
            this.Bt_RemoveBoatFromUse.UseVisualStyleBackColor = true;
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bt_Cancel.Location = new System.Drawing.Point(265, 391);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(135, 35);
            this.Bt_Cancel.TabIndex = 5;
            this.Bt_Cancel.Text = "Annuleren";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // Name_RemoveBoatFromUseTab
            // 
            this.Name_RemoveBoatFromUseTab.HeaderText = "Naam";
            this.Name_RemoveBoatFromUseTab.MinimumWidth = 6;
            this.Name_RemoveBoatFromUseTab.Name = "Name_RemoveBoatFromUseTab";
            this.Name_RemoveBoatFromUseTab.ReadOnly = true;
            this.Name_RemoveBoatFromUseTab.Width = 214;
            // 
            // Status_RemoveBoatFromUseTab
            // 
            this.Status_RemoveBoatFromUseTab.HeaderText = "Bootstatus";
            this.Status_RemoveBoatFromUseTab.MinimumWidth = 6;
            this.Status_RemoveBoatFromUseTab.Name = "Status_RemoveBoatFromUseTab";
            this.Status_RemoveBoatFromUseTab.ReadOnly = true;
            this.Status_RemoveBoatFromUseTab.Width = 214;
            // 
            // Name_BrokenBoats
            // 
            this.Name_BrokenBoats.HeaderText = "Naam";
            this.Name_BrokenBoats.MinimumWidth = 6;
            this.Name_BrokenBoats.Name = "Name_BrokenBoats";
            this.Name_BrokenBoats.ReadOnly = true;
            this.Name_BrokenBoats.Width = 214;
            // 
            // Status_BrokenBoats
            // 
            this.Status_BrokenBoats.HeaderText = "Bootstatus";
            this.Status_BrokenBoats.MinimumWidth = 6;
            this.Status_BrokenBoats.Name = "Status_BrokenBoats";
            this.Status_BrokenBoats.ReadOnly = true;
            this.Status_BrokenBoats.Width = 214;
            // 
            // Form_RemoveBoatFromUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bt_Cancel;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.Bt_RemoveBoatFromUse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datagrid_RemoveBoatFromUse2);
            this.Controls.Add(this.Datagrid_RemoveBoatFromUse1);
            this.Name = "Form_RemoveBoatFromUse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boot uit vaart nemen";
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_RemoveBoatFromUse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_RemoveBoatFromUse2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datagrid_RemoveBoatFromUse1;
        private System.Windows.Forms.DataGridView Datagrid_RemoveBoatFromUse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bt_RemoveBoatFromUse;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_RemoveBoatFromUseTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_RemoveBoatFromUseTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_BrokenBoats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_BrokenBoats;
    }
}