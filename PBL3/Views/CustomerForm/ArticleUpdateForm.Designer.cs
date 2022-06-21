
namespace PBL3.Views.CustomerForm
{
    partial class ArticleUpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Ward = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_District = new PBL3.Views.CustomComponents.CustomComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DetailAddressTextBox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.diaChiGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_NotRented = new System.Windows.Forms.RadioButton();
            this.radioButton_Rented = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.descTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.discardBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.updateBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeImgBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.areaTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.priceTextBox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.titleTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.diaChiGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, -122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đăng bài";
            // 
            // cbb_Ward
            // 
            this.cbb_Ward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_Ward.BackColor = System.Drawing.Color.White;
            this.cbb_Ward.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbb_Ward.BorderSize = 3;
            this.cbb_Ward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Ward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_Ward.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_Ward.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbb_Ward.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_Ward.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_Ward.Location = new System.Drawing.Point(803, 56);
            this.cbb_Ward.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Ward.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbb_Ward.Name = "cbb_Ward";
            this.cbb_Ward.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_Ward.Size = new System.Drawing.Size(236, 33);
            this.cbb_Ward.TabIndex = 5;
            this.cbb_Ward.Texts = "";
            // 
            // cbb_District
            // 
            this.cbb_District.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_District.BackColor = System.Drawing.Color.White;
            this.cbb_District.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbb_District.BorderSize = 3;
            this.cbb_District.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_District.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_District.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_District.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbb_District.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_District.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_District.Location = new System.Drawing.Point(291, 56);
            this.cbb_District.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_District.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbb_District.Name = "cbb_District";
            this.cbb_District.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_District.Size = new System.Drawing.Size(270, 33);
            this.cbb_District.TabIndex = 4;
            this.cbb_District.Texts = "";
            this.cbb_District.OnSelectionChangedCommited += new System.EventHandler(this.cbb_District_OnSelectionChangedCommited);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ cụ thể";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(649, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phường/Xã : ";
            // 
            // DetailAddressTextBox
            // 
            this.DetailAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailAddressTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DetailAddressTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.DetailAddressTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.DetailAddressTextBox.BorderRadius = 10;
            this.DetailAddressTextBox.BorderSize = 2;
            this.DetailAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailAddressTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.DetailAddressTextBox.Location = new System.Drawing.Point(291, 124);
            this.DetailAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DetailAddressTextBox.Multiline = true;
            this.DetailAddressTextBox.Name = "DetailAddressTextBox";
            this.DetailAddressTextBox.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.DetailAddressTextBox.PasswordChar = false;
            this.DetailAddressTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.DetailAddressTextBox.PlaceholderText = "";
            this.DetailAddressTextBox.Size = new System.Drawing.Size(748, 33);
            this.DetailAddressTextBox.TabIndex = 7;
            this.DetailAddressTextBox.Texts = "";
            this.DetailAddressTextBox.UnderlinedStyle = false;
            // 
            // diaChiGroupBox
            // 
            this.diaChiGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diaChiGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.diaChiGroupBox.Controls.Add(this.DetailAddressTextBox);
            this.diaChiGroupBox.Controls.Add(this.cbb_Ward);
            this.diaChiGroupBox.Controls.Add(this.cbb_District);
            this.diaChiGroupBox.Controls.Add(this.label5);
            this.diaChiGroupBox.Controls.Add(this.label4);
            this.diaChiGroupBox.Controls.Add(this.label2);
            this.diaChiGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiGroupBox.Location = new System.Drawing.Point(18, 71);
            this.diaChiGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.diaChiGroupBox.Name = "diaChiGroupBox";
            this.diaChiGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.diaChiGroupBox.Size = new System.Drawing.Size(1123, 214);
            this.diaChiGroupBox.TabIndex = 9;
            this.diaChiGroupBox.TabStop = false;
            this.diaChiGroupBox.Text = "Địa chỉ phòng trọ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quận/Huyện :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1123, 49);
            this.label3.TabIndex = 12;
            this.label3.Text = "CẬP NHẬT BÀI ĐĂNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.groupBox1.Controls.Add(this.radioButton_NotRented);
            this.groupBox1.Controls.Add(this.radioButton_Rented);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.descTextbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.discardBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.areaTextbox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.titleTextbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 300);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1123, 744);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mô tả";
            // 
            // radioButton_NotRented
            // 
            this.radioButton_NotRented.AutoSize = true;
            this.radioButton_NotRented.Location = new System.Drawing.Point(538, 363);
            this.radioButton_NotRented.Name = "radioButton_NotRented";
            this.radioButton_NotRented.Size = new System.Drawing.Size(166, 32);
            this.radioButton_NotRented.TabIndex = 17;
            this.radioButton_NotRented.TabStop = true;
            this.radioButton_NotRented.Text = "Chưa cho thuê";
            this.radioButton_NotRented.UseVisualStyleBackColor = true;
            // 
            // radioButton_Rented
            // 
            this.radioButton_Rented.AutoSize = true;
            this.radioButton_Rented.Location = new System.Drawing.Point(291, 363);
            this.radioButton_Rented.Name = "radioButton_Rented";
            this.radioButton_Rented.Size = new System.Drawing.Size(144, 32);
            this.radioButton_Rented.TabIndex = 16;
            this.radioButton_Rented.TabStop = true;
            this.radioButton_Rented.Text = "Đã cho thuê";
            this.radioButton_Rented.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 368);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tình trạng phòng:";
            // 
            // descTextbox
            // 
            this.descTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.descTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.descTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.descTextbox.BorderRadius = 10;
            this.descTextbox.BorderSize = 2;
            this.descTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.descTextbox.Location = new System.Drawing.Point(291, 227);
            this.descTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.descTextbox.Multiline = true;
            this.descTextbox.Name = "descTextbox";
            this.descTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.descTextbox.PasswordChar = false;
            this.descTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.descTextbox.PlaceholderText = "";
            this.descTextbox.Size = new System.Drawing.Size(748, 104);
            this.descTextbox.TabIndex = 14;
            this.descTextbox.Texts = "";
            this.descTextbox.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Miêu tả:";
            // 
            // discardBtn
            // 
            this.discardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.discardBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.discardBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.discardBtn.BorderRadius = 10;
            this.discardBtn.BorderSize = 0;
            this.discardBtn.FlatAppearance.BorderSize = 0;
            this.discardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardBtn.ForeColor = System.Drawing.Color.White;
            this.discardBtn.Location = new System.Drawing.Point(902, 681);
            this.discardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(137, 44);
            this.discardBtn.TabIndex = 12;
            this.discardBtn.Text = "Hủy";
            this.discardBtn.TextColor = System.Drawing.Color.White;
            this.discardBtn.UseVisualStyleBackColor = false;
            this.discardBtn.Click += new System.EventHandler(this.discardBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.BackColor = System.Drawing.Color.Green;
            this.updateBtn.BackgroundColor = System.Drawing.Color.Green;
            this.updateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateBtn.BorderRadius = 10;
            this.updateBtn.BorderSize = 0;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(737, 681);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(137, 44);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Cập nhật";
            this.updateBtn.TextColor = System.Drawing.Color.White;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.changeImgBtn);
            this.panel1.Location = new System.Drawing.Point(291, 440);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 220);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::PBL3.Properties.Resources.phongtro1;
            this.pictureBox3.Location = new System.Drawing.Point(511, 26);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(207, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::PBL3.Properties.Resources.phongtro1;
            this.pictureBox2.Location = new System.Drawing.Point(275, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PBL3.Properties.Resources.phongtro1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // changeImgBtn
            // 
            this.changeImgBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeImgBtn.BackColor = System.Drawing.Color.Green;
            this.changeImgBtn.BackgroundColor = System.Drawing.Color.Green;
            this.changeImgBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.changeImgBtn.BorderRadius = 10;
            this.changeImgBtn.BorderSize = 0;
            this.changeImgBtn.FlatAppearance.BorderSize = 0;
            this.changeImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeImgBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeImgBtn.ForeColor = System.Drawing.Color.White;
            this.changeImgBtn.Location = new System.Drawing.Point(312, 167);
            this.changeImgBtn.Margin = new System.Windows.Forms.Padding(2);
            this.changeImgBtn.Name = "changeImgBtn";
            this.changeImgBtn.Size = new System.Drawing.Size(137, 44);
            this.changeImgBtn.TabIndex = 7;
            this.changeImgBtn.Text = "Sửa ảnh";
            this.changeImgBtn.TextColor = System.Drawing.Color.White;
            this.changeImgBtn.UseVisualStyleBackColor = false;
            this.changeImgBtn.Click += new System.EventHandler(this.changeImgBtn_Click);
            // 
            // areaTextbox
            // 
            this.areaTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.areaTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.areaTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.areaTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.areaTextbox.BorderRadius = 10;
            this.areaTextbox.BorderSize = 2;
            this.areaTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.areaTextbox.Location = new System.Drawing.Point(291, 165);
            this.areaTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.areaTextbox.Multiline = true;
            this.areaTextbox.Name = "areaTextbox";
            this.areaTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.areaTextbox.PasswordChar = false;
            this.areaTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.areaTextbox.PlaceholderText = "";
            this.areaTextbox.Size = new System.Drawing.Size(748, 33);
            this.areaTextbox.TabIndex = 10;
            this.areaTextbox.Texts = "";
            this.areaTextbox.UnderlinedStyle = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.priceTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.priceTextBox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.priceTextBox.BorderRadius = 10;
            this.priceTextBox.BorderSize = 2;
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.priceTextBox.Location = new System.Drawing.Point(291, 105);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.priceTextBox.PasswordChar = false;
            this.priceTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.priceTextBox.PlaceholderText = "";
            this.priceTextBox.Size = new System.Drawing.Size(748, 33);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.Texts = "";
            this.priceTextBox.UnderlinedStyle = false;
            // 
            // titleTextbox
            // 
            this.titleTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.titleTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.titleTextbox.BorderRadius = 10;
            this.titleTextbox.BorderSize = 2;
            this.titleTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.titleTextbox.Location = new System.Drawing.Point(291, 49);
            this.titleTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextbox.Multiline = true;
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.titleTextbox.PasswordChar = false;
            this.titleTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.titleTextbox.PlaceholderText = "";
            this.titleTextbox.Size = new System.Drawing.Size(748, 33);
            this.titleTextbox.TabIndex = 8;
            this.titleTextbox.Texts = "";
            this.titleTextbox.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 440);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Hình ảnh : ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Diện tích : ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giá cho thuê : ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tiêu đề : ";
            // 
            // ArticleUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diaChiGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1170, 683);
            this.Name = "ArticleUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticleUpdateForm";
            this.diaChiGroupBox.ResumeLayout(false);
            this.diaChiGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomComboBox cbb_Ward;
        private CustomComponents.CustomComboBox cbb_District;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CustomComponents.CustomTextBox DetailAddressTextBox;
        private System.Windows.Forms.GroupBox diaChiGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomComponents.CustomTextBox descTextbox;
        private System.Windows.Forms.Label label6;
        private CustomComponents.CustomButton discardBtn;
        private CustomComponents.CustomButton updateBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomComponents.CustomButton changeImgBtn;
        private CustomComponents.CustomTextBox areaTextbox;
        private CustomComponents.CustomTextBox priceTextBox;
        private CustomComponents.CustomTextBox titleTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton_NotRented;
        private System.Windows.Forms.RadioButton radioButton_Rented;
    }
}