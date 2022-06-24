
namespace PBL3.Views.CustomerForm
{
    partial class InformationUpdateForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_Ward = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_District = new PBL3.Views.CustomComponents.CustomComboBox();
            this.txt_DetailAddress = new PBL3.Views.CustomComponents.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new PBL3.Views.CustomComponents.CustomButton();
            this.btnSave = new PBL3.Views.CustomComponents.CustomButton();
            this.txt_Mail = new PBL3.Views.CustomComponents.CustomTextBox();
            this.txt_Phone = new PBL3.Views.CustomComponents.CustomTextBox();
            this.txt_Fullname = new PBL3.Views.CustomComponents.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.Controls.Add(this.cbb_Ward);
            this.customPanel1.Controls.Add(this.cbb_District);
            this.customPanel1.Controls.Add(this.txt_DetailAddress);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.btnCancel);
            this.customPanel1.Controls.Add(this.btnSave);
            this.customPanel1.Controls.Add(this.txt_Mail);
            this.customPanel1.Controls.Add(this.txt_Phone);
            this.customPanel1.Controls.Add(this.txt_Fullname);
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.Azure;
            this.customPanel1.GradientTopColor = System.Drawing.Color.Azure;
            this.customPanel1.Location = new System.Drawing.Point(75, 35);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(796, 538);
            this.customPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "Địa chỉ:";
            // 
            // cbb_Ward
            // 
            this.cbb_Ward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_Ward.BackColor = System.Drawing.Color.AliceBlue;
            this.cbb_Ward.BorderColor = System.Drawing.Color.Green;
            this.cbb_Ward.BorderSize = 3;
            this.cbb_Ward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Ward.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ward.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_Ward.IconColor = System.Drawing.Color.Green;
            this.cbb_Ward.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_Ward.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_Ward.Location = new System.Drawing.Point(520, 284);
            this.cbb_Ward.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Ward.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbb_Ward.Name = "cbb_Ward";
            this.cbb_Ward.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_Ward.Size = new System.Drawing.Size(236, 33);
            this.cbb_Ward.TabIndex = 26;
            this.cbb_Ward.Texts = "Phường";
            // 
            // cbb_District
            // 
            this.cbb_District.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_District.BackColor = System.Drawing.Color.AliceBlue;
            this.cbb_District.BorderColor = System.Drawing.Color.Green;
            this.cbb_District.BorderSize = 3;
            this.cbb_District.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_District.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_District.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_District.IconColor = System.Drawing.Color.Green;
            this.cbb_District.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_District.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_District.Location = new System.Drawing.Point(199, 284);
            this.cbb_District.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_District.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbb_District.Name = "cbb_District";
            this.cbb_District.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_District.Size = new System.Drawing.Size(236, 33);
            this.cbb_District.TabIndex = 25;
            this.cbb_District.Texts = "Quận";
            this.cbb_District.OnSelectionChangedCommited += new System.EventHandler(this.cbb_District_OnSelectionChangedCommited);
            // 
            // txt_DetailAddress
            // 
            this.txt_DetailAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DetailAddress.AutoSize = true;
            this.txt_DetailAddress.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_DetailAddress.BorderColor = System.Drawing.Color.Green;
            this.txt_DetailAddress.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txt_DetailAddress.BorderRadius = 6;
            this.txt_DetailAddress.BorderSize = 2;
            this.txt_DetailAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DetailAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txt_DetailAddress.Location = new System.Drawing.Point(46, 345);
            this.txt_DetailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DetailAddress.Multiline = true;
            this.txt_DetailAddress.Name = "txt_DetailAddress";
            this.txt_DetailAddress.Padding = new System.Windows.Forms.Padding(30, 7, 10, 7);
            this.txt_DetailAddress.PasswordChar = false;
            this.txt_DetailAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DetailAddress.PlaceholderText = "Địa chỉ cụ thể";
            this.txt_DetailAddress.Size = new System.Drawing.Size(710, 109);
            this.txt_DetailAddress.TabIndex = 24;
            this.txt_DetailAddress.Texts = "";
            this.txt_DetailAddress.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(642, 476);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 35);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.BackgroundColor = System.Drawing.Color.Green;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(507, 476);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt_Mail
            // 
            this.txt_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Mail.BackColor = System.Drawing.Color.Azure;
            this.txt_Mail.BorderColor = System.Drawing.Color.Green;
            this.txt_Mail.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txt_Mail.BorderRadius = 6;
            this.txt_Mail.BorderSize = 2;
            this.txt_Mail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mail.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Mail.Location = new System.Drawing.Point(199, 215);
            this.txt_Mail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Mail.Multiline = false;
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.txt_Mail.PasswordChar = false;
            this.txt_Mail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Mail.PlaceholderText = "Nhập email";
            this.txt_Mail.Size = new System.Drawing.Size(557, 37);
            this.txt_Mail.TabIndex = 18;
            this.txt_Mail.Texts = "";
            this.txt_Mail.UnderlinedStyle = false;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Phone.BackColor = System.Drawing.Color.Azure;
            this.txt_Phone.BorderColor = System.Drawing.Color.Green;
            this.txt_Phone.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txt_Phone.BorderRadius = 6;
            this.txt_Phone.BorderSize = 2;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Phone.Location = new System.Drawing.Point(199, 147);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Phone.Multiline = false;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.txt_Phone.PasswordChar = false;
            this.txt_Phone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Phone.PlaceholderText = "Nhập số điện thoại";
            this.txt_Phone.Size = new System.Drawing.Size(557, 37);
            this.txt_Phone.TabIndex = 17;
            this.txt_Phone.Texts = "";
            this.txt_Phone.UnderlinedStyle = false;
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Fullname.BackColor = System.Drawing.Color.Azure;
            this.txt_Fullname.BorderColor = System.Drawing.Color.Green;
            this.txt_Fullname.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txt_Fullname.BorderRadius = 6;
            this.txt_Fullname.BorderSize = 2;
            this.txt_Fullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fullname.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Fullname.Location = new System.Drawing.Point(199, 80);
            this.txt_Fullname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Fullname.Multiline = false;
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.txt_Fullname.PasswordChar = false;
            this.txt_Fullname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Fullname.PlaceholderText = "Nhập họ và tên";
            this.txt_Fullname.Size = new System.Drawing.Size(557, 37);
            this.txt_Fullname.TabIndex = 15;
            this.txt_Fullname.Texts = "";
            this.txt_Fullname.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ và tên:";
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel2.Location = new System.Drawing.Point(0, 0);
            this.customPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(796, 49);
            this.customPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(-13, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(821, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN CÁ NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 602);
            this.Controls.Add(this.customPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InformationUpdateForm";
            this.Text = "InformationUpdateForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private CustomComponents.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomButton btnCancel;
        private CustomComponents.CustomButton btnSave;
        private CustomComponents.CustomTextBox txt_Mail;
        private CustomComponents.CustomTextBox txt_Phone;
        private CustomComponents.CustomTextBox txt_Fullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomComboBox cbb_Ward;
        private CustomComponents.CustomComboBox cbb_District;
        private CustomComponents.CustomTextBox txt_DetailAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}