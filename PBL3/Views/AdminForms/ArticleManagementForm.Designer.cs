
namespace PBL3.Views.AdminForms
{
    partial class ArticleManagementForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.viewUser = new PBL3.Views.CustomComponents.CustomButton();
            this.deleteBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.readBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.confirmBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reverse = new PBL3.Views.CustomComponents.CustomButton();
            this.cbbSort = new PBL3.Views.CustomComponents.CustomComboBox();
            this.txt_Search = new PBL3.Views.CustomComponents.CustomTextBox();
            this.searchBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.postedFilterCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Honeydew;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.viewUser);
            this.panelMenu.Controls.Add(this.deleteBtn);
            this.panelMenu.Controls.Add(this.readBtn);
            this.panelMenu.Controls.Add(this.confirmBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 597);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1552, 66);
            this.panelMenu.TabIndex = 19;
            // 
            // viewUser
            // 
            this.viewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewUser.BackColor = System.Drawing.Color.Green;
            this.viewUser.BackgroundColor = System.Drawing.Color.Green;
            this.viewUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.viewUser.BorderRadius = 6;
            this.viewUser.BorderSize = 0;
            this.viewUser.FlatAppearance.BorderSize = 0;
            this.viewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUser.ForeColor = System.Drawing.Color.White;
            this.viewUser.Location = new System.Drawing.Point(383, 12);
            this.viewUser.Name = "viewUser";
            this.viewUser.Size = new System.Drawing.Size(203, 41);
            this.viewUser.TabIndex = 18;
            this.viewUser.Text = "Thông tin người đăng";
            this.viewUser.TextColor = System.Drawing.Color.White;
            this.viewUser.UseVisualStyleBackColor = false;
            this.viewUser.Click += new System.EventHandler(this.viewUser_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 6;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(1012, 12);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(156, 41);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Xoá bài đăng";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.readBtn.BackColor = System.Drawing.Color.Green;
            this.readBtn.BackgroundColor = System.Drawing.Color.Green;
            this.readBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.readBtn.BorderRadius = 6;
            this.readBtn.BorderSize = 0;
            this.readBtn.FlatAppearance.BorderSize = 0;
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.ForeColor = System.Drawing.Color.White;
            this.readBtn.Location = new System.Drawing.Point(623, 12);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(156, 41);
            this.readBtn.TabIndex = 15;
            this.readBtn.Text = "Xem bài đăng";
            this.readBtn.TextColor = System.Drawing.Color.White;
            this.readBtn.UseVisualStyleBackColor = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmBtn.BackColor = System.Drawing.Color.Green;
            this.confirmBtn.BackgroundColor = System.Drawing.Color.Green;
            this.confirmBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.confirmBtn.BorderRadius = 6;
            this.confirmBtn.BorderSize = 0;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(820, 12);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(156, 41);
            this.confirmBtn.TabIndex = 16;
            this.confirmBtn.Text = "Duyệt bài đăng";
            this.confirmBtn.TextColor = System.Drawing.Color.White;
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.btn_reverse);
            this.panel1.Controls.Add(this.cbbSort);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.postedFilterCbb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1552, 68);
            this.panel1.TabIndex = 20;
            // 
            // btn_reverse
            // 
            this.btn_reverse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reverse.BackColor = System.Drawing.Color.Honeydew;
            this.btn_reverse.BackgroundColor = System.Drawing.Color.Honeydew;
            this.btn_reverse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_reverse.BorderRadius = 6;
            this.btn_reverse.BorderSize = 0;
            this.btn_reverse.FlatAppearance.BorderSize = 0;
            this.btn_reverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reverse.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reverse.ForeColor = System.Drawing.Color.White;
            this.btn_reverse.Image = global::PBL3.Properties.Resources.sort;
            this.btn_reverse.Location = new System.Drawing.Point(1287, 16);
            this.btn_reverse.Name = "btn_reverse";
            this.btn_reverse.Size = new System.Drawing.Size(48, 37);
            this.btn_reverse.TabIndex = 23;
            this.btn_reverse.TextColor = System.Drawing.Color.White;
            this.btn_reverse.UseVisualStyleBackColor = false;
            this.btn_reverse.Click += new System.EventHandler(this.btn_reverse_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSort.BackColor = System.Drawing.Color.Honeydew;
            this.cbbSort.BorderColor = System.Drawing.Color.Green;
            this.cbbSort.BorderSize = 3;
            this.cbbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSort.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSort.ForeColor = System.Drawing.Color.DimGray;
            this.cbbSort.IconColor = System.Drawing.Color.Green;
            this.cbbSort.Items.AddRange(new object[] {
            "Thời gian tạo",
            "Số bình luận",
            "Rating"});
            this.cbbSort.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbbSort.ListTextColor = System.Drawing.Color.Black;
            this.cbbSort.Location = new System.Drawing.Point(1081, 16);
            this.cbbSort.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Padding = new System.Windows.Forms.Padding(3);
            this.cbbSort.Size = new System.Drawing.Size(200, 37);
            this.cbbSort.TabIndex = 22;
            this.cbbSort.Texts = "Sắp xếp";
            this.cbbSort.OnSelectionChangedCommited += new System.EventHandler(this.cbbSort_OnSelectionChangedCommited);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Search.AutoSize = true;
            this.txt_Search.BackColor = System.Drawing.Color.Honeydew;
            this.txt_Search.BorderColor = System.Drawing.Color.Green;
            this.txt_Search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Search.BorderRadius = 6;
            this.txt_Search.BorderSize = 2;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Search.Location = new System.Drawing.Point(13, 16);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txt_Search.PasswordChar = false;
            this.txt_Search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Search.PlaceholderText = "Nhập nội dung cần tìm";
            this.txt_Search.Size = new System.Drawing.Size(637, 37);
            this.txt_Search.TabIndex = 21;
            this.txt_Search.Texts = "";
            this.txt_Search.UnderlinedStyle = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.Green;
            this.searchBtn.BackgroundColor = System.Drawing.Color.Green;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 6;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(1375, 16);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(122, 37);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // postedFilterCbb
            // 
            this.postedFilterCbb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postedFilterCbb.BackColor = System.Drawing.Color.Honeydew;
            this.postedFilterCbb.BorderColor = System.Drawing.Color.Green;
            this.postedFilterCbb.BorderSize = 3;
            this.postedFilterCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postedFilterCbb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postedFilterCbb.ForeColor = System.Drawing.Color.DimGray;
            this.postedFilterCbb.IconColor = System.Drawing.Color.Green;
            this.postedFilterCbb.Items.AddRange(new object[] {
            "Tất cả bài đăng",
            "Bài đăng đã được duyệt",
            "Bài đăng chưa được duyệt",
            "Bài đăng đã cho thuê",
            "Bài đăng chưa được cho thuê",
            "Bài viết có chỉnh sửa"});
            this.postedFilterCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.postedFilterCbb.ListTextColor = System.Drawing.Color.Black;
            this.postedFilterCbb.Location = new System.Drawing.Point(673, 16);
            this.postedFilterCbb.MinimumSize = new System.Drawing.Size(200, 33);
            this.postedFilterCbb.Name = "postedFilterCbb";
            this.postedFilterCbb.Padding = new System.Windows.Forms.Padding(3);
            this.postedFilterCbb.Size = new System.Drawing.Size(385, 37);
            this.postedFilterCbb.TabIndex = 18;
            this.postedFilterCbb.Texts = "Chọn bộ lọc";
            this.postedFilterCbb.OnSelectionChangedCommited += new System.EventHandler(this.postedFilterCbb_OnSelectionChangedCommited);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1552, 529);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ArticleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1552, 663);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Name = "ArticleManagementForm";
            this.Text = "ArticleManagementForm";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomComponents.CustomComboBox postedFilterCbb;
        private CustomComponents.CustomButton deleteBtn;
        private CustomComponents.CustomButton confirmBtn;
        private CustomComponents.CustomButton readBtn;
        private CustomComponents.CustomButton searchBtn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomComponents.CustomTextBox txt_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private CustomComponents.CustomButton viewUser;
        private CustomComponents.CustomButton btn_reverse;
        private CustomComponents.CustomComboBox cbbSort;
    }
}