using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Views.CustomComponents
{
    public partial class CustomComment : UserControl
    {
        public CustomComment()
        {
            InitializeComponent();
        }

        //Event
        public event EventHandler _EditEventHandler;
        public event EventHandler _DeleteEventHandler;

        public string Username
        {
            get => usernameLabel.Text;
            set {
                usernameLabel.Text = value;
                this.Invalidate();
            }
        }

        public string Comment
        {
            get => textBox1.Text;
            set
            {
                textBox1.Text = value;
                this.Invalidate();
            }
        }

        public int deleteCommentID
        {
            get => deleteLinkLabel.ID;
            set
            {
                deleteLinkLabel.ID = value;
                this.Invalidate();
            }
        }

        public int editCommentID
        {
            get => editLinkLabel.ID;
            set
            {
                editLinkLabel.ID = value;
                this.Invalidate();
            }
        }

        private void editLinkLabel__LinkLabelClicked(object sender, EventArgs e)
        {
            if (_EditEventHandler != null)
                _EditEventHandler.Invoke(sender, e);
        }

        private void deleteLinkLabel__LinkLabelClicked(object sender, EventArgs e)
        {
            if (_DeleteEventHandler != null)
                _DeleteEventHandler.Invoke(sender, e);
        }

        public void HideUtilityPanel()
        {
            utilityPanel.Visible = false;
        }

        public void DisplayUtilityPanel()
        {
            utilityPanel.Visible = true;
        }
    }
}
