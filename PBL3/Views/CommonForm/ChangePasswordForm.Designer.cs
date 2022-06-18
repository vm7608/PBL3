
namespace PBL3.Views.CommonForm
{
    partial class ChangePasswordForm
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
            this.btn_Cancel = new PBL3.Views.CustomComponents.CustomButton();
            this.saveBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.oldPassTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.confirmNewPassField = new PBL3.Views.CustomComponents.CustomTextBox();
            this.newPassTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
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
            this.customPanel1.BorderRadius = 50;
            this.customPanel1.Controls.Add(this.btn_Cancel);
            this.customPanel1.Controls.Add(this.saveBtn);
            this.customPanel1.Controls.Add(this.oldPassTextbox);
            this.customPanel1.Controls.Add(this.confirmNewPassField);
            this.customPanel1.Controls.Add(this.newPassTextbox);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.Azure;
            this.customPanel1.GradientTopColor = System.Drawing.Color.Azure;
            this.customPanel1.Location = new System.Drawing.Point(126, 42);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(690, 405);
            this.customPanel1.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Cancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.btn_Cancel.BorderRadius = 10;
            this.btn_Cancel.BorderSize = 0;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Cancel.Location = new System.Drawing.Point(452, 330);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(126, 41);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.TextColor = System.Drawing.SystemColors.Window;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.BackgroundColor = System.Drawing.Color.Green;
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.saveBtn.Location = new System.Drawing.Point(293, 330);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(126, 41);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.TextColor = System.Drawing.SystemColors.Window;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // oldPassTextbox
            // 
            this.oldPassTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldPassTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.oldPassTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.oldPassTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.oldPassTextbox.BorderRadius = 10;
            this.oldPassTextbox.BorderSize = 2;
            this.oldPassTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.oldPassTextbox.Location = new System.Drawing.Point(119, 106);
            this.oldPassTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.oldPassTextbox.Multiline = false;
            this.oldPassTextbox.Name = "oldPassTextbox";
            this.oldPassTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.oldPassTextbox.PasswordChar = true;
            this.oldPassTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.oldPassTextbox.PlaceholderText = "Nhập mật khẩu cũ";
            this.oldPassTextbox.Size = new System.Drawing.Size(459, 37);
            this.oldPassTextbox.TabIndex = 9;
            this.oldPassTextbox.Texts = "";
            this.oldPassTextbox.UnderlinedStyle = false;
            // 
            // confirmNewPassField
            // 
            this.confirmNewPassField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmNewPassField.BackColor = System.Drawing.Color.AliceBlue;
            this.confirmNewPassField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.confirmNewPassField.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.confirmNewPassField.BorderRadius = 10;
            this.confirmNewPassField.BorderSize = 2;
            this.confirmNewPassField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPassField.ForeColor = System.Drawing.Color.DimGray;
            this.confirmNewPassField.Location = new System.Drawing.Point(119, 251);
            this.confirmNewPassField.Margin = new System.Windows.Forms.Padding(4);
            this.confirmNewPassField.Multiline = false;
            this.confirmNewPassField.Name = "confirmNewPassField";
            this.confirmNewPassField.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.confirmNewPassField.PasswordChar = true;
            this.confirmNewPassField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.confirmNewPassField.PlaceholderText = "Xác nhận mật khẩu mới";
            this.confirmNewPassField.Size = new System.Drawing.Size(459, 37);
            this.confirmNewPassField.TabIndex = 11;
            this.confirmNewPassField.Texts = "";
            this.confirmNewPassField.UnderlinedStyle = false;
            // 
            // newPassTextbox
            // 
            this.newPassTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPassTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.newPassTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.newPassTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.newPassTextbox.BorderRadius = 10;
            this.newPassTextbox.BorderSize = 2;
            this.newPassTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.newPassTextbox.Location = new System.Drawing.Point(119, 179);
            this.newPassTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.newPassTextbox.Multiline = false;
            this.newPassTextbox.Name = "newPassTextbox";
            this.newPassTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.newPassTextbox.PasswordChar = true;
            this.newPassTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.newPassTextbox.PlaceholderText = "Nhập mật khẩu mới";
            this.newPassTextbox.Size = new System.Drawing.Size(459, 37);
            this.newPassTextbox.TabIndex = 10;
            this.newPassTextbox.Texts = "";
            this.newPassTextbox.UnderlinedStyle = false;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel2.Location = new System.Drawing.Point(-47, 0);
            this.customPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(784, 68);
            this.customPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(-8, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 504);
            this.Controls.Add(this.customPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private CustomComponents.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomButton saveBtn;
        private CustomComponents.CustomTextBox oldPassTextbox;
        private CustomComponents.CustomTextBox confirmNewPassField;
        private CustomComponents.CustomTextBox newPassTextbox;
        private CustomComponents.CustomButton btn_Cancel;
    }
}