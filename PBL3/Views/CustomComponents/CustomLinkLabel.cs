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
    [DefaultEvent("_LinkLabelClicked")]
    public partial class CustomLinkLabel : UserControl
    {
        //Properties
        private int id = -1;
        private Color linkColor = Color.Blue;

        public int ID
        {
            get => id;
            set => id = value;
        }

        public string LinkText
        {
            get => linkLabel1.Text;
            set
            {
                linkLabel1.Text = value;
                this.Invalidate();
            }
        }

        public Color LinkColor
        {
            get => linkLabel1.LinkColor;
            set
            {
                linkLabel1.LinkColor = value;
                this.Invalidate();
            }
        }

        public event EventHandler _LinkLabelClicked;
        public CustomLinkLabel()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LinkLabelClicked != null)
                _LinkLabelClicked.Invoke(sender, e);
        }
    }
}
