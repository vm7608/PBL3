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
    }
}
