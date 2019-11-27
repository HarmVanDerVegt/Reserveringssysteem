namespace ReserveringssysteemWF
{
    partial class RemoveMatchDialog
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
            this.button1 = new System.Windows.Forms.Button();
            this.Context = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Remove_Datagrid_Games = new System.Windows.Forms.DataGridView();
            this.Date_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boat_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Remove_Datagrid_Games)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(269, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Context
            // 
            this.Context.AutoSize = true;
            this.Context.Location = new System.Drawing.Point(206, 53);
            this.Context.Name = "Context";
            this.Context.Size = new System.Drawing.Size(382, 17);
            this.Context.TabIndex = 1;
            this.Context.Text = "Weet je zeker dat je de volgende wedstrijd wilt verwijderen?";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(438, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Nee";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Remove_Datagrid_Games
            // 
            this.Remove_Datagrid_Games.AllowUserToResizeColumns = false;
            this.Remove_Datagrid_Games.AllowUserToResizeRows = false;
            this.Remove_Datagrid_Games.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Remove_Datagrid_Games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Remove_Datagrid_Games.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_GameTab,
            this.StartTime_GameTab,
            this.EndTime_GameTab,
            this.Boat_GameTab,
            this.Distance_GameTab,
            this.Gender_GameTab,
            this.ID});
            this.Remove_Datagrid_Games.Location = new System.Drawing.Point(12, 93);
            this.Remove_Datagrid_Games.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Remove_Datagrid_Games.Name = "Remove_Datagrid_Games";
            this.Remove_Datagrid_Games.RowHeadersVisible = false;
            this.Remove_Datagrid_Games.RowHeadersWidth = 51;
            this.Remove_Datagrid_Games.RowTemplate.Height = 24;
            this.Remove_Datagrid_Games.Size = new System.Drawing.Size(759, 204);
            this.Remove_Datagrid_Games.TabIndex = 3;
            // 
            // Date_GameTab
            // 
            this.Date_GameTab.HeaderText = "Datum";
            this.Date_GameTab.MinimumWidth = 6;
            this.Date_GameTab.Name = "Date_GameTab";
            this.Date_GameTab.ReadOnly = true;
            this.Date_GameTab.Width = 126;
            // 
            // StartTime_GameTab
            // 
            this.StartTime_GameTab.HeaderText = "Starttijd";
            this.StartTime_GameTab.MinimumWidth = 6;
            this.StartTime_GameTab.Name = "StartTime_GameTab";
            this.StartTime_GameTab.ReadOnly = true;
            this.StartTime_GameTab.Width = 126;
            // 
            // EndTime_GameTab
            // 
            this.EndTime_GameTab.HeaderText = "Eindtijd";
            this.EndTime_GameTab.MinimumWidth = 6;
            this.EndTime_GameTab.Name = "EndTime_GameTab";
            this.EndTime_GameTab.ReadOnly = true;
            this.EndTime_GameTab.Width = 126;
            // 
            // Boat_GameTab
            // 
            this.Boat_GameTab.HeaderText = "Boot";
            this.Boat_GameTab.MinimumWidth = 6;
            this.Boat_GameTab.Name = "Boat_GameTab";
            this.Boat_GameTab.ReadOnly = true;
            this.Boat_GameTab.Width = 126;
            // 
            // Distance_GameTab
            // 
            this.Distance_GameTab.HeaderText = "Afstand";
            this.Distance_GameTab.MinimumWidth = 6;
            this.Distance_GameTab.Name = "Distance_GameTab";
            this.Distance_GameTab.ReadOnly = true;
            this.Distance_GameTab.Width = 126;
            // 
            // Gender_GameTab
            // 
            this.Gender_GameTab.HeaderText = "Geslacht";
            this.Gender_GameTab.MinimumWidth = 6;
            this.Gender_GameTab.Name = "Gender_GameTab";
            this.Gender_GameTab.ReadOnly = true;
            this.Gender_GameTab.Width = 126;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // RemoveMatchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(778, 378);
            this.Controls.Add(this.Remove_Datagrid_Games);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Context);
            this.Controls.Add(this.button1);
            this.Name = "RemoveMatchDialog";
            this.Text = "RemoveMatchDialog";
            ((System.ComponentModel.ISupportInitialize)(this.Remove_Datagrid_Games)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Context;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Remove_Datagrid_Games;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boat_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}