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
    public partial class HouseInfoComponent : UserControl
    {
        public HouseInfoComponent()
        {
            InitializeComponent();
        }

        public Image PictureBox
        {
            get => pictureBox1.Image;
            set
            {
                pictureBox1.Image = value;
                this.Invalidate();
            }
        }
        public string HomeLink { get => tenNhaLinkLabel.Text;
            set
            {
                tenNhaLinkLabel.Text = value;
                this.Invalidate();
            }
        }

        public string MoneyLabel { get => tienLabel.Text;
            set
            {
                tienLabel.Text = value;
                this.Invalidate();
            }
        }

        public string DescLabel { get => mieuTaLabel.Text;
            set 
            { 
                mieuTaLabel.Text = value;
                this.Invalidate();
            } 
        }
        public string AreaLabel { get => dienTichLabel.Text;
            set
            {
                dienTichLabel.Text = value;
                this.Invalidate();
            }
        }

        public string AddressLabel { get => diaChiLabel.Text;
            set
            {
                diaChiLabel.Text = value;
                this.Invalidate();
            }
        }
        public event EventHandler OnLabelClicked;


     

        private void tenNhaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OnLabelClicked != null) OnLabelClicked.Invoke(sender, e);
        }
    }
}
