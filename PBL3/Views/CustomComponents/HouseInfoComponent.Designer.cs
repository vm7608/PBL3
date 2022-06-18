
namespace PBL3.Views.CustomComponents
{
    partial class HouseInfoComponent
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tenNhaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.mieuTaLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.dienTichLabel = new System.Windows.Forms.Label();
            this.tienLabel = new System.Windows.Forms.Label();
            this.postID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PBL3.Properties.Resources.ImageNotFound;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 491);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.postID);
            this.panel2.Controls.Add(this.tenNhaLinkLabel);
            this.panel2.Controls.Add(this.mieuTaLabel);
            this.panel2.Controls.Add(this.diaChiLabel);
            this.panel2.Controls.Add(this.dienTichLabel);
            this.panel2.Controls.Add(this.tienLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(474, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 491);
            this.panel2.TabIndex = 8;
            // 
            // tenNhaLinkLabel
            // 
            this.tenNhaLinkLabel.AutoSize = true;
            this.tenNhaLinkLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNhaLinkLabel.ForeColor = System.Drawing.Color.Red;
            this.tenNhaLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.tenNhaLinkLabel.Location = new System.Drawing.Point(100, 45);
            this.tenNhaLinkLabel.Name = "tenNhaLinkLabel";
            this.tenNhaLinkLabel.Size = new System.Drawing.Size(273, 86);
            this.tenNhaLinkLabel.TabIndex = 11;
            this.tenNhaLinkLabel.TabStop = true;
            this.tenNhaLinkLabel.Text = "Tên nhà";
            this.tenNhaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tenNhaLinkLabel_LinkClicked);
            // 
            // mieuTaLabel
            // 
            this.mieuTaLabel.AutoSize = true;
            this.mieuTaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mieuTaLabel.ForeColor = System.Drawing.Color.Black;
            this.mieuTaLabel.Location = new System.Drawing.Point(106, 239);
            this.mieuTaLabel.Name = "mieuTaLabel";
            this.mieuTaLabel.Size = new System.Drawing.Size(149, 45);
            this.mieuTaLabel.TabIndex = 10;
            this.mieuTaLabel.Text = "Miêu tả: ";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiLabel.ForeColor = System.Drawing.Color.Black;
            this.diaChiLabel.Location = new System.Drawing.Point(108, 155);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(119, 45);
            this.diaChiLabel.TabIndex = 9;
            this.diaChiLabel.Text = "Địa chỉ";
            // 
            // dienTichLabel
            // 
            this.dienTichLabel.AutoSize = true;
            this.dienTichLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienTichLabel.ForeColor = System.Drawing.Color.Black;
            this.dienTichLabel.Location = new System.Drawing.Point(108, 395);
            this.dienTichLabel.Name = "dienTichLabel";
            this.dienTichLabel.Size = new System.Drawing.Size(197, 45);
            this.dienTichLabel.TabIndex = 8;
            this.dienTichLabel.Text = "Mét vuông: ";
            // 
            // tienLabel
            // 
            this.tienLabel.AutoSize = true;
            this.tienLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienLabel.ForeColor = System.Drawing.Color.Black;
            this.tienLabel.Location = new System.Drawing.Point(106, 320);
            this.tienLabel.Name = "tienLabel";
            this.tienLabel.Size = new System.Drawing.Size(138, 45);
            this.tienLabel.TabIndex = 7;
            this.tienLabel.Text = "Số tiền: ";
            // 
            // postID
            // 
            this.postID.AutoSize = true;
            this.postID.Location = new System.Drawing.Point(115, 17);
            this.postID.Name = "postID";
            this.postID.Size = new System.Drawing.Size(73, 25);
            this.postID.TabIndex = 12;
            this.postID.Text = "postID";
            this.postID.Visible = false;
            // 
            // HouseInfoComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HouseInfoComponent";
            this.Size = new System.Drawing.Size(1539, 491);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel tenNhaLinkLabel;
        private System.Windows.Forms.Label mieuTaLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.Label dienTichLabel;
        private System.Windows.Forms.Label tienLabel;
        private System.Windows.Forms.Label postID;
    }
}
