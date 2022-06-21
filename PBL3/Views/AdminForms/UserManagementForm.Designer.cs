
namespace PBL3.Views.AdminForms
{
    partial class UserManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.deleteBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.searchBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.cbbUserRole = new PBL3.Views.CustomComponents.CustomComboBox();
            this.txt_Search = new PBL3.Views.CustomComponents.CustomTextBox();
            this.cbbFilter = new PBL3.Views.CustomComponents.CustomComboBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Honeydew;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.viewBtn);
            this.panelMenu.Controls.Add(this.deleteBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 599);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1652, 66);
            this.panelMenu.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1652, 83);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.searchBtn);
            this.panel4.Controls.Add(this.cbbUserRole);
            this.panel4.Location = new System.Drawing.Point(1184, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 81);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_Search);
            this.panel3.Controls.Add(this.cbbFilter);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1196, 81);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nội dung tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1652, 665);
            this.panel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1652, 516);
            this.dataGridView1.TabIndex = 10;
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.viewBtn.BackColor = System.Drawing.Color.Green;
            this.viewBtn.BackgroundColor = System.Drawing.Color.Green;
            this.viewBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.viewBtn.BorderRadius = 10;
            this.viewBtn.BorderSize = 0;
            this.viewBtn.FlatAppearance.BorderSize = 0;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(503, 12);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(187, 42);
            this.viewBtn.TabIndex = 6;
            this.viewBtn.Text = "Xem thông tin";
            this.viewBtn.TextColor = System.Drawing.Color.White;
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.Green;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.Green;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 10;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(891, 12);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(187, 42);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Xoá tài khoản";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.Green;
            this.searchBtn.BackgroundColor = System.Drawing.Color.Green;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 10;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(258, 24);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(187, 33);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cbbUserRole
            // 
            this.cbbUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbUserRole.BackColor = System.Drawing.Color.Honeydew;
            this.cbbUserRole.BorderColor = System.Drawing.Color.Green;
            this.cbbUserRole.BorderSize = 3;
            this.cbbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUserRole.ForeColor = System.Drawing.Color.DimGray;
            this.cbbUserRole.IconColor = System.Drawing.Color.Green;
            this.cbbUserRole.Items.AddRange(new object[] {
            "Tất cả người dùng",
            "Người cho thuê",
            "Người thuê"});
            this.cbbUserRole.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbUserRole.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbUserRole.Location = new System.Drawing.Point(2, 24);
            this.cbbUserRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbbUserRole.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbbUserRole.Name = "cbbUserRole";
            this.cbbUserRole.Padding = new System.Windows.Forms.Padding(2);
            this.cbbUserRole.Size = new System.Drawing.Size(200, 33);
            this.cbbUserRole.TabIndex = 3;
            this.cbbUserRole.Texts = "Loại tài khoản";
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Search.AutoSize = true;
            this.txt_Search.BackColor = System.Drawing.Color.Honeydew;
            this.txt_Search.BorderColor = System.Drawing.Color.Green;
            this.txt_Search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Search.BorderRadius = 0;
            this.txt_Search.BorderSize = 2;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Search.Location = new System.Drawing.Point(195, 24);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txt_Search.PasswordChar = false;
            this.txt_Search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Search.PlaceholderText = "";
            this.txt_Search.Size = new System.Drawing.Size(641, 34);
            this.txt_Search.TabIndex = 12;
            this.txt_Search.Texts = "";
            this.txt_Search.UnderlinedStyle = false;
            // 
            // cbbFilter
            // 
            this.cbbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbFilter.BackColor = System.Drawing.Color.Honeydew;
            this.cbbFilter.BorderColor = System.Drawing.Color.Green;
            this.cbbFilter.BorderSize = 3;
            this.cbbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilter.ForeColor = System.Drawing.Color.DimGray;
            this.cbbFilter.IconColor = System.Drawing.Color.Green;
            this.cbbFilter.Items.AddRange(new object[] {
            "Tìm theo tên",
            "Tìm theo số điện thoại",
            "Tìm theo email"});
            this.cbbFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbFilter.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbFilter.Location = new System.Drawing.Point(896, 24);
            this.cbbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilter.MinimumSize = new System.Drawing.Size(200, 33);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Padding = new System.Windows.Forms.Padding(2);
            this.cbbFilter.Size = new System.Drawing.Size(232, 33);
            this.cbbFilter.TabIndex = 6;
            this.cbbFilter.Texts = "Bộ lọc tìm kiếm";
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1652, 665);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomComponents.CustomComboBox cbbUserRole;
        private CustomComponents.CustomButton searchBtn;
        private CustomComponents.CustomButton viewBtn;
        private CustomComponents.CustomButton deleteBtn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private CustomComponents.CustomComboBox cbbFilter;
        private CustomComponents.CustomTextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}