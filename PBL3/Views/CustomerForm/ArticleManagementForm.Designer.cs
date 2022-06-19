
namespace PBL3.Views.CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.readBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.updateBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.postedFilterCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.uploadBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.searchBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.readBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 865);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 97);
            this.panel1.TabIndex = 20;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.Green;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.Green;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 15;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(438, 22);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(212, 52);
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
            this.readBtn.BorderRadius = 15;
            this.readBtn.BorderSize = 0;
            this.readBtn.FlatAppearance.BorderSize = 0;
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.ForeColor = System.Drawing.Color.White;
            this.readBtn.Location = new System.Drawing.Point(730, 22);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(212, 52);
            this.readBtn.TabIndex = 14;
            this.readBtn.Text = "Xem bài đăng";
            this.readBtn.TextColor = System.Drawing.Color.White;
            this.readBtn.UseVisualStyleBackColor = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.BackColor = System.Drawing.Color.Green;
            this.updateBtn.BackgroundColor = System.Drawing.Color.Green;
            this.updateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateBtn.BorderRadius = 15;
            this.updateBtn.BorderSize = 0;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(1017, 22);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(246, 52);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Cập nhật bài đăng";
            this.updateBtn.TextColor = System.Drawing.Color.White;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1656, 962);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1656, 862);
            this.panel3.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1656, 862);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Honeydew;
            this.panelMenu.Controls.Add(this.postedFilterCbb);
            this.panelMenu.Controls.Add(this.uploadBtn);
            this.panelMenu.Controls.Add(this.searchBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1656, 100);
            this.panelMenu.TabIndex = 19;
            // 
            // postedFilterCbb
            // 
            this.postedFilterCbb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postedFilterCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.postedFilterCbb.BackColor = System.Drawing.Color.Honeydew;
            this.postedFilterCbb.BorderColor = System.Drawing.Color.Green;
            this.postedFilterCbb.BorderSize = 3;
            this.postedFilterCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.postedFilterCbb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postedFilterCbb.ForeColor = System.Drawing.Color.DimGray;
            this.postedFilterCbb.IconColor = System.Drawing.Color.Green;
            this.postedFilterCbb.Items.AddRange(new object[] {
            "Tất cả bài đăng",
            "Sắp xếp theo thời gian tạo",
            "Bài đăng đã được duyệt",
            "Bài đăng chưa được duyệt",
            "Bài đăng đã cho thuê",
            "Bài đăng chưa được cho thuê"});
            this.postedFilterCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.postedFilterCbb.ListTextColor = System.Drawing.Color.Black;
            this.postedFilterCbb.Location = new System.Drawing.Point(38, 19);
            this.postedFilterCbb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postedFilterCbb.MinimumSize = new System.Drawing.Size(300, 52);
            this.postedFilterCbb.Name = "postedFilterCbb";
            this.postedFilterCbb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postedFilterCbb.Size = new System.Drawing.Size(1048, 55);
            this.postedFilterCbb.TabIndex = 19;
            this.postedFilterCbb.Texts = "Chọn bộ lọc";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadBtn.BackColor = System.Drawing.Color.Green;
            this.uploadBtn.BackgroundColor = System.Drawing.Color.Green;
            this.uploadBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.uploadBtn.BorderRadius = 15;
            this.uploadBtn.BorderSize = 0;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(1383, 19);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(212, 52);
            this.uploadBtn.TabIndex = 16;
            this.uploadBtn.Text = "Đăng bài";
            this.uploadBtn.TextColor = System.Drawing.Color.White;
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.Green;
            this.searchBtn.BackgroundColor = System.Drawing.Color.Green;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 15;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(1142, 19);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(212, 52);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // ArticleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1656, 962);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ArticleManagementForm";
            this.Text = "ArticleManagementForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.CustomButton deleteBtn;
        private CustomComponents.CustomButton updateBtn;
        private CustomComponents.CustomButton readBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelMenu;
        private CustomComponents.CustomComboBox postedFilterCbb;
        private CustomComponents.CustomButton uploadBtn;
        private CustomComponents.CustomButton searchBtn;
    }
}