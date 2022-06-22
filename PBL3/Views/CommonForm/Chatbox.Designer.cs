
namespace PBL3.Views.CommonForm
{
    partial class Chatbox
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.sendBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.messageTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.disconnectBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.AliceBlue;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1630, 857);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.BackColor = System.Drawing.Color.Green;
            this.sendBtn.BackgroundColor = System.Drawing.Color.Green;
            this.sendBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sendBtn.BorderRadius = 10;
            this.sendBtn.BorderSize = 0;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(1370, 31);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(231, 45);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Gửi";
            this.sendBtn.TextColor = System.Drawing.Color.White;
            this.sendBtn.UseVisualStyleBackColor = false;
            // 
            // messageTextbox
            // 
            this.messageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.messageTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.messageTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.messageTextbox.BorderRadius = 10;
            this.messageTextbox.BorderSize = 2;
            this.messageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.messageTextbox.Location = new System.Drawing.Point(54, 31);
            this.messageTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.messageTextbox.Multiline = false;
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.messageTextbox.PasswordChar = false;
            this.messageTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.messageTextbox.PlaceholderText = "";
            this.messageTextbox.Size = new System.Drawing.Size(1287, 43);
            this.messageTextbox.TabIndex = 1;
            this.messageTextbox.Texts = "";
            this.messageTextbox.UnderlinedStyle = false;
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disconnectBtn.BackColor = System.Drawing.Color.Red;
            this.disconnectBtn.BackgroundColor = System.Drawing.Color.Red;
            this.disconnectBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.disconnectBtn.BorderRadius = 10;
            this.disconnectBtn.BorderSize = 0;
            this.disconnectBtn.FlatAppearance.BorderSize = 0;
            this.disconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectBtn.ForeColor = System.Drawing.Color.White;
            this.disconnectBtn.Location = new System.Drawing.Point(1370, 20);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(231, 45);
            this.disconnectBtn.TabIndex = 3;
            this.disconnectBtn.Text = "Thoát";
            this.disconnectBtn.TextColor = System.Drawing.Color.White;
            this.disconnectBtn.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.sendBtn);
            this.panelMenu.Controls.Add(this.messageTextbox);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 943);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1630, 96);
            this.panelMenu.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.disconnectBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1630, 86);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gửi đến:";
            // 
            // Chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1630, 1039);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Name = "Chatbox";
            this.Text = "Chatbox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chatbox_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private CustomComponents.CustomButton sendBtn;
        private CustomComponents.CustomTextBox messageTextbox;
        private CustomComponents.CustomButton disconnectBtn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}