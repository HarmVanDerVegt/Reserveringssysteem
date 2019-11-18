namespace ReserveringssysteemWF
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_News = new System.Windows.Forms.TabPage();
            this.Datagrid_News = new System.Windows.Forms.DataGridView();
            this.Tab_Boats = new System.Windows.Forms.TabPage();
            this.Datagrid_Boats = new System.Windows.Forms.DataGridView();
            this.tab_Reservations = new System.Windows.Forms.TabPage();
            this.tab_Games = new System.Windows.Forms.TabPage();
            this.tab_Profiles = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tab_Members = new System.Windows.Forms.TabPage();
            this.tab_Teams = new System.Windows.Forms.TabPage();
            this.Bt_AddBoat = new System.Windows.Forms.Button();
            this.Bt_ModifyBoat = new System.Windows.Forms.Button();
            this.Bt_DeleteBoat = new System.Windows.Forms.Button();
            this.Datagrid_Reservations = new System.Windows.Forms.DataGridView();
            this.Date_NewsTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title_NewsTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_BoatTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity_BoatTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coxswain_BoatTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_BoatTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_RemoveReservation = new System.Windows.Forms.Button();
            this.Bt_ModifyReservation = new System.Windows.Forms.Button();
            this.Bt_AddReservation = new System.Windows.Forms.Button();
            this.Date_ReservationTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime_ReservationTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime_ReservationTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_News.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_News)).BeginInit();
            this.Tab_Boats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Boats)).BeginInit();
            this.tab_Reservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_News);
            this.tabControl1.Controls.Add(this.Tab_Boats);
            this.tabControl1.Controls.Add(this.tab_Reservations);
            this.tabControl1.Controls.Add(this.tab_Games);
            this.tabControl1.Controls.Add(this.tab_Profiles);
            this.tabControl1.Controls.Add(this.tab_Members);
            this.tabControl1.Controls.Add(this.tab_Teams);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 413);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_News
            // 
            this.tab_News.Controls.Add(this.Datagrid_News);
            this.tab_News.Location = new System.Drawing.Point(4, 25);
            this.tab_News.Name = "tab_News";
            this.tab_News.Padding = new System.Windows.Forms.Padding(3);
            this.tab_News.Size = new System.Drawing.Size(760, 384);
            this.tab_News.TabIndex = 0;
            this.tab_News.Text = "Nieuws";
            this.tab_News.UseVisualStyleBackColor = true;
            // 
            // Datagrid_News
            // 
            this.Datagrid_News.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datagrid_News.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.Datagrid_News.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_News.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_NewsTab,
            this.Title_NewsTab});
            this.Datagrid_News.Location = new System.Drawing.Point(7, 7);
            this.Datagrid_News.Name = "Datagrid_News";
            this.Datagrid_News.ReadOnly = true;
            this.Datagrid_News.RowHeadersVisible = false;
            this.Datagrid_News.RowHeadersWidth = 51;
            this.Datagrid_News.RowTemplate.Height = 24;
            this.Datagrid_News.Size = new System.Drawing.Size(747, 371);
            this.Datagrid_News.TabIndex = 0;
            // 
            // Tab_Boats
            // 
            this.Tab_Boats.Controls.Add(this.Bt_DeleteBoat);
            this.Tab_Boats.Controls.Add(this.Bt_ModifyBoat);
            this.Tab_Boats.Controls.Add(this.Bt_AddBoat);
            this.Tab_Boats.Controls.Add(this.Datagrid_Boats);
            this.Tab_Boats.Location = new System.Drawing.Point(4, 25);
            this.Tab_Boats.Name = "Tab_Boats";
            this.Tab_Boats.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Boats.Size = new System.Drawing.Size(760, 384);
            this.Tab_Boats.TabIndex = 1;
            this.Tab_Boats.Text = "Boten";
            this.Tab_Boats.UseVisualStyleBackColor = true;
            // 
            // Datagrid_Boats
            // 
            this.Datagrid_Boats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datagrid_Boats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_Boats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_BoatTab,
            this.Capacity_BoatTab,
            this.Coxswain_BoatTab,
            this.Amount_BoatTab});
            this.Datagrid_Boats.Location = new System.Drawing.Point(0, 77);
            this.Datagrid_Boats.Name = "Datagrid_Boats";
            this.Datagrid_Boats.RowHeadersVisible = false;
            this.Datagrid_Boats.RowHeadersWidth = 51;
            this.Datagrid_Boats.RowTemplate.Height = 24;
            this.Datagrid_Boats.Size = new System.Drawing.Size(760, 311);
            this.Datagrid_Boats.TabIndex = 0;
            // 
            // tab_Reservations
            // 
            this.tab_Reservations.Controls.Add(this.Bt_RemoveReservation);
            this.tab_Reservations.Controls.Add(this.Bt_ModifyReservation);
            this.tab_Reservations.Controls.Add(this.Bt_AddReservation);
            this.tab_Reservations.Controls.Add(this.Datagrid_Reservations);
            this.tab_Reservations.Location = new System.Drawing.Point(4, 25);
            this.tab_Reservations.Name = "tab_Reservations";
            this.tab_Reservations.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Reservations.Size = new System.Drawing.Size(760, 384);
            this.tab_Reservations.TabIndex = 2;
            this.tab_Reservations.Text = "Reserveringen";
            this.tab_Reservations.UseVisualStyleBackColor = true;
            // 
            // tab_Games
            // 
            this.tab_Games.Location = new System.Drawing.Point(4, 25);
            this.tab_Games.Name = "tab_Games";
            this.tab_Games.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Games.Size = new System.Drawing.Size(760, 384);
            this.tab_Games.TabIndex = 3;
            this.tab_Games.Text = "Wedstrijden";
            this.tab_Games.UseVisualStyleBackColor = true;
            // 
            // tab_Profiles
            // 
            this.tab_Profiles.Location = new System.Drawing.Point(4, 25);
            this.tab_Profiles.Name = "tab_Profiles";
            this.tab_Profiles.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Profiles.Size = new System.Drawing.Size(760, 384);
            this.tab_Profiles.TabIndex = 4;
            this.tab_Profiles.Text = "Profielen";
            this.tab_Profiles.UseVisualStyleBackColor = true;
            // 
            // tab_Members
            // 
            this.tab_Members.Location = new System.Drawing.Point(4, 25);
            this.tab_Members.Name = "tab_Members";
            this.tab_Members.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Members.Size = new System.Drawing.Size(760, 384);
            this.tab_Members.TabIndex = 5;
            this.tab_Members.Text = "Leden";
            this.tab_Members.UseVisualStyleBackColor = true;
            // 
            // tab_Teams
            // 
            this.tab_Teams.Location = new System.Drawing.Point(4, 25);
            this.tab_Teams.Name = "tab_Teams";
            this.tab_Teams.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Teams.Size = new System.Drawing.Size(760, 384);
            this.tab_Teams.TabIndex = 6;
            this.tab_Teams.Text = "Teams";
            this.tab_Teams.UseVisualStyleBackColor = true;
            // 
            // Bt_AddBoat
            // 
            this.Bt_AddBoat.Location = new System.Drawing.Point(16, 24);
            this.Bt_AddBoat.Name = "Bt_AddBoat";
            this.Bt_AddBoat.Size = new System.Drawing.Size(127, 31);
            this.Bt_AddBoat.TabIndex = 1;
            this.Bt_AddBoat.Text = "Boot toevoegen";
            this.Bt_AddBoat.UseVisualStyleBackColor = true;
            // 
            // Bt_ModifyBoat
            // 
            this.Bt_ModifyBoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_ModifyBoat.Location = new System.Drawing.Point(455, 24);
            this.Bt_ModifyBoat.Name = "Bt_ModifyBoat";
            this.Bt_ModifyBoat.Size = new System.Drawing.Size(127, 31);
            this.Bt_ModifyBoat.TabIndex = 2;
            this.Bt_ModifyBoat.Text = "Boot wijzigen";
            this.Bt_ModifyBoat.UseVisualStyleBackColor = true;
            // 
            // Bt_DeleteBoat
            // 
            this.Bt_DeleteBoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_DeleteBoat.Location = new System.Drawing.Point(617, 24);
            this.Bt_DeleteBoat.Name = "Bt_DeleteBoat";
            this.Bt_DeleteBoat.Size = new System.Drawing.Size(127, 31);
            this.Bt_DeleteBoat.TabIndex = 3;
            this.Bt_DeleteBoat.Text = "Boot verwijderen";
            this.Bt_DeleteBoat.UseVisualStyleBackColor = true;
            // 
            // Datagrid_Reservations
            // 
            this.Datagrid_Reservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datagrid_Reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_Reservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_ReservationTab,
            this.StartTime_ReservationTab,
            this.EndTime_ReservationTab});
            this.Datagrid_Reservations.Location = new System.Drawing.Point(0, 77);
            this.Datagrid_Reservations.Name = "Datagrid_Reservations";
            this.Datagrid_Reservations.RowHeadersVisible = false;
            this.Datagrid_Reservations.RowHeadersWidth = 51;
            this.Datagrid_Reservations.RowTemplate.Height = 24;
            this.Datagrid_Reservations.Size = new System.Drawing.Size(761, 314);
            this.Datagrid_Reservations.TabIndex = 0;
            // 
            // Date_NewsTab
            // 
            this.Date_NewsTab.HeaderText = "Datum";
            this.Date_NewsTab.MinimumWidth = 6;
            this.Date_NewsTab.Name = "Date_NewsTab";
            this.Date_NewsTab.ReadOnly = true;
            this.Date_NewsTab.Width = 200;
            // 
            // Title_NewsTab
            // 
            this.Title_NewsTab.HeaderText = "Titel";
            this.Title_NewsTab.MinimumWidth = 6;
            this.Title_NewsTab.Name = "Title_NewsTab";
            this.Title_NewsTab.ReadOnly = true;
            this.Title_NewsTab.Width = 550;
            // 
            // Name_BoatTab
            // 
            this.Name_BoatTab.HeaderText = "Naam";
            this.Name_BoatTab.MinimumWidth = 6;
            this.Name_BoatTab.Name = "Name_BoatTab";
            this.Name_BoatTab.ReadOnly = true;
            this.Name_BoatTab.Width = 190;
            // 
            // Capacity_BoatTab
            // 
            this.Capacity_BoatTab.HeaderText = "Capaciteit";
            this.Capacity_BoatTab.MinimumWidth = 6;
            this.Capacity_BoatTab.Name = "Capacity_BoatTab";
            this.Capacity_BoatTab.ReadOnly = true;
            this.Capacity_BoatTab.Width = 190;
            // 
            // Coxswain_BoatTab
            // 
            this.Coxswain_BoatTab.HeaderText = "Stuurman";
            this.Coxswain_BoatTab.MinimumWidth = 6;
            this.Coxswain_BoatTab.Name = "Coxswain_BoatTab";
            this.Coxswain_BoatTab.ReadOnly = true;
            this.Coxswain_BoatTab.Width = 190;
            // 
            // Amount_BoatTab
            // 
            this.Amount_BoatTab.HeaderText = "Aantal";
            this.Amount_BoatTab.MinimumWidth = 6;
            this.Amount_BoatTab.Name = "Amount_BoatTab";
            this.Amount_BoatTab.ReadOnly = true;
            this.Amount_BoatTab.Width = 190;
            // 
            // Bt_RemoveReservation
            // 
            this.Bt_RemoveReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_RemoveReservation.Location = new System.Drawing.Point(571, 24);
            this.Bt_RemoveReservation.Name = "Bt_RemoveReservation";
            this.Bt_RemoveReservation.Size = new System.Drawing.Size(173, 31);
            this.Bt_RemoveReservation.TabIndex = 6;
            this.Bt_RemoveReservation.Text = "Reservering annuleren";
            this.Bt_RemoveReservation.UseVisualStyleBackColor = true;
            // 
            // Bt_ModifyReservation
            // 
            this.Bt_ModifyReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_ModifyReservation.Location = new System.Drawing.Point(407, 24);
            this.Bt_ModifyReservation.Name = "Bt_ModifyReservation";
            this.Bt_ModifyReservation.Size = new System.Drawing.Size(149, 31);
            this.Bt_ModifyReservation.TabIndex = 5;
            this.Bt_ModifyReservation.Text = "Reservering wijzigen";
            this.Bt_ModifyReservation.UseVisualStyleBackColor = true;
            // 
            // Bt_AddReservation
            // 
            this.Bt_AddReservation.Location = new System.Drawing.Point(16, 24);
            this.Bt_AddReservation.Name = "Bt_AddReservation";
            this.Bt_AddReservation.Size = new System.Drawing.Size(127, 31);
            this.Bt_AddReservation.TabIndex = 4;
            this.Bt_AddReservation.Text = "Reserveren";
            this.Bt_AddReservation.UseVisualStyleBackColor = true;
            // 
            // Date_ReservationTab
            // 
            this.Date_ReservationTab.HeaderText = "Datum";
            this.Date_ReservationTab.MinimumWidth = 6;
            this.Date_ReservationTab.Name = "Date_ReservationTab";
            this.Date_ReservationTab.ReadOnly = true;
            this.Date_ReservationTab.Width = 253;
            // 
            // StartTime_ReservationTab
            // 
            this.StartTime_ReservationTab.HeaderText = "Starttijd";
            this.StartTime_ReservationTab.MinimumWidth = 6;
            this.StartTime_ReservationTab.Name = "StartTime_ReservationTab";
            this.StartTime_ReservationTab.ReadOnly = true;
            this.StartTime_ReservationTab.Width = 253;
            // 
            // EndTime_ReservationTab
            // 
            this.EndTime_ReservationTab.HeaderText = "Eindtijd";
            this.EndTime_ReservationTab.MinimumWidth = 6;
            this.EndTime_ReservationTab.Name = "EndTime_ReservationTab";
            this.EndTime_ReservationTab.ReadOnly = true;
            this.EndTime_ReservationTab.Width = 253;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Reserveringssyteem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_News.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_News)).EndInit();
            this.Tab_Boats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Boats)).EndInit();
            this.tab_Reservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Reservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_News;
        private System.Windows.Forms.TabPage Tab_Boats;
        private System.Windows.Forms.TabPage tab_Reservations;
        private System.Windows.Forms.TabPage tab_Games;
        private System.Windows.Forms.TabPage tab_Profiles;
        private System.Windows.Forms.DataGridView Datagrid_News;
        private System.Windows.Forms.DataGridView Datagrid_Boats;
        private System.Windows.Forms.TabPage tab_Members;
        private System.Windows.Forms.TabPage tab_Teams;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Bt_DeleteBoat;
        private System.Windows.Forms.Button Bt_ModifyBoat;
        private System.Windows.Forms.Button Bt_AddBoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_NewsTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title_NewsTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_BoatTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity_BoatTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coxswain_BoatTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_BoatTab;
        private System.Windows.Forms.DataGridView Datagrid_Reservations;
        private System.Windows.Forms.Button Bt_RemoveReservation;
        private System.Windows.Forms.Button Bt_ModifyReservation;
        private System.Windows.Forms.Button Bt_AddReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_ReservationTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime_ReservationTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime_ReservationTab;
    }
}

