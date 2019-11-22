namespace ReserveringssysteemWF
{
    partial class Form_AddBoat
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
            this.Cb_AddBoats = new System.Windows.Forms.ComboBox();
            this.Bt_Add_AddBoats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Cancel_AddBoats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cb_AddBoats
            // 
            this.Cb_AddBoats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_AddBoats.FormattingEnabled = true;
            this.Cb_AddBoats.Location = new System.Drawing.Point(111, 96);
            this.Cb_AddBoats.Name = "Cb_AddBoats";
            this.Cb_AddBoats.Size = new System.Drawing.Size(218, 24);
            this.Cb_AddBoats.TabIndex = 0;
            // 
            // Bt_Add_AddBoats
            // 
            this.Bt_Add_AddBoats.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bt_Add_AddBoats.Location = new System.Drawing.Point(111, 137);
            this.Bt_Add_AddBoats.Name = "Bt_Add_AddBoats";
            this.Bt_Add_AddBoats.Size = new System.Drawing.Size(100, 28);
            this.Bt_Add_AddBoats.TabIndex = 1;
            this.Bt_Add_AddBoats.Text = "Toevoegen";
            this.Bt_Add_AddBoats.UseVisualStyleBackColor = true;
            this.Bt_Add_AddBoats.Click += new System.EventHandler(this.Bt_Add_AddBoats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecteer boottype";
            // 
            // Bt_Cancel_AddBoats
            // 
            this.Bt_Cancel_AddBoats.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bt_Cancel_AddBoats.Location = new System.Drawing.Point(229, 137);
            this.Bt_Cancel_AddBoats.Name = "Bt_Cancel_AddBoats";
            this.Bt_Cancel_AddBoats.Size = new System.Drawing.Size(100, 28);
            this.Bt_Cancel_AddBoats.TabIndex = 3;
            this.Bt_Cancel_AddBoats.Text = "Annuleren";
            this.Bt_Cancel_AddBoats.UseVisualStyleBackColor = true;
            // 
            // Form_AddBoat
            // 
            this.AcceptButton = this.Bt_Add_AddBoats;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bt_Cancel_AddBoats;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.Bt_Cancel_AddBoats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_Add_AddBoats);
            this.Controls.Add(this.Cb_AddBoats);
            this.MaximizeBox = false;
            this.Name = "Form_AddBoat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boot toevoegen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_AddBoats;
        private System.Windows.Forms.Button Bt_Add_AddBoats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Cancel_AddBoats;
    }
}