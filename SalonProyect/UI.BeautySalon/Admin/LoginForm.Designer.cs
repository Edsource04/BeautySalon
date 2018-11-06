namespace UI.BeautySalon.Admin
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.lblErrorUsers = new System.Windows.Forms.Label();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(303, 500);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Bienvenidos A Sysflex Administrador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(124)))));
            this.panel2.Location = new System.Drawing.Point(413, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 10);
            this.panel2.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(124)))));
            this.panel1.Location = new System.Drawing.Point(413, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 10);
            this.panel1.TabIndex = 45;
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLogin.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblErrorLogin.Location = new System.Drawing.Point(442, 327);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(51, 17);
            this.lblErrorLogin.TabIndex = 44;
            this.lblErrorLogin.Text = "Login?";
            this.lblErrorLogin.Visible = false;
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblErrorPass.Location = new System.Drawing.Point(414, 293);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(112, 17);
            this.lblErrorPass.TabIndex = 43;
            this.lblErrorPass.Text = "DIGITE LA CLAVE";
            // 
            // lblErrorUsers
            // 
            this.lblErrorUsers.AutoSize = true;
            this.lblErrorUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsers.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblErrorUsers.Location = new System.Drawing.Point(410, 208);
            this.lblErrorUsers.Name = "lblErrorUsers";
            this.lblErrorUsers.Size = new System.Drawing.Size(122, 17);
            this.lblErrorUsers.TabIndex = 42;
            this.lblErrorUsers.Text = "DIGITE SU USUARIO";
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.Color.DarkGray;
            this.linkpass.Location = new System.Drawing.Point(525, 397);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(182, 17);
            this.linkpass.TabIndex = 38;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "¿Ha olvidado contraseña?";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnlogin.Location = new System.Drawing.Point(413, 347);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(408, 40);
            this.btnlogin.TabIndex = 41;
            this.btnlogin.Text = "ACCEDER";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Silver;
            this.txtpass.Location = new System.Drawing.Point(413, 244);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '■';
            this.txtpass.Size = new System.Drawing.Size(408, 37);
            this.txtpass.TabIndex = 40;
            this.txtpass.Text = "123";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(413, 168);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(408, 37);
            this.txtuser.TabIndex = 39;
            this.txtuser.Text = "PVENEIKER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(413, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "integration solution automatization services";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErrorLogin);
            this.Controls.Add(this.lblErrorPass);
            this.Controls.Add(this.lblErrorUsers);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrorLogin;
        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.Label lblErrorUsers;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
    }
}