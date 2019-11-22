namespace ReserveringssysteemWF
{
    partial class Form_ReportDamage
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
            this.Bt_ReportDamagedBoat = new System.Windows.Forms.Button();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.Lb_ReservationBoats = new System.Windows.Forms.Label();
            this.Datagrid_ReportDamage = new System.Windows.Forms.DataGridView();
            this.Date_ReportDamageDialog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boat_ReportDamageDialog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_ReportDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_ReportDamagedBoat
            // 
            this.Bt_ReportDamagedBoat.Location = new System.Drawing.Point(33, 385);
            this.Bt_ReportDamagedBoat.Name = "Bt_ReportDamagedBoat";
            this.Bt_ReportDamagedBoat.Size = new System.Drawing.Size(147, 35);
            this.Bt_ReportDamagedBoat.TabIndex = 0;
            this.Bt_ReportDamagedBoat.Text = "Melden schade";
            this.Bt_ReportDamagedBoat.UseVisualStyleBackColor = true;
            this.Bt_ReportDamagedBoat.Click += new System.EventHandler(this.Bt_ReportDamagedBoat_Click);
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bt_Cancel.Location = new System.Drawing.Point(244, 385);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(147, 35);
            this.Bt_Cancel.TabIndex = 1;
            this.Bt_Cancel.Text = "Annuleren";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // Lb_ReservationBoats
            // 
            this.Lb_ReservationBoats.AutoSize = true;
            this.Lb_ReservationBoats.Location = new System.Drawing.Point(13, 13);
            this.Lb_ReservationBoats.Name = "Lb_ReservationBoats";
            this.Lb_ReservationBoats.Size = new System.Drawing.Size(292, 17);
            this.Lb_ReservationBoats.TabIndex = 2;
            this.Lb_ReservationBoats.Text = "Selecteer uw boot om te melden voor schade";
            // 
            // Datagrid_ReportDamage
            // 
            this.Datagrid_ReportDamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_ReportDamage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_ReportDamageDialog,
            this.Boat_ReportDamageDialog});
            this.Datagrid_ReportDamage.Location = new System.Drawing.Point(13, 34);
            this.Datagrid_ReportDamage.Name = "Datagrid_ReportDamage";
            this.Datagrid_ReportDamage.RowHeadersVisible = false;
            this.Datagrid_ReportDamage.RowHeadersWidth = 51;
            this.Datagrid_ReportDamage.RowTemplate.Height = 24;
            this.Datagrid_ReportDamage.Size = new System.Drawing.Size(407, 335);
            this.Datagrid_ReportDamage.TabIndex = 3;
            // 
            // Date_ReportDamageDialog
            // 
            this.Date_ReportDamageDialog.HeaderText = "Datum reservering";
            this.Date_ReportDamageDialog.MinimumWidth = 6;
            this.Date_ReportDamageDialog.Name = "Date_ReportDamageDialog";
            this.Date_ReportDamageDialog.ReadOnly = true;
            this.Date_ReportDamageDialog.Width = 202;
            // 
            // Boat_ReportDamageDialog
            // 
            this.Boat_ReportDamageDialog.HeaderText = "Boot";
            this.Boat_ReportDamageDialog.MinimumWidth = 6;
            this.Boat_ReportDamageDialog.Name = "Boat_ReportDamageDialog";
            this.Boat_ReportDamageDialog.ReadOnly = true;
            this.Boat_ReportDamageDialog.Width = 202;
            // 
            // Form_ReportDamage
            // 
            this.AcceptButton = this.Bt_ReportDamagedBoat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bt_Cancel;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.Datagrid_ReportDamage);
            this.Controls.Add(this.Lb_ReservationBoats);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.Bt_ReportDamagedBoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_ReportDamage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ReportDamage";
            this.Load += new System.EventHandler(this.Form_ReportDamage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_ReportDamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_ReportDamagedBoat;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.Label Lb_ReservationBoats;
        private System.Windows.Forms.DataGridView Datagrid_ReportDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_ReportDamageDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boat_ReportDamageDialog;
    }
}