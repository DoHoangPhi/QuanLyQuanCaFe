
namespace QuanLyCafe_FormNew.All_User_Controlls
{
    partial class TaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.doiMK = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.Img_CafeLogin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_CafeLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.doiMK);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtConfirmPassword);
            this.guna2Panel1.Controls.Add(this.txtNewPassword);
            this.guna2Panel1.Controls.Add(this.txtUsername);
            this.guna2Panel1.Controls.Add(this.Img_CafeLogin);
            this.guna2Panel1.Location = new System.Drawing.Point(75, 119);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1112, 550);
            this.guna2Panel1.TabIndex = 1;
            // 
            // doiMK
            // 
            this.doiMK.BorderRadius = 18;
            this.doiMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.doiMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.doiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.doiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.doiMK.FillColor = System.Drawing.Color.Tan;
            this.doiMK.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doiMK.ForeColor = System.Drawing.Color.White;
            this.doiMK.Location = new System.Drawing.Point(521, 468);
            this.doiMK.Name = "doiMK";
            this.doiMK.Size = new System.Drawing.Size(415, 51);
            this.doiMK.TabIndex = 7;
            this.doiMK.Text = "CẬP NHẬP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(581, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "ĐỔI MẬT KHẨU ";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 18;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtConfirmPassword.IconLeft")));
            this.txtConfirmPassword.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtConfirmPassword.Location = new System.Drawing.Point(513, 349);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtConfirmPassword.MaxLength = 20;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "Nhập lại mật khẩu ";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(412, 58);
            this.txtConfirmPassword.TabIndex = 1;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderRadius = 18;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNewPassword.IconLeft")));
            this.txtNewPassword.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtNewPassword.Location = new System.Drawing.Point(513, 253);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.PlaceholderText = "Mật khẩu mới ";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(412, 58);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 18;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsername.IconLeft")));
            this.txtUsername.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtUsername.Location = new System.Drawing.Point(513, 161);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Tên tài khoản ";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(412, 58);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Img_CafeLogin
            // 
            this.Img_CafeLogin.BackColor = System.Drawing.Color.Transparent;
            this.Img_CafeLogin.Image = ((System.Drawing.Image)(resources.GetObject("Img_CafeLogin.Image")));
            this.Img_CafeLogin.ImageRotate = 0F;
            this.Img_CafeLogin.Location = new System.Drawing.Point(54, 86);
            this.Img_CafeLogin.Name = "Img_CafeLogin";
            this.Img_CafeLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Img_CafeLogin.Size = new System.Drawing.Size(390, 400);
            this.Img_CafeLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_CafeLogin.TabIndex = 1;
            this.Img_CafeLogin.TabStop = false;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TaiKhoan";
            this.Size = new System.Drawing.Size(1262, 788);
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_CafeLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button doiMK;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Img_CafeLogin;
    }
}
