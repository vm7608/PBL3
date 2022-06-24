
namespace PBL3.Views.CommonForm
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
            this.customPanel1 = new PBL3.Views.CustomComponents.CustomPanel();
            this.btn_Show = new PBL3.Views.CustomComponents.CustomButton();
            this.btn_Hide = new PBL3.Views.CustomComponents.CustomButton();
            this.passwordTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.loginBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.usernameTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel2 = new PBL3.Views.CustomComponents.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.btn_Show);
            this.customPanel1.Controls.Add(this.btn_Hide);
            this.customPanel1.Controls.Add(this.passwordTextbox);
            this.customPanel1.Controls.Add(this.loginBtn);
            this.customPanel1.Controls.Add(this.usernameTextbox);
            this.customPanel1.Controls.Add(this.signUpLinkLabel);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.Azure;
            this.customPanel1.GradientTopColor = System.Drawing.Color.Azure;
            this.customPanel1.Location = new System.Drawing.Point(75, 50);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(742, 499);
            this.customPanel1.TabIndex = 0;
            // 
            // btn_Show
            // 
            this.btn_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Show.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Show.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.btn_Show.BorderColor = System.Drawing.Color.AliceBlue;
            this.btn_Show.BorderRadius = 0;
            this.btn_Show.BorderSize = 0;
            this.btn_Show.FlatAppearance.BorderSize = 0;
            this.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.ForeColor = System.Drawing.Color.White;
            this.btn_Show.Image = global::PBL3.Properties.Resources.show;
            this.btn_Show.Location = new System.Drawing.Point(509, 225);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(42, 31);
            this.btn_Show.TabIndex = 14;
            this.btn_Show.TextColor = System.Drawing.Color.White;
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Hide.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Hide.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.btn_Hide.BorderColor = System.Drawing.Color.AliceBlue;
            this.btn_Hide.BorderRadius = 0;
            this.btn_Hide.BorderSize = 0;
            this.btn_Hide.FlatAppearance.BorderSize = 0;
            this.btn_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Hide.Image = global::PBL3.Properties.Resources.hide;
            this.btn_Hide.Location = new System.Drawing.Point(509, 225);
            this.btn_Hide.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(42, 28);
            this.btn_Hide.TabIndex = 15;
            this.btn_Hide.TextColor = System.Drawing.Color.AliceBlue;
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.passwordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.passwordTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.passwordTextbox.BorderRadius = 6;
            this.passwordTextbox.BorderSize = 2;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTextbox.Location = new System.Drawing.Point(165, 218);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.passwordTextbox.PasswordChar = true;
            this.passwordTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTextbox.PlaceholderText = "Password";
            this.passwordTextbox.Size = new System.Drawing.Size(400, 44);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.Texts = "";
            this.passwordTextbox.UnderlinedStyle = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.loginBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.loginBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginBtn.BorderRadius = 6;
            this.loginBtn.BorderSize = 0;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(165, 292);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(400, 47);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.TextColor = System.Drawing.Color.White;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.usernameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.usernameTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.usernameTextbox.BorderRadius = 6;
            this.usernameTextbox.BorderSize = 2;
            this.usernameTextbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.usernameTextbox.Location = new System.Drawing.Point(165, 154);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Multiline = false;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.usernameTextbox.PasswordChar = false;
            this.usernameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTextbox.PlaceholderText = "Username";
            this.usernameTextbox.Size = new System.Drawing.Size(400, 44);
            this.usernameTextbox.TabIndex = 1;
            this.usernameTextbox.Texts = "";
            this.usernameTextbox.UnderlinedStyle = false;
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.signUpLinkLabel.Location = new System.Drawing.Point(486, 373);
            this.signUpLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(79, 15);
            this.signUpLinkLabel.TabIndex = 12;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Đăng ký ngay";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(360, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chưa có tài khoản ?";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel2.Location = new System.Drawing.Point(0, 0);
            this.customPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(742, 68);
            this.customPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.BackgroundImage = global::PBL3.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 576);
            this.Controls.Add(this.customPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(666, 497);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private CustomComponents.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomTextBox passwordTextbox;
        private CustomComponents.CustomButton loginBtn;
        private CustomComponents.CustomTextBox usernameTextbox;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomButton btn_Hide;
        private CustomComponents.CustomButton btn_Show;
    }
}