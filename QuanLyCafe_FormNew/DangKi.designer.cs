
namespace QuanLyCafe_FormNew
{
    partial class DangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_DK = new Guna.UI2.WinForms.Guna2Button();
            this.Password_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.Img_CafeLogin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_CafeLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.BT_DK);
            this.guna2Panel1.Controls.Add(this.Password_txt);
            this.guna2Panel1.Controls.Add(this.txt_TKH);
            this.guna2Panel1.Controls.Add(this.Img_CafeLogin);
            this.guna2Panel1.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel1.Location = new System.Drawing.Point(177, 270);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1228, 588);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "ĐĂNG KÍ ";
            // 
            // BT_DK
            // 
            this.BT_DK.BorderRadius = 18;
            this.BT_DK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BT_DK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BT_DK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BT_DK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BT_DK.FillColor = System.Drawing.Color.Tan;
            this.BT_DK.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DK.ForeColor = System.Drawing.Color.White;
            this.BT_DK.Location = new System.Drawing.Point(545, 385);
            this.BT_DK.Margin = new System.Windows.Forms.Padding(4);
            this.BT_DK.Name = "BT_DK";
            this.BT_DK.Size = new System.Drawing.Size(553, 63);
            this.BT_DK.TabIndex = 2;
            this.BT_DK.Text = "Đăng kí ";
            this.BT_DK.Click += new System.EventHandler(this.BT_DK_Click);
            // 
            // Password_txt
            // 
            this.Password_txt.BorderRadius = 18;
            this.Password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_txt.DefaultText = "";
            this.Password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_txt.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.ForeColor = System.Drawing.Color.Black;
            this.Password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_txt.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password_txt.IconLeft")));
            this.Password_txt.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Password_txt.Location = new System.Drawing.Point(585, 283);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Password_txt.MaxLength = 20;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '●';
            this.Password_txt.PlaceholderText = "Mật khẩu";
            this.Password_txt.SelectedText = "";
            this.Password_txt.Size = new System.Drawing.Size(484, 71);
            this.Password_txt.TabIndex = 1;
            this.Password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_txt.UseSystemPasswordChar = true;
            // 
            // txt_TKH
            // 
            this.txt_TKH.BorderRadius = 18;
            this.txt_TKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TKH.DefaultText = "";
            this.txt_TKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TKH.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TKH.ForeColor = System.Drawing.Color.Black;
            this.txt_TKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TKH.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_TKH.IconLeft")));
            this.txt_TKH.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_TKH.Location = new System.Drawing.Point(585, 167);
            this.txt_TKH.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txt_TKH.MaxLength = 20;
            this.txt_TKH.Name = "txt_TKH";
            this.txt_TKH.PasswordChar = '\0';
            this.txt_TKH.PlaceholderText = "Tên tài khoản";
            this.txt_TKH.SelectedText = "";
            this.txt_TKH.Size = new System.Drawing.Size(472, 61);
            this.txt_TKH.TabIndex = 0;
            this.txt_TKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TKH.TextChanged += new System.EventHandler(this.txt_TKH_TextChanged);
            // 
            // Img_CafeLogin
            // 
            this.Img_CafeLogin.BackColor = System.Drawing.Color.Transparent;
            this.Img_CafeLogin.Image = ((System.Drawing.Image)(resources.GetObject("Img_CafeLogin.Image")));
            this.Img_CafeLogin.ImageRotate = 0F;
            this.Img_CafeLogin.Location = new System.Drawing.Point(-18, 24);
            this.Img_CafeLogin.Margin = new System.Windows.Forms.Padding(4);
            this.Img_CafeLogin.Name = "Img_CafeLogin";
            this.Img_CafeLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Img_CafeLogin.Size = new System.Drawing.Size(520, 492);
            this.Img_CafeLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_CafeLogin.TabIndex = 1;
            this.Img_CafeLogin.TabStop = false;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.Location = new System.Drawing.Point(1409, -1);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(75, 59);
            this.guna2CircleButton1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1422, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 921);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangKi_FormClosing);
            this.Load += new System.EventHandler(this.DangKi_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_CafeLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BT_DK;
        private Guna.UI2.WinForms.Guna2TextBox Password_txt;
        private Guna.UI2.WinForms.Guna2TextBox txt_TKH;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Img_CafeLogin;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Button button1;
    }
}