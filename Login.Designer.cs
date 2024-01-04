
namespace HeThongQLDVGiaoHangNhanh
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnEyePass = new Guna.UI2.WinForms.Guna2Button();
            this.btnEyeClosePass = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnKhach = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEyePass
            // 
            this.btnEyePass.BackColor = System.Drawing.Color.Transparent;
            this.btnEyePass.FillColor = System.Drawing.Color.White;
            this.btnEyePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEyePass.ForeColor = System.Drawing.Color.White;
            this.btnEyePass.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.eye_close;
            this.btnEyePass.Location = new System.Drawing.Point(418, 71);
            this.btnEyePass.Name = "btnEyePass";
            this.btnEyePass.Size = new System.Drawing.Size(34, 34);
            this.btnEyePass.TabIndex = 2;
            this.btnEyePass.Click += new System.EventHandler(this.btnEyePass_Click);
            // 
            // btnEyeClosePass
            // 
            this.btnEyeClosePass.BackColor = System.Drawing.Color.Transparent;
            this.btnEyeClosePass.FillColor = System.Drawing.Color.White;
            this.btnEyeClosePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEyeClosePass.ForeColor = System.Drawing.Color.White;
            this.btnEyeClosePass.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.eye;
            this.btnEyeClosePass.Location = new System.Drawing.Point(418, 71);
            this.btnEyeClosePass.Name = "btnEyeClosePass";
            this.btnEyeClosePass.Size = new System.Drawing.Size(34, 30);
            this.btnEyeClosePass.TabIndex = 2;
            this.btnEyeClosePass.Click += new System.EventHandler(this.btnEyeClosePass_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.BorderRadius = 3;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.FillColor2 = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(537, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnKhach
            // 
            this.btnKhach.BorderRadius = 10;
            this.btnKhach.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKhach.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnKhach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhach.ForeColor = System.Drawing.Color.White;
            this.btnKhach.Location = new System.Drawing.Point(413, 292);
            this.btnKhach.Name = "btnKhach";
            this.btnKhach.Size = new System.Drawing.Size(156, 44);
            this.btnKhach.TabIndex = 3;
            this.btnKhach.Text = "K.Hàng";
            this.btnKhach.Click += new System.EventHandler(this.btnKhach_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(251, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 44);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this;
            this.DragControl.UseTransparentDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 54);
            this.panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(13, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Đăng Nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(13, 4);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Tài khoản";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(449, 48);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(12, 62);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(12, 16, 12, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(449, 48);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pnlLogin
            // 
            this.pnlLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.btnEyePass);
            this.pnlLogin.Controls.Add(this.btnEyeClosePass);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Location = new System.Drawing.Point(68, 103);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(464, 114);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(581, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnKhach);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập giao hàng nhanh";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btnKhach;
        private Guna.UI2.WinForms.Guna2Button btnEyePass;
        private Guna.UI2.WinForms.Guna2Button btnEyeClosePass;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
    }
}