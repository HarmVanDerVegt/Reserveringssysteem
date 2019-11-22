namespace ReserveringssysteemWF
{
    partial class Form_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Login = new System.Windows.Forms.TextBox();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.Bt_Login = new System.Windows.Forms.Button();
            this.Lb_ErrorMessageLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mailadres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wachtwoord:";
            // 
            // Tb_Login
            // 
            this.Tb_Login.Location = new System.Drawing.Point(181, 33);
            this.Tb_Login.Name = "Tb_Login";
            this.Tb_Login.Size = new System.Drawing.Size(125, 22);
            this.Tb_Login.TabIndex = 2;
            // 
            // Tb_Password
            // 
            this.Tb_Password.Location = new System.Drawing.Point(181, 77);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.PasswordChar = '*';
            this.Tb_Password.Size = new System.Drawing.Size(125, 22);
            this.Tb_Password.TabIndex = 3;
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bt_Cancel.Location = new System.Drawing.Point(181, 130);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(125, 33);
            this.Bt_Cancel.TabIndex = 5;
            this.Bt_Cancel.Text = "Annuleren";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // Bt_Login
            // 
            this.Bt_Login.Location = new System.Drawing.Point(38, 130);
            this.Bt_Login.Name = "Bt_Login";
            this.Bt_Login.Size = new System.Drawing.Size(125, 33);
            this.Bt_Login.TabIndex = 6;
            this.Bt_Login.Text = "Inloggen";
            this.Bt_Login.UseVisualStyleBackColor = true;
            this.Bt_Login.Click += new System.EventHandler(this.Bt_Login_Click);
            // 
            // Lb_ErrorMessageLogin
            // 
            this.Lb_ErrorMessageLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ErrorMessageLogin.Location = new System.Drawing.Point(-2, 177);
            this.Lb_ErrorMessageLogin.Name = "Lb_ErrorMessageLogin";
            this.Lb_ErrorMessageLogin.Size = new System.Drawing.Size(332, 17);
            this.Lb_ErrorMessageLogin.TabIndex = 7;
            this.Lb_ErrorMessageLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Login
            // 
            this.AcceptButton = this.Bt_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bt_Cancel;
            this.ClientSize = new System.Drawing.Size(332, 203);
            this.Controls.Add(this.Lb_ErrorMessageLogin);
            this.Controls.Add(this.Bt_Login);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.Tb_Password);
            this.Controls.Add(this.Tb_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Login;
        private System.Windows.Forms.TextBox Tb_Password;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.Button Bt_Login;
        private System.Windows.Forms.Label Lb_ErrorMessageLogin;
    }
}