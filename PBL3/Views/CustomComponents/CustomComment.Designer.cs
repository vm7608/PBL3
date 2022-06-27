
namespace PBL3.Views.CustomComponents
{
    partial class CustomComment
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.utilityPanel = new System.Windows.Forms.Panel();
            this.deleteLinkLabel = new PBL3.Views.CustomComponents.CustomLinkLabel();
            this.editLinkLabel = new PBL3.Views.CustomComponents.CustomLinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.utilityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.Location = new System.Drawing.Point(0, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.usernameLabel.Size = new System.Drawing.Size(380, 109);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Tên người dùng";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utilityPanel
            // 
            this.utilityPanel.Controls.Add(this.deleteLinkLabel);
            this.utilityPanel.Controls.Add(this.editLinkLabel);
            this.utilityPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.utilityPanel.Location = new System.Drawing.Point(962, 0);
            this.utilityPanel.Name = "utilityPanel";
            this.utilityPanel.Size = new System.Drawing.Size(142, 109);
            this.utilityPanel.TabIndex = 3;
            // 
            // deleteLinkLabel
            // 
            this.deleteLinkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.deleteLinkLabel.ID = -1;
            this.deleteLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.deleteLinkLabel.LinkText = "Delete";
            this.deleteLinkLabel.Location = new System.Drawing.Point(0, 59);
            this.deleteLinkLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteLinkLabel.Name = "deleteLinkLabel";
            this.deleteLinkLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.deleteLinkLabel.Size = new System.Drawing.Size(142, 50);
            this.deleteLinkLabel.TabIndex = 1;
            this.deleteLinkLabel._LinkLabelClicked += new System.EventHandler(this.deleteLinkLabel__LinkLabelClicked);
            // 
            // editLinkLabel
            // 
            this.editLinkLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.editLinkLabel.ID = -1;
            this.editLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editLinkLabel.LinkText = "Edit";
            this.editLinkLabel.Location = new System.Drawing.Point(0, 0);
            this.editLinkLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editLinkLabel.Name = "editLinkLabel";
            this.editLinkLabel.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.editLinkLabel.Size = new System.Drawing.Size(142, 50);
            this.editLinkLabel.TabIndex = 0;
            this.editLinkLabel._LinkLabelClicked += new System.EventHandler(this.editLinkLabel__LinkLabelClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(380, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(582, 109);
            this.textBox1.TabIndex = 5;
            // 
            // CustomComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.utilityPanel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "CustomComment";
            this.Size = new System.Drawing.Size(1104, 109);
            this.utilityPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel utilityPanel;
        private System.Windows.Forms.TextBox textBox1;
        private CustomLinkLabel editLinkLabel;
        private CustomLinkLabel deleteLinkLabel;
    }
}
