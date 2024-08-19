
namespace QuanLyCafe_FormNew.ADMIN
{
    partial class QL_TaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Tim = new Guna.UI2.WinForms.Guna2TextBox();
            this.BT_TimHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.BT_Xoa = new System.Windows.Forms.Button();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dsNV = new Guna.UI2.WinForms.Guna2Button();
            this.DSKH = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.pass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(-86, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 241);
            this.groupBox2.TabIndex = 226;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.BackColor = System.Drawing.Color.SeaShell;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.Location = new System.Drawing.Point(211, 151);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(225, 30);
            this.pass.TabIndex = 205;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(30, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 204;
            this.label4.Text = "Mật khẩu";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.SeaShell;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(207, 72);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(225, 30);
            this.txtID.TabIndex = 203;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(30, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 201;
            this.label7.Text = "Tên tài khoản";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(199, -33);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(658, 68);
            this.label11.TabIndex = 222;
            this.label11.Text = "QUẢN LÍ  TÀI KHOẢN";
            // 
            // Tim
            // 
            this.Tim.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Tim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tim.DefaultText = "";
            this.Tim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Tim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Tim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tim.Location = new System.Drawing.Point(332, 750);
            this.Tim.Name = "Tim";
            this.Tim.PasswordChar = '\0';
            this.Tim.PlaceholderText = "";
            this.Tim.SelectedText = "";
            this.Tim.Size = new System.Drawing.Size(349, 50);
            this.Tim.TabIndex = 232;
            // 
            // BT_TimHD
            // 
            this.BT_TimHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BT_TimHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BT_TimHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BT_TimHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BT_TimHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BT_TimHD.ForeColor = System.Drawing.Color.White;
            this.BT_TimHD.Location = new System.Drawing.Point(148, 750);
            this.BT_TimHD.Name = "BT_TimHD";
            this.BT_TimHD.Size = new System.Drawing.Size(167, 50);
            this.BT_TimHD.TabIndex = 231;
            this.BT_TimHD.Text = "Tìm kiếm";
            this.BT_TimHD.Click += new System.EventHandler(this.BT_TimHD_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnClear.Location = new System.Drawing.Point(187, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 46);
            this.btnClear.TabIndex = 228;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BT_Xoa
            // 
            this.BT_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_Xoa.BackColor = System.Drawing.Color.White;
            this.BT_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Xoa.FlatAppearance.BorderSize = 3;
            this.BT_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_Xoa.ForeColor = System.Drawing.Color.Red;
            this.BT_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Xoa.Location = new System.Drawing.Point(-39, 414);
            this.BT_Xoa.Name = "BT_Xoa";
            this.BT_Xoa.Size = new System.Drawing.Size(182, 46);
            this.BT_Xoa.TabIndex = 229;
            this.BT_Xoa.Text = "Xoá tài khoản ";
            this.BT_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_Xoa.UseVisualStyleBackColor = false;
            this.BT_Xoa.Click += new System.EventHandler(this.BT_Xoa_Click);
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(799, 295);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(628, 626);
            this.dataGridView.TabIndex = 227;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView.ThemeStyle.ReadOnly = false;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(693, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 45);
            this.label10.TabIndex = 223;
            this.label10.Text = "Danh sách tài khoản ";
            // 
            // dsNV
            // 
            this.dsNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dsNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dsNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dsNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dsNV.FillColor = System.Drawing.Color.RosyBrown;
            this.dsNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dsNV.ForeColor = System.Drawing.Color.White;
            this.dsNV.Location = new System.Drawing.Point(137, 644);
            this.dsNV.Name = "dsNV";
            this.dsNV.Size = new System.Drawing.Size(209, 52);
            this.dsNV.TabIndex = 234;
            this.dsNV.Text = "Danh sách nhân viên";
            this.dsNV.Click += new System.EventHandler(this.dsNV_Click);
            // 
            // DSKH
            // 
            this.DSKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DSKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DSKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DSKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DSKH.FillColor = System.Drawing.Color.RosyBrown;
            this.DSKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DSKH.ForeColor = System.Drawing.Color.White;
            this.DSKH.Location = new System.Drawing.Point(428, 644);
            this.DSKH.Name = "DSKH";
            this.DSKH.Size = new System.Drawing.Size(205, 52);
            this.DSKH.TabIndex = 235;
            this.DSKH.Text = "Danh sách khách hàng";
            this.DSKH.Click += new System.EventHandler(this.DSKH_Click);
            // 
            // QL_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DSKH);
            this.Controls.Add(this.dsNV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.BT_TimHD);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.BT_Xoa);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label10);
            this.Name = "QL_TaiKhoan";
            this.Size = new System.Drawing.Size(1543, 1050);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox Tim;
        private Guna.UI2.WinForms.Guna2Button BT_TimHD;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button BT_Xoa;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button dsNV;
        private Guna.UI2.WinForms.Guna2Button DSKH;
    }
}
