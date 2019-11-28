namespace ReserveringssysteemWF
{
    partial class Form_ModifyMember
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
            this.components = new System.ComponentModel.Container();
            this.LB_ErrorMessageRegister = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rb_MaleGender = new System.Windows.Forms.RadioButton();
            this.Rb_FemaleGender = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.Tb_Organisation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tb_Annex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.Tb_City = new System.Windows.Forms.TextBox();
            this.Tb_Housenumber = new System.Windows.Forms.TextBox();
            this.Tb_Zipcode = new System.Windows.Forms.TextBox();
            this.Tb_Street = new System.Windows.Forms.TextBox();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.Tb_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_ChangeMember = new System.Windows.Forms.Button();
            this.Cb_Certificates = new System.Windows.Forms.ComboBox();
            this.Bt_addCertificate = new System.Windows.Forms.Button();
            this.Bt_AddRoles = new System.Windows.Forms.Button();
            this.Cb_Roles = new System.Windows.Forms.ComboBox();
            this.Bt_RemoveRole = new System.Windows.Forms.Button();
            this.Bt_RemoveCertificate = new System.Windows.Forms.Button();
            this.Lb_Roles = new System.Windows.Forms.ListBox();
            this.Lb_Certificaat = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ErrorMessageRegister
            // 
            this.LB_ErrorMessageRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LB_ErrorMessageRegister.Location = new System.Drawing.Point(0, 411);
            this.LB_ErrorMessageRegister.Name = "LB_ErrorMessageRegister";
            this.LB_ErrorMessageRegister.Size = new System.Drawing.Size(800, 39);
            this.LB_ErrorMessageRegister.TabIndex = 51;
            this.LB_ErrorMessageRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rb_MaleGender);
            this.panel1.Controls.Add(this.Rb_FemaleGender);
            this.panel1.Location = new System.Drawing.Point(257, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 29);
            this.panel1.TabIndex = 35;
            // 
            // Rb_MaleGender
            // 
            this.Rb_MaleGender.AutoSize = true;
            this.Rb_MaleGender.Checked = true;
            this.Rb_MaleGender.Location = new System.Drawing.Point(6, 3);
            this.Rb_MaleGender.Name = "Rb_MaleGender";
            this.Rb_MaleGender.Size = new System.Drawing.Size(56, 21);
            this.Rb_MaleGender.TabIndex = 9;
            this.Rb_MaleGender.TabStop = true;
            this.Rb_MaleGender.Text = "Man";
            this.Rb_MaleGender.UseVisualStyleBackColor = true;
            // 
            // Rb_FemaleGender
            // 
            this.Rb_FemaleGender.AutoSize = true;
            this.Rb_FemaleGender.Location = new System.Drawing.Point(76, 3);
            this.Rb_FemaleGender.Name = "Rb_FemaleGender";
            this.Rb_FemaleGender.Size = new System.Drawing.Size(68, 21);
            this.Rb_FemaleGender.TabIndex = 10;
            this.Rb_FemaleGender.Text = "Vrouw";
            this.Rb_FemaleGender.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Geboortedatum";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Date.Location = new System.Drawing.Point(48, 166);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(180, 22);
            this.DTP_Date.TabIndex = 37;
            this.DTP_Date.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Tb_Organisation
            // 
            this.Tb_Organisation.Location = new System.Drawing.Point(48, 211);
            this.Tb_Organisation.Name = "Tb_Organisation";
            this.Tb_Organisation.Size = new System.Drawing.Size(180, 22);
            this.Tb_Organisation.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Organisatie";
            // 
            // Tb_Annex
            // 
            this.Tb_Annex.Location = new System.Drawing.Point(325, 259);
            this.Tb_Annex.Name = "Tb_Annex";
            this.Tb_Annex.Size = new System.Drawing.Size(40, 22);
            this.Tb_Annex.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Naam";
            // 
            // Tb_Name
            // 
            this.Tb_Name.Location = new System.Drawing.Point(48, 118);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(180, 22);
            this.Tb_Name.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Geslacht";
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bt_Cancel.Location = new System.Drawing.Point(257, 350);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(132, 40);
            this.Bt_Cancel.TabIndex = 50;
            this.Bt_Cancel.Text = "Annuleren";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // Tb_City
            // 
            this.Tb_City.Location = new System.Drawing.Point(257, 309);
            this.Tb_City.Name = "Tb_City";
            this.Tb_City.Size = new System.Drawing.Size(180, 22);
            this.Tb_City.TabIndex = 48;
            // 
            // Tb_Housenumber
            // 
            this.Tb_Housenumber.Location = new System.Drawing.Point(257, 259);
            this.Tb_Housenumber.Name = "Tb_Housenumber";
            this.Tb_Housenumber.Size = new System.Drawing.Size(43, 22);
            this.Tb_Housenumber.TabIndex = 43;
            // 
            // Tb_Zipcode
            // 
            this.Tb_Zipcode.Location = new System.Drawing.Point(48, 309);
            this.Tb_Zipcode.Name = "Tb_Zipcode";
            this.Tb_Zipcode.Size = new System.Drawing.Size(180, 22);
            this.Tb_Zipcode.TabIndex = 46;
            // 
            // Tb_Street
            // 
            this.Tb_Street.Location = new System.Drawing.Point(48, 259);
            this.Tb_Street.Name = "Tb_Street";
            this.Tb_Street.Size = new System.Drawing.Size(180, 22);
            this.Tb_Street.TabIndex = 41;
            // 
            // Tb_Password
            // 
            this.Tb_Password.Location = new System.Drawing.Point(48, 70);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.PasswordChar = '*';
            this.Tb_Password.Size = new System.Drawing.Size(180, 22);
            this.Tb_Password.TabIndex = 29;
            // 
            // Tb_Email
            // 
            this.Tb_Email.Location = new System.Drawing.Point(48, 25);
            this.Tb_Email.Name = "Tb_Email";
            this.Tb_Email.Size = new System.Drawing.Size(180, 22);
            this.Tb_Email.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Huisnummer + bijvoeging";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Woonplaats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Postcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Straat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Wachtwoord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Email";
            // 
            // Bt_ChangeMember
            // 
            this.Bt_ChangeMember.Location = new System.Drawing.Point(48, 350);
            this.Bt_ChangeMember.Name = "Bt_ChangeMember";
            this.Bt_ChangeMember.Size = new System.Drawing.Size(132, 40);
            this.Bt_ChangeMember.TabIndex = 49;
            this.Bt_ChangeMember.Text = "Wijzigen";
            this.Bt_ChangeMember.UseVisualStyleBackColor = true;
            this.Bt_ChangeMember.Click += new System.EventHandler(this.Bt_ChangeMember_Click);
            // 
            // Cb_Certificates
            // 
            this.Cb_Certificates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Certificates.FormattingEnabled = true;
            this.Cb_Certificates.Location = new System.Drawing.Point(503, 116);
            this.Cb_Certificates.Name = "Cb_Certificates";
            this.Cb_Certificates.Size = new System.Drawing.Size(270, 24);
            this.Cb_Certificates.TabIndex = 52;
            // 
            // Bt_addCertificate
            // 
            this.Bt_addCertificate.Location = new System.Drawing.Point(503, 152);
            this.Bt_addCertificate.Name = "Bt_addCertificate";
            this.Bt_addCertificate.Size = new System.Drawing.Size(132, 40);
            this.Bt_addCertificate.TabIndex = 53;
            this.Bt_addCertificate.Text = "Toevoegen ";
            this.Bt_addCertificate.UseVisualStyleBackColor = true;
            this.Bt_addCertificate.Click += new System.EventHandler(this.Bt_addCertificate_Click);
            // 
            // Bt_AddRoles
            // 
            this.Bt_AddRoles.Location = new System.Drawing.Point(503, 346);
            this.Bt_AddRoles.Name = "Bt_AddRoles";
            this.Bt_AddRoles.Size = new System.Drawing.Size(132, 40);
            this.Bt_AddRoles.TabIndex = 54;
            this.Bt_AddRoles.Text = "Toevoegen ";
            this.Bt_AddRoles.UseVisualStyleBackColor = true;
            this.Bt_AddRoles.Click += new System.EventHandler(this.Bt_AddRoles_Click);
            // 
            // Cb_Roles
            // 
            this.Cb_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Roles.FormattingEnabled = true;
            this.Cb_Roles.Location = new System.Drawing.Point(503, 305);
            this.Cb_Roles.Name = "Cb_Roles";
            this.Cb_Roles.Size = new System.Drawing.Size(270, 24);
            this.Cb_Roles.TabIndex = 55;
            // 
            // Bt_RemoveRole
            // 
            this.Bt_RemoveRole.Location = new System.Drawing.Point(641, 346);
            this.Bt_RemoveRole.Name = "Bt_RemoveRole";
            this.Bt_RemoveRole.Size = new System.Drawing.Size(132, 40);
            this.Bt_RemoveRole.TabIndex = 56;
            this.Bt_RemoveRole.Text = "Verwijderen";
            this.Bt_RemoveRole.UseVisualStyleBackColor = true;
            // 
            // Bt_RemoveCertificate
            // 
            this.Bt_RemoveCertificate.Location = new System.Drawing.Point(641, 152);
            this.Bt_RemoveCertificate.Name = "Bt_RemoveCertificate";
            this.Bt_RemoveCertificate.Size = new System.Drawing.Size(132, 40);
            this.Bt_RemoveCertificate.TabIndex = 57;
            this.Bt_RemoveCertificate.Text = "Verwijderen";
            this.Bt_RemoveCertificate.UseVisualStyleBackColor = true;
            // 
            // Lb_Roles
            // 
            this.Lb_Roles.FormattingEnabled = true;
            this.Lb_Roles.ItemHeight = 16;
            this.Lb_Roles.Location = new System.Drawing.Point(503, 223);
            this.Lb_Roles.Name = "Lb_Roles";
            this.Lb_Roles.Size = new System.Drawing.Size(270, 68);
            this.Lb_Roles.TabIndex = 58;
            // 
            // Lb_Certificaat
            // 
            this.Lb_Certificaat.FormattingEnabled = true;
            this.Lb_Certificaat.ItemHeight = 16;
            this.Lb_Certificaat.Location = new System.Drawing.Point(503, 37);
            this.Lb_Certificaat.Name = "Lb_Certificaat";
            this.Lb_Certificaat.Size = new System.Drawing.Size(270, 68);
            this.Lb_Certificaat.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Certificaat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(503, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 61;
            this.label12.Text = "Rollen";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_ModifyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bt_Cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lb_Certificaat);
            this.Controls.Add(this.Lb_Roles);
            this.Controls.Add(this.Bt_RemoveCertificate);
            this.Controls.Add(this.Bt_RemoveRole);
            this.Controls.Add(this.Cb_Roles);
            this.Controls.Add(this.Bt_AddRoles);
            this.Controls.Add(this.Bt_addCertificate);
            this.Controls.Add(this.Cb_Certificates);
            this.Controls.Add(this.LB_ErrorMessageRegister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.Tb_Organisation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Tb_Annex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Tb_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.Tb_City);
            this.Controls.Add(this.Tb_Housenumber);
            this.Controls.Add(this.Tb_Zipcode);
            this.Controls.Add(this.Tb_Street);
            this.Controls.Add(this.Tb_Password);
            this.Controls.Add(this.Tb_Email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_ChangeMember);
            this.Name = "Form_ModifyMember";
            this.Text = "Wijzigen lid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ErrorMessageRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rb_MaleGender;
        private System.Windows.Forms.RadioButton Rb_FemaleGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.TextBox Tb_Organisation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tb_Annex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.TextBox Tb_City;
        private System.Windows.Forms.TextBox Tb_Housenumber;
        private System.Windows.Forms.TextBox Tb_Zipcode;
        private System.Windows.Forms.TextBox Tb_Street;
        private System.Windows.Forms.TextBox Tb_Password;
        private System.Windows.Forms.TextBox Tb_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_ChangeMember;
        private System.Windows.Forms.ComboBox Cb_Certificates;
        private System.Windows.Forms.Button Bt_addCertificate;
        private System.Windows.Forms.Button Bt_AddRoles;
        private System.Windows.Forms.ComboBox Cb_Roles;
        private System.Windows.Forms.Button Bt_RemoveRole;
        private System.Windows.Forms.Button Bt_RemoveCertificate;
        private System.Windows.Forms.ListBox Lb_Roles;
        private System.Windows.Forms.ListBox Lb_Certificaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}