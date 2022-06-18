
namespace PBL3.Views.CommonForm
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.houseInfoComponent5 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.houseInfoComponent4 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.houseInfoComponent3 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.houseInfoComponent2 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.houseInfoComponent1 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.cbb_Ward = new PBL3.Views.CustomComponents.CustomComboBox();
            this.searchBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.cbb_University = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_Area = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_Price = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_District = new PBL3.Views.CustomComponents.CustomComboBox();
            this.nextPageBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.prevPageBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.resetBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.nextPageBtn);
            this.panel1.Controls.Add(this.prevPageBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 533);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1628, 64);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.houseInfoComponent5);
            this.panel2.Controls.Add(this.houseInfoComponent4);
            this.panel2.Controls.Add(this.houseInfoComponent3);
            this.panel2.Controls.Add(this.houseInfoComponent2);
            this.panel2.Controls.Add(this.houseInfoComponent1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1628, 533);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.resetBtn);
            this.panel3.Controls.Add(this.cbb_Ward);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.cbb_University);
            this.panel3.Controls.Add(this.cbb_Area);
            this.panel3.Controls.Add(this.cbb_Price);
            this.panel3.Controls.Add(this.cbb_District);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1607, 68);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(702, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Duyệt theo diện tích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(142, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duyệt theo trường đại học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(702, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duyệt theo giá tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duyệt theo thành phố";
            // 
            // houseInfoComponent5
            // 
            this.houseInfoComponent5.AddressLabel = "Địa chỉ";
            this.houseInfoComponent5.AreaLabel = "Mét vuông";
            this.houseInfoComponent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent5.DescLabel = "Miêu tả";
            this.houseInfoComponent5.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent5.HomeLink = "Tên nhà";
            this.houseInfoComponent5.Location = new System.Drawing.Point(0, 1332);
            this.houseInfoComponent5.Margin = new System.Windows.Forms.Padding(1);
            this.houseInfoComponent5.MoneyLabel = "Số tiền";
            this.houseInfoComponent5.Name = "houseInfoComponent5";
            this.houseInfoComponent5.PictureBox = null;
            this.houseInfoComponent5.Size = new System.Drawing.Size(1607, 316);
            this.houseInfoComponent5.TabIndex = 6;
            this.houseInfoComponent5.OnLabelClicked += new System.EventHandler(this.houseInfoComponent5_OnLabelClicked);
            // 
            // houseInfoComponent4
            // 
            this.houseInfoComponent4.AddressLabel = "Địa chỉ";
            this.houseInfoComponent4.AreaLabel = "Mét vuông";
            this.houseInfoComponent4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent4.DescLabel = "Miêu tả";
            this.houseInfoComponent4.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent4.HomeLink = "Tên nhà";
            this.houseInfoComponent4.Location = new System.Drawing.Point(0, 1016);
            this.houseInfoComponent4.Margin = new System.Windows.Forms.Padding(1);
            this.houseInfoComponent4.MoneyLabel = "Số tiền";
            this.houseInfoComponent4.Name = "houseInfoComponent4";
            this.houseInfoComponent4.PictureBox = null;
            this.houseInfoComponent4.Size = new System.Drawing.Size(1607, 316);
            this.houseInfoComponent4.TabIndex = 5;
            this.houseInfoComponent4.OnLabelClicked += new System.EventHandler(this.houseInfoComponent4_OnLabelClicked);
            // 
            // houseInfoComponent3
            // 
            this.houseInfoComponent3.AddressLabel = "Địa chỉ";
            this.houseInfoComponent3.AreaLabel = "Mét vuông";
            this.houseInfoComponent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent3.DescLabel = "Miêu tả";
            this.houseInfoComponent3.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent3.HomeLink = "Tên nhà";
            this.houseInfoComponent3.Location = new System.Drawing.Point(0, 700);
            this.houseInfoComponent3.Margin = new System.Windows.Forms.Padding(1);
            this.houseInfoComponent3.MoneyLabel = "Số tiền";
            this.houseInfoComponent3.Name = "houseInfoComponent3";
            this.houseInfoComponent3.PictureBox = null;
            this.houseInfoComponent3.Size = new System.Drawing.Size(1607, 316);
            this.houseInfoComponent3.TabIndex = 4;
            this.houseInfoComponent3.OnLabelClicked += new System.EventHandler(this.houseInfoComponent3_OnLabelClicked);
            // 
            // houseInfoComponent2
            // 
            this.houseInfoComponent2.AddressLabel = "Địa chỉ";
            this.houseInfoComponent2.AreaLabel = "Mét vuông";
            this.houseInfoComponent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent2.DescLabel = "Miêu tả";
            this.houseInfoComponent2.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent2.HomeLink = "Tên nhà";
            this.houseInfoComponent2.Location = new System.Drawing.Point(0, 384);
            this.houseInfoComponent2.Margin = new System.Windows.Forms.Padding(1);
            this.houseInfoComponent2.MoneyLabel = "Số tiền";
            this.houseInfoComponent2.Name = "houseInfoComponent2";
            this.houseInfoComponent2.PictureBox = null;
            this.houseInfoComponent2.Size = new System.Drawing.Size(1607, 316);
            this.houseInfoComponent2.TabIndex = 3;
            this.houseInfoComponent2.OnLabelClicked += new System.EventHandler(this.houseInfoComponent2_OnLabelClicked);
            // 
            // houseInfoComponent1
            // 
            this.houseInfoComponent1.AddressLabel = "Địa chỉ";
            this.houseInfoComponent1.AreaLabel = "Mét vuông";
            this.houseInfoComponent1.BackColor = System.Drawing.Color.Honeydew;
            this.houseInfoComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent1.DescLabel = "Miêu tả";
            this.houseInfoComponent1.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent1.HomeLink = "Tên nhà";
            this.houseInfoComponent1.Location = new System.Drawing.Point(0, 68);
            this.houseInfoComponent1.Margin = new System.Windows.Forms.Padding(1);
            this.houseInfoComponent1.MoneyLabel = "Số tiền";
            this.houseInfoComponent1.Name = "houseInfoComponent1";
            this.houseInfoComponent1.PictureBox = null;
            this.houseInfoComponent1.Size = new System.Drawing.Size(1607, 316);
            this.houseInfoComponent1.TabIndex = 2;
            this.houseInfoComponent1.OnLabelClicked += new System.EventHandler(this.houseInfoComponent1_OnLabelClicked);
            // 
            // cbb_Ward
            // 
            this.cbb_Ward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbb_Ward.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_Ward.BorderColor = System.Drawing.Color.Green;
            this.cbb_Ward.BorderSize = 3;
            this.cbb_Ward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Ward.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ward.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_Ward.IconColor = System.Drawing.Color.Green;
            this.cbb_Ward.Items.AddRange(new object[] {
            "Da nang",
            "Ha noi"});
            this.cbb_Ward.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_Ward.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_Ward.Location = new System.Drawing.Point(250, 18);
            this.cbb_Ward.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Ward.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbb_Ward.Name = "cbb_Ward";
            this.cbb_Ward.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_Ward.Size = new System.Drawing.Size(232, 33);
            this.cbb_Ward.TabIndex = 9;
            this.cbb_Ward.Texts = "Phường";
            this.cbb_Ward.OnSelectionChangedCommited += new System.EventHandler(this.cbb_Ward_OnSelectionChangedCommited);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchBtn.BackColor = System.Drawing.Color.Green;
            this.searchBtn.BackgroundColor = System.Drawing.Color.Green;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 15;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(1270, 18);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(154, 33);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cbb_University
            // 
            this.cbb_University.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbb_University.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_University.BorderColor = System.Drawing.Color.Green;
            this.cbb_University.BorderSize = 3;
            this.cbb_University.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_University.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_University.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_University.IconColor = System.Drawing.Color.Green;
            this.cbb_University.Items.AddRange(new object[] {
            "DHBK Da Nang",
            "DHBK Ha Noi"});
            this.cbb_University.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_University.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_University.Location = new System.Drawing.Point(503, 18);
            this.cbb_University.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_University.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbb_University.Name = "cbb_University";
            this.cbb_University.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_University.Size = new System.Drawing.Size(232, 33);
            this.cbb_University.TabIndex = 3;
            this.cbb_University.Texts = "Trường";
            this.cbb_University.OnSelectionChangedCommited += new System.EventHandler(this.cbb_University_OnSelectionChangedCommited);
            // 
            // cbb_Area
            // 
            this.cbb_Area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbb_Area.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_Area.BorderColor = System.Drawing.Color.Green;
            this.cbb_Area.BorderSize = 3;
            this.cbb_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Area.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Area.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_Area.IconColor = System.Drawing.Color.Green;
            this.cbb_Area.Items.AddRange(new object[] {
            "Tất cả diện tích",
            "Dưới 20m2",
            "Từ 20 - 25m2",
            "Từ 25 - 30m2",
            "Trên 30m2"});
            this.cbb_Area.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_Area.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_Area.Location = new System.Drawing.Point(1014, 18);
            this.cbb_Area.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Area.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbb_Area.Name = "cbb_Area";
            this.cbb_Area.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_Area.Size = new System.Drawing.Size(232, 33);
            this.cbb_Area.TabIndex = 2;
            this.cbb_Area.Texts = "Diện tích";
            // 
            // cbb_Price
            // 
            this.cbb_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbb_Price.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_Price.BorderColor = System.Drawing.Color.Green;
            this.cbb_Price.BorderSize = 3;
            this.cbb_Price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Price.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_Price.IconColor = System.Drawing.Color.Green;
            this.cbb_Price.Items.AddRange(new object[] {
            "Tất cả khoảng giá",
            "Dưới 1 triệu",
            "Từ 1 triệu - 1,5 triệu",
            "Từ 1,5 triệu - 2 triệu",
            "Trên 2 triệu"});
            this.cbb_Price.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_Price.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_Price.Location = new System.Drawing.Point(760, 18);
            this.cbb_Price.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Price.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbb_Price.Name = "cbb_Price";
            this.cbb_Price.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_Price.Size = new System.Drawing.Size(232, 33);
            this.cbb_Price.TabIndex = 1;
            this.cbb_Price.Texts = "Giá tiền";
            // 
            // cbb_District
            // 
            this.cbb_District.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbb_District.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_District.BorderColor = System.Drawing.Color.Green;
            this.cbb_District.BorderSize = 3;
            this.cbb_District.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_District.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_District.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_District.IconColor = System.Drawing.Color.Green;
            this.cbb_District.Items.AddRange(new object[] {
            "Da nang",
            "Ha noi"});
            this.cbb_District.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_District.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_District.Location = new System.Drawing.Point(-7, 18);
            this.cbb_District.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_District.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbb_District.Name = "cbb_District";
            this.cbb_District.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_District.Size = new System.Drawing.Size(232, 33);
            this.cbb_District.TabIndex = 0;
            this.cbb_District.Texts = "Quận";
            this.cbb_District.OnSelectionChangedCommited += new System.EventHandler(this.cbb_District_OnSelectionChangedCommited);
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextPageBtn.BackColor = System.Drawing.Color.Green;
            this.nextPageBtn.BackgroundColor = System.Drawing.Color.Green;
            this.nextPageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nextPageBtn.BorderRadius = 20;
            this.nextPageBtn.BorderSize = 0;
            this.nextPageBtn.FlatAppearance.BorderSize = 0;
            this.nextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPageBtn.ForeColor = System.Drawing.Color.White;
            this.nextPageBtn.Location = new System.Drawing.Point(901, 9);
            this.nextPageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(187, 44);
            this.nextPageBtn.TabIndex = 1;
            this.nextPageBtn.Text = "Trang sau";
            this.nextPageBtn.TextColor = System.Drawing.Color.White;
            this.nextPageBtn.UseVisualStyleBackColor = false;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevPageBtn.BackColor = System.Drawing.Color.Green;
            this.prevPageBtn.BackgroundColor = System.Drawing.Color.Green;
            this.prevPageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.prevPageBtn.BorderRadius = 20;
            this.prevPageBtn.BorderSize = 0;
            this.prevPageBtn.FlatAppearance.BorderSize = 0;
            this.prevPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevPageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPageBtn.ForeColor = System.Drawing.Color.White;
            this.prevPageBtn.Location = new System.Drawing.Point(530, 9);
            this.prevPageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(187, 44);
            this.prevPageBtn.TabIndex = 0;
            this.prevPageBtn.Text = "Trang trước";
            this.prevPageBtn.TextColor = System.Drawing.Color.White;
            this.prevPageBtn.UseVisualStyleBackColor = false;
            this.prevPageBtn.Click += new System.EventHandler(this.prevPageBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetBtn.BackColor = System.Drawing.Color.Green;
            this.resetBtn.BackgroundColor = System.Drawing.Color.Green;
            this.resetBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.resetBtn.BorderRadius = 15;
            this.resetBtn.BorderSize = 0;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(1450, 18);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(154, 33);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Đặt lại";
            this.resetBtn.TextColor = System.Drawing.Color.White;
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1628, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1037, 635);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomComponents.CustomButton nextPageBtn;
        private CustomComponents.CustomButton prevPageBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CustomComponents.CustomComboBox cbb_District;
        private CustomComponents.CustomComboBox cbb_University;
        private CustomComponents.CustomComboBox cbb_Area;
        private CustomComponents.CustomComboBox cbb_Price;
        private CustomComponents.CustomButton searchBtn;
        private CustomComponents.CustomComboBox cbb_Ward;
        private CustomComponents.HouseInfoComponent houseInfoComponent5;
        private CustomComponents.HouseInfoComponent houseInfoComponent4;
        private CustomComponents.HouseInfoComponent houseInfoComponent3;
        private CustomComponents.HouseInfoComponent houseInfoComponent2;
        private CustomComponents.HouseInfoComponent houseInfoComponent1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomButton resetBtn;
    }
}