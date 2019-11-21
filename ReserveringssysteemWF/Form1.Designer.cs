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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_News = new System.Windows.Forms.TabPage();
            this.Datagrid_News = new System.Windows.Forms.DataGridView();
            this.Date_NewsTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title_NewsTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab_Boats = new System.Windows.Forms.TabPage();
            this.Bt_ReportDamage = new System.Windows.Forms.Button();
            this.Bt_DeleteBoat = new System.Windows.Forms.Button();
            this.Bt_ModifyBoat = new System.Windows.Forms.Button();
            this.Bt_AddBoat = new System.Windows.Forms.Button();
            this.Datagrid_Boats = new System.Windows.Forms.DataGridView();
            this.Name_BoatTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity_BoatTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coxswain_BoatTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_BoatTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Reservations = new System.Windows.Forms.TabPage();
            this.Bt_RemoveReservation = new System.Windows.Forms.Button();
            this.Bt_ModifyReservation = new System.Windows.Forms.Button();
            this.Bt_AddReservation = new System.Windows.Forms.Button();
            this.Datagrid_Reservations = new System.Windows.Forms.DataGridView();
            this.Date_ReservationTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime_ReservationTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime_ReservationTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Games = new System.Windows.Forms.TabPage();
            this.Bt_RemoveGame = new System.Windows.Forms.Button();
            this.Bt_AddGame = new System.Windows.Forms.Button();
            this.Datagrid_Games = new System.Windows.Forms.DataGridView();
            this.Date_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boat_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender_GameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Profiles = new System.Windows.Forms.TabPage();
            this.Bt_RemoveProfile = new System.Windows.Forms.Button();
            this.Bt_ModifyProfile = new System.Windows.Forms.Button();
            this.Bt_MakeProfile = new System.Windows.Forms.Button();
            this.Datagrid_Profiles = new System.Windows.Forms.DataGridView();
            this.Club_ProfilesTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ProfilesTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth_ProfilesTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender_ProfilesTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Members = new System.Windows.Forms.TabPage();
            this.Datagrid_Members = new System.Windows.Forms.DataGridView();
            this.Email_MembersTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress_MembersTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_RemoveMember = new System.Windows.Forms.Button();
            this.Bt_ModifyMember = new System.Windows.Forms.Button();
            this.Bt_AddMember = new System.Windows.Forms.Button();
            this.tab_Teams = new System.Windows.Forms.TabPage();
            this.Datagrid_Teams = new System.Windows.Forms.DataGridView();
            this.Teamname_TeamsTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamMembers_TeamsTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_RemoveTeam = new System.Windows.Forms.Button();
            this.Bt_ModifyTeam = new System.Windows.Forms.Button();
            this.Bt_CreateTeam = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Bt_RemoveBoatFromUse = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_News.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_News)).BeginInit();
            this.Tab_Boats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Boats)).BeginInit();
            this.tab_Reservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Reservations)).BeginInit();
            this.tab_Games.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Games)).BeginInit();
            this.tab_Profiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Profiles)).BeginInit();
            this.tab_Members.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Members)).BeginInit();
            this.tab_Teams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Teams)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 30);
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem.Text = "About";
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
            this.tabControl1.Size = new System.Drawing.Size(1002, 413);
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
            this.Datagrid_News.AllowUserToResizeColumns = false;
            this.Datagrid_News.AllowUserToResizeRows = false;
            this.Datagrid_News.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datagrid_News.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.Datagrid_News.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_News.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_NewsTab,
            this.Title_NewsTab});
            this.Datagrid_News.Location = new System.Drawing.Point(0, 7);
            this.Datagrid_News.Name = "Datagrid_News";
            this.Datagrid_News.ReadOnly = true;
            this.Datagrid_News.RowHeadersVisible = false;
            this.Datagrid_News.RowHeadersWidth = 51;
            this.Datagrid_News.RowTemplate.Height = 24;
            this.Datagrid_News.Size = new System.Drawing.Size(760, 371);
            this.Datagrid_News.TabIndex = 0;
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
            this.Title_NewsTab.Width = 560;
            // 
            // Tab_Boats
            // 
            this.Tab_Boats.Controls.Add(this.Bt_RemoveBoatFromUse);
            this.Tab_Boats.Controls.Add(this.Bt_ReportDamage);
            this.Tab_Boats.Controls.Add(this.Bt_DeleteBoat);
            this.Tab_Boats.Controls.Add(this.Bt_ModifyBoat);
            this.Tab_Boats.Controls.Add(this.Bt_AddBoat);
            this.Tab_Boats.Controls.Add(this.Datagrid_Boats);
            this.Tab_Boats.Location = new System.Drawing.Point(4, 25);
            this.Tab_Boats.Name = "Tab_Boats";
            this.Tab_Boats.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Boats.Size = new System.Drawing.Size(994, 384);
            this.Tab_Boats.TabIndex = 1;
            this.Tab_Boats.Text = "Boten";
            this.Tab_Boats.UseVisualStyleBackColor = true;
            // 
            // Bt_ReportDamage
            // 
            this.Bt_ReportDamage.Location = new System.Drawing.Point(16, 24);
            this.Bt_ReportDamage.Name = "Bt_ReportDamage";
            this.Bt_ReportDamage.Size = new System.Drawing.Size(127, 31);
            this.Bt_ReportDamage.TabIndex = 4;
            this.Bt_ReportDamage.Text = "Schade melden";
            this.Bt_ReportDamage.UseVisualStyleBackColor = true;
            // 
            // Bt_DeleteBoat
            // 
            this.Bt_DeleteBoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_DeleteBoat.Location = new System.Drawing.Point(851, 24);
            this.Bt_DeleteBoat.Name = "Bt_DeleteBoat";
            this.Bt_DeleteBoat.Size = new System.Drawing.Size(127, 31);
            this.Bt_DeleteBoat.TabIndex = 3;
            this.Bt_DeleteBoat.Text = "Boot verwijderen";
            this.Bt_DeleteBoat.UseVisualStyleBackColor = true;
            this.Bt_DeleteBoat.Click += new System.EventHandler(this.Bt_DeleteBoat_Click);
            // 
            // Bt_ModifyBoat
            // 
            this.Bt_ModifyBoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_ModifyBoat.Location = new System.Drawing.Point(689, 24);
            this.Bt_ModifyBoat.Name = "Bt_ModifyBoat";
            this.Bt_ModifyBoat.Size = new System.Drawing.Size(127, 31);
            this.Bt_ModifyBoat.TabIndex = 2;
            this.Bt_ModifyBoat.Text = "Boot wijzigen";
            this.Bt_ModifyBoat.UseVisualStyleBackColor = true;
            // 
            // Bt_AddBoat
            // 
            this.Bt_AddBoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_AddBoat.Location = new System.Drawing.Point(521, 24);
            this.Bt_AddBoat.Name = "Bt_AddBoat";
            this.Bt_AddBoat.Size = new System.Drawing.Size(127, 31);
            this.Bt_AddBoat.TabIndex = 1;
            this.Bt_AddBoat.Text = "Boot toevoegen";
            this.Bt_AddBoat.UseVisualStyleBackColor = true;
            this.Bt_AddBoat.Click += new System.EventHandler(this.Bt_AddBoat_Click);
            // 
            // Datagrid_Boats
            // 
            this.Datagrid_Boats.AllowUserToResizeColumns = false;
            this.Datagrid_Boats.AllowUserToResizeRows = false;
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
            this.Datagrid_Boats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_Boats.Size = new System.Drawing.Size(994, 311);
            this.Datagrid_Boats.TabIndex = 0;
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
            // Datagrid_Reservations
            // 
            this.Datagrid_Reservations.AllowUserToResizeColumns = false;
            this.Datagrid_Reservations.AllowUserToResizeRows = false;
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
            // tab_Games
            // 
            this.tab_Games.Controls.Add(this.Bt_RemoveGame);
            this.tab_Games.Controls.Add(this.Bt_AddGame);
            this.tab_Games.Controls.Add(this.Datagrid_Games);
            this.tab_Games.Location = new System.Drawing.Point(4, 25);
            this.tab_Games.Name = "tab_Games";
            this.tab_Games.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Games.Size = new System.Drawing.Size(760, 384);
            this.tab_Games.TabIndex = 3;
            this.tab_Games.Text = "Wedstrijden";
            this.tab_Games.UseVisualStyleBackColor = true;
            // 
            // Bt_RemoveGame
            // 
            this.Bt_RemoveGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_RemoveGame.Location = new System.Drawing.Point(584, 24);
            this.Bt_RemoveGame.Name = "Bt_RemoveGame";
            this.Bt_RemoveGame.Size = new System.Drawing.Size(156, 31);
            this.Bt_RemoveGame.TabIndex = 6;
            this.Bt_RemoveGame.Text = "Wedstrijd annuleren";
            this.Bt_RemoveGame.UseVisualStyleBackColor = true;
            // 
            // Bt_AddGame
            // 
            this.Bt_AddGame.Location = new System.Drawing.Point(16, 24);
            this.Bt_AddGame.Name = "Bt_AddGame";
            this.Bt_AddGame.Size = new System.Drawing.Size(158, 31);
            this.Bt_AddGame.TabIndex = 4;
            this.Bt_AddGame.Text = "Wedstrijd toevoegen";
            this.Bt_AddGame.UseVisualStyleBackColor = true;
            // 
            // Datagrid_Games
            // 
            this.Datagrid_Games.AllowUserToResizeColumns = false;
            this.Datagrid_Games.AllowUserToResizeRows = false;
            this.Datagrid_Games.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datagrid_Games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_Games.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_GameTab,
            this.StartTime_GameTab,
            this.EndTime_GameTab,
            this.Boat_GameTab,
            this.Distance_GameTab,
            this.Gender_GameTab});
            this.Datagrid_Games.Location = new System.Drawing.Point(0, 77);
            this.Datagrid_Games.Name = "Datagrid_Games";
            this.Datagrid_Games.RowHeadersVisible = false;
            this.Datagrid_Games.RowHeadersWidth = 51;
            this.Datagrid_Games.RowTemplate.Height = 24;
            this.Datagrid_Games.Size = new System.Drawing.Size(760, 311);
            this.Datagrid_Games.TabIndex = 0;
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
            // tab_Profiles
            // 
            this.tab_Profiles.Controls.Add(this.Bt_RemoveProfile);
            this.tab_Profiles.Controls.Add(this.Bt_ModifyProfile);
            this.tab_Profiles.Controls.Add(this.Bt_MakeProfile);
            this.tab_Profiles.Controls.Add(this.Datagrid_Profiles);
            this.tab_Profiles.Location = new System.Drawing.Point(4, 25);
            this.tab_Profiles.Name = "tab_Profiles";
            this.tab_Profiles.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Profiles.Size = new System.Drawing.Size(760, 384);
            this.tab_Profiles.TabIndex = 4;
            this.tab_Profiles.Text = "Profielen";
            this.tab_Profiles.UseVisualStyleBackColor = true;
            // 
            // Bt_RemoveProfile
            // 
            this.Bt_RemoveProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_RemoveProfile.Location = new System.Drawing.Point(604, 24);
            this.Bt_RemoveProfile.Name = "Bt_RemoveProfile";
            this.Bt_RemoveProfile.Size = new System.Drawing.Size(140, 31);
            this.Bt_RemoveProfile.TabIndex = 6;
            this.Bt_RemoveProfile.Text = "Profiel verwijderen";
            this.Bt_RemoveProfile.UseVisualStyleBackColor = true;
            // 
            // Bt_ModifyProfile
            // 
            this.Bt_ModifyProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_ModifyProfile.Location = new System.Drawing.Point(455, 24);
            this.Bt_ModifyProfile.Name = "Bt_ModifyProfile";
            this.Bt_ModifyProfile.Size = new System.Drawing.Size(127, 31);
            this.Bt_ModifyProfile.TabIndex = 5;
            this.Bt_ModifyProfile.Text = "Profiel wijzigen";
            this.Bt_ModifyProfile.UseVisualStyleBackColor = true;
            // 
            // Bt_MakeProfile
            // 
            this.Bt_MakeProfile.Location = new System.Drawing.Point(16, 24);
            this.Bt_MakeProfile.Name = "Bt_MakeProfile";
            this.Bt_MakeProfile.Size = new System.Drawing.Size(133, 31);
            this.Bt_MakeProfile.TabIndex = 4;
            this.Bt_MakeProfile.Text = "Profiel aanmaken";
            this.Bt_MakeProfile.UseVisualStyleBackColor = true;
            // 
            // Datagrid_Profiles
            // 
            this.Datagrid_Profiles.AllowUserToResizeColumns = false;
            this.Datagrid_Profiles.AllowUserToResizeRows = false;
            this.Datagrid_Profiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datagrid_Profiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_Profiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Club_ProfilesTab,
            this.Name_ProfilesTab,
            this.DateOfBirth_ProfilesTab,
            this.Gender_ProfilesTab});
            this.Datagrid_Profiles.Location = new System.Drawing.Point(0, 77);
            this.Datagrid_Profiles.Name = "Datagrid_Profiles";
            this.Datagrid_Profiles.RowHeadersVisible = false;
            this.Datagrid_Profiles.RowHeadersWidth = 51;
            this.Datagrid_Profiles.RowTemplate.Height = 24;
            this.Datagrid_Profiles.Size = new System.Drawing.Size(757, 307);
            this.Datagrid_Profiles.TabIndex = 0;
            // 
            // Club_ProfilesTab
            // 
            this.Club_ProfilesTab.HeaderText = "Vereniging";
            this.Club_ProfilesTab.MinimumWidth = 6;
            this.Club_ProfilesTab.Name = "Club_ProfilesTab";
            this.Club_ProfilesTab.ReadOnly = true;
            this.Club_ProfilesTab.Width = 189;
            // 
            // Name_ProfilesTab
            // 
            this.Name_ProfilesTab.HeaderText = "Naam";
            this.Name_ProfilesTab.MinimumWidth = 6;
            this.Name_ProfilesTab.Name = "Name_ProfilesTab";
            this.Name_ProfilesTab.ReadOnly = true;
            this.Name_ProfilesTab.Width = 189;
            // 
            // DateOfBirth_ProfilesTab
            // 
            this.DateOfBirth_ProfilesTab.HeaderText = "Geboortedatum";
            this.DateOfBirth_ProfilesTab.MinimumWidth = 6;
            this.DateOfBirth_ProfilesTab.Name = "DateOfBirth_ProfilesTab";
            this.DateOfBirth_ProfilesTab.ReadOnly = true;
            this.DateOfBirth_ProfilesTab.Width = 189;
            // 
            // Gender_ProfilesTab
            // 
            this.Gender_ProfilesTab.HeaderText = "Geslacht";
            this.Gender_ProfilesTab.MinimumWidth = 6;
            this.Gender_ProfilesTab.Name = "Gender_ProfilesTab";
            this.Gender_ProfilesTab.ReadOnly = true;
            this.Gender_ProfilesTab.Width = 189;
            // 
            // tab_Members
            // 
            this.tab_Members.Controls.Add(this.Datagrid_Members);
            this.tab_Members.Controls.Add(this.Bt_RemoveMember);
            this.tab_Members.Controls.Add(this.Bt_ModifyMember);
            this.tab_Members.Controls.Add(this.Bt_AddMember);
            this.tab_Members.Location = new System.Drawing.Point(4, 25);
            this.tab_Members.Name = "tab_Members";
            this.tab_Members.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Members.Size = new System.Drawing.Size(760, 384);
            this.tab_Members.TabIndex = 5;
            this.tab_Members.Text = "Leden";
            this.tab_Members.UseVisualStyleBackColor = true;
            // 
            // Datagrid_Members
            // 
            this.Datagrid_Members.AllowUserToResizeColumns = false;
            this.Datagrid_Members.AllowUserToResizeRows = false;
            this.Datagrid_Members.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datagrid_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email_MembersTab,
            this.Adress_MembersTab});
            this.Datagrid_Members.Location = new System.Drawing.Point(0, 77);
            this.Datagrid_Members.Name = "Datagrid_Members";
            this.Datagrid_Members.RowHeadersVisible = false;
            this.Datagrid_Members.RowHeadersWidth = 51;
            this.Datagrid_Members.RowTemplate.Height = 24;
            this.Datagrid_Members.Size = new System.Drawing.Size(760, 311);
            this.Datagrid_Members.TabIndex = 10;
            // 
            // Email_MembersTab
            // 
            this.Email_MembersTab.HeaderText = "E-mail";
            this.Email_MembersTab.MinimumWidth = 6;
            this.Email_MembersTab.Name = "Email_MembersTab";
            this.Email_MembersTab.ReadOnly = true;
            this.Email_MembersTab.Width = 380;
            // 
            // Adress_MembersTab
            // 
            this.Adress_MembersTab.HeaderText = "Adres";
            this.Adress_MembersTab.MinimumWidth = 6;
            this.Adress_MembersTab.Name = "Adress_MembersTab";
            this.Adress_MembersTab.ReadOnly = true;
            this.Adress_MembersTab.Width = 380;
            // 
            // Bt_RemoveMember
            // 
            this.Bt_RemoveMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_RemoveMember.Location = new System.Drawing.Point(603, 24);
            this.Bt_RemoveMember.Name = "Bt_RemoveMember";
            this.Bt_RemoveMember.Size = new System.Drawing.Size(140, 31);
            this.Bt_RemoveMember.TabIndex = 9;
            this.Bt_RemoveMember.Text = "Lid verwijderen";
            this.Bt_RemoveMember.UseVisualStyleBackColor = true;
            // 
            // Bt_ModifyMember
            // 
            this.Bt_ModifyMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_ModifyMember.Location = new System.Drawing.Point(454, 24);
            this.Bt_ModifyMember.Name = "Bt_ModifyMember";
            this.Bt_ModifyMember.Size = new System.Drawing.Size(127, 31);
            this.Bt_ModifyMember.TabIndex = 8;
            this.Bt_ModifyMember.Text = "Lid wijzigen";
            this.Bt_ModifyMember.UseVisualStyleBackColor = true;
            // 
            // Bt_AddMember
            // 
            this.Bt_AddMember.Location = new System.Drawing.Point(16, 24);
            this.Bt_AddMember.Name = "Bt_AddMember";
            this.Bt_AddMember.Size = new System.Drawing.Size(133, 31);
            this.Bt_AddMember.TabIndex = 7;
            this.Bt_AddMember.Text = "Lid toevoegen";
            this.Bt_AddMember.UseVisualStyleBackColor = true;
            // 
            // tab_Teams
            // 
            this.tab_Teams.Controls.Add(this.Datagrid_Teams);
            this.tab_Teams.Controls.Add(this.Bt_RemoveTeam);
            this.tab_Teams.Controls.Add(this.Bt_ModifyTeam);
            this.tab_Teams.Controls.Add(this.Bt_CreateTeam);
            this.tab_Teams.Location = new System.Drawing.Point(4, 25);
            this.tab_Teams.Name = "tab_Teams";
            this.tab_Teams.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Teams.Size = new System.Drawing.Size(760, 384);
            this.tab_Teams.TabIndex = 6;
            this.tab_Teams.Text = "Teams";
            this.tab_Teams.UseVisualStyleBackColor = true;
            // 
            // Datagrid_Teams
            // 
            this.Datagrid_Teams.AllowUserToResizeColumns = false;
            this.Datagrid_Teams.AllowUserToResizeRows = false;
            this.Datagrid_Teams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datagrid_Teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_Teams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Teamname_TeamsTab,
            this.TeamMembers_TeamsTab});
            this.Datagrid_Teams.Location = new System.Drawing.Point(0, 77);
            this.Datagrid_Teams.Name = "Datagrid_Teams";
            this.Datagrid_Teams.RowHeadersVisible = false;
            this.Datagrid_Teams.RowHeadersWidth = 51;
            this.Datagrid_Teams.RowTemplate.Height = 24;
            this.Datagrid_Teams.Size = new System.Drawing.Size(760, 311);
            this.Datagrid_Teams.TabIndex = 13;
            // 
            // Teamname_TeamsTab
            // 
            this.Teamname_TeamsTab.HeaderText = "Teamnaam";
            this.Teamname_TeamsTab.MinimumWidth = 6;
            this.Teamname_TeamsTab.Name = "Teamname_TeamsTab";
            this.Teamname_TeamsTab.ReadOnly = true;
            this.Teamname_TeamsTab.Width = 380;
            // 
            // TeamMembers_TeamsTab
            // 
            this.TeamMembers_TeamsTab.HeaderText = "Teamleden";
            this.TeamMembers_TeamsTab.MinimumWidth = 6;
            this.TeamMembers_TeamsTab.Name = "TeamMembers_TeamsTab";
            this.TeamMembers_TeamsTab.ReadOnly = true;
            this.TeamMembers_TeamsTab.Width = 380;
            // 
            // Bt_RemoveTeam
            // 
            this.Bt_RemoveTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_RemoveTeam.Location = new System.Drawing.Point(603, 24);
            this.Bt_RemoveTeam.Name = "Bt_RemoveTeam";
            this.Bt_RemoveTeam.Size = new System.Drawing.Size(140, 31);
            this.Bt_RemoveTeam.TabIndex = 12;
            this.Bt_RemoveTeam.Text = "Team verwijderen";
            this.Bt_RemoveTeam.UseVisualStyleBackColor = true;
            // 
            // Bt_ModifyTeam
            // 
            this.Bt_ModifyTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_ModifyTeam.Location = new System.Drawing.Point(454, 24);
            this.Bt_ModifyTeam.Name = "Bt_ModifyTeam";
            this.Bt_ModifyTeam.Size = new System.Drawing.Size(127, 31);
            this.Bt_ModifyTeam.TabIndex = 11;
            this.Bt_ModifyTeam.Text = "Team wijzigen";
            this.Bt_ModifyTeam.UseVisualStyleBackColor = true;
            // 
            // Bt_CreateTeam
            // 
            this.Bt_CreateTeam.Location = new System.Drawing.Point(16, 24);
            this.Bt_CreateTeam.Name = "Bt_CreateTeam";
            this.Bt_CreateTeam.Size = new System.Drawing.Size(133, 31);
            this.Bt_CreateTeam.TabIndex = 10;
            this.Bt_CreateTeam.Text = "Team aanmaken";
            this.Bt_CreateTeam.UseVisualStyleBackColor = true;
            // 
            // Bt_RemoveBoatFromUse
            // 
            this.Bt_RemoveBoatFromUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_RemoveBoatFromUse.Location = new System.Drawing.Point(330, 24);
            this.Bt_RemoveBoatFromUse.Name = "Bt_RemoveBoatFromUse";
            this.Bt_RemoveBoatFromUse.Size = new System.Drawing.Size(153, 31);
            this.Bt_RemoveBoatFromUse.TabIndex = 5;
            this.Bt_RemoveBoatFromUse.Text = "Boot uit vaart nemen";
            this.Bt_RemoveBoatFromUse.UseVisualStyleBackColor = true;
            this.Bt_RemoveBoatFromUse.Click += new System.EventHandler(this.Bt_RemoveBoatFromUse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
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
            this.tab_Games.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Games)).EndInit();
            this.tab_Profiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Profiles)).EndInit();
            this.tab_Members.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Members)).EndInit();
            this.tab_Teams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Teams)).EndInit();
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
        private System.Windows.Forms.Button Bt_RemoveGame;
        private System.Windows.Forms.Button Bt_AddGame;
        private System.Windows.Forms.DataGridView Datagrid_Games;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boat_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance_GameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender_GameTab;
        private System.Windows.Forms.Button Bt_RemoveProfile;
        private System.Windows.Forms.Button Bt_ModifyProfile;
        private System.Windows.Forms.Button Bt_MakeProfile;
        private System.Windows.Forms.DataGridView Datagrid_Profiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club_ProfilesTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_ProfilesTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth_ProfilesTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender_ProfilesTab;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button Bt_RemoveMember;
        private System.Windows.Forms.Button Bt_ModifyMember;
        private System.Windows.Forms.Button Bt_AddMember;
        private System.Windows.Forms.DataGridView Datagrid_Members;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_MembersTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress_MembersTab;
        private System.Windows.Forms.DataGridView Datagrid_Teams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teamname_TeamsTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamMembers_TeamsTab;
        private System.Windows.Forms.Button Bt_RemoveTeam;
        private System.Windows.Forms.Button Bt_ModifyTeam;
        private System.Windows.Forms.Button Bt_CreateTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_NewsTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title_NewsTab;
        private System.Windows.Forms.Button Bt_ReportDamage;
        private System.Windows.Forms.Button Bt_RemoveBoatFromUse;
    }
}

