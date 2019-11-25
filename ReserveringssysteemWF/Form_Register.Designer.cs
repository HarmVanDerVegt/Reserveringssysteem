namespace ReserveringssysteemWF
{
    partial class Form_Register
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_EmailRegister = new System.Windows.Forms.TextBox();
            this.Tb_PasswordRegister = new System.Windows.Forms.TextBox();
            this.Tb_Password2Register = new System.Windows.Forms.TextBox();
            this.Tb_StreetRegister = new System.Windows.Forms.TextBox();
            this.Tb_ZipcodeRegister = new System.Windows.Forms.TextBox();
            this.Tb_HousenumberRegister = new System.Windows.Forms.TextBox();
            this.Tb_CityRegister = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Tb_NameRegister = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tb_AnnexRegister = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tb_OrganisationRegister = new System.Windows.Forms.TextBox();
            this.Rb_MaleGender = new System.Windows.Forms.RadioButton();
            this.Rb_FemaleGender = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DTP_DateRegister = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_ErrorMessageRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Registreren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wachtwoord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Herhaling wachtwoord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Straat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Woonplaats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Huisnummer + bijvoeging";
            // 
            // Tb_EmailRegister
            // 
            this.Tb_EmailRegister.Location = new System.Drawing.Point(48, 29);
            this.Tb_EmailRegister.Name = "Tb_EmailRegister";
            this.Tb_EmailRegister.Size = new System.Drawing.Size(180, 22);
            this.Tb_EmailRegister.TabIndex = 1;
            // 
            // Tb_PasswordRegister
            // 
            this.Tb_PasswordRegister.Location = new System.Drawing.Point(48, 74);
            this.Tb_PasswordRegister.Name = "Tb_PasswordRegister";
            this.Tb_PasswordRegister.PasswordChar = '*';
            this.Tb_PasswordRegister.Size = new System.Drawing.Size(180, 22);
            this.Tb_PasswordRegister.TabIndex = 3;
            // 
            // Tb_Password2Register
            // 
            this.Tb_Password2Register.Location = new System.Drawing.Point(257, 74);
            this.Tb_Password2Register.Name = "Tb_Password2Register";
            this.Tb_Password2Register.PasswordChar = '*';
            this.Tb_Password2Register.Size = new System.Drawing.Size(180, 22);
            this.Tb_Password2Register.TabIndex = 5;
            // 
            // Tb_StreetRegister
            // 
            this.Tb_StreetRegister.Location = new System.Drawing.Point(48, 263);
            this.Tb_StreetRegister.Name = "Tb_StreetRegister";
            this.Tb_StreetRegister.Size = new System.Drawing.Size(180, 22);
            this.Tb_StreetRegister.TabIndex = 15;
            // 
            // Tb_ZipcodeRegister
            // 
            this.Tb_ZipcodeRegister.Location = new System.Drawing.Point(48, 313);
            this.Tb_ZipcodeRegister.Name = "Tb_ZipcodeRegister";
            this.Tb_ZipcodeRegister.Size = new System.Drawing.Size(180, 22);
            this.Tb_ZipcodeRegister.TabIndex = 20;
            // 
            // Tb_HuisnumberRegister
            // 
            this.Tb_HousenumberRegister.Location = new System.Drawing.Point(257, 263);
            this.Tb_HousenumberRegister.Name = "Tb_HuisnumberRegister";
            this.Tb_HousenumberRegister.Size = new System.Drawing.Size(43, 22);
            this.Tb_HousenumberRegister.TabIndex = 17;
            // 
            // Tb_CityRegister
            // 
            this.Tb_CityRegister.Location = new System.Drawing.Point(257, 313);
            this.Tb_CityRegister.Name = "Tb_CityRegister";
            this.Tb_CityRegister.Size = new System.Drawing.Size(180, 22);
            this.Tb_CityRegister.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(314, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 24;
            this.button2.Text = "Annuleren";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Geslacht";
            // 
            // Tb_NameRegister
            // 
            this.Tb_NameRegister.Location = new System.Drawing.Point(48, 122);
            this.Tb_NameRegister.Name = "Tb_NameRegister";
            this.Tb_NameRegister.Size = new System.Drawing.Size(180, 22);
            this.Tb_NameRegister.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Naam";
            // 
            // Tb_AnnexRegister
            // 
            this.Tb_AnnexRegister.Location = new System.Drawing.Point(325, 263);
            this.Tb_AnnexRegister.Name = "Tb_AnnexRegister";
            this.Tb_AnnexRegister.Size = new System.Drawing.Size(40, 22);
            this.Tb_AnnexRegister.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Organisatie";
            // 
            // Tb_OrganisationRegister
            // 
            this.Tb_OrganisationRegister.Location = new System.Drawing.Point(48, 215);
            this.Tb_OrganisationRegister.Name = "Tb_OrganisationRegister";
            this.Tb_OrganisationRegister.Size = new System.Drawing.Size(180, 22);
            this.Tb_OrganisationRegister.TabIndex = 13;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DTP_DateRegister
            // 
            this.DTP_DateRegister.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DateRegister.Location = new System.Drawing.Point(48, 170);
            this.DTP_DateRegister.Name = "DTP_DateRegister";
            this.DTP_DateRegister.Size = new System.Drawing.Size(180, 22);
            this.DTP_DateRegister.TabIndex = 11;
            this.DTP_DateRegister.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Geboortedatum";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rb_MaleGender);
            this.panel1.Controls.Add(this.Rb_FemaleGender);
            this.panel1.Location = new System.Drawing.Point(257, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 29);
            this.panel1.TabIndex = 9;
            // 
            // LB_ErrorMessageRegister
            // 
            this.LB_ErrorMessageRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LB_ErrorMessageRegister.Location = new System.Drawing.Point(0, 414);
            this.LB_ErrorMessageRegister.Name = "LB_ErrorMessageRegister";
            this.LB_ErrorMessageRegister.Size = new System.Drawing.Size(482, 39);
            this.LB_ErrorMessageRegister.TabIndex = 25;
            this.LB_ErrorMessageRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Register
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.LB_ErrorMessageRegister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DTP_DateRegister);
            this.Controls.Add(this.Tb_OrganisationRegister);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Tb_AnnexRegister);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Tb_NameRegister);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tb_CityRegister);
            this.Controls.Add(this.Tb_HousenumberRegister);
            this.Controls.Add(this.Tb_ZipcodeRegister);
            this.Controls.Add(this.Tb_StreetRegister);
            this.Controls.Add(this.Tb_Password2Register);
            this.Controls.Add(this.Tb_PasswordRegister);
            this.Controls.Add(this.Tb_EmailRegister);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Register";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_EmailRegister;
        private System.Windows.Forms.TextBox Tb_PasswordRegister;
        private System.Windows.Forms.TextBox Tb_Password2Register;
        private System.Windows.Forms.TextBox Tb_StreetRegister;
        private System.Windows.Forms.TextBox Tb_ZipcodeRegister;
        private System.Windows.Forms.TextBox Tb_HousenumberRegister;
        private System.Windows.Forms.TextBox Tb_CityRegister;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tb_NameRegister;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tb_AnnexRegister;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tb_OrganisationRegister;
        private System.Windows.Forms.RadioButton Rb_MaleGender;
        private System.Windows.Forms.RadioButton Rb_FemaleGender;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker DTP_DateRegister;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_ErrorMessageRegister;
    }
}